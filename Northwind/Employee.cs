using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    internal class Employee
    {
        //Variables and defaults
        private int employeeId = -1;//-1 default set
        private string lastName = "n/a";
        private string firstName = "n/a";
        private string title = "n/a";
        private string titleOfCourtesy = "n/a";
        private string birthDate = "n/a";
        private string hireDate = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string homePhone = "n/a";
        private string extension = "n/a";
        private string notes = "n/a";
        private int reportTo = -1; //default set to -1 

        // Gets and Sets
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
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string TitleOfCourtesy
        {
            get { return this.titleOfCourtesy; }
            set { this.titleOfCourtesy = value; }
        }
        public string BirthDate
        {
            get { return this.birthDate; }
            set { this.birthdate = value; }
        }
        public string HireDate
        {
            get { return this.hireDate; }
            set { this.hireDate = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }
        public string PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
        }
        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }
        public string HomePhone
        {
            get { return this.homePhone; }
            set { this.homePhone = value; }
        }
        public string Extension
        {
            get { return this.extension; }
            set { this.extension = value; }
        }
        public string Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }
        public int ReportTo
        {
            get { return this.reportTo; }
            set
            {
                if (value > -1)
                {
                    this.reportTo = value;
                }
                else
                {
                    this.reportTo = 0;
                }
            }
        }
    }
}
    

        
    
