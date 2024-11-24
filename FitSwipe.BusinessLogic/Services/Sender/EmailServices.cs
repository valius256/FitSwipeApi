﻿using FitSwipe.BusinessLogic.Interfaces.Sender;
using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.SchedulerJobs;
using LinqKit;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

namespace FitSwipe.BusinessLogic.Services.Sender;

public class EmailServices : IEmailServices
{
    private readonly IDefaultScheduleJob _defaultScheduleJob;
    private readonly IEmailTemplateRepository _emailTemplateRepository;
    private readonly SmtpAppSetting _smtpAppSetting;

    public EmailServices(
        IDefaultScheduleJob defaultScheduleJob,
        IEmailTemplateRepository emailTemplateRepository,
        IOptions<SmtpAppSetting> appSetting
    )
    {
        _defaultScheduleJob = defaultScheduleJob;
        _emailTemplateRepository = emailTemplateRepository;
        _smtpAppSetting = appSetting.Value;
    }




    public async Task SendAsync(string name, List<string> toAddress, List<string> ccAddresses, Dictionary<string, string> param, bool isInQueue = false)
    {
        if (!isInQueue)
        {
            _defaultScheduleJob.Enqueue<IEmailServices>(m => m.SendAsync(name, toAddress, ccAddresses, param, true));
            return;
        }

        var template = await _emailTemplateRepository.FindOneAsync(e => e.Name == name && e.Status == true);
        if (template != null)
        {
            await SendAsync(template, toAddress, ccAddresses, param);
        }
    }


    private async Task SendAsync(EmailTemplate template, List<string> toAddress, List<string> ccAddresses, Dictionary<string, string> param)
    {
        var smtpAppSetting = new SmtpAppSetting
        {
            SmtpHost = _smtpAppSetting.SmtpHost,
            SmtpPort = _smtpAppSetting.SmtpPort,
            SmtpUserName = _smtpAppSetting.SmtpUserName,
            SmtpPassword = _smtpAppSetting.SmtpPassword,
            AppVerify = _smtpAppSetting.AppVerify
        };

        using (var client = new SmtpClient(smtpAppSetting.SmtpHost, smtpAppSetting.SmtpPort))
        {
            client.EnableSsl = _smtpAppSetting.EnableSsl;
            client.Credentials = new NetworkCredential(smtpAppSetting.SmtpUserName, smtpAppSetting.AppVerify);
            client.Port = smtpAppSetting.SmtpPort;

            using (var message = new MailMessage())
            {
                try
                {
                    message.From = new MailAddress(smtpAppSetting.SmtpUserName);

                    toAddress?.ForEach(to => message.To.Add(to));
                    ccAddresses?.ForEach(cc => message.CC.Add(cc));

                    message.Subject = ReplaceParam(template.Subject, param);
                    message.Body = ReplaceParam(template.Body, param);
                    message.IsBodyHtml = true;

                    message.BodyEncoding = System.Text.Encoding.UTF8;
                    message.SubjectEncoding = System.Text.Encoding.UTF8;

                    await client.SendMailAsync(message);
                }
                catch (Exception ex)
                {
                    throw new ApplicationException($"Failed to send Email: {ex.Message}", ex);
                }
            }
        }
    }

    public async Task SendEmailAsync(List<string> toAddresses, List<string> ccAddresses, string subject, string body, bool isHtml, bool isInQueue = false)
    {
        if (!isInQueue)
        {
            _defaultScheduleJob.Enqueue<IEmailServices>(m => m.SendEmailAsync(toAddresses, ccAddresses, subject, body, isHtml, true));
            return;
        }

        using (var client = new SmtpClient(_smtpAppSetting.SmtpHost, _smtpAppSetting.SmtpPort))
        {
            client.EnableSsl = _smtpAppSetting.EnableSsl;
            client.Credentials = new NetworkCredential(_smtpAppSetting.SmtpUserName, _smtpAppSetting.AppVerify);
            client.Port = _smtpAppSetting.SmtpPort;

            using (var message = new MailMessage())
            {
                try
                {
                    message.From = new MailAddress(_smtpAppSetting.SmtpUserName);

                    toAddresses?.ForEach(to => message.To.Add(to));
                    ccAddresses?.ForEach(cc => message.CC.Add(cc));

                    message.Subject = subject;
                    message.Body = body;
                    message.IsBodyHtml = isHtml;

                    message.BodyEncoding = System.Text.Encoding.UTF8;
                    message.SubjectEncoding = System.Text.Encoding.UTF8;

                    await client.SendMailAsync(message);
                }
                catch (Exception ex)
                {
                    throw new ApplicationException($"Failed to send Email: {ex.Message}", ex);
                }
            }
        }
    }

    private static string ReplaceParam(string data, Dictionary<string, string> parameters)
    {
        parameters.ForEach(k => data = data.Replace($"[{k.Key}]", k.Value));
        return data;
    }
}