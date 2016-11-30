using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using DataAccess;
using Domain;
using Domain.Dto;
using Domain.Models;
using EventsMap.Views.ViewModel;

namespace EventsMap.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var repo = new EventRepo(new EventMapContext());
            var results = repo.FindEventWithSearchModel(new SearchingModel());
            ViewBag.Json = new JavaScriptSerializer().Serialize(results);
            
            EventResultsSearch searchResult = new EventResultsSearch()
            {
                SearchCriteria = new SearchingModel(),
                Results = results
            };
            return View(searchResult);
            
        }

        public PartialViewResult GetResultsBasedOnSearch(EventResultsSearch searchingModel, string datepicker, string postcodeH)
        {
            var repo = new EventRepo(new EventMapContext());
            if (postcodeH != null)
            {
                if (postcodeH.Trim().Length != 0)
                {
                    string[] strings = postcodeH.Split(',');
                    searchingModel.SearchCriteria.PostCode = new LatLong(double.Parse(strings[0]),
                        double.Parse(strings[1]));
                }
            }

            IEnumerable<EventDto> results = repo.FindEventWithSearchModel(searchingModel.SearchCriteria);
            
            new EventResultsSearch(results, searchingModel.SearchCriteria);
            ViewBag.Json = new JavaScriptSerializer().Serialize(results);
            return PartialView("_GetResultsBasedOnSearch", results);                        /*results.ToList())*/
        }

        
    }
}