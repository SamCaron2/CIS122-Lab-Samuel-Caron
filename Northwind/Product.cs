using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public class Product
    {
        private int productId = -1;
        private string productName = "n/a";
        private int supplierId = -1;
        private int categoryId = -1;
        private string quantityPerUnit = "n/a";
        private double unitPrice = double.MaxValue;
        private int unitsInStock = -1;
        private int unitsOnOrder = -1;
        private int reorderLevel = int.MaxValue;
        private bool discountinued = true;


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
        public string ProductName
        {
            get { return this.productName; }    
            set { this.productName = value; }
        }
        public int SupplierId
        {
            get { return this.supplierId; }
            set
            {
                if (value > -1)
                {
                    this.supplierId = value;
                }
                else
                {
                    this.supplierId = 0;
                }
            }
        }
        public int CategoryId
        {
            get { return this.categoryId; }
            set
            {
                if (value > -1)
                {
                    this.categoryId = value;
                }
                else
                {
                    this.categoryId = 0;
                }
            }
        }
        public string QuantityPerUnit
        {
            get { return this.quantityPerUnit; }
            set { this.quantityPerUnit = value; }
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
        public int UnitsInStock
        {
            get { return this.unitsInStock; }
            set
            {
                if (value > -1)
                {
                    this.unitsInStock = value;
                }
                else
                {
                    this.unitsInStock = 0;
                }
            }
        }
        public int UnitsOnOrder
        {
            get { return this.unitsOnOrder; }
            set
            {
                if (value > -1)
                {
                    this.unitsOnOrder = value;
                }
                else
                {
                    this.unitsOnOrder = 0;
                }
            }
        }
        public int ReorderLevel
        {
            get { return this.reorderLevel; }
            set
            {
                if (value > 0)
                {
                    this.reorderLevel = value;
                }
                else
                {
                    this.reorderLevel = 0;
                }
            }
        }
        public bool Discountinued
        {
            get { return this.discountinued; }
            set { this.discountinued = value; }
        }
    }
}
