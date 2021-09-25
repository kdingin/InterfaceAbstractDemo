using InterfaceAbstractDemo.Concrate;
using InterfaceAbstractDeno.Abstract;
using InterfaceAbstractDeno.Adapters;
using InterfaceAbstractDeno.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDeno
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(2000, 7, 16),
                FirstName = "Fatih",
                LastName = "Küçükdingin",
                NationalityId = "000"
            });
        }
    }
}
