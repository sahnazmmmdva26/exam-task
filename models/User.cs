using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasstaskUser.models
{
    internal class User
    {
        private string _userName;
        private string _password;
        private bool _isSignedIn;
        private Product[] _products;
        private Product _product;

        public Product Product
        {
            get { return _product; }
            set { _product = value; }   
        }
        public Product[] Products
        {
            get { return _products; }
            set { _products = value; }
        }
        public bool IsSignedIn
        {
            get { return _isSignedIn; }
            set { _isSignedIn = value; }
        }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public void login()
        {
            string name = Console.ReadLine();
            string password = Console.ReadLine();

            UserName = name;
            Password = password;
        }

       public bool CheckPassword()
        {
            (bool, bool, bool) result = (false, false, false);
            foreach(char i in Password)
            {
                if(char.IsDigit(i))
                {
                    result.Item1 = true;
                }
                if(char.IsUpper(i))
                {
                    result.Item2 = true;
                }
                if(char.IsLower(i))
                {
                    result.Item3 = true;
                }
            }
            if(result==(true,true,true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Add()
        {
            if(UserName!=null && Password!=null)
            {
                Array.Resize( Products, Products.Length + 1);
                Products[Products.Length - 1] = Product;
            }
        }
    }
}
