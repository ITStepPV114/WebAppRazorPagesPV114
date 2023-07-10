using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPagesPV114.Pages.Movies
{
    public class ListMoviesModel : PageModel
    {
        public string UserName { get; }
        public ListMoviesModel() { 
            UserName= "admin";
        }
        public string PrintHello()
        {
            return "Hello, World";
        }
        public void OnGet()
        {
        }
    }
}
