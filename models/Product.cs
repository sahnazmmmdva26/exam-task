using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasstaskUser.models
{
    internal class Product
    {
        private string _name;
        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


    }
}
