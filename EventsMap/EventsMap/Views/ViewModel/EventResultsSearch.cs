using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain;
using Domain.Dto;
using Domain.HelperModel;
using Domain.Models;

namespace EventsMap.Views.ViewModel
{
    public class EventResultsSearch
    {
        public EventResultsSearch()
        {
            Results = new List<EventDto>();
            SearchCriteria = new SearchingModel();
        }

        public EventResultsSearch(IEnumerable<EventDto> results, SearchingModel searchCriteria)
        {
            Results = results;
            SearchCriteria = searchCriteria;
            searchCriteria.PagingInformation.TotalItems = results.Count();
        }

        public IEnumerable<EventDto> Results { get; set; }
        
        public SearchingModel SearchCriteria{ get; set; }

    }
}