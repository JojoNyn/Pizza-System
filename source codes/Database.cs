using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Project
{
    class Database
    {
        public List<Customer> customers = new List<Customer>();//creates list for customers
        
        public Database()//default constructor for dattabase
        {
        }
        public void addCustomer(Customer item)//adds customers to the database
        {
            customers.Add(item);
        }
        public Customer findPhoneNumber(string pn)//search for customer based on phone number
        {
            Customer cus = new Customer();//creates customer
            foreach(Customer c in customers)//goes through all customers in the database
            {
                if(c.getPhoneNumber() == pn)//if the customer's phonenumber = entered pnonumber
                {
                    cus = c;//set cus to c
                }
            }
            return cus;//return customer
        }
    }
}
