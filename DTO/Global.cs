using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DTO
{
    static class Global
    {
        public static string GlobalEmpId { get; private set; }
        public static void SetGlobalEmpIdD(string Emp_ID)
        {
            GlobalEmpId = Emp_ID;
        }
    }
}
