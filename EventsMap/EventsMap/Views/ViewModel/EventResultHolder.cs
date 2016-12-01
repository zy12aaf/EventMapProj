using System.Collections.Generic;
using Domain;
using Domain.Dto;
using Domain.HelperModel;

namespace EventsMap.Views.ViewModel
{
    public class EventResultHolder
    {
        public EventResultHolder(IEnumerable<EventDto> allMapResults, IEnumerable<EventDto> results, PagingInformation pagingInfo) {
            Results = results;
        }
        public IEnumerable<EventDto> Results { get; set; }

    }
}