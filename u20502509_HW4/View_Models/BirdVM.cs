using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20502509_HW4.View_Models
{
    public class BirdVM : Animal
    {
        
        private int _NumEggs;
        private string _BURL;

        public BirdVM(string name, int expectancy, string origin, string food, string endangered, int eggs, string url) : base(name, expectancy, origin, food, endangered)
        {
            _NumEggs = eggs;
            _BURL = url;
           
        }

        public int Eggs
        {
            get { return _NumEggs; }
            set { Eggs = value; }
        }

        public string BURL
        {
            get { return _BURL; }
            set { BURL = value; }
        }
    }
}