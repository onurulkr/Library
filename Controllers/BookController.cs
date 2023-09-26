using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        BookManager bookManager = new BookManager(new EfBookDal());

        public IActionResult Index()
        {
            var values = bookManager.TGetList();

            return View(values);
        }

        [HttpGet]
        public PartialViewResult AddBook()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddBook(Book b)
        {
            // Kitap eklerken gerekli alanların doldurulup doldurulmadığını kontrol eder
            if (ModelState.IsValid)
            {
                if (!string.IsNullOrWhiteSpace(b.BookName) && !string.IsNullOrWhiteSpace(b.BookWriter))
                {
                    bookManager.TAdd(b);

                    return RedirectToAction("Index", "Book");
                }
                else
                {
                    ModelState.AddModelError("", "Kitap adı ve yazar alanları boş olamaz.");
                }
            }

            return View(b);
        }

    }
}
