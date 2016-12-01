using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Domain;
using Domain.Dto;
using Domain.Models;
using LinqKit;

namespace DataAccess
{
    public class EventRepo : IEventRepo, IDisposable
    {
        private readonly EventMapContext context;

        public EventRepo(EventMapContext context) {
            this.context = context;
        }

        public IEnumerable<Event> GetEvents() {
            return context.Events.ToList();
        }

        public IEnumerable<EventDto> FindEventWithSearchModel(SearchingModel sm, out string jsonPar) {
            var queryBuilder = (from t in context.Events
                                select t);
            queryBuilder = queryBuilder.Include(o => o.Location);

            if (sm.Keyword != null && sm.Keyword.Trim().Length != 0) {
                queryBuilder = queryBuilder.Where(o => o.Location.EventName.ToUpper().Contains(sm.Keyword.ToUpper()));
            }

            if (sm.MainAudience != null) {
                queryBuilder = queryBuilder.Where(o => o.MainAudience == sm.MainAudience);
            }

            if (sm.Region != null) {
                queryBuilder = queryBuilder.Where(o => o.Location.Region == sm.Region);
            }

            if (sm.Type != null) {
                queryBuilder = queryBuilder.Where(o => o.Type == sm.Type);
            }
            if (sm.DateOfEvent != null) {
                queryBuilder = queryBuilder.Where(o => o.DateOfEvent.Date == sm.DateOfEvent);
            }

            IEnumerable<Event> list;
            if (sm.PostCode != null && sm.SearchWithinRadius != null)
            {
                list = queryBuilder.ToList();
                var dist = (int)sm.SearchWithinRadius;
                list = list.Where(o => o.Location.WithinDistance(sm.PostCode, dist)).ToList();
            }
            else
            {
                list = queryBuilder;
            }

            string json = "";

            if (sm.PagingInformation != null) {
                if (sm.PagingInformation.LoadAll) {
                    var dtoListt = list.Select(o => new EventDto(
                        o.Name,
                        o.Location.Address,
                        o.Location.Postcode,
                        o.Location.Latitude,
                        o.Location.Longtitude,
                        o.Location.Region,
                        o.DateOfEvent,
                        o.Description)).ToList();

                    json = new JavaScriptSerializer().Serialize(dtoListt);
                }
                list =
                        queryBuilder
                            .OrderBy(o => o.DateOfEvent)
                            .Skip(sm.PagingInformation.CurrentPage * sm.PagingInformation.ItemsPerPage)
                            .Take(sm.PagingInformation.ItemsPerPage);

                
            }



            var dtoList = list.Select(o => new EventDto(
                o.Name,
                o.Location.Address,
                o.Location.Postcode,
                o.Location.Latitude,
                o.Location.Longtitude,
                o.Location.Region,
                o.DateOfEvent,
                o.Description)).ToList();
            jsonPar = json;

            return dtoList;
        }

        public Event GetEventByID(int id) {
            return context.Events.Find(id);
        }

        public void InsertEvent(Event apprenticeEvent) {
            context.Events.Add(apprenticeEvent);
        }

        public void DeleteEvent(int apprenticeEventId) {
            Event apprenticeEvent = context.Events.Find(apprenticeEventId);
            context.Events.Remove(apprenticeEvent);
        }

        public void UpdateEvent(Event apprenticeEvent) {
            context.Entry(apprenticeEvent).State = EntityState.Modified;
        }

        public void Save() {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing) {
            if (!this.disposed) {
                if (disposing) {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
