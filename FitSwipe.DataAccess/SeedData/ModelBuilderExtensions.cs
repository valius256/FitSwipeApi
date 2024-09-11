﻿using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.Shared.Enum;
using Microsoft.EntityFrameworkCore;

namespace FitSwipe.DataAccess.SeedData
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region UserModel

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    FireBaseId = "123abc",
                    UserName = "john doe",
                    Gender = Gender.Male,
                    Email = "john.doe@example.com",
                    Password = "hashedpassword1",
                    AvatarUrl = "https://example.com/avatar1.jpg",
                    Phone = "1234567890",
                    DateOfBirth = new DateTime(1990, 5, 1),
                    Weight = 75.5,
                    Height = 180.3,
                    Bio = "Fitness enthusiast and certified personal trainer.",
                    City = "New York",
                    District = "Manhattan",
                    Ward = "Ward 5",
                    Street = "5th Avenue",
                    Role = Role.Trainee,
                    Job = "Student",
                    Status = UserStatus.Active,
                    Balance = 1000,
                },
                new User
                {
                    FireBaseId = "456def",
                    UserName = "jane smith",
                    Gender = Gender.Female,
                    Email = "jane.smith@example.com",
                    Password = "hashedpassword2",
                    AvatarUrl = "https://example.com/avatar2.jpg",
                    Phone = "0987654321",
                    DateOfBirth = new DateTime(1985, 8, 20),
                    Weight = 65.0,
                    Height = 170.2,
                    Bio = "Yoga instructor with a passion for holistic health.",
                    City = "Los Angeles",
                    District = "Beverly Hills",
                    Ward = "Ward 3",
                    Street = "Rodeo Drive",
                    Role = Role.PT,
                    Job = "Yoga Instructor",
                    Status = UserStatus.Active,
                    Balance = 1500,
                    PTStatus = PTStatus.Active,
                    PTExperienceYear = 3.5,
                    SubscriptionPurchasedDate = new DateTime(2023, 2, 10),
                    SubscriptionLevel = 1,
                    SubscriptionPaymentStatus = PaymentStatus.Paid
                },
                new User
                {
                    FireBaseId = "789ghi",
                    UserName = "alex jones",
                    Gender = Gender.Male,
                    Email = "alex.jones@example.com",
                    Password = "hashedpassword3",
                    AvatarUrl = "https://example.com/avatar3.jpg",
                    Phone = "5551234567",
                    DateOfBirth = new DateTime(1992, 3, 10),
                    Weight = 85.0,
                    Height = 185.4,
                    Bio = "Aspiring bodybuilder and nutrition expert.",
                    City = "Chicago",
                    District = "Lincoln Park",
                    Ward = "Ward 7",
                    Street = "Clark Street",
                    Role = Role.PT,
                    Job = "Nutritionist",
                    Status = UserStatus.Active,
                    Balance = 2000,
                    PTStatus = PTStatus.Pending,
                    PTExperienceYear = 2.0,
                }
            );


            #endregion

            #region Tag
            modelBuilder.Entity<Tag>().HasData(
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Bóng đá",
                   TagType = TagType.Hobby,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Video game",
                   TagType = TagType.Hobby,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Giảm cân",
                   TagType = TagType.Target,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Phát triển cơ bắp",
                   TagType = TagType.Target,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Yoga",
                   TagType = TagType.TrainingType,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Cardino",
                   TagType = TagType.TrainingType,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Ngoại hình đẹp",
                   TagType = TagType.PTTaste,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Giá rẻ",
                   TagType = TagType.PTTaste,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Kiên trì",
                   TagType = TagType.SelfDescription,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Siêng năng",
                   TagType = TagType.SelfDescription,
                   CreateById = "123abc",
               }
            );
            #endregion
        }
    }
}
