using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1
{
    class Ap
    {
        public string name { get; set; }
        public string address { get; set; }
        public int zipcode { get; set; }


        public Ap()
        {
            zipcode = 0;
            address = "";
            name = "";

        }
    }
}
