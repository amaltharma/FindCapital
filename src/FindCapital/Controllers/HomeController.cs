using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FindCapital.Models;

namespace FindCapital.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public JsonResult GetStateAutoComplete(string state)
        {
            var states = GetStateInformation();
            var results = !string.IsNullOrEmpty(state) ? states.Where(c => c.StateName.ToLower().StartsWith(state.ToLower().Trim())).ToList() : states;

            return Json(results);
        }
        
        private List<StateInformation> GetStateInformation()
        {
            var states = new List<StateInformation>
            {
                new StateInformation("Alabama", "AL", "Montgomery"),
                new StateInformation("Alaska", "AK", "Juneau"),
                new StateInformation("Arizona", "AZ", "Phoenix"),
                new StateInformation("Arkansas", "AR", "Little Rock"),
                new StateInformation("California", "CA", "Sacramento"),
                new StateInformation("Colorado", "CO", "Denver"),
                new StateInformation("Connecticut", "CT", "Hartford"),
                new StateInformation("Delaware", "DE", "Dover"),
                new StateInformation("Florida", "FL", "Tallahassee"),
                new StateInformation("Georgia", "GA", "Atlanta"),
                new StateInformation("Hawaii", "HI", "Honolulu"),
                new StateInformation("Idaho", "ID", "Boise" ),
                new StateInformation("Illinois", "IL", "Springfield"),
                new StateInformation("Indiana", "ID", "Indianapolis" ),
                new StateInformation("Iowa", "IA", "Des Moines"),
                new StateInformation("Kansas", "KS", "Topeka"),
                new StateInformation("Kentucky", "KY", "Frankfort" ),
                new StateInformation("Louisiana", "LA", "Baton Rouge"),
                new StateInformation("Maine", "ME", "Augusta"),
                new StateInformation("Maryland", "MD", "Annapolis"),
                new StateInformation("Massachusetts", "MA", "Boston"),
                new StateInformation("Michigan", "MI", "Lansing" ),
                new StateInformation("Minnesota", "MN", "Saint Paul"),
                new StateInformation("Mississippi", "MS", "Jackson"),
                new StateInformation("Missouri", "MO", "Jefferson City"),
                new StateInformation("Montana", "MT", "Helena"),
                new StateInformation("Nebraska", "NE", "Lincoln"),
                new StateInformation("Nevada", "NV", "Carson City" ),
                new StateInformation("New Hampshire"," NH", "Concord"),
                new StateInformation("New Jersey", "NJ", "Trenton"),
                new StateInformation("New Mexico", "NM", "Santa Fe"),
                new StateInformation("New York", "NY", "Albany"),
                new StateInformation("North Carolina", "NC", "Raleigh"),
                new StateInformation("North Dakota", "ND", "Bismark" ),
                new StateInformation("Ohio", "OH", "Columbus"),
                new StateInformation("Oklahoma", "OK", "Oklahoma City"),
                new StateInformation("Oregon", "OR", "Salem"),
                new StateInformation("Pennsylvania", "PA", "Harrisburg"),
                new StateInformation("Rhode Island", "RI", "Providence"),
                new StateInformation("South Carolina", "SC", "Columbia"),
                new StateInformation("South Dakota", "SD", "Pierre"),
                new StateInformation("Tennessee", "TN", "Nashville"),
                new StateInformation("Texas", "TX", "Austin"),
                new StateInformation("Utah", "UT", "Salt Lake City"),
                new StateInformation("Vermont", "VT", "Montpelier"),
                new StateInformation("Virginia", "VA", "Richmond"),
                new StateInformation("Washington", "WA", "Olympia"),
                new StateInformation("West Virginia", "WV", "Charleston"),
                new StateInformation("Wisconsin", "WI", "Madison"),
                new StateInformation("Wyoming", "WY", "Cheyenne")
            };

            return states;

        } 





    }   

}
