using DomainLayer.Models;
using Microsoft.AspNetCore.Hosting;

namespace RazorCoreWebApplication.Utilities
{
    public class FileUploadProcess
    {
        public static string UploadFile(IFormFile file)
        {
            string uniqueFileName = string.Empty;

            if (file != null)
            {
                string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }
            
            return uniqueFileName;   
        }

        public static void DeleteFile(string filePath)
        {
            if (filePath != null)
            {
                string currentPath = Path.Combine(Directory.GetCurrentDirectory(),
                       "images", filePath);
                File.Delete(currentPath);
            }
        }
    }
}
