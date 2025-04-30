using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DTO
{
    public class Import_Transaction
    {
        public string Imp_ID { get; set; }
        public string Emp_ID { get; set; }
        public string Sup_ID { get; set; }
        public DateTime Imp_Date { get; set; }
        

        // Constructor cho Insert (thêm mới)
        public Import_Transaction(string emp_ID, string sup_ID)
        {
            this.Emp_ID = emp_ID;
            this.Sup_ID = sup_ID;
        }

        // Constructor cho Delete (xóa giao dịch nhập)
        public Import_Transaction(string imp_ID)
        {
            this.Imp_ID = imp_ID;
        }

        // Constructor cho Update (cập nhật giao dịch nhập)
        public Import_Transaction(string imp_ID, string emp_ID, string sup_ID, DateTime imp_Date)
        {
            this.Imp_ID = imp_ID;
            this.Emp_ID = emp_ID;
            this.Sup_ID = sup_ID;
            this.Imp_Date = imp_Date;
        }

        // Constructor cho Search (tìm kiếm giao dịch nhập)
        public Import_Transaction(string imp_ID = "", string emp_ID = "", string sup_ID = "", DateTime? imp_Date = null)
        {
            this.Imp_ID = imp_ID;
            this.Emp_ID = emp_ID;
            this.Sup_ID = sup_ID;
            this.Imp_Date = imp_Date ?? DateTime.MinValue;
        }

        // Constructor từ DataRow (lấy dữ liệu từ SQL)
        public Import_Transaction(System.Data.DataRow row)
        {
            Imp_ID = row["Imp_ID"]?.ToString();
            Emp_ID = row["Emp_ID"].ToString();
            Sup_ID = row["Sup_ID"]?.ToString();
            Imp_Date = row["Imp_Date"] != DBNull.Value ? Convert.ToDateTime(row["Imp_Date"]) : DateTime.MinValue;

        }

        public Import_Transaction(string imp_ID, string emp_ID, string sup_ID) : this(imp_ID)
        {
            Emp_ID = emp_ID;
            Sup_ID = sup_ID;
        }
    }
}
