using Microsoft.AspNetCore.Mvc;
using Store.Models;

namespace Store.Controllers
{
    public class StoreController : Controller
    {

        public StoreController()
        {
        }


        public IActionResult Index()
        {
            List<DataStore> dataList = new List<DataStore>
            {
             new DataStore { ImgUrl = "https://i.ebayimg.com/images/g/KoUAAOSwJUZkywLD/s-l1600.webp", Name = "Lilly Pulitzer Dress Size M, L, XL Fished My Wish Ross Shift Blue and Pink", PriceAfter =99.99,Price=59.99 },
             new DataStore { ImgUrl = "https://i.ebayimg.com/images/g/jV0AAOSwRdxmYBc7/s-l1600.webp", Name = "Pure Cotton Indian Hand Block Print Summer Dress Blouson Dress Women's Clothing", PriceAfter = 69.99,Price=41.40 },
             new DataStore { ImgUrl = "https://i.ebayimg.com/images/g/Af4AAOSwT~dgP9aS/s-l960.webp", Name = "Women Ladies Boho Floral Maxi Dress Cocktail Party Evening Summer Beach Sundress", PriceAfter = 29.99,Price=21.99 },
             new DataStore { ImgUrl = "https://i.ebayimg.com/images/g/37cAAOSwPv9gJCbn/s-l1600.webp", Name = "Women's Casual Sundress Boho Beach Slit Long Maxi Floral Summer Beach Dress", PriceAfter = 24.99,Price=18.99 },
             new DataStore { ImgUrl = "https://i.ebayimg.com/images/g/mvoAAOSwpRlmjA2r/s-l960.webp", Name = "Women's Sleeveless Ring Detail Maxi Dress - Future Collective with Jenee Naylor", PriceAfter = 29.99,Price=14.99 },
             new DataStore { ImgUrl = "https://i.ebayimg.com/images/g/yCAAAOSwOZ5mcJrm/s-l960.webp", Name = "A New Day Women's Summer Casual Smocked Midi Sundress Bandeau Dress", PriceAfter = 39.99,Price=24.99 },
             new DataStore { ImgUrl = "https://i.ebayimg.com/images/g/7H0AAOSwSKpmY2GP/s-l960.webp", Name = "Universal Thread Women's Corset Denim Dress Midi A-Line", PriceAfter = 19.99,Price=13.15 },
             new DataStore { ImgUrl = "https://target.scene7.com/is/image/Target/GUEST_9f2de374-c032-476f-ad50-dd75e5da1d12?.jpg", Name = "Women's Short Sleeve Linen Midi Shirtdress - A New Day", PriceAfter = 19.99,Price=9.99 },
             new DataStore { ImgUrl = "https://target.scene7.com/is/image/Target/GUEST_497d9f83-efa2-49fd-bef9-110754373bfc?.jpg", Name = "A New Day Women's Poplin Cross Back Cinch Waist Summer Midi Dress", PriceAfter = 29.99,Price=14.99 },
             new DataStore { ImgUrl = "https://target.scene7.com/is/image/Target/GUEST_3e58d583-8a22-4222-8ad0-deaaf305c453?.jpg", Name = "A New Day Women's Casual Midi Dress Spaghetti Straps Cutout Back", PriceAfter = 14.99,Price=12.99 },
             new DataStore { ImgUrl = "https://target.scene7.com/is/image/Target/GUEST_354acb9e-277b-4c92-84aa-e7e93e8f047a?.jpg", Name = "Women's Knit Lace Up Detail Active Dress - JoyLab", PriceAfter = 19.99,Price=11.99 },
             new DataStore { ImgUrl = "https://i.ebayimg.com/images/g/aPEAAOSwQYhmcJp~/s-l960.webp", Name = "Universal Thread Women's Halter Summer Denim Maxi Dress", PriceAfter = 29.99 ,Price=19.99 },
             new DataStore { ImgUrl = "https://i.ebayimg.com/images/g/8a4AAOSwTDhmcErb/s-l960.webp", Name = "Women's Cut-Out Maxi A-Line Dress - Universal Thread Tan Abstract S", PriceAfter = 29.99,Price=19.99 },
             new DataStore { ImgUrl = "https://i.ebayimg.com/images/g/HTkAAOSwqmpmO6HT/s-l960.webp", Name = "A New Day Women's Summer Maxi Sundress Casual Dress", PriceAfter = 99.99,Price=59.99 },
             new DataStore { ImgUrl = "https://target.scene7.com/is/image/Target/GUEST_64d9857c-d4aa-4174-8a03-673079fe8b94?.jpg", Name = "Women's Sleeveless One Shoulder A-Line Dress - Knox Rose", PriceAfter = 19.99,Price=4.99 },
             new DataStore { ImgUrl = "https://i.ebayimg.com/images/g/0xUAAOSw5J5mNVNW/s-l960.webp", Name = "Diane von Furstenberg Women's Midi Wrap Dress Deep V-Neck Long Sleeve", PriceAfter = 59.99 ,Price=49.99 },
             new DataStore { ImgUrl = "https://target.scene7.com/is/image/Target/GUEST_a4c38fec-2594-4435-858a-7fe62ffa325a?.jpg", Name = "Diane von Furstenberg Women's Collared Midi Wrap Dress", PriceAfter = 23.99,Price=14.99 },
             new DataStore { ImgUrl = "https://target.scene7.com/is/image/Target/GUEST_6df44ff2-6d48-4828-976e-8bcca319eb40?.jpg", Name = "Women's Short Sleeve Wrap Dress - Knox Rose", PriceAfter = 24.99,Price=12.99 },
             new DataStore { ImgUrl = "https://i.ebayimg.com/images/g/U0YAAOSwTANmgvCO/s-l960.webp", Name = "A New Day Women's Eyelet Ballon Short Sleeve Mini Summer Shirt Dress", PriceAfter = 13.99,Price=9.99 },
             new DataStore { ImgUrl = "https://i.ebayimg.com/images/g/ETMAAOSw6UJmgv6I/s-l960.webp", Name = "A New Day Women's Long Sleeve Crepe Collared Midi Shirt Dress", PriceAfter = 29.99 ,Price=19.99 }
            };
            return View(dataList);
        }

    }
}