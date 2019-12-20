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
    public class EmployeeTableBL
    {
        private AirlinkDbEntities context = DataAccess.Context;
        public Result<List<EmployeeTable>> GetAllEmployeeTables(string name, int? page, int? pageSize)
        {
            var result = new Result<List<EmployeeTable>>();

            var query = from d in context.EmployeeTables
                        where d.Id.Trim().EndsWith("-2")
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

        public Result<EmployeeTable> GetEmployeeTableById(string id)
        {
            var result = new Result<EmployeeTable>();

            if (ValidationHelper.IsIntValid(id))
            {
                result.HasError = true;
                result.Messages.Add("Invalid Id ");
                return result;
            }

           // int empId = Int32.Parse(id);
            string empId = id;

            result.Data = context.EmployeeTables.FirstOrDefault(d => d.Id == empId+"");

            return result;
        }

        public Result<EmployeeTable> Delete(string id)
        {
            var result = new Result<EmployeeTable>();

            try
            {
                var employeeTable = context.EmployeeTables.FirstOrDefault(d => d.Id == id+"");
                if (employeeTable == null)
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid ID");
                    return result;
                }

                context.EmployeeTables.Remove(employeeTable);
                context.SaveChanges();

                result.Data = employeeTable;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Messages.Add(ex.Message);
            }
            return result;
        }





        public Result<EmployeeTable> SaveEmployeeTable(EmployeeTable emp)
        {
            var result = new Result<EmployeeTable>();
            try
            {
                if (!ValidationHelper.IsStringValid(emp.Name))
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid Name");
                    return result;
                }


                var employeeTable = context.EmployeeTables.FirstOrDefault(d => d.Id == emp.Id);
                if (employeeTable == null)
                {
                    
                    employeeTable = new EmployeeTable();
                    employeeTable.Id = emp.Id;
                    context.EmployeeTables.Add(employeeTable);
                }

                
                employeeTable.Name = emp.Name;
                employeeTable.Designation = emp.Designation;
                employeeTable.Email = emp.Email;
                employeeTable.departmentId = emp.departmentId;
                employeeTable.DOB = emp.DOB;
                employeeTable.Username = emp.Username;
                employeeTable.Password = emp.Password;
                if (emp.ProfilePic != null)
                {
                    employeeTable.ProfilePic = emp.ProfilePic.Trim();
                }
                



                context.SaveChanges();

                employeeTable.Department = context.Departments.FirstOrDefault(d => d.Id == employeeTable.departmentId);
                result.Data = employeeTable;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Messages.Add(ex.Message);
            }

            return result;
        }

        public Result<EmployeeTable> SaveEmp(EmployeeTable emp)
        {
            var result = new Result<EmployeeTable>();
            try
            {
                if (!ValidationHelper.IsStringValid(emp.Name))
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid Name");
                    return result;
                }


                var employeeTable = context.EmployeeTables.FirstOrDefault(d => d.Id == emp.Id);
                if (employeeTable == null)
                {

                    employeeTable = new EmployeeTable();
                    employeeTable.Id = emp.Id;
                    context.EmployeeTables.Add(employeeTable);
                }


                employeeTable.Name = emp.Name;
                employeeTable.Designation = emp.Designation;
                employeeTable.Email = emp.Email;
                employeeTable.departmentId = emp.departmentId;
                employeeTable.DOB = emp.DOB;
                employeeTable.Username = emp.Username;
                employeeTable.Password = emp.Password;
                if (emp.ProfilePic != null)
                {
                    employeeTable.ProfilePic = emp.ProfilePic.Trim();
                }




                context.SaveChanges();

                employeeTable.Department = context.Departments.FirstOrDefault(d => d.Id == employeeTable.departmentId);
                result.Data = employeeTable;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Messages.Add(ex.Message);
            }

            return result;
        }


        public Result<EmployeeTable> ChangePassword(string username,string oldPassword,string newPassword)
        {
            var result = new Result<EmployeeTable>();
            try
            {
                var employeeTable = context.EmployeeTables.FirstOrDefault(d => d.Username == username && d.Password==oldPassword);
                if (employeeTable == null)
                {

                    result.HasError = true;
                    result.Messages.Add("Invalid Password");
                    return result;
                }


                employeeTable.Password = newPassword;

                context.SaveChanges();
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

