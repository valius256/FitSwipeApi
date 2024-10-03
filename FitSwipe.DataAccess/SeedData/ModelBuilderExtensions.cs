using FitSwipe.DataAccess.Model.Entity;
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
                    Id = Guid.NewGuid(),
                    FireBaseId = "123abc",
                    UserName = "john doe",
                    Gender = Gender.Male,
                    Email = "john.doe@example.com",
                    Password = "hashedpassword1", // Ensure this is hashed securely before production
                    AvatarUrl = "https://i.ibb.co/HYsHmpm/pt5.png",
                    Phone = "1234567890",
                    DateOfBirth = DateTime.SpecifyKind(new DateTime(1990, 5, 1), DateTimeKind.Utc), // Set to UTC
                    Weight = 75.5,
                    Height = 180.3,
                    Bio = "Fitness enthusiast and certified personal trainer.",
                    City = "New York",
                    District = "Manhattan",
                    Ward = "Ward 5",
                    Street = "5th Avenue",
                    Role = Role.Trainee,
                    Job = "Student",
                    PricePerHour = 0,
                    Status = UserStatus.Active,
                    Balance = 1000,
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FireBaseId = "456def",
                    UserName = "jane smith",
                    Gender = Gender.Female,
                    Email = "jane.smith@example.com",
                    Password = "hashedpassword2", // Ensure this is hashed securely before production
                    AvatarUrl = "https://i.ibb.co/ZVhq6W7/c239694df88fecb8c521de3dd8625ba10fbbfa14f3559342640b9710e25b9d01-w-1024-h-1024-pmaid-165228136.png",
                    Phone = "0987654321",
                    DateOfBirth = DateTime.SpecifyKind(new DateTime(1985, 8, 20), DateTimeKind.Utc), // Set to UTC
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
                    PricePerHour = 100000,
                    SubscriptionPurchasedDate = DateTime.SpecifyKind(new DateTime(2023, 2, 10), DateTimeKind.Utc), // Set to UTC
                    SubscriptionLevel = 1,
                    SubscriptionPaymentStatus = PaymentStatus.Paid
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FireBaseId = "789ghi",
                    UserName = "alex jones",
                    Gender = Gender.Male,
                    Email = "alex.jones@example.com",
                    Password = "hashedpassword3", // Ensure this is hashed securely before production
                    AvatarUrl = "https://i.ibb.co/zVGS1Xv/pt1.png",
                    Phone = "5551234567",
                    DateOfBirth = DateTime.SpecifyKind(new DateTime(1992, 3, 10), DateTimeKind.Utc), // Set to UTC
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
                    PricePerHour = 150000,
                    PTStatus = PTStatus.Active,
                    PTExperienceYear = 2.0,
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FireBaseId = "101jkl",
                    UserName = "jocker_lol",
                    Gender = Gender.Male,
                    Email = "sarah.smith@example.com",
                    Password = "hashedpassword4", // Ensure this is hashed securely before production
                    AvatarUrl = "https://i.ibb.co/QY6zDfp/pt3.png",
                    Phone = "5559876543",
                    DateOfBirth = DateTime.SpecifyKind(new DateTime(1988, 7, 15), DateTimeKind.Utc), // Set to UTC
                    Weight = 62.5,
                    Height = 170.2,
                    Bio = "Certified yoga instructor and personal trainer with 5 years of experience.",
                    City = "New York",
                    District = "Manhattan",
                    Ward = "Ward 3",
                    Street = "Broadway",
                    Role = Role.PT,
                    Job = "Yoga Instructor",
                    Status = UserStatus.Active,
                    Balance = 3500,
                    PricePerHour = 200000,
                    PTStatus = PTStatus.Active,
                    PTExperienceYear = 5.0,
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FireBaseId = "202mno",
                    UserName = "mike_johnson",
                    Gender = Gender.Male,
                    Email = "mike.johnson@example.com",
                    Password = "hashedpassword5", // Ensure this is hashed securely before production
                    AvatarUrl = "https://i.ibb.co/27LXG3q/pt4.png",
                    Phone = "5552468101",
                    DateOfBirth = DateTime.SpecifyKind(new DateTime(1995, 11, 22), DateTimeKind.Utc), // Set to UTC
                    Weight = 78.3,
                    Height = 180.0,
                    Bio = "CrossFit enthusiast and certified personal trainer specializing in HIIT workouts.",
                    City = "Los Angeles",
                    District = "Santa Monica",
                    Ward = "Ward 2",
                    Street = "Ocean Avenue",
                    Role = Role.PT,
                    Job = "CrossFit Trainer",
                    Status = UserStatus.Active,
                    Balance = 2800,
                    PricePerHour = 180000,
                    PTStatus = PTStatus.Active,
                    PTExperienceYear = 3.5,
                },

                new User
                {
                    Id = Guid.NewGuid(),
                    FireBaseId = "303pqr",
                    UserName = "emma_davis",
                    Gender = Gender.Female,
                    Email = "emma.davis@example.com",
                    Password = "hashedpassword6", // Ensure this is hashed securely before production
                    AvatarUrl = "https://i.ibb.co/TWNFj0M/image.png",
                    Phone = "5553691470",
                    DateOfBirth = DateTime.SpecifyKind(new DateTime(1990, 5, 8), DateTimeKind.Utc), // Set to UTC
                    Weight = 58.7,
                    Height = 165.5,
                    Bio = "Sports nutritionist and strength training coach with a focus on women's fitness.",
                    City = "Seattle",
                    District = "Capitol Hill",
                    Ward = "Ward 5",
                    Street = "Pike Street",
                    Role = Role.PT,
                    Job = "Strength Coach",
                    Status = UserStatus.Active,
                    Balance = 4200,
                    PricePerHour = 220000,
                    PTStatus = PTStatus.Active,
                    PTExperienceYear = 7.0,
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FireBaseId = "404stu",
                    UserName = "carlos_rodriguez",
                    Gender = Gender.Male,
                    Email = "carlos.rodriguez@example.com",
                    Password = "hashedpassword7", // Ensure this is hashed securely before production
                    AvatarUrl = "https://i.ibb.co/mR8n9zJ/pt2.png",
                    Phone = "5557891234",
                    DateOfBirth = DateTime.SpecifyKind(new DateTime(1987, 9, 30), DateTimeKind.Utc), // Set to UTC
                    Weight = 75.8,
                    Height = 175.3,
                    Bio = "Former professional soccer player turned fitness coach. Specializes in sports-specific training.",
                    City = "Miami",
                    District = "South Beach",
                    Ward = "Ward 4",
                    Street = "Ocean Drive",
                    Role = Role.PT,
                    Job = "Sports Performance Coach",
                    Status = UserStatus.Active,
                    Balance = 3800,
                    PricePerHour = 190000,
                    PTStatus = PTStatus.Active,
                    PTExperienceYear = 6.5,
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FireBaseId = "505vwx",
                    UserName = "lisa_chen",
                    Gender = Gender.Female,
                    Email = "lisa.chen@example.com",
                    Password = "hashedpassword8", // Ensure this is hashed securely before production
                    AvatarUrl = "https://i.ibb.co/dDrHRqL/40c820d3e9d438025d4def0dedeab78a883cb8ab8c34614d1fb7d5ddf147668e-w-1024-h-1024-pmaid-165229888.png",
                    Phone = "5554567890",
                    DateOfBirth = DateTime.SpecifyKind(new DateTime(1993, 2, 14), DateTimeKind.Utc), // Set to UTC
                    Weight = 54.2,
                    Height = 162.0,
                    Bio = "Pilates instructor and rehabilitation specialist. Focused on posture correction and core strength.",
                    City = "San Francisco",
                    District = "Marina",
                    Ward = "Ward 2",
                    Street = "Chestnut Street",
                    Role = Role.PT,
                    Job = "Pilates Instructor",
                    Status = UserStatus.Active,
                    Balance = 3200,
                    PricePerHour = 175000,
                    PTStatus = PTStatus.Active,
                    PTExperienceYear = 4.0,
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FireBaseId = "606yza",
                    UserName = "marcus_brown",
                    Gender = Gender.Male,
                    Email = "marcus.brown@example.com",
                    Password = "hashedpassword9", // Ensure this is hashed securely before production
                    AvatarUrl = "https://i.ibb.co/QY6zDfp/pt3.png",
                    Phone = "5552345678",
                    DateOfBirth = DateTime.SpecifyKind(new DateTime(1985, 8, 5), DateTimeKind.Utc), // Set to UTC
                    Weight = 90.5,
                    Height = 188.0,
                    Bio = "Bodybuilding champion and powerlifting coach. Specializes in muscle gain and strength training.",
                    City = "Houston",
                    District = "Midtown",
                    Ward = "Ward 3",
                    Street = "Main Street",
                    Role = Role.PT,
                    Job = "Strength and Conditioning Coach",
                    Status = UserStatus.Active,
                    Balance = 4500,
                    PricePerHour = 230000,
                    PTStatus = PTStatus.Active,
                    PTExperienceYear = 10.0,
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FireBaseId = "707bcd",
                    UserName = "will_taylor",
                    Gender = Gender.Male,
                    Email = "will.taylor@example.com",
                    Password = "hashedpassword10", // Ensure this is hashed securely before production
                    AvatarUrl = "https://i.ibb.co/HYsHmpm/pt5.png",
                    Phone = "5558765432",
                    DateOfBirth = DateTime.SpecifyKind(new DateTime(1991, 12, 18), DateTimeKind.Utc), // Set to UTC
                    Weight = 60.1,
                    Height = 168.5,
                    Bio = "Certified nutritionist and functional fitness trainer. Specializes in weight management and holistic health.",
                    City = "Boston",
                    District = "Back Bay",
                    Ward = "Ward 5",
                    Street = "Newbury Street",
                    Role = Role.PT,
                    Job = "Functional Fitness Trainer",
                    Status = UserStatus.Active,
                    Balance = 3900,
                    PricePerHour = 195000,
                    PTStatus = PTStatus.Active,
                    PTExperienceYear = 3.5,
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
                   TagImage = "https://cdn.tuoitre.vn/ttct//2020/12/13/16078750289060-lich-thi-dau-bong-da-hom-nay-0211.jpg",
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Bơi lội",
                   TagType = TagType.Hobby,
                   TagImage = "https://file.hstatic.net/1000391576/file/boi_loi_7d4d69c53ac1494eabb2a446d4d503a0_grande.jpg",
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Cầu Lông",
                   TagType = TagType.Hobby,
                   TagImage = "https://vecgroup.vn/images/products/2021/08/24/large/qua-cau-long_1629778779.jpg",
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Bóng chuyền",
                   TagType = TagType.Hobby,
                   TagImage = "https://file.hstatic.net/200000333667/article/image.jpg_4b1e1c8ce20f4c32824f275f34ff30af_1024x1024.jpg",
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Bóng rổ",
                   TagType = TagType.Hobby,
                   TagImage = "https://thethaothienlong.vn/wp-content/uploads/2022/04/Kich-thuoc-qua-bong-ro-1.jpg",
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Thể thao nói chung",
                   TagType = TagType.Hobby,
                   TagImage = "https://llv.edu.vn/media/2018/09/iStock-949190756-800x440.jpg",
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Bida",
                   TagType = TagType.Hobby,
                   TagImage = "https://billiardshoanthuy.vn/wp-content/uploads/2021/05/phu-kien-ban-bida-2.jpg",
                   CreateById = "123abc",
               },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Tập Gym",
                    TagType = TagType.Hobby,
                    TagImage = "https://tiki.vn/blog/wp-content/uploads/2023/07/elite-fitness-1024x583.jpg",
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Đi, chạy bộ",
                    TagType = TagType.Hobby,
                    TagImage = "https://pos.nvncdn.com/be3294-43017/art/artCT/20230228_9uObLfWys7Q0IXe4.jpg",
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Phim ảnh",
                    TagImage = "https://lawnet.vn/uploads/image/2023/10/17/015815855.jpg",
                    TagType = TagType.Hobby,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Truyện tranh",
                    TagImage = "https://taschen.makaira.media/taschen/image/upload/f_webp,w_1200/v1673462260/products-live/a3d446fb0046b587eb0ed76edca3f4d6.jpg",
                    TagType = TagType.Hobby,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Du lịch",
                    TagImage = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/18/4f/7d/fc/caption.jpg?w=1200&h=1200&s=1",
                    TagType = TagType.Hobby,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Thể thao trí tuệ",
                    TagImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/ChessSet.jpg/640px-ChessSet.jpg",
                    TagType = TagType.Hobby,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Đọc sách",
                    TagImage = "https://images.theconversation.com/files/45159/original/rptgtpxd-1396254731.jpg?ixlib=rb-4.1.0&q=45&auto=format&w=1356&h=668&fit=crop",
                    TagType = TagType.Hobby,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Khoa học",
                    TagImage = "https://www.training.com.au/wp-content/uploads/science-stem-feature.png",
                    TagType = TagType.Hobby,
                    CreateById = "123abc",
                },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Game",
                   TagImage = "https://genk.mediacdn.vn/139269124445442048/2022/7/28/tmb-1658998970448906989995.jpg",
                   TagType = TagType.Hobby,
                   CreateById = "123abc",
               },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Nhiếp ảnh",
                    TagImage = "https://aaftonline.com/blog/wp-content/uploads/2024/01/What-are-the-Benefits-of-Photography-Complete-Overview.png",
                    TagType = TagType.Hobby,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Hội họa",
                    TagImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg/1200px-Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg",
                    TagType = TagType.Hobby,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Nghe nhạc",
                    TagImage = "https://static.vecteezy.com/system/resources/thumbnails/037/044/052/small_2x/ai-generated-studio-shot-of-black-headphones-over-music-note-explosion-background-with-empty-space-for-text-photo.jpg",
                    TagType = TagType.Hobby,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Chơi nhạc cụ",
                    TagImage = "https://t3.ftcdn.net/jpg/01/34/38/92/360_F_134389281_5Jak3tbsoDggHIfIKKwJ8L7064ACIMNE.jpg",
                    TagType = TagType.Hobby,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Tán gẫu",
                    TagImage = "https://transcode-v2.app.engoo.com/image/fetch/f_auto,c_lfill,w_300,dpr_3/https://assets.app.engoo.com/images/rGTEEA2fm66YMzeJz2UbwkKOW62bZVlqKOKZrXlMN7g.jpeg",
                    TagType = TagType.Hobby,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Công nghệ",
                    TagImage = "https://www.simplilearn.com/ice9/free_resources_article_thumb/Technology_Trends.jpg",
                    TagType = TagType.Hobby,
                    CreateById = "123abc",
                },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Lịch Sử",
                   TagImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRWz_tIgvQXPAaSmvYa7CqZo_biaRK9D_O8uA&s",
                   TagType = TagType.Hobby,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Địa lý",
                   TagImage = "https://www.aag.org/wp-content/uploads/2021/12/shutterstock_1111879247.jpg",
                   TagType = TagType.Hobby,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Triết học",
                   TagImage = "https://www.rollingstone.com/wp-content/uploads/2024/01/unlocking_the_power_why_you_should_consider_hiring_philosophy_graduates-.jpg",
                   TagType = TagType.Hobby,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Sống Ảo",
                   TagImage = "https://imagev3.vietnamplus.vn/w1000/Uploaded/2024/hotnnz/2024_08_13/song-ao3-6646.jpg.webp",
                   TagType = TagType.Hobby,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Quản lý cân nặng",
                   TagImage = "https://thanhnien.mediacdn.vn/Uploaded/minhnguyet/2022_05_10/an-kieng-9141.jpg",
                   TagType = TagType.Target,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Phát triển cơ bắp",
                   TagImage = "https://www.dmoose.com/cdn/shop/articles/feature-image_87a28752-6da3-4be8-8814-d5221236136d.jpg?v=1676644951",
                   TagType = TagType.Target,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Có body chuẩn chỉnh",
                   TagImage = "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/fitness_la_gi_loi_ich_va_phuong_phap_tap_luyen_fitness_1_3c4e094223.png",
                   TagType = TagType.Target,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Phòng tránh bệnh",
                   TagImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s",
                   TagType = TagType.Target,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Cải thiện tình trạng bệnh",
                   TagImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s",
                   TagType = TagType.Target,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Tăng cảm giác hạnh phúc, giảm căng thẳng",
                   TagImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8ZXc_bemAYbupxmGz0pZGy4L1Zr6hGVsYdA&s",
                   TagType = TagType.Target,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Cải thiện sự dẻo dai",
                   TagImage = "https://cdn.shopify.com/s/files/1/0453/0381/files/fullsizeoutput_2d4_1024x1024.jpg?v=1662646979",
                   TagType = TagType.Target,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Cải thiện sức bền",
                   TagImage = "https://vinmec-prod.s3.amazonaws.com/images/20210524_085806_814180_chay-bo-bao-nhieu-cal.max-800x800.jpg",
                   TagType = TagType.Target,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Cải thiện sức khỏe tổng quát",
                   TagImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThCjFemkP0h0IZYpu31k-xGK9IvigaysteqA&s",
                   TagType = TagType.Target,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Yoga / Pilates",
                   TagImage = "https://thamtapyoga.vn/wp-content/uploads/2024/01/3-2.jpeg",
                   TagType = TagType.TrainingType,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Calisthenic",
                   TagImage = "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/giai_dap_thac_mac_calisthenics_khac_gi_gym_1_8d5dd4026b.jpg",
                   TagType = TagType.TrainingType,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Tập sức mạnh",
                   TagImage = "https://www.thethaothientruong.vn/uploads/2020/Powerlifting-la-gi.jpg",
                   TagType = TagType.TrainingType,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Cardio",
                   TagImage = "https://file.hstatic.net/1000308068/file/tap-cardio-vao-luc-nao-la-hieu-qua-nhat_cb884317c05d4df980138121ee113112_grande.jpg",
                   TagType = TagType.TrainingType,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "HIIT",
                   TagImage = "https://hips.hearstapps.com/hmg-prod/images/athletes-doing-push-ups-with-dumbbells-on-floor-royalty-free-image-1638463573.jpg",
                   TagType = TagType.TrainingType,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Kickfit",
                   TagImage = "https://storage.googleapis.com/leep_app_website/2020/11/Kick-fit-khong-phai-la-kick-boxing.jpg",
                   TagType = TagType.TrainingType,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Tập ép dẻo",
                   TagImage = "https://prod-everyoneactive-wp.s3.eu-west-2.amazonaws.com/wp-content/uploads/2020/03/23151503/flexibility-at-home.jpg",
                   TagType = TagType.TrainingType,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Thể dục nhịp điệu, theo nhạc",
                   TagImage = "https://i.vietgiaitri.com/2018/10/9/the-duc-nhip-dieu-b2ab9f.jpg",
                   TagType = TagType.TrainingType,
                   CreateById = "123abc",
               },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Cùng giới",
                    TagType = TagType.PTTaste,
                    SpecialTag = SpecialTag.SameGender,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Khác giới",
                    TagType = TagType.PTTaste,
                    SpecialTag = SpecialTag.DifferentGender,
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
                   Name = "Cung cấp giá cả phải chăng",
                   TagType = TagType.PTTaste,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Gần",
                   SpecialTag = SpecialTag.Close,
                   TagType = TagType.PTTaste,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Tâm huyết với học viên",
                   TagType = TagType.PTTaste,
                   CreateById = "123abc",
               },             
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Có trách nhiệm",
                   TagType = TagType.PTTaste,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Có kinh nghiệm",
                   TagType = TagType.PTTaste,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Không nặng nề với học viên",
                   TagType = TagType.PTTaste,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Giàu kiến thức",
                   TagType = TagType.PTTaste,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Luôn sẵn sàng tư vấn ngoài giờ",
                   TagType = TagType.PTTaste,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Biết truyền cảm hứng, tạo động lực",
                   TagType = TagType.PTTaste,
                   CreateById = "123abc",
               },
               new Tag
               {
                   Id = Guid.NewGuid(),
                   Name = "Đảm bảo mục tiêu cho học viên",
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
               },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Vui tính, hài hước",
                    TagType = TagType.SelfDescription,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Hòa đồng",
                    TagType = TagType.SelfDescription,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Năng động",
                    TagType = TagType.SelfDescription,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Dễ gần",
                    TagType = TagType.SelfDescription,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Thi thoảng bất thường",
                    TagType = TagType.SelfDescription,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Lạnh lùng, ít nói",
                    TagType = TagType.SelfDescription,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Nhút nhát",
                    TagType = TagType.SelfDescription,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Nhạy cảm",
                    TagType = TagType.SelfDescription,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Dễ nản",
                    TagType = TagType.SelfDescription,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Hay bị lười",
                    TagType = TagType.SelfDescription,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Sẵn sàng học hỏi",
                    TagType = TagType.SelfDescription,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Hiền lành",
                    TagType = TagType.SelfDescription,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Rảnh rỗi",
                    TagType = TagType.SelfDescription,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Cầu toàn",
                    TagType = TagType.SelfDescription,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Thoải mái",
                    TagType = TagType.SelfDescription,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Dễ bị khó chịu",
                    TagType = TagType.SelfDescription,
                    CreateById = "123abc",
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Độc thân lâu năm",
                    TagType = TagType.SelfDescription,
                    CreateById = "123abc",
                }

            );
            #endregion

            #region EmailTemplateModel

            modelBuilder.Entity<EmailTemplate>().HasData(
                new EmailTemplate
                {
                    Id = Guid.NewGuid(),
                    Name = "Register_Mail",
                    Status = true,
                    Body = "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe",
                    Params = "[Name], [VerificationLink]",
                    Subject = "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn",
                    Description = "Email này được gửi để xác nhận đăng ký tài khoản FitWipe."
                }
            );

            modelBuilder.Entity<EmailTemplate>().HasData(
                new EmailTemplate
                {
                    Id = Guid.NewGuid(),
                    Name = "Forgot_Password",
                    Status = true,
                    Body = "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn tại FitWipe. Kính gửi [Name], vui lòng đặt lại mật khẩu của bạn bằng cách nhấn vào đường link sau: <a href=\"[ResetPasswordLink]\">Đặt lại mật khẩu</a>.<br><br>Nếu bạn không yêu cầu việc này, vui lòng bỏ qua email này.<br><br>Đội ngũ FitWipe",
                    Params = "[Name], [ResetPasswordLink]",
                    Subject = "Yêu cầu đặt lại mật khẩu FitWipe",
                    Description = "Email này được gửi khi người dùng yêu cầu đặt lại mật khẩu cho tài khoản FitWipe."
                }
            );

            #endregion

            #region Slot

            

            #endregion
        }
    }
}
