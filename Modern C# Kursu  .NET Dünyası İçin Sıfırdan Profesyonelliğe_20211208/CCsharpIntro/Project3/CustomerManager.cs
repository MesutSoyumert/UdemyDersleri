using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class CustomerManager
    {
        public CustomerManager()
        {
            customers = new List<Customer>()
            {
                new Customer
                 {
                    Id        = 1,
                    FirstName = "Mesut",
                    LastName  = "Soyumert",
                    City      = "Ankara",
                    Email     = "mesut@soyumert.com"
                 },

                new Customer
                 {
                    Id        = 2,
                    FirstName = "Deniz",
                    LastName  = "Soyumert",
                    City      = "Ankara",
                    Email     = "deniz@soyumert.com"
                 },

                new Customer
                 {
                    Id        = 3,
                    FirstName = "Nazlı",
                    LastName  = "Soyumert",
                    City      = "Ankara",
                    Email     = "nazli@soyumert.com"
                 },

                new Customer
                 {
                    Id        = 4,
                    FirstName = "Mert",
                    LastName  = "Soyumert",
                    City      = "Ankara",
                    Email     = "mert@soyumert.com"
                 },

                new Customer
                 {
                    Id        = 5,
                    FirstName = "Halet",
                    LastName  = "Tunalı",
                    City      = "Ankara",
                    Email     = "halet@tunali.com"
                 }
            };
        }

        List<Customer> customers;

        public List<Customer> GetAll()
        {
            //Veri tabanına bağlan

            return customers;
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
