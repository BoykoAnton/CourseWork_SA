using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
using DAL;

namespace BLL
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeTableContext context = new TimeTableContext();
            UnitOfWork UoW = new UnitOfWork(context, new ContextRepository<User>(context), new ContextRepository<Department>(context), new ContextRepository<Group>(context), new ContextRepository<Lesson>(context), new ContextRepository<Auditory>(context), new ContextRepository<Subject>(context), new ContextRepository<Teatcher>(context));
            DepartmentOperations auditoryOperations = new DepartmentOperations(UoW);

            auditoryOperations.AddDepartment(new Models.MDepartment("sgfjks", new List<MTeatcher> { new MTeatcher(null, "sdfs", null)}, new List<MGroup>()));

            foreach (MDepartment a in  auditoryOperations.GetDepartments())
            {
                Console.WriteLine(a.Teachers.ToList()[0].Name);
            }
            Console.Read();

            /*Auditory auditory = new Auditory("Name 1");
            UoW.Auditories.Create(auditory);
            UoW.Save();
            UoW.Lessons.Create(new Lesson(auditory, "Monday", 2, 5));
            UoW.Save();

            Lesson lesson = UoW.Lessons.GetWithInclude(x => x.Auditory).ToList()[0];

            Console.WriteLine(UoW.Lessons.Get().Count());
            Console.WriteLine(UoW.Auditories.Get().Count());

            Console.WriteLine(lesson.Day);
            Console.WriteLine(lesson.Auditory.Name);
            Console.WriteLine(lesson.Para);
            Console.WriteLine(lesson.Week);*/
        }
    }
}
