using Microsoft.AspNetCore.Mvc;

namespace Day_02_G02.Controllers
    //MVC Controller
{
    public class MoviesController : Controller
    {
        // Actions : Public non-static [Object] Member Methods

        public string GetMovie(int id)
        {
            return $" Get Movie with Id: {id}";
        }
        public string AddMovie(int id)
        {
            return $" Add Movie with Id: {id}";
        }

    }
}
