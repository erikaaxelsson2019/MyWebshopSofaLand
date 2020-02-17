using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebshop.Data;
using MyWebshop.Models;

namespace MyWebshop.Controllers
{
    public class StoreController : Controller
    {
        readonly List<Product> products = new List<Product>()
        {
            new Product { Id = 1, ProductName = "Petito 4-seated", Photo="../images/petitoSofa.jpg", Price = 1210.99,
                Description = "In terms of surface, the series is very effective on shallow " +
                "out of the narrow armrests which, in addition to being stylish, also gives a" +
                " larger seating area in relation to the total length.",
                Material = "60% cotton, 40% linen", Color = "Tristan Stone", Width = "248 cm", Height = "82 cm", Depth = "102 cm",  },

            new Product { Id = 2, ProductName = "Cluster 3-seated", Photo="../images/clusterSofa.jpg", Price = 1300.99,
                Description = "this sofa gives a cool feeling with its cool fauxleather upholstery." +
                " Works in many different rooms, and is stylish over time.",
                Material = "Faux leather", Color = "Tyg Antracit", Width = "210 cm", Height = "80 cm", Depth = "90 cm" },

            new Product { Id = 3, ProductName = "Lean 3-seated", Photo=("../images/leanSofa.jpg"), Price = 2300.19,
                Description = "Lean is a sofa with simple shapes that can be combined with a " +
                "few different sofa parts. Sofa Lean is available in 1, 1.5, corner section" +
                " and 2 sizes of sofa.",
                Material = "60% cotton, 40% polyster", Color = "Camel", Width = "318 cm", Height = "70 cm", Depth = "100 cm"  },

            new Product { Id = 4, ProductName = "Electra 3-seated", Photo=("../images/electraSoffa.jpg"), Price = 2475.50,
                Description = "An irresistible flirt with the tight, simple, and ever-present. A tribute to exquisite" +
                    " materials and comfort. With metal legs & wooden legs is a choice you make for both self-esteem and " +
                    "integrity.",
                Material = "leather vintage", Color = "Congnac", Width = "202 cm", Height = "85 cm", Depth = "90 cm"  },

            new Product { Id = 5, ProductName = "Rodeo 3-seated", Photo=("../images/rodeoSofa.jpg"), Price = 1378.90,
                Description = "The rodeo series is modern, tough and contemporary. This 3-seater sofa has the perfect" +
                    " medium size, offers enough seating space and has a sturdy fabric of recycled leather.",
                Material = "Ecoleather", Color = "Congac", Width = "190 cm", Height = "85 cm", Depth = "86 cm" },

            new Product { Id = 6, ProductName = "Julia 4-seated", Photo=("../images/juliaSofa.jpg"), Price = 25100.90,
                Description = "Lean is a sofa with simple shapes that can be combined with a " +
                "few different sofa parts. Sofa Lean is available in 1, 1.5, corner section" +
                " and 2 sizes of sofa.",
                Material = "60% cotton, 40% polyster", Color = "Kizz 3 stone", Width = "269 cm", Height = "81 cm", Depth = "109 cm"  }
        };

        public PartialViewResult ProtoType()
        {
            return PartialView();
        }

        public PartialViewResult PremiumProtoType()
        {
            return PartialView();
        }

        public IActionResult Index()
        {

            return View(products);
        }

        public IActionResult PremiumStore()
        {

            return View(products);
        }
    }
}