using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmApp
{
    internal class Address
    {
        public string name;
        public string phoneNumber;
        public string yearsOld;
        public string fenZu;
        public Address() 
        { 
            name = string.Empty;
            phoneNumber = "0000000000";
            yearsOld = "0";
            fenZu = "";
        }
        public Address(string name)
        {
            this.name = name;
            phoneNumber = "0000000000";
            yearsOld = "0";
            fenZu = "";
        }
        public Address(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            yearsOld = "0";
            fenZu = "";
        }
        public Address(string name, string phoneNumber, string yearsOld)
        {
            this.name = name;
            this.phoneNumber = phoneNumber; 
            this.yearsOld = yearsOld;
            this.fenZu = "陌生人";
        }
        public Address(string name, string phoneNumber, string yearsOld, string fenZu)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.yearsOld = yearsOld;
            this.fenZu = fenZu;
        }
    }
}
