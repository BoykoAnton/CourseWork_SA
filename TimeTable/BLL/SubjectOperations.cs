using BLL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BLL
{
    class SubjectOperations
    {
        IMapper SubjectToM = new MapperConfiguration(cfg => cfg.CreateMap<Subject, MSubject>()).CreateMapper();
        private readonly UnitOfWork _uow;

        public SubjectOperations(UnitOfWork uow)
        {
            this._uow = uow;
        }

        public List<MSubject> GetSubjects()
        {
            return SubjectToM.Map<IEnumerable<Subject>, List<MSubject>>(_uow.Subjects.Get());

        }

        public MSubject GetSubjectsById(int id)
        {
            return SubjectToM.Map<Subject, MSubject>(_uow.Subjects.GetOne(x => (x.Id == id)));

        }

        public void AddSubjects(MSubject subject)
        {
            _uow.Subjects.Create(new Subject { Name = subject.Name });
            _uow.Save();
        }

        public void DeleteSubjectByID(int id)
        {
            _uow.Subjects.Remove(_uow.Subjects.FindById(id));
            _uow.Save();
        }
        
    }
}
