using core.DbModel;
using core.Helper;
using core.IRepository;
using core.IService;
using core.ViewModel;
using System.Net;

namespace infrastructure.Service
{
    public class DemoService : IDemoService
    {
        public readonly IDemoRepository demoRepository;
        public DemoService(IDemoRepository demoRepository)
        {
            this.demoRepository = demoRepository;
        }

        public ApiResponse GetAllDemoList()
        {            
            try
            {
                this.demoRepository.GetAll();
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
