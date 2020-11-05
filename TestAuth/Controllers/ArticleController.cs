using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestAuth.Models;

namespace TestAuth.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Section()
        {
            return View();
        }
        public IActionResult GetArticle(int id) 
        {

            /*var a = db.Articles.SingleOrDefault(x => x.Id == id);

            if (a != null)
            {
                List<string> html = new List<string>() { a.Header,  a.Content, a.Button };
                return View("Section", html);
            }
            return View("Section");*/

            //Костыыыыль. Аж стыдно, но я пока не знаю как мне хранить html в бд( Так я мог бы подключить код выше и все было чики пуки.

            switch (id)
            {
                case (1):
                    string a1 = "GetArticle" + Convert.ToString(id);
                    List<string> html1 = new List<string>() { TestArticleData.Article1, a1};
                    return View("Section", html1);

                case (2):
                    string a2 = "GetArticle" + Convert.ToString(id);
                    List<string> html2 = new List<string>() { TestArticleData.Article2, a2 };
                    return View("Section", html2);

                case (3):
                    string a3 = "GetArticle" + Convert.ToString(id);
                    List<string> html3 = new List<string>() { TestArticleData.Article3, a3 };
                    return View("Section", html3);

                case (4):
                    string a4 = "GetArticle" + Convert.ToString(id);
                    List<string> html4 = new List<string>() { TestArticleData.Article4, a4 };
                    return View("Section", html4);

                case (5):
                    string a5 = "GetArticle" + Convert.ToString(id);
                    List<string> html5 = new List<string>() { TestArticleData.Article5, a5 };
                    return View("Section", html5);

                default:
                    string a = "GetArticle" + Convert.ToString(id);
                    List<string> html = new List<string>() { TestArticleData.Article1, a };
                    return View("Section", html);

            }

        }
    }
}
