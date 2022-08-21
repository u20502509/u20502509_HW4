using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20502509_HW4.View_Models;

namespace u20502509_HW4.Controllers
{
    public class FishController : Controller
    {
        // GET: Fish
        public ActionResult Index()
        {
            List < FishVM > fish = getFish();
            return View(fish);
        }

        private List<FishVM> getFish()
        {
             List<FishVM> fish = new List<FishVM>();
             FishVM fish1 = new FishVM("Steenbrass", 5, "South Africa", "Other small fish", "Endangered", "Open ocean and close to reefs", "https://www.aquarium.co.za/cache/ce_img_cache/local/24be6a810f238a37/15939342960_fc775d26a9_z_1_640_427_70.jpg");
             FishVM fish2 = new FishVM("Zebra Fish", 5, "South Africa", "Small plants and small fish", "Vulnerable", "Shallow reefs", "https://www.animal.photos/fish1/bream-zeb_files/bream_zebra1.jpg");
             FishVM fish3 = new FishVM("West Coast Lobster", 15, "South Africa", "Dead fish and other animals", "Endangered", "Reefs and Rocky areas", "https://ntbrand-wp.s3.amazonaws.com/impressivenature/wp-content/uploads/2020/04/17154046/capture03-1280x800-8.png");
             FishVM fish4 = new FishVM("Musselcracker", 7, "South Africa", "Mussels", "Critical", "Deep sea reefs", "https://i.pinimg.com/originals/45/6c/a1/456ca12322fb48cbb445f39c12048dca.png");
             FishVM fish5 = new FishVM("Galjoen", 10, "South Africa", "Other small fish", "Critical", "Areas close to where it was born", "https://www.aquarium.co.za/uploads/files/galjoen1.jpg");
             FishVM fish6 = new FishVM("Abalone", 25, "New Zealand, South Africa, Australia", "Giant kelp", "Critical", "Ocean floor and reefs", "https://www.aquariumofpacific.org/images/olc/red-abalone_noaa.jpg");

            fish.Add(fish1);
            fish.Add(fish2);
            fish.Add(fish3);
            fish.Add(fish4);
            fish.Add(fish5);
            fish.Add(fish6);

            return fish;


        }


}
}