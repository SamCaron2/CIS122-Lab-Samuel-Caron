using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public class OrderDetail
    {
        private int orderId = -1;
        private int productId = -1;
        private double unitPrice = double.MaxValue;
        private int quantity = 0;
        private double discount = 0.0;



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
        public int ProductId
        {
            get { return this.productId; }
            set
            {
                if (value > -1)
                {
                    this.productId = value;
                }
                else
                {
                    this.productId = 0;
                }
            }
        }
        
        public double UnitPrice
        {
            get { return this.unitPrice; }
            set
            {
                if (value > 0.0)
                {
                    this.unitPrice = value;
                }
                else
                {
                    this.unitPrice = 0.0;
                }
            }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set
            {
                if (value > 0)
                {
                    this.quantity = value;
                }
                else
                {
                    this.quantity = 0;
                }
            }
        }

        public double Discount
        {
            get { return this.discount; }
            set
            {
                if (value > 0.0)
                {
                    this.discount = value;
                }
                else
                {
                    this.discount= 0.0;
                }
            }
        }
    }
}
