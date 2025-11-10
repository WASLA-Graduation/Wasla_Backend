namespace Wasla_Backend.Helpers.File
{
    public static class FileOperation
    {
        public static async Task<string> SaveFile(IFormFile file, string filePath)
        {
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
            var path = Path.Combine(filePath, fileName);

            using var stream = System.IO.File.Create(path); 
            await file.CopyToAsync(stream);

            return fileName;
        }

        public static void DeleteFile(string fileName, string filePath)
        {
            var fileUrl = Path.Combine(filePath, fileName);

            if (System.IO.File.Exists(fileUrl)) 
                System.IO.File.Delete(fileUrl);
        }
    }


}
