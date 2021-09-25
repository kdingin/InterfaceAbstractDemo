using InterfaceAbstractDeno.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDeno.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
