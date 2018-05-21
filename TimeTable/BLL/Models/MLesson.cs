using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    class MLesson
    {
        public MLesson() { }

        public MLesson(MAuditory Auditory, string Day, int Week, int Para)
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

        public MGroup Group { get; set; }

        public MTeatcher Teacher { get; set; }

        public MAuditory Auditory { get; set; }

        public MSubject Subject { get; set; }
    }
}
