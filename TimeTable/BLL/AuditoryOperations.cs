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
    class AuditoryOperations
    {
        IMapper AuditoryToM = new MapperConfiguration(cfg => cfg.CreateMap<Auditory, MAuditory>()).CreateMapper();
        private readonly UnitOfWork _uow;

        public AuditoryOperations(UnitOfWork uow)
        {
            this._uow = uow;
        }

        public List<MAuditory> GetAuditories()
        {
            return AuditoryToM.Map<IEnumerable<Auditory>, List<MAuditory>>(_uow.Auditories.Get());

        }

        public MAuditory GetAuditoryById(int id)
        {
            return AuditoryToM.Map<Auditory, MAuditory>(_uow.Auditories.GetOne(x => (x.Id == id)));

        }

        public void AddAuditory(MAuditory group)
        {
            _uow.Auditories.Create(new Auditory { Name = group.Name });
            _uow.Save();
        }

        public void DeleteAuditoryByID(int id)
        {
            _uow.Auditories.Remove(_uow.Auditories.FindById(id));
            _uow.Save();
        }
        
    }
}
