using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20502509_HW4.View_Models
{
    public class FishVM : Animal
    {
        
        private string _Habitat;
        private string _FURL;

        public FishVM(string name, int expectancy, string origin, string food, string endangered, string habitat, string url) : base(name, expectancy, origin, food, endangered)
        {
            _Habitat = habitat;
            _FURL = url;

        }

        

        public string Habitat
        {
            get { return _Habitat; }
            set { Habitat = value; }
        }

        public string FURL
        {
            get { return _FURL; }
            set { FURL = value; }
        }
    }
}