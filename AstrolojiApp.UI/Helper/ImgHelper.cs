namespace AstrolojiApp.Helper
{
    public static class ImgHelper
    {

        // public static async Task<string> ImgUpload(IFormFile file)
        // {
        //     var fileName = file.Name + "-" + Guid.NewGuid().ToString().Split("-")[0] + ".jpg";



        //     if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Img")))
        //     {
        //         Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(),"wwwroot",  "Img"));
        //     }

        //     string filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Img",fileName);

        //     using (var stream=new FileStream(filepath,FileMode.Create))
        //     {
        //        await file.CopyToAsync(stream);
        //     }

        //     var path = "/Img/" + fileName;
        //     return  path;
        // }

        private static readonly string[] AllowedExtensions = { ".jpg", ".jpeg", ".png", ".gif" };
        private static readonly long MaxFileSize = 5 * 1024 * 1024; // 5MB

        public static async Task<string> ImgUpload(IFormFile file)
        {
            // ... existing code ...

            // Dosya adı oluşturma
            var fileName = file.Name + "-" + Guid.NewGuid().ToString().Split("-")[0] + Path.GetExtension(file.FileName);

            // Klasör yolu oluşturma
            var uploadsFolder = Path.Combine("UI", "assets", "img");
            var yearFolder = Path.Combine(uploadsFolder, DateTime.Now.Year.ToString());
            var monthFolder = Path.Combine(yearFolder, DateTime.Now.Month.ToString("00"));

            // Klasörleri oluşturma
            Directory.CreateDirectory(monthFolder);

            // Tam dosya yolu
            var filePath = Path.Combine(monthFolder, fileName);

            try
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                // Web'den erişilebilir yolu döndürme
                return $"/assets/img/{DateTime.Now.Year}/{DateTime.Now.Month:00}/{fileName}";
            }
            catch (Exception ex)
            {
                throw new Exception($"Dosya yükleme hatası: {ex.Message}");
            }
        }
    }
}
