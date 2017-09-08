using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public string HelloTeacher(string university)
        {
            return "Hello Nguyễn Công Hoan!! - University: " + university;
        }
        public ActionResult ListBook()
        {
            var books = new List<string>();
            books.Add("Lap trinh huong doi tuong");
            books.Add(" Lap trinh web");
            books.Add("Cong nghe phan mem");
            ViewBag.SanPhams = books;
            return View();
        }
        public ActionResult ListBookModel()
        {
            var books = new List<Book>();
            books.Add(new Book(1, "Lap trinh hUONG doi TUONG", "NguYen Van An", "/Content/image/book1cover.png"));
            books.Add(new Book(2, "Lap trinh hUONG doi TUONG", "NguYen Van An", "/Content/image/book2cover.png"));
            books.Add(new Book(3, "Lap trinh hUONG doi TUONG", "NguYen Van An", "/Content/image/book3cover.png"));
            return View(books);
        }
    }
}