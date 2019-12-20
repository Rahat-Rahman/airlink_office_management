using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlink.Data
{
    partial class EmployeeTable
    {
        public string DepartmentName
        {
            get
            {
                if (this.Department == null)
                    return "-";

                return this.Department.Name;
            }
        }
    }
}
