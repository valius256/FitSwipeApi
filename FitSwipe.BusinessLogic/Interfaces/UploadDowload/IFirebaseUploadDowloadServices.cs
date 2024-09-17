using FitSwipe.Shared.Dtos.UploadDowloads;

namespace FitSwipe.BusinessLogic.Interfaces.UploadDowload
{
    public interface IFirebaseUploadDowloadServices
    {
        Task<string> UploadImageAsync(string userFirebaseId, string fileName, Stream fileStream, string mimeType);
        Task<List<DowloadImagesDtos>> DownloadImagesAsync(string uid);
        Task<string> UploadVideoAsync(string userFirebaseId, string fileName, Stream fileStream);
    }
}
