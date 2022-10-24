using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public class Order
    {
        private int orderId = -1;
        private string customerId = "n/a";
        private int employeeId = -1;
        private string orderDate = "n/a";
        private string requiredDate = "n/a";
        private string shippedDate = "n/a";
        private int shipVia = -1;
        private double freight = double.MaxValue;
        private string shipName = "n/a";
        private string shipAdress = "n/a";
        private string shipCity = "n/a";
        private string shipRegion = "n/a";
        private string shipPostalCode = "n/a";
        private string shipCountry = "n/a";


        public int OrderId
            
        {
            get { return this.orderId; }
            set
            {
                if (value > -1)
                {
                    this.orderId = value;
                }
                else
                {
                    this.orderId = 0;
                }
            }
        }
        public string CustomerId
        {
            get { return this.customerId; }
            set { this.customerId = value; }
        }
        public int EmployeeId
        {
            get { return this.employeeId; }
            set
            {
                if (value > -1)
                {
                    this.employeeId = value;
                }
                else
                {
                    this.employeeId = 0;
                }
            }
        }

        public string OrderDate
        {
            get { return this.orderDate; }
            set { this.orderDate = value; }
        }
        public string RequiredDate
        {
            get { return this.requiredDate; }
            set { this.requiredDate = value; }


        }

        public string ShippedDate
        {
            get { return this.shippedDate; }
            set { this.shippedDate = value; }
        }
        public int ShipVia
        {
            get { return this.shipVia; }
            set
            {
                if (value > -1)
                {
                    this.shipVia = value;
                }
                else
                {
                    this.shipVia = 0;
                }
            }
        }
        public double Freight
        {
            get { return this.freight; }
            set
            {
                if (value > 0.0)
                {
                    this.freight = value;
                }
                else
                {
                    this.freight = 0.0;
                }
            }
        }

        public string ShipName
        {
            get { return this.shipName; }
            set { this.shipName = value; }
        }
        public string ShipAdress
        {
            get { return this.shipAdress; }
            set { this.shipAdress = value; }
        }
        public string ShipCity
        {
            get { return this.shipCity; }
            set { this.shipCity = value; }
        }
        public string ShipRegion
        {
            get { return this.shipRegion; }
            set { this.shipRegion = value; }
        }
        public string ShipPostalCode
        {
            get { return this.shipPostalCode; }
            set { this.shipPostalCode = value; }
        }
        public string ShipCountry
        {
            get { return this.shipCountry; }
            set { this.shipCountry = value; }
        }




    }
}
