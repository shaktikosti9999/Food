using core.IService;
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
            return Ok(result);

        }
    }
}
