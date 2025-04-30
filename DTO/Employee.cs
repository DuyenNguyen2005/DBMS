using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DTO
{
    public class Employee
    {
        public string Emp_ID { get; set; }
        public string Emp_Name { get; set; }
        public DateTime Emp_DOB { get; set; }
        public string Emp_Gender { get; set; }
        public string Emp_Address { get; set; }
        public string Emp_Phone { get; set; }
        public string Emp_Email { get; set; }
        public string Emp_Position { get; set; }
        public DateTime Emp_HireDate { get; set; }
        public bool Emp_Status { get; set; }
        public decimal Emp_Salary { get; set; }
        // Contructor rông
        public Employee() { }
        // Constructor cho việc xóa
        public Employee(string emp_ID)
        {
            Emp_ID = emp_ID;
        }
        public Employee(string empId, string emp_Name, DateTime emp_DOB, string emp_Gender, string emp_Address, string emp_Phone, string emp_Email, string emp_Position, DateTime emp_HireDate, decimal emp_Salary)
        {
            Emp_ID = empId;
            Emp_Name = emp_Name;
            Emp_DOB = emp_DOB;
            Emp_Gender = emp_Gender;
            Emp_Address = emp_Address;
            Emp_Phone = emp_Phone;
            Emp_Email = emp_Email;
            Emp_Position = emp_Position;
            Emp_HireDate = emp_HireDate;
            Emp_Salary = emp_Salary;
        }
        public Employee(string empId, string emp_Name, DateTime emp_DOB, string emp_Gender, string emp_Address, string emp_Phone, string emp_Email, string emp_Position, DateTime emp_HireDate, bool emp_Status, decimal emp_Salary)
        {
            Emp_ID = empId;
            Emp_Name = emp_Name;
            Emp_DOB = emp_DOB;
            Emp_Gender = emp_Gender;
            Emp_Address = emp_Address;
            Emp_Phone = emp_Phone;
            Emp_Email = emp_Email;
            Emp_Position = emp_Position;
            Emp_HireDate = emp_HireDate;
            Emp_Status = emp_Status;
            Emp_Salary = emp_Salary;
        }
        // Constructor từ DataRow
        public Employee(DataRow row)
        {
            Emp_ID = row["Emp_ID"].ToString();
            Emp_Name = row["Emp_Name"].ToString();
            Emp_DOB = (DateTime)row["Emp_DOB"];
            Emp_Gender = row["Emp_Gender"].ToString();
            Emp_Address = row["Emp_Address"].ToString();
            Emp_Phone = row["Emp_Phone"].ToString();
            Emp_Email = row["Emp_Email"].ToString();
            Emp_Position = row["Emp_Position"].ToString();
            Emp_HireDate = (DateTime)row["Emp_HireDate"];
            Emp_Status = Convert.ToBoolean(row["Emp_Status"]);
            Emp_Salary = Convert.ToDecimal(row["Emp_Salary"]);
        }
    }
}
