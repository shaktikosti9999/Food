using core.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/Test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private IDemoService _iDemoService;

        public TestController(IDemoService iDemoService)
        {
            _iDemoService = iDemoService;
        }

        [HttpGet]
        [Route("GetAllTest")]
        public ActionResult GetAllTest()
        {
            var result = _iDemoService.GetAllDemoList();

            List<string> strings = new List<string>();
            strings.Add("Shakti");
            strings.Add("Koshti");
            return Ok(strings);

        }
    }
}
