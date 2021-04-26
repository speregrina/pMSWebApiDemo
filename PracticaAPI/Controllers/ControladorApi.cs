using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace PracticaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControladorApi : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Models.ImagesGallery> metodo()
        {
            using (var db = new Models.AppClubSuizoContext())
            {
                IEnumerable<Models.ImagesGallery> imageneGal = db.ImagesGalleries.ToList();
                return imageneGal;
            }
        }
    }
}
