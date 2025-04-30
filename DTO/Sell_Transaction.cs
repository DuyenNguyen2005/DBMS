using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DTO
{
    class Sell_Transaction
    {
        public string Sell_ID { get; set; }
        public string Cus_ID { get; set; }
        public string Emp_ID { get; set; }
        public DateTime Sell_Date { get; set; }
        public Sell_Transaction() { }
        public Sell_Transaction(string cus_ID, string emp_ID, DateTime sell_Date)
        {
            this.Cus_ID = cus_ID;
            this.Emp_ID = emp_ID;
            this.Sell_Date = sell_Date;
        }
        public Sell_Transaction(string sell_ID)
        {
            this.Sell_ID = sell_ID;
        }
        public Sell_Transaction(string sell_ID, string cus_ID, string emp_ID, DateTime sell_Date)
        {
            this.Sell_ID = sell_ID;
            this.Cus_ID = cus_ID;
            this.Emp_ID = emp_ID;
            this.Sell_Date = sell_Date;
        }
        public Sell_Transaction(string sell_ID, string cus_ID, string emp_ID)
        {
            this.Sell_ID = sell_ID;
            this.Cus_ID = cus_ID;
            this.Emp_ID = emp_ID;
        }
        public Sell_Transaction(string sell_ID = null, string cus_ID = null, string emp_ID = null, DateTime? sell_Date = null)
        {
            this.Sell_ID = sell_ID;
            this.Cus_ID = cus_ID;
            this.Emp_ID = emp_ID;
            this.Sell_Date = sell_Date ?? DateTime.MinValue;
        }
        public Sell_Transaction(DataRow row)
        {
            Sell_ID = row["Sell_ID"].ToString();
            Cus_ID = row["Cus_ID"].ToString();
            Emp_ID = row["Emp_ID"].ToString();
            Sell_Date = row["Sell_Date"] != DBNull.Value ? Convert.ToDateTime(row["Sell_Date"]) : DateTime.MinValue;
        }

    }
}
