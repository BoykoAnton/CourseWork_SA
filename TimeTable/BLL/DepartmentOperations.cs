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
    class DepartmentOperations
    {
        IMapper DepartmentsToM = new MapperConfiguration(cfg => cfg.CreateMap<Department, MDepartment>()).CreateMapper();
        private readonly UnitOfWork _uow;
        public DepartmentOperations(UnitOfWork uow)
        {
            this._uow = uow;
        }

        public List<MDepartment> GetDepartments()
        {
            return DepartmentsToM.Map<IEnumerable<Department>, List<MDepartment >>(_uow.Departaments.GetWithInclude(x => x.Teachers, x => x.Groups));

        }
        public MDepartment GetDepartmentById(int id)
        {
            return DepartmentsToM.Map<Department, MDepartment>(_uow.Departaments.GetOne(x => (x.Id == id)));

        }
        public void AddDepartment (MDepartment department)
        {
            _uow.Departaments.Create(new Department { Name = department.Name });
            _uow.Save();
        }

        public void DeletDepartmentByID(int id)
        {
            _uow.Departaments.Remove(_uow.Departaments.FindById(id));
            _uow.Save();
        }
        
    }
}
