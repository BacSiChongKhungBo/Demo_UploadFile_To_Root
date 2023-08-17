using BlazorInputFile;

namespace BlazorApp7.Services.IServices
{
    public interface IUploadFileService
    {
        Task UploadFileAsync(IFileListEntry file);
    }
}
