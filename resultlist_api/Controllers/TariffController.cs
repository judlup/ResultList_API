using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using resultlist_api.Models;

namespace resultlist_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TariffController : ControllerBase
    {
        [DisableCors]
        [HttpGet()]
        public dynamic Get()
        {
            dynamic jsonFromFile;
            using(var reader =  new StreamReader("./Data/Data.json"))
            {
                jsonFromFile = reader.ReadToEnd();
            }
            
            return Ok(jsonFromFile);
        }
    } 
}
