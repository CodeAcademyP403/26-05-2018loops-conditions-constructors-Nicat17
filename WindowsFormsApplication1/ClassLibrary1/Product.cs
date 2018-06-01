using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSection
{
    public class Product
    {
        private string _name;
        private static int _id;
        private byte _weight;
        private double _price;
        private int _date;
        private static int _countProduct;
        private Catagory catagories;

        static Product()
        {
            _id=0;
            _countProduct = 0;
        }

        public int ID
        {
            get { return _id;}
            set
            {
                _id=value;
            }
        }
        public int Count
        {
            get { return _countProduct; }
            set
            {
                _countProduct = value;
            }
        }

        public string Name {
            get { return _name;}
            set
            {
                if(value.Length>=3 && value.Length <= 50)
                {
                    _name = value;
                    _countProduct++;
                    _id++;
                }
            }
        }
        public byte Weight
        {
            get { return _weight; }
            set
            {
                if (value>0)
                {
                    _weight = value;
                }
            }
        }
        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        public int Date
        {
            get { return _date; }
            set
            {
                if (value > 0)
                {
                    _date = value;
                }
            }
        }

        public Catagory Catagory
        {
            get { return catagories; }
            set
            {
                catagories = value;
            }
        }
    }
}
