using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DTO
{
    public class Customer
    {
        public string Cus_ID { get; set; }
        public string Cus_Name { get; set; }
        public string Cus_Phone { get; set; }
        public string Cus_Address { get; set; }

        public Customer(string Cus_ID = null, string Cus_Name = null, string Cus_Phone = null, string Cus_Address = null)
        {
            this.Cus_ID = Cus_ID;
            this.Cus_Name = Cus_Name;
            this.Cus_Phone = Cus_Phone;
            this.Cus_Address = Cus_Address;
        }
        public Customer()
        {
            
        }
        public Customer(string cus_ID)
        {
            this.Cus_ID = cus_ID;
        }
        public Customer(DataRow row)
        {
            Cus_ID = row["Cus_ID"].ToString();
            Cus_Name = row["Cus_Name"].ToString();
            Cus_Phone = row["Cus_Phone"].ToString();
            Cus_Address = row["Cus_Address"].ToString();
        }
    }
}
