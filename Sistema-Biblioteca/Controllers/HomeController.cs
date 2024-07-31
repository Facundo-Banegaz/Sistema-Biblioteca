using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_Biblioteca.Models;
using System.Diagnostics;

namespace Sistema_Biblioteca.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       
        public HomeController(ILogger<HomeController> logger) 
        {
            _logger = logger;
        }


        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }


        [Authorize(Roles = "Administrator")]

        public IActionResult Acceso()
        {
            return View();
        }

        [Authorize(Roles = "Librarian")]

        public IActionResult Bibliotecario()
        {

                return View();  
        }
        //public IActionResult GetImage(int id)
        //{
        //    Book requestedBook = _context.Books.FirstOrDefault(b => b.Id == id);
        //    if (requestedBook != null)
        //    {
        //        string webRootpath = _environment.WebRootPath;
        //        string folderPath = "\\images\\";
        //        string fullPath = webRootpath + folderPath + requestedBook.ImageName;
        //        if (System.IO.File.Exists(fullPath))
        //        {
        //            FileStream fileOnDisk = new FileStream(fullPath, FileMode.Open);
        //            byte[] fileBytes;
        //            using (BinaryReader br = new BinaryReader(fileOnDisk))
        //            {
        //                fileBytes = br.ReadBytes((int)fileOnDisk.Length);
        //            }
        //            return File(fileBytes, requestedBook.ImageMimeType);
        //        }
        //        else
        //        {
        //            if (requestedBook.PhotoFile.Length > 0)
        //            {
        //                return File(requestedBook.PhotoFile, requestedBook.ImageMimeType);
        //            }
        //            else
        //            {
        //                return NotFound();
        //            }
        //        }
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
