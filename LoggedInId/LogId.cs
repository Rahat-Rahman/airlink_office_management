using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlink.Data;

namespace LoggedInId
{
    public class LogId
    {
        public static string Id { get; set; }
        public static bool isAdmin = false;

        public static EmployeeTable LoginUserInfo { get; set; }

    }
}
