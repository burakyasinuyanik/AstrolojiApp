namespace AstrolojiApp.Helper
{
    public static class ImgHelper
    {

        public static async Task<string> ImgUpload(IFormFile file)
        {
            var fileName = file.Name + "-" + Guid.NewGuid().ToString().Split("-")[0] + ".jpg";

            

            if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Img")))
            {
                Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(),"wwwroot",  "Img"));
            }

            string filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Img",fileName);

            using (var stream=new FileStream(filepath,FileMode.Create))
            {
               await file.CopyToAsync(stream);
            }

            var path = "/Img/" + fileName;
            return  path;
        }
    }
}
