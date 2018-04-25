using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EAB_Business_Solution.Class
{
    public class clsReport
    {
        public int SalesID { get; set; }
        public string TableName { get; set; }
        public int SalesQty { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public int MemberPromotion { get; set; }
        public int Tax { get; set; }
        public int ServiceCharges { get; set; }
        public int CashAmount { get; set; }
        public int Change { get; set; }
    }
}
