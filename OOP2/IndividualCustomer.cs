using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class IndividualCustomer:Customer
    {
        public string TcNo { get; set; }                        //TC numarası   
        public string Name { get; set; }                        //isim
        public string Surname { get; set; }                     //soy ismi
    }
}
