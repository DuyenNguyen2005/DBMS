using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DTO
{
    class Employee
    {
        public int Emp_ID { get; set; }
        public string Emp_Name { get; set; }
        public string Emp_DOB { get; set; }
        public string Emp_Phone { get; set; }

        public Employee(int Emp_ID, string Emp_Name, string Emp_DOB, string Emp_Phone)
        {
            this.Emp_ID = Emp_ID;
            this.Emp_Name = Emp_Name;
            this.Emp_DOB = Emp_DOB;
            this.Emp_Phone = Emp_Phone;
        }

        public Employee(DataRow row)
        {
            Emp_ID = (int)row["Emp_ID"];
            Emp_Name = row["Emp_Name"].ToString();
            Emp_DOB = row["Emp_DOB"].ToString();
            Emp_Phone = row["Emp_Phone"].ToString();
        }
    }
}
