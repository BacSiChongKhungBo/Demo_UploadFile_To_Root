
using BlazorApp7.Services.IServices;
using BlazorInputFile;
using Microsoft.AspNetCore.Components;

namespace BlazorApp7.Pages
{
    public class MyUploadFileBase : ComponentBase
    {
        [Inject]
        protected IUploadFileService uploadFileService { get; set; }
        public IFileListEntry file { get; set; }

        public async Task HandleFileSelected(IFileListEntry[] files)
        {
            //lay file dau tien duoc chon
            file = files.FirstOrDefault();
            if (file != null) 
            {
                await uploadFileService.UploadFileAsync(file);
            }
        }
    }
}
