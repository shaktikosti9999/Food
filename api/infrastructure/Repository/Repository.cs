using core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Repository
{
    public class Repository : IRepository
    {
        public string GetAll()
        {
            return "Test";
        }
    }
}
