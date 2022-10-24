using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public class Category
    {
        // Category vaeriables and sets
        private int categoryId = -1;
        private string categoryName = "n/a";
        private string description = "n/a";

        public int CategoryId
        // gets and sets
        {
            get { return this.categoryId; }
            set
            {
                if (value > -1) // 0 or higher, negative numbers will return 0
                {
                    this.categoryId = value;
                }
                else
                {
                    this.categoryId = 0;
                }


            }
        }


        public string CategoryName
        {
            get { return this.categoryName; }
            set { this.categoryName = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }

        }
    }
}

