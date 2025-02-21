using core.DbModel;
using core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.IService
{
    public interface IDemoService
    {
        public ApiResponse GetAllDemoList();
    }
}
