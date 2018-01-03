using Microsoft.AspNetCore.Mvc;
using OpieAndAnthonyRadioShow.Data.Models;
using OpieAndAnthonyRadioShow.Models;
using System;
using System.Collections.Generic;

namespace OpieAndAnthonyRadioShow.Controllers
{
    public class RadioShowController : Controller
    {
        public IActionResult Index()
        {
            // MOCK DATA FOR NOW
            #region MOCK DATA FOR TESTING PURPOSES

            var guestList = new List<Guest>()
            {
                new Guest()
                {
                    Id = 1,
                    Name = "Test Person 1",
                    Occupation = "Comedian"
                },
                new Guest()
                {
                    Id = 2,
                    Name = "Test Person 2",
                    Occupation = "Comedian"
                },
                new Guest()
                {
                    Id = 3,
                    Name = "Test Person 3",
                    Occupation = "Comedian"
                },
            };

            var tagList = new List<RadioShowTag>()
            {
                new RadioShowTag()
                {
                    Id = 1,
                    Description = "First radioshow!!!"
                },
                new RadioShowTag()
                {
                    Id = 2,
                    Description = "Comedian"
                },
                new RadioShowTag()
                {
                    Id = 3,
                    Description = "Testing shit"
                }
            };

            var radioShowList = new List<RadioShow>()
            {
                new RadioShow()
                {
                    AirTime = DateTime.Now,
                    Guests = guestList,
                    Id = 1,
                    Tags = tagList,
                    Title = "First radioshow with Opie and Anthony",
                    URL = "https://static.pexels.com/photos/754392/pexels-photo-754392.jpeg"
                },
                new RadioShow()
                {
                    AirTime = DateTime.Today,
                    Guests = guestList,
                    Id = 2,
                    Tags = tagList,
                    Title = "Second radioshow with Opie and Anthony",
                    URL = "https://static.pexels.com/photos/754392/pexels-photo-754392.jpeg"
                },
                new RadioShow()
                {
                    AirTime = DateTime.Now,
                    Guests = guestList,
                    Id = 1,
                    Tags = tagList,
                    Title = "First radioshow with Opie and Anthony",
                    URL = "https://static.pexels.com/photos/754392/pexels-photo-754392.jpeg"
                },
                new RadioShow()
                {
                    AirTime = DateTime.Now,
                    Guests = guestList,
                    Id = 1,
                    Tags = tagList,
                    Title = "First radioshow with Opie and Anthony",
                    URL = "https://static.pexels.com/photos/754392/pexels-photo-754392.jpeg"
                },
                new RadioShow()
                {
                    AirTime = DateTime.Now,
                    Guests = guestList,
                    Id = 1,
                    Tags = tagList,
                    Title = "First radioshow with Opie and Anthony",
                    URL = "https://static.pexels.com/photos/754392/pexels-photo-754392.jpeg"
                },
                new RadioShow()
                {
                    AirTime = DateTime.Now,
                    Guests = guestList,
                    Id = 1,
                    Tags = tagList,
                    Title = "First radioshow with Opie and Anthony",
                    URL = "https://static.pexels.com/photos/754392/pexels-photo-754392.jpeg"
                },
                new RadioShow()
                {
                    AirTime = DateTime.Now,
                    Guests = guestList,
                    Id = 1,
                    Tags = tagList,
                    Title = "First radioshow with Opie and Anthony",
                    URL = "https://static.pexels.com/photos/754392/pexels-photo-754392.jpeg"
                },
            };

            #endregion

            var radioViewModel = new RadioShowViewModel()
            {
                RadioShows = radioShowList,
                SearchQuery = ""
            };
            return View(radioViewModel);
        }
    }
}