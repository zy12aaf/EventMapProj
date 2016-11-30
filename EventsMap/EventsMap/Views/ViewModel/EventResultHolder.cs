using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.Dto;

namespace EventsMap.Views.ViewModel
{
    public class EventResultHolder
    {
        public int CurrentPage { get; set; }

        public IEnumerable<EventDto> Results { get; set; }
    }
}