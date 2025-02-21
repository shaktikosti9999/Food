using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.DbModel
{
    public class Demo
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public int rowId { get; set; }
        public string? demoText { get; set; }

    }
}
