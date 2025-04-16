using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DTO
{
    class Supplier
    {
        public int Sup_ID { get; set; }
        public string Sup_Name { get; set; }
        public string Sup_Phone { get; set; }
        public Supplier() { }
        public Supplier(int Sup_ID, string Sup_Name, string Sup_Phone)
        {
            this.Sup_ID = Sup_ID;
            this.Sup_Name = Sup_Name;
            this.Sup_Phone = Sup_Phone;
        }
        public Supplier(DataRow row)
        {
            Sup_ID = (int)row["Sup_ID"];
            Sup_Name = row["Sup_Name"].ToString();
            Sup_Phone = row["Sup_Phone"].ToString();
        }
    }
}
