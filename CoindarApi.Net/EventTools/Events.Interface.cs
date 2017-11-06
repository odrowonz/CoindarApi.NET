using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odry.CoindarAPI.EventTools
{
    public interface IEvents
    {
        /// <summary>Returns number of events sorted by date of addition in Coindar in reverse order. The last events are returned first.</summary>
        /// <param name="limit">Maximum number of events to return.</param>
        Task<IList<IEvent>> LastEventsAsync(uint limit);


        /// <summary>Returns all events sorted by date of addition in Coindar in reverse order. The last events are returned first.</summary>
        Task<IList<IEvent>> AllLastEventsAsync();

        /// <summary>Returns events associated with a particular coin. Events are output in the order similar to lastEvents.</summary>
        Task<IList<IEvent>> CoinEventsAsync(string name);

        /// <summary>Returns all events for a specific day.</summary>
        Task<IList<IEvent>> DayEventsAsync(uint year, uint month, uint day);


        /// <summary>Returns all events for a specific month.</summary>
        Task<IList<IEvent>> MonthEventsAsync(uint year, uint month);
    }
}
