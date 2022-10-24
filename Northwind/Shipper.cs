using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public class Shipper
    {
        private int shipperId = 0;
        private string companyName = "n/a";
        private string phone = "n/a";


        public int ShipperId
        {
            get { return this.shipperId; }
            set
            {
                if (value > -1)
                {
                    this.shipperId = value;
                }
                else
                {
                    this.shipperId = 0;
                }
            }
        }

        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
    }
}
