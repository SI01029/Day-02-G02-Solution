using Microsoft.AspNetCore.Routing.Constraints;

namespace Day_02_G02
{
    public class  Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            #region Configure Service
           // builder.Services.AddControllers(); //Register Built in APIs Service
            builder.Services.AddControllersWithViews(); //Register Built in MVC Service
           // builder.Services.AddRazorPages(); //Register Built in Razor Page Service
           // builder.Services.AddMvc(); //Register All Service

            #endregion

            var app = builder.Build();

            #region Configure Middlewares
            app.UseRouting();

            //app.MapGet("/", () => "Hello World!");
            // app.MapGet("/login", () => "you are sigend in!");
            // app.MapGet("/login",SignIn ); 

            //MVC
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Movies}/{action=GetMovie}/{id:int=12}"  //id optinal id?
               // defaults: new { Controllers = "Movies", action = "GetMovie", id = 2 }//old syntax
               //constraints: new {id=new IntRouteConstraint()} //old syntax
                );

            #endregion

            app.Run();
        }
        public static string SignIn()
        {
            return $"you are sigend in!";
        }
    }
}
