using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DTO
{
    class Sell_Transaction
    {
        public int Sell_ID { get; set; }
        public int Pro_ID { get; set; }
        public int Cus_ID { get; set; }
        public int Emp_ID { get; set; }
        public DateTime Sell_Date { get; set; }
        public double Sell_Discount { get; set; }
        public Sell_Transaction() { }
        
        public Sell_Transaction(int Sell_ID, int Pro_ID, int Cus_ID, int Emp_ID, DateTime Sell_Date, double Sell_Discount)
        {
            this.Sell_ID = Sell_ID;
            this.Pro_ID = Pro_ID;
            this.Cus_ID = Cus_ID;
            this.Emp_ID = Emp_ID;
            this.Sell_Date = Sell_Date;
            this.Sell_Discount = Sell_Discount;
        }

        public Sell_Transaction(System.Data.DataRow row)
        {
            Sell_ID = (int)row["Sell_ID"];
            Pro_ID = (int)row["Pro_ID"];
            Cus_ID = (int)row["Cus_ID"];
            Emp_ID = (int)row["Emp_ID"];
            Sell_Date = (DateTime)row["Sell_Date"];
            Sell_Discount = (double)row["Sell_Discount"];
        }
    }
}
