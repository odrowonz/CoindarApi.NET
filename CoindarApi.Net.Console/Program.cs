using Odry.CoindarAPI;
using Odry.CoindarAPI.EventTools;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoindarApi.Net.Console
{
    class Program
    {
        static private CoindarClient CoindarClient { get; set; }

        static void Main(string[] args)
        {
            CoindarClient = new CoindarClient();
            IList<IEvent> events;

            Task.Run(async () =>
            {

                //events = await CoindarClient.Events.AllLastEventsAsync();
                //events = await CoindarClient.Events.LastEventsAsync(5);
                //events = await CoindarClient.Events.CoinEventsAsync("XMR");
                //events = await CoindarClient.Events.DayEventsAsync(2017, 10, 22);
                events = await CoindarClient.Events.MonthEventsAsync(2017, 11);

                var filteredEvents = events.Where(n => (n.CoinSymbol == @"BTS"));
                foreach (var ev in filteredEvents)
                {
                    System.Console.WriteLine(ev.Caption);
                    System.Console.WriteLine(ev.Proof);
                    System.Console.WriteLine(ev.CaptionRu);
                    System.Console.WriteLine(ev.ProofRu);
                    System.Console.WriteLine(ev.PublicDate.ToString());
                    System.Console.WriteLine(ev.StartDate);
                    System.Console.WriteLine(ev.EndDate);
                    System.Console.WriteLine(ev.CoinName);
                    System.Console.WriteLine(ev.CoinSymbol);
                }
                System.Console.ReadLine();
            }).GetAwaiter().GetResult();
        }

    }
}
