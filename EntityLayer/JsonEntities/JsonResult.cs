using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.JsonEntities
{
    public class JsonResult
    {
        public string Base { get; set; }
        public string lastupdate { get; set; }
        public MyClass [] data { get; set; }
    }
}
