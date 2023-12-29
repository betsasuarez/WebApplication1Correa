using Microsoft.AspNetCore.Mvc;

namespace WebApplication1Correa.Controllers
{
    public class ContactController : Controller
    {
        public string[] Get()
        {
            return new string[]
            {
             "Hello","World"
            };

        }

    }
}

       