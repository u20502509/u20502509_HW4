using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20502509_HW4.View_Models
{
    public abstract class Animal
    {
        private string _Name;
        private int _Expectancy;
        private string _Origin;
        private string _Food;
        private string _Endangered;

        public Animal(string name, int expectancy, string origin, string food, string endangered)
        {
            _Name = name;
            _Expectancy = expectancy;
            _Origin = origin;
            _Food = food;
            _Endangered = endangered;
        }

        public string Name
        {
            get { return _Name; }
            set { Name = value; }
        }

        public int Expectancy
        {
            get { return _Expectancy; }
            set { Expectancy = value; }
        }

        public string Origin
        {
            get { return _Origin; }
            set { Origin = value; }
        }

        public string Food
        {
            get { return _Food; }
            set { Food = value; }
        }

        public string Endangered
        {
            get { return _Endangered; }
            set { Endangered = value; }
        }

       
    }
}