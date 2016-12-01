using System.Collections.Generic;
using Domain;
using Domain.Dto;

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