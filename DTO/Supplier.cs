using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DTO
{
    public class Supplier
    {
        public string Sup_ID { get; set; }
        public string Sup_Name { get; set; }
        public string Sup_Address {  get; set; }
        public string Sup_Phone { get; set; }
        public string Sup_Email { get; set; }
        public string Sup_Website { get; set; }
        public DateTime Sup_JoinDate { get; set; }
        public bool Sup_Status { get; set; }
        //public Supplier() { }
        public Supplier(string Sup_ID)
        {
            this.Sup_ID = Sup_ID;
        }
        public Supplier(DataRow row)
        {
            Sup_ID = row["Sup_ID"].ToString();
            Sup_Name = row["Sup_Name"].ToString();
            Sup_Phone = row["Sup_Phone"].ToString();
            Sup_Address = row["Sup_Address"].ToString();
            Sup_Email = row["Sup_Email"].ToString();
            Sup_Website = row["Sup_Website"].ToString();
            Sup_JoinDate = (DateTime)row["Sup_JoinDate"];
            Sup_Status = Convert.ToBoolean(row["Sup_Status"]);
        }

        public Supplier(string Sup_ID, string Sup_Name, string Sup_Address, string Sup_Phone, string Sup_Email, string Sup_Website, DateTime Sup_JoinDate, bool Sup_Status)
        {
            this.Sup_ID = Sup_ID;
            this.Sup_Name = Sup_Name;
            this.Sup_Address = Sup_Address;
            this.Sup_Phone = Sup_Phone;
            this.Sup_Email = Sup_Email;
            this.Sup_Website = Sup_Website;
            this.Sup_JoinDate = Sup_JoinDate;
            this.Sup_Status = Sup_Status;
        }
        public Supplier(string Sup_ID, string Sup_Name, string Sup_Address, string Sup_Phone, string Sup_Email, string Sup_Website, DateTime Sup_JoinDate)
        {
            this.Sup_ID = Sup_ID;
            this.Sup_Name = Sup_Name;
            this.Sup_Address = Sup_Address;
            this.Sup_Phone = Sup_Phone;
            this.Sup_Email = Sup_Email;
            this.Sup_Website = Sup_Website;
            this.Sup_JoinDate = Sup_JoinDate;

        }
        public Supplier(string Sup_ID, string Sup_Name, string Sup_Address, string Sup_Phone, string Sup_Email, string Sup_Website)
        {
            this.Sup_ID = Sup_ID;
            this.Sup_Name = Sup_Name;
            this.Sup_Address = Sup_Address;
            this.Sup_Phone = Sup_Phone;
            this.Sup_Email = Sup_Email;
            this.Sup_Website = Sup_Website;
        }
        public Supplier(string sup_id = "", string sup_Name = "", string sup_Adress = "", string sup_Phone = "", string sup_Email = "", string sup_Website = "", DateTime? sup_JoinDate = null, bool? sup_Status = null)
        {
            this.Sup_ID = sup_id;
            this.Sup_Name = sup_Name;
            this.Sup_Address = sup_Adress;
            this.Sup_Phone = sup_Phone;
            this.Sup_Email = sup_Email;
            this.Sup_Website = sup_Website;
            this.Sup_JoinDate = sup_JoinDate ?? DateTime.MinValue;
            this.Sup_Status = sup_Status ?? true;
        }
    }
}
