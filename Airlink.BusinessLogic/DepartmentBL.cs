using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Airlink.Data;
using Airlink.Framework;
using Microsoft.SqlServer.Server;

namespace Airlink.BusinessLogic
{
    public class DepartmentBL
    {
        private AirlinkDbEntities context = DataAccess.Context;
        public Result<List<Department>> GetAllDepartments(string name, int? page, int? pageSize)
        {
            var result = new Result<List<Department>>();

            var query = from d in context.Departments
                select d;
            if (ValidationHelper.IsStringValid(name))
            {
                query = from d in query
                    where d.Name.Contains(name)
                    select d;
            }
            if (page.HasValue && pageSize.HasValue)
            {
                query = (from d in query
                    select d).Skip((page.Value - 1)*pageSize.Value).Take(pageSize.Value);
            }

            result.Data = query.ToList();
            return result;

        }

        public Result<Department> GetDepartmentById(string id)
        {
            var result = new Result<Department>();

            if (ValidationHelper.IsIntValid(id))
            {
                result.HasError = true;
                result.Messages.Add("Invalid Id ");
                return result;
            }

            int deptId = Int32.Parse(id);

            result.Data = context.Departments.FirstOrDefault(d => d.Id == deptId);

            return result;
        }

        public Result<Department> Delete(int id)
        {
            var result = new Result<Department>();

            try
            {
                var department = context.Departments.FirstOrDefault(d => d.Id == id);
                if (department == null)
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid ID");
                    return result;
                }

                context.Departments.Remove(department);
                context.SaveChanges();

                result.Data = department;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Messages.Add(ex.Message);
            }
            return result;
        }





        public Result<Department> SaveDepartment(Department dept)
        {
            var result = new Result<Department>();
            try
            {
                if (!ValidationHelper.IsStringValid(dept.Name))
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid Name");
                    return result;
                }

                if (context.Departments.Any(d => d.Name == dept.Name && d.Id != dept.Id))
                {
                    result.HasError = true;
                    result.Messages.Add("Name Already Exist");
                    return result;
                }

                var department = context.Departments.FirstOrDefault(d => d.Id == dept.Id);
                if (department == null)
                {
                    department = new Department();
                    context.Departments.Add(department);
                }

                department.Name = dept.Name;

                context.SaveChanges();
                result.Data = department;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Messages.Add(ex.Message);
            }

            return result;
        }

    }
}

