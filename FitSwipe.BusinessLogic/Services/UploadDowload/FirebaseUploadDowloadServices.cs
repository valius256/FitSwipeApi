﻿using FitSwipe.BusinessLogic.Interfaces.UploadDowload;
using FitSwipe.Shared.Dtos.UploadDowloads;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Storage.v1.Data;
using Google.Cloud.Storage.V1;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;


namespace FitSwipe.BusinessLogic.Services.UploadDowload
{
    public class FirebaseUploadDowloadServices : IFirebaseUploadDowloadServices
    {

        private readonly string ServiceAccountPath =
                @"D:\Semester8\Exe201\Project\FitSwipeApi\FitSwipe.API\fit-swipe-161d7-firebase-adminsdk-l0tth-9884dc9fa1.json";
        private readonly string StorageBucketName = "fit-swipe-161d7.appspot.com";



        public async Task<string> UploadVideoAsync(string userFirebaseId, string fileName, Stream fileStream)
        {
            try
            {
                var contentType = GetContentType(fileName);
                if (string.IsNullOrEmpty(contentType))
                {
                    throw new ArgumentException("Invalid video file type");
                }
                var videoUrl = await UploadMediaToFirebaseStorage(userFirebaseId, fileName, fileStream, contentType);


                return videoUrl;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to upload video: {ex.Message}");
                throw;
            }
        }

        private async Task EnsurePublicAccess(StorageClient storage)
        {
            var policy = storage.GetBucketIamPolicy(StorageBucketName);
            if (!policy.Bindings.Any(b => b.Role == "roles/storage.objectViewer" && b.Members.Contains("allUsers")))
            {
                policy.Bindings.Add(new Policy.BindingsData
                {
                    Role = "roles/storage.objectViewer",
                    Members = new List<string> { "allUsers" }
                });
                storage.SetBucketIamPolicy(StorageBucketName, policy);
            }
        }

        public static async Task<(Image Image, IImageFormat Format)> LoadImageWithFormatAsync(Stream stream)
        {
            // Detect the image format
            IImageFormat format = Image.DetectFormat(stream);

            // Rewind the stream for loading the image
            stream.Position = 0;

            // Load the image
            Image image = await Image.LoadAsync(stream);

            return (image, format);
        }


        public async Task<string> UploadImageAsync(string userFirebaseId, string fileName, Stream fileStream, string mimeType)
        {
            try
            {

                var contentType = GetContentTypeImage(mimeType);
                if (string.IsNullOrEmpty(contentType))
                {
                    throw new ArgumentException("Invalid image file type");
                }

                var imageUrl = await UploadMediaToFirebaseStorage(userFirebaseId, fileName, fileStream, contentType);

                return imageUrl;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to upload image: {ex.Message}");
                throw;
            }
        }

        public async Task<List<DowloadImagesDtos>> DownloadImagesAsync(string uid)
        {
            var downloadLinksList = new List<DowloadImagesDtos>();
            var storage = StorageClient.Create(GoogleCredential.FromFile(ServiceAccountPath));
            try
            {
                // Reference to the folder containing images for the given uid
                var objects = storage.ListObjects(StorageBucketName, $"images/{uid}/");

                var urlSigner = UrlSigner.FromCredential(
                    GoogleCredential.FromFile(ServiceAccountPath).UnderlyingCredential as ServiceAccountCredential);


                foreach (var obj in objects)
                {
                    // Extracting the file Name from the full object Name
                    var fileName = obj.Name.Substring(obj.Name.LastIndexOf('/') + 1);

                    // Generate a signed URL for each image
                    var url = urlSigner.Sign(
                        obj.Bucket,
                        obj.Name,
                        TimeSpan.FromDays(7),
                        HttpMethod.Get);
                    var fetchUrl = storage.GetObjectAsync(obj.Bucket, obj.Name);

                    // Create DTO object
                    var dto = new DowloadImagesDtos
                    {
                        Uid = uid,
                        Url = url,
                        FileName = fileName // Assigning the extracted file Name
                    };

                    downloadLinksList.Add(dto);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating download links: {ex.Message}");
                // Handle exceptions according to your requirement
            }

            return downloadLinksList;
        }


        private async Task<string> UploadMediaToFirebaseStorage(string uid, string fileName, Stream fileStream, string contentType)
        {
            try
            {
                var storage = StorageClient.Create(GoogleCredential.FromFile(ServiceAccountPath));
                await EnsurePublicAccess(storage);

                // Determine the folder based on content type
                var folder = contentType.StartsWith("image/") ? "images" : "videos";
                var storageFileName = $"{folder}/{uid}/{fileName}";
                await storage.UploadObjectAsync(StorageBucketName, storageFileName, contentType, fileStream);

                var storageObject = await storage.GetObjectAsync(StorageBucketName, storageFileName);
                storage.UpdateObject(storageObject,
                    new UpdateObjectOptions { PredefinedAcl = PredefinedObjectAcl.PublicRead });

                return $"https://storage.googleapis.com/{StorageBucketName}/{storageFileName}";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to upload media to Firebase Storage: {ex.Message}");
                throw;
            }
            finally
            {
                // Dispose the stream to release resources
                fileStream.Dispose();
            }
        }
        // handle multiple type vide 

        private string GetContentType(string fileName)
        {
            var extension = Path.GetExtension(fileName).ToLowerInvariant();
            return extension switch
            {
                ".mp4" => "video/mp4",
                ".avi" => "video/x-msvideo",
                ".mov" => "video/quicktime",
                ".wmv" => "video/x-ms-wmv",
                ".flv" => "video/x-flv",
                ".mkv" => "video/x-matroska",
                ".webm" => "video/webm",
                _ => null
            };
        }

        private string GetContentTypeImage(string fileName)
        {
            var extension = fileName;
            return extension switch
            {
                "image/jpg" or "image/jpeg" => "image/jpeg",
                "image/png" => "image/png",
                "image/gif" => "image/gif",
                "image/bmp" => "image/bmp",
                "image/tiff" or "image/tif" => "image/tiff",
                "image/webp" => "image/webp",
                "image/heif" or "image/heic" => "image/heif",
                _ => throw new ArgumentException("Unsupported image file type")
            };
        }

    }
}