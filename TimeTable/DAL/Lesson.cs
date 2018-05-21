using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Lesson
    {
        public Lesson() { }

        public Lesson(Auditory Auditory, string Day, int Week, int Para)
        {
            this.Auditory = Auditory;
            this.Day = Day;
            this.Week = Week;
            this.Para = Para;
        }
        public int Id { get; set; }

        public string Day { get; set; }
        public int Week { get; set; }
        public int Para { get; set; }

        public Group Group { get; set; }

        public Teatcher Teacher { get; set; }

        public Auditory Auditory { get; set; }

        public Subject Subject { get; set; }
    }
}
