using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Odry.CoindarAPI.EventTools
{
    public class Events : IEvents
    {
        private ApiWebClient ApiWebClient { get; set; }

        internal Events(ApiWebClient apiWebClient)
        {
            ApiWebClient = apiWebClient;
        }

        private IList<IEvent> LastEvents(uint limit)
        {
            var data = GetData<IList<Event>>(
                "lastEvents",
                "limit=" + limit
            );
            return new List<IEvent>(data);
        }

        private IList<IEvent> AllLastEvents()
        {
            var data = GetData<IList<Event>>("lastEvents");
            return new List<IEvent>(data);
        }
        private IList<IEvent> CoinEvents(string name)
        {
            var data = GetData<IList<Event>>(
                "coinEvents",
                "name=" + name
            );
            return new List<IEvent>(data);
        }
        private IList<IEvent> DayEvents(uint year, uint month, uint day)
        {
            var data = GetData<IList<Event>>(
                "Events",
                "Year=" + year,
                "Month=" + month,
                "Day=" + day
            );
            return new List<IEvent>(data);
        }
        private IList<IEvent> MonthEvents(uint year, uint month)
        {
            var data = GetData<IList<Event>>(
                "Events",
                "Year=" + year,
                "Month=" + month
            );
            return new List<IEvent>(data);
        }


        public Task<IList<IEvent>> LastEventsAsync(uint limit)
        {
            return Task.Factory.StartNew(() => LastEvents(limit));
        }

        public Task<IList<IEvent>> AllLastEventsAsync()
        {
            return Task.Factory.StartNew(() => AllLastEvents());
        }
        public Task<IList<IEvent>> CoinEventsAsync(string name)
        {
            return Task.Factory.StartNew(() => CoinEvents(name));
        }

        public Task<IList<IEvent>> DayEventsAsync(uint year, uint month, uint day)
        {
            return Task.Factory.StartNew(() => DayEvents(year, month, day));
        }
        public Task<IList<IEvent>> MonthEventsAsync(uint year, uint month)
        {
            return Task.Factory.StartNew(() => MonthEvents(year, month));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private T GetData<T>(string command, params object[] parameters)
        {
            return ApiWebClient.GetData<T>(command, parameters);
        }

    }
}
