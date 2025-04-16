using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DTO
{
    class Customer
    {
        public int Cus_ID { get; set; }
        public string Cus_Name { get; set; }
        public string Cus_Phone { get; set; }
        public string Cus_Address { get; set; }

        public Customer(int Cus_ID, string Cus_Name, string Cus_Phone, string Cus_Address)
        {
            this.Cus_ID = Cus_ID;
            this.Cus_Name = Cus_Name;
            this.Cus_Phone = Cus_Phone;
            this.Cus_Address = Cus_Address;
        }
        public Customer(DataRow row)
        {
            Cus_ID = (int)row["Cus_ID"];
            Cus_Name = row["Cus_Name"].ToString();
            Cus_Phone = row["Cus_Phone"].ToString();
            Cus_Address = row["Cus_Address"].ToString();
        }
    }
}
