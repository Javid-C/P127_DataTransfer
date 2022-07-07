using Microsoft.AspNetCore.Mvc;
using P127_FrontToBack.Models;
using P127_FrontToBack.ViewModels;
using System;
using System.Collections.Generic;

namespace P127_FrontToBack.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {

            List<Phone> phones = GetProducts();
            List<Advertisement> advertisements = GetAdvs();
            HomeVM model = new HomeVM
            {
                Phones = phones,
                Advertisements = advertisements
            };
            //ViewBag.Model = model;
            //ViewData["Model"] = model;
            return View(model);
        }

        public List<Phone> GetProducts()
        {
            List<Phone> phones = new List<Phone>
            {
                new Phone
                {
                    Id = 1,
                    Brand = "Samsung",
                    Model = "Galaxy S22 Ultra",
                    Price = 2200.20m,
                    Color = "Black",
                    Ram = "12GB",
                    Count = 0
                },
                new Phone
                {
                    Id = 2,
                    Brand = "Samsung",
                    Model = "Galaxy S22",
                    Price = 1800.5m,
                    Color = "White",
                    Ram = "8GB",
                    Count = 25
                },
                new Phone
                {
                    Id = 3,
                    Brand = "Apple",
                    Model = "Iphone 13 Pro Max",
                    Price = 2900.99m,
                    Color = "Purple",
                    Ram = "8GB",
                    Count = 30
                },
                new Phone
                {
                    Id = 4,
                    Brand = "Apple",
                    Model = "Iphone 13 Mini",
                    Price = 2500.7m,
                    Color = "Black",
                    Ram = "6GB",
                    Count = 22
                },
                new Phone
                {
                    Id = 5,
                    Brand = "Xiaomi",
                    Model = "Mi 8 Lite",
                    Price = 30.70m,
                    Color = "Black",
                    Ram = "18GB",
                    Count = 400
                },
                new Phone
                {
                    Id = 6,
                    Brand = "Huawei",
                    Model = "Honor 20",
                    Price = 1200.20m,
                    Color = "Pacific blue",
                    Ram = "12GB",
                    Count = 0
                },
                new Phone
                {
                    Id = 7,
                    Brand = "Nokia",
                    Model = "6300",
                    Price =0.20m,
                    Color = "Silver",
                    Ram = "1kb",
                    Count = 990
                },
                new Phone
                {
                    Id = 8,
                    Brand = "Vertu",
                    Model = "Signature",
                    Price = 9200.20m,
                    Color = "Gold",
                    Ram = "4GB",
                    Count = 7
                },
            };
            return phones;
        }

        public List<Advertisement> GetAdvs()
        {
            List<Advertisement> advertisements = new List<Advertisement>
            {
                new Advertisement
                {
                    Id =1,
                    Image = "https://fdn.gsmarena.com/imgroot/news/22/02/samsung-ad-s22-ultra/-1220x526/gsmarena_000.jpg",
                    Name = "Samsung S23 Ultra",
                    Description = "As Soon As Possible (A$AP)",
                    ReleaseDate = new DateTime(2023,02,24)
                },
                new Advertisement
                {
                    Id =2,
                    Image = "https://i.ytimg.com/vi/XKfgdkcIUxw/maxresdefault.jpg",
                    Name = "Iphone 14 Pro Max",
                    Description = "As Soon As Possible (A$AP)",
                    ReleaseDate = new DateTime(2023,03,25)
                },
                new Advertisement
                {
                    Id =3,
                    Image = "https://smart-phoneprice.com/wp-content/uploads/2021/03/Nokia-6300-5G-2021-1200x675.jpg",
                    Name = "Nokia 6301",
                    Description = "As Soon As Impossible (A$AI)",
                    ReleaseDate = new DateTime(2083,08,30)
                }
            };
            return advertisements;
        }


        public IActionResult Detail(int? id)
        {
            Phone phone = GetProducts().Find(x=>x.Id == id);
            if(phone == null)
            {
                return NotFound();
            }
            return View(phone);
        }
    }
}
