using core.DbModel;
using core.Helper;
using core.IService;
using core.ViewModel;
using System.Net;

namespace infrastructure.Service
{
    public class DemoService : IDemoService
    {
        public ApiResponse GetAllDemoList()
        {
            try
            {
                Demo demo = new Demo();
                DemoViewModel demoVm = new DemoViewModel();
                demoVm.Id = demo.Id;
                demoVm.DemoText = demo.DemoText;
                return new ApiResponse(HttpStatusCode.OK, APIStatus.Success, null, demoVm);
            }
            catch (Exception ex)
            {
                return new ApiResponse(HttpStatusCode.ExpectationFailed, APIStatus.Error, ex.Message.ToString(), null);
            }
        }

    }
}
