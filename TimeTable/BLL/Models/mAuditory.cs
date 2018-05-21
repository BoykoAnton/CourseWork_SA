using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    class MAuditory
    {
        public MAuditory() { }
        public MAuditory(string Name)
        {
            this.Name = Name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
