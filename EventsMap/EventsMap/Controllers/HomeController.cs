﻿using System;
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
        public ActionResult Index() {
            var repo = new EventRepo(new EventMapContext());
            string json = "";
            var results = repo.FindEventWithSearchModel(new SearchingModel() { PagingInformation = new PagingInformation()}, out json);
            ViewBag.Json = json;
            EventResultsSearch searchResult = new EventResultsSearch(results, new SearchingModel() { PagingInformation = new PagingInformation() });


            return View(searchResult);
        }

        public PartialViewResult GetResultsBasedOnSearch(EventResultsSearch searchingModel, string datepicker, string postcodeH, string pageNumber = "1") {
            int page = int.Parse(pageNumber);
            searchingModel.SearchCriteria.PagingInformation.CurrentPage = page;

            var repo = new EventRepo(new EventMapContext());
            if (postcodeH != null) {
                if (postcodeH.Trim().Length != 0) {
                    string[] strings = postcodeH.Split(',');
                    searchingModel.SearchCriteria.PostCode = new LatLong(double.Parse(strings[0]),
                        double.Parse(strings[1]));
                }
            }
            string json = "";
            IEnumerable<EventDto> results = repo.FindEventWithSearchModel(searchingModel.SearchCriteria, out json);

            EventResultsSearch eventResultsSearch = new EventResultsSearch(results, searchingModel.SearchCriteria);
            ViewBag.Json = json;
            return PartialView("_GetResultsBasedOnSearch", eventResultsSearch);                        /*results.ToList())*/
        }
    }
}