using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend
{
    internal class Department
    {
        public int id { get; set; }
        public string description { get; set; }
        public int parentId { get; set; }
    }
}
