using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DTO
{
    class Import_Transaction
    {
        public int Imp_ID { get; set; }
        public int Sup_ID { get; set; }
        public int Pro_ID { get; set; }
        public DateTime Imp_Date { get; set; }
        public int Imp_Quantity { get; set; }
        public double Imp_Price { get; set; }
        public Import_Transaction() { }
        public Import_Transaction(int Imp_ID, int Sup_ID, int Pro_ID, DateTime Imp_Date, int Imp_Quantity, double Imp_Price)
        {
            this.Imp_ID = Imp_ID;
            this.Sup_ID = Sup_ID;
            this.Pro_ID = Pro_ID;
            this.Imp_Date = Imp_Date;
            this.Imp_Quantity = Imp_Quantity;
            this.Imp_Price = Imp_Price;
        }

        public Import_Transaction(System.Data.DataRow row)
        {
            Imp_ID = (int)row["Imp_ID"];
            Sup_ID = (int)row["Sup_ID"];
            Pro_ID = (int)row["Pro_ID"];
            Imp_Date = (DateTime)row["Imp_Date"];
            Imp_Quantity = (int)row["Imp_Quantity"];
            Imp_Price = (double)row["Imp_Price"];
        }
    }
}
