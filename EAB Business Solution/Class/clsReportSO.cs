using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EAB_Business_Solution.Class
{
    class clsReportSO
    {
        public int SOID { get; set; }
        public string CName { get; set; }
        public DateTime SODate { get; set; }
        public DateTime SODeliveryDate { get; set; }
        public string ProductName { get; set; }
        public int SOQty { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public int MemberPromotion { get; set; }
        public int Tax { get; set; }
        public int DepositAmount { get; set; }
        public int FirstPayment { get; set; }
        public int AmendmentPayment { get; set; }
        public int CreditAmount { get; set; }
      //  public int GrandTotal { get; set; }
    }
}
