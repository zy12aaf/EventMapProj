﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using CsvHelper;
using DataAccess;
using Domain;
using Domain.Dto;
using Domain.Mappers;
using Domain.Models;
using EventsMap.Views.ViewModel;

namespace EventsMap.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index() {
            var repo = new EventRepo(new EventMapContext());
            var results = repo.FindEventWithSearchModel(new SearchingModel());
            ViewBag.Json = new JavaScriptSerializer().Serialize(results);
            EventResultsSearch searchResult = new EventResultsSearch(results, new SearchingModel() { PagingInformation = new PagingInformation() });


            return View(searchResult);
        }

        public PartialViewResult GetResultsBasedOnSearch(EventResultsSearch searchingModel, string datepicker, string postcodeH, string pageNumber = "1") {
            int page = int.Parse(pageNumber);
            searchingModel.SearchCriteria.PagingInformation.CurrentPage = page;
            searchingModel.SearchCriteria.PagingInformation.LoadAll = false;

            var repo = new EventRepo(new EventMapContext());
            if (postcodeH != null) {
                if (postcodeH.Trim().Length != 0) {
                    string[] strings = postcodeH.Split(',');
                    searchingModel.SearchCriteria.PostCode = new LatLong(double.Parse(strings[0]),
                        double.Parse(strings[1]));
                }
            }


            IEnumerable<EventDto> results = repo.FindEventWithSearchModel(searchingModel.SearchCriteria);

            EventResultsSearch eventResultsSearch = new EventResultsSearch(results, searchingModel.SearchCriteria);
            ViewBag.Json = new JavaScriptSerializer().Serialize(results);
            return PartialView("_GetResultsBasedOnSearch", eventResultsSearch);                        /*results.ToList())*/
        }

        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            string path = null;

            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                path = AppDomain.CurrentDomain.BaseDirectory + "Upload\\" + fileName;
                file.SaveAs(path);

                var csv = new CsvReader(new StreamReader(path));
                csv.Configuration.RegisterClassMap<ImportMappers>();
                IEnumerable<ImportModel> eventList = csv.GetRecords<ImportModel>();

                EventRepo eventRepo = new EventRepo(new EventMapContext());
                foreach (ImportModel imported in eventList)
                {
                    Event convertEvents = ImportConverter.ConvertEvents(imported);
                    eventRepo.InsertEvent(convertEvents);
                }
                eventRepo.Save();
            }

            return View();
        }



    }
}