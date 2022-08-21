using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20502509_HW4.View_Models;

namespace u20502509_HW4.Controllers
{
    public class BirdController : Controller
    {
        // GET: Bird
        public ActionResult Index()
        {
            List < BirdVM > birds = getBirds();
            return View(birds);
        }

        private List<BirdVM> getBirds()
        {
            List<BirdVM> birds = new List<BirdVM>();

            BirdVM bird1 = new BirdVM("Kiwi", 15, "New Zealand", "Worms", "Critical", 1, "https://assets3.thrillist.com/v1/image/2624055/792x456/scale;webp=auto;jpeg_quality=60;progressive.jpg");
            BirdVM bird2 = new BirdVM("Kakapo", 15, "New Zealand", "Grubs", "Critical", 2, "https://www.goodnewsnetwork.org/wp-content/uploads/2022/07/36213329345_adddca26fb_k-1024x683.jpg");
            BirdVM bird3 = new BirdVM("Snowy Owl", 30, "The Arctic", "Hares", "Vulnerable", 3, "https://cdn.download.ams.birds.cornell.edu/api/v1/asset/297366501/1800");
            BirdVM bird4 = new BirdVM("Condor", 25, "Grand Canyon", "Small mammals", "Critical", 4, "https://scx2.b-cdn.net/gfx/news/2021/expertsbelie.jpg");
            BirdVM bird5 = new BirdVM("Northern Bald Ibis", 15, "North Africa", "Beetles", "Vulnerable", 3, "https://s3.amazonaws.com/mongabay-images/13/1202.baldibis.IMG_1040.600.jpg");
            BirdVM bird6 = new BirdVM("African Grey Parrot", 40, "Democratic Republic of Congo (DRC)", "Fruit and nuts", "Threatened", 2, "https://cff2.earth.com/uploads/2021/10/20180948/African-grey-parrot-960x640.jpg");
            BirdVM bird7 = new BirdVM("Curassow", 10, "Columbia", "Forages for insects", "Critical", 5, "https://media.kidadl.com/Wattled_Curassow_Facts_You_Won_t_Believe_b815cf3481.jpg");

            birds.Add(bird1);
            birds.Add(bird2);
            birds.Add(bird3);
            birds.Add(bird4);
            birds.Add(bird5);
            birds.Add(bird6);
            birds.Add(bird7);

            return birds;

        }
    }
}