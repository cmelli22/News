using Infraestructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Implementation;
using System.Threading.Tasks;

namespace NewsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsServices _newsServices;

        public NewsController(INewsServices newsServices)
        {
            _newsServices = newsServices;
        }

        [HttpGet]
        [Route("search")]
        public async Task<IActionResult> Search([FromQuery]SearchRequest request)
        {
            var reply = await _newsServices.GetEverything(request);
            return Ok(reply);
        }

        [HttpGet]
        [Route("top-headlines")]
        public async Task<IActionResult> GetTopHeadLines([FromQuery] TopHeadLinesRequest request)
        {
            var reply = await _newsServices.GetTopHeadLines(request);
            return Ok(reply);
        }
    }
}
