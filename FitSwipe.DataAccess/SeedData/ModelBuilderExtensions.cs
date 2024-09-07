using FitSwipe.DataAccess.Model.Enum;
using FitSwipe.Shared.Enum;
using FitSwipe.Shared.Model.User;
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
                    FireBaseId = "uid1",
                    UserName = "johndoe",
                    Gender = Gender.Male,
                    Email = "johndoe@example.com",
                    Password = "hashedpassword1",
                    AvatarUrl = "https://example.com/avatar1.png",
                    Phone = "1234567890",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    Weight = 80.5,
                    Height = 180.2,
                    Bio = "Fitness enthusiast",
                    FavoriteSport = new List<Sport> { Sport.Gym, Sport.Running }
                },
                new User
                {
                    FireBaseId = "uid2",
                    UserName = "janesmith",
                    Gender = Gender.Female,
                    Email = "janesmith@example.com",
                    Password = "hashedpassword2",
                    AvatarUrl = "https://example.com/avatar2.png",
                    Phone = "0987654321",
                    DateOfBirth = new DateTime(1992, 5, 20),
                    Weight = 60.3,
                    Height = 165.7,
                    Bio = "Yoga lover",
                    FavoriteSport = new List<Sport> { Sport.Yoga, Sport.Pilates }
                },
                new User
                {
                    FireBaseId = "uid3",
                    UserName = "roberthill",
                    Gender = Gender.Male,
                    Email = "roberthill@example.com",
                    Password = "hashedpassword3",
                    AvatarUrl = "https://example.com/avatar3.png",
                    Phone = "1122334455",
                    DateOfBirth = new DateTime(1985, 9, 10),
                    Weight = 75.0,
                    Height = 175.3,
                    Bio = "Crossfit and cycling fanatic",
                    FavoriteSport = new List<Sport> { Sport.Crossfit, Sport.Cycling }
                },
                new User
                {
                    FireBaseId = "uid4",
                    UserName = "sarahlee",
                    Gender = Gender.Female,
                    Email = "sarahlee@example.com",
                    Password = "hashedpassword4",
                    AvatarUrl = "https://example.com/avatar4.png",
                    Phone = "5544332211",
                    DateOfBirth = new DateTime(1995, 3, 15),
                    Weight = 58.2,
                    Height = 160.8,
                    Bio = "Dancer and fitness lover",
                    FavoriteSport = new List<Sport> { Sport.Dance, Sport.Cardio }
                },
                new User
                {
                    FireBaseId = "uid5",
                    UserName = "michaelgreen",
                    Gender = Gender.Male,
                    Email = "michaelgreen@example.com",
                    Password = "hashedpassword5",
                    AvatarUrl = "https://example.com/avatar5.png",
                    Phone = "6677889900",
                    DateOfBirth = new DateTime(1988, 11, 23),
                    Weight = 85.7,
                    Height = 185.5,
                    Bio = "Climbing and hiking lover",
                    FavoriteSport = new List<Sport> { Sport.Climbing, Sport.Hiking }
                },
                new User
                {
                    FireBaseId = "uid6",
                    UserName = "emilybrown",
                    Gender = Gender.Female,
                    Email = "emilybrown@example.com",
                    Password = "hashedpassword6",
                    AvatarUrl = "https://example.com/avatar6.png",
                    Phone = "1029384756",
                    DateOfBirth = new DateTime(1996, 7, 30),
                    Weight = 63.0,
                    Height = 170.0,
                    Bio = "Pilates and yoga enthusiast",
                    FavoriteSport = new List<Sport> { Sport.Pilates, Sport.Yoga }
                },
                new User
                {
                    FireBaseId = "uid7",
                    UserName = "davidjohnson",
                    Gender = Gender.Male,
                    Email = "davidjohnson@example.com",
                    Password = "hashedpassword7",
                    AvatarUrl = "https://example.com/avatar7.png",
                    Phone = "3344556677",
                    DateOfBirth = new DateTime(1982, 4, 5),
                    Weight = 90.3,
                    Height = 182.5,
                    Bio = "Swimming and crossfit lover",
                    FavoriteSport = new List<Sport> { Sport.Swimming, Sport.Crossfit }
                },
                new User
                {
                    FireBaseId = "uid8",
                    UserName = "oliviabaker",
                    Gender = Gender.Female,
                    Email = "oliviabaker@example.com",
                    Password = "hashedpassword8",
                    AvatarUrl = "https://example.com/avatar8.png",
                    Phone = "4455667788",
                    DateOfBirth = new DateTime(1994, 12, 12),
                    Weight = 59.4,
                    Height = 162.3,
                    Bio = "Yoga and running lover",
                    FavoriteSport = new List<Sport> { Sport.Yoga, Sport.Running }
                }
            );

            #endregion
        }
    }
}
