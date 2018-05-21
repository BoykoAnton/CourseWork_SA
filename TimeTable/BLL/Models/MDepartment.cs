using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    class MDepartment
    {
        public MDepartment()
        {
        }

        public MDepartment(string name, ICollection<MTeatcher> teachers, ICollection<MGroup> groups)
        {
            Name = name;
            Teachers = teachers;
            Groups = groups;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<MTeatcher> Teachers { get; set; }
        public ICollection<MGroup> Groups { get; set; }
    }
}