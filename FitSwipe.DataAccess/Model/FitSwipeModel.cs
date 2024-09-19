using System.Text.Json.Serialization;

namespace FitSwipe.DataAccess.Model;

public partial class Appsettings
{
    [JsonPropertyName("ConnectionStrings")]
    public string ConnectionStrings { get; set; }

    [JsonPropertyName("FireBase")]
    public FireBase FireBase { get; set; }

    [JsonPropertyName("Logging")]
    public Logging Logging { get; set; }

    [JsonPropertyName("VnPay")]
    public VnPay VnPay { get; set; }

    [JsonPropertyName("SmtpSettings")]
    public SmtpSettings SmtpSettings { get; set; }

    [JsonPropertyName("AllowedHosts")]
    public string AllowedHosts { get; set; }

    [JsonPropertyName("Hangfire")]
    public string Hangfire { get; set; }
    [JsonPropertyName("SmtpAppSetting")]
    public SmtpAppSetting SmtpAppSetting { get; set; }
    [JsonPropertyName("FirebaseUpload")]
    public FirebaseUpload FirebaseUpload { get; set; }
}

public partial class SmtpAppSetting
{
    public string SmtpHost { get; set; }
    public int SmtpPort { get; set; }
    public string SmtpUserName { get; set; }
    public string SmtpPassword { get; set; }
    public bool EnableSsl { get; set; }
    public string AppVerify { get; set; }
}

public partial class FirebaseUpload
{
    [JsonPropertyName("BucketName")]
    public string BucketName { get; set; }
    [JsonPropertyName("ProjectId")]
    public string ProjectId { get; set; }
    [JsonPropertyName("ServicesAccountPath")]
    public string ServicesAccountPath { get; set; }

}

public partial class SmtpSettings
{
    [JsonPropertyName("SmtpHost")]
    public string SmtpHost { get; set; }
    [JsonPropertyName("SmtpPort")]
    public string SmtpPort { get; set; }
    [JsonPropertyName("SmtpUserName")]
    public string SmtpUserName { get; set; }
    [JsonPropertyName("SmtpPassword")]
    public string SmtpPassword { get; set; }
    [JsonPropertyName("EnableSsl")]
    public bool EnableSsl { get; set; }
    [JsonPropertyName("AppVerify")]
    public string AppVerify { get; set; }
}

public partial class VnPay
{
    [JsonPropertyName("TmnCode")]
    public string TmnCode { get; set; }
    [JsonPropertyName("HashSecret")]
    public string HashSecret { get; set; }
    [JsonPropertyName("BaseUrl")]
    public string BaseUrl { get; set; }
    [JsonPropertyName("Command")]
    public string Command { get; set; }
    [JsonPropertyName("CurrCode")]
    public string CurrCode { get; set; }
    [JsonPropertyName("Version")]
    public string Version { get; set; }
    [JsonPropertyName("Locale")]
    public string Locale { get; set; }
}

public partial class Logging
{
    [JsonPropertyName("LogLevel")]
    public string LogLevel { get; set; }
}

public partial class FireBase
{
    [JsonPropertyName("ProjectId")]
    public string ProjectId { get; set; }
}



