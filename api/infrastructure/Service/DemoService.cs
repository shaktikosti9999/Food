using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using core.DbModel;
using core.IService;
using core.ViewModel;

namespace infrastructure.Service
{
    class DemoService : IDemoService
    {
        public ApiResponse GetAllDemoList()
        {
            try
            {
                Demo demo = new Demo();
                DemoViewModel demoVm = new DemoViewModel();
                demoVm.id = demo.id;
                demoVm.demoText = demo.demoText;

                return new ApiResponse("Sucess", null, demoVm);
            }
            catch (Exception ex)
            {
                return new ApiResponse("Fail", ex.Message.ToString(), null);                
            }
        }

    }
}
