using Day_02_G02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_02_G02.Controllers
    //MVC Controller
{
    public class MoviesController : Controller
    {
        // Actions : Public non-static [Object] Member Methods
        //Actions :Have Special Return Type

        //public string GetMovie(int id)
        //{
        //    return $" Get Movie with Id: {id}";
        //}
        //public string AddMovie(int id)
        //{
        //    return $" Add Movie with Id: {id}";
        //}

        //public ContentResult GetMovie(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"<h1>Get Movie With Id :{id}</h1>",
        //        ContentType = "text/html",
        //        StatusCode=200,
        //    };

        //    return contentResult;
        //}
        //public ContentResult GetMovie(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"<h1>Get Movie With Id :{id}</h1>",
        //        ContentType = "object/pdf",
        //        StatusCode = 200,
        //    };

        //    return contentResult;
        //}
        //public RedirectResult  GetMovie(int id)
        //{
        //    var redirectResult = new RedirectResult("https://wuzzuf.net/jop/egypt")
        //    ;

        //    return redirectResult;
        //}
        //public RedirectToActionResult GetMovie(int id)
        //{
        //    var redirectToActionResult = new RedirectToActionResult("AddMovie", "Movies", new {id=33})
        //    ;

        //    return redirectToActionResult;
        //}
        //public string AddMovie(int id)
        //{
        //    return $" Add Movie with Id: { id}";
        //}
        //public IActionResult GetMovie(int id)
        //{
        //    if (id == 1)
        //        //    return new ContentResult()
        //        //{
        //        //    Content = $"<h1>Get Movie With Id :{id}</h1>",
        //        //    ContentType = "text/html",
        //        //};
        //        return Content($"<h1>Get Movie With Id :{id}</h1>", "text/html");
        //    else if (id == 2)
        //        //return new ContentResult()
        //        //{
        //        //    Content = $"<h1>Get Movie With Id :{id}</h1>",
        //        //    ContentType = "object/pdf",

        //        //  };
        //        return Content($"<h1>Get Movie With Id :{id}</h1>", "object/pdf");
        //    else if (id == 3)
        //        //  return new RedirectResult("https://wuzzuf.net/jop/egypt");
        //        return Redirect("https://wuzzuf.net/jop/egypt");

        //    else
        //       //  return new RedirectToActionResult("AddMovie", "Movies", new { id = 33 });
        //    return RedirectToAction("AddMovie", "Movies", new { id = 33 }); 


        //}

        //public string AddMovie(int id)
        //{
        //    return $" Add Movie with Id: {id}";
        //}


        //Action Parameters [Model] Binding
        //1 Form
        //2 Segements
        //3 Query String
        //4 File

        //[ActionName("GetMovie")]
        //[HttpGet]
        //public IActionResult GetMovie(int id)
        //{
        //    return Content($"<h1>Get Movie With Id :{id}</h1>", "text/html");
        //}

        public IActionResult GetMovie( int Id, string Name,Movie movie,int []arr)
        {
            return Content($"<h1>Get Movie With Id :{movie.Id},Name:{movie.Name}</h1>", "text/html");
        }


    }
}
