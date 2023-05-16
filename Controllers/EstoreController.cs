
using Microsoft.AspNetCore.Mvc;

namespace WebAss.Controllers
{
    public class EstoreController: Controller
    {

        private readonly DBConTextProd _dpprod;

        public EstoreController(DBConTextProd dpprod)
        {
            _dpprod = dpprod;
        }

        [HttpPut("EstoreAdd")]
        public IActionResult Index(EstoreHome estoreHome)
        {
            _dpprod.esiteHomes.Add(estoreHome);
            _dpprod.SaveChanges();

            return Ok();
        }

        [HttpGet("EstoreShow")]
        public IEnumerable<EstoreHome> GetAll()
        {
            return _dpprod.estoreHomes;
        }
    }
}


