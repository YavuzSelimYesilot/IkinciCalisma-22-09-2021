using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CooperateCustomer:Customer
    {
        public string CompanyName { get; set; }                 //şirket adı
        public string TaxNo { get; set; }                       //vergi no
    }
}
