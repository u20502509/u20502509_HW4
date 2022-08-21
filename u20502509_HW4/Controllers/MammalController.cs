using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20502509_HW4.View_Models;

namespace u20502509_HW4.Controllers
{
    public class MammalController : Controller
    {
        // GET: Mammal
        public ActionResult Index()
        {
            List<MammalVM> mammals = getMammals();
            return View(mammals);
        }

        private List<MammalVM> getMammals()
        {
            List<MammalVM> mammals = new List<MammalVM>();
            MammalVM mammal1 = new MammalVM("Amur Leopard", 15, "Himalayan Mountains", "Mountain goat", "Critical", 5, "Solitary", "https://files.worldwildlife.org/wwfcmsprod/images/Amur_Leopard_/story_full_width/9g51xqtsf1_amur_leopard_99144569.jpg");
            MammalVM mammal2 = new MammalVM("Eastern Lowland Gorilla", 50, "Africa", "Fresh Vegetation", "Critical", 9, "Troops", "https://www.naturalworldsafaris.com/media/5570/nws-st-lowland-gorilla.jpg");
            MammalVM mammal3 = new MammalVM("Black Rhino", 25, "Africa", "Leaves and Twigs", "Critical", 6, "Solitary", "https://i.guim.co.uk/img/media/e3114ec958a8c0e4cf6ea4239cebeeb99fe77cef/301_0_2876_1726/master/2876.jpg?width=1200&quality=85&auto=format&fit=max&s=f49d2867ea1497f8876562032c12a88e");
            MammalVM mammal4 = new MammalVM("Orangutang", 30, "Malaysia", "Dragon Fruit", "Endangered", 9, "Troops", "https://files.worldwildlife.org/wwfcmsprod/images/LG_Orangutans_Hero_image__c__naturepl.com_Anup_Shah_WWF.jpg/story_full_width/1y3j5is7n5_LG_Orangutans_Hero_image__c__naturepl.com_Anup_Shah_WWF.jpg");
            MammalVM mammal5 = new MammalVM("Wild Dog", 20, "Africa", "Impala", "Endangered", 7, "Packs", "https://cf.ltkcdn.net/dogs/images/orig/233907-1600x1030-fast-facts-about-african-wild-dog.jpg");
            MammalVM mammal6 = new MammalVM("Panda", 25, "China", "Bamboo", "Vulnerable", 8, "Solitary", "https://files.worldwildlife.org/wwfcmsprod/images/Giant_Panda/story_full_width/p80g9bsjj_giant_panda_shutterstock_86500690.jpg");
            MammalVM mammal7 = new MammalVM("Siberian Tiger", 20, "Russia", "Elk", "Endangered", 6, "Solitary", "https://cms.bbcearth.com/sites/default/files/2021-07/Siberian%20tiger%20in%20the%20snow_GettyImages-1287040214.jpg");
            MammalVM mammal8 = new MammalVM("Hectors Dolphin", 15, "New Zealand", "Herring", "Critical", 6, "Pods", "https://www.akaroadolphins.co.nz/assets/Uploads/SliderBlockImages/Jumping-1.jpg");

            mammals.Add(mammal1);
            mammals.Add(mammal2);
            mammals.Add(mammal3);
            mammals.Add(mammal4);
            mammals.Add(mammal5);
            mammals.Add(mammal6);
            mammals.Add(mammal7);
            mammals.Add(mammal8);

            return mammals;

        }
   
    }
}