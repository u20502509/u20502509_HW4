using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20502509_HW4.View_Models
{
    public class MammalVM : Animal
    {
        private int _Gestation;
        private string _Family;
        private string _MURL;

        public MammalVM(string name, int expectancy, string origin, string food, string endangered, int gestation, string family, string url) : base(name, expectancy, origin, food, endangered)
        {
            _Gestation = gestation;
            _Family = family;
            _MURL = url;
        }
        public int Gestation
        {
            get { return _Gestation; }
            set { Gestation = value; }
        }

        public string Family
        {
            get { return _Family; }
            set { Family = value; }
        }

        public string MURL
        {
            get { return _MURL; }
            set { MURL = value; }
        }
    }
}