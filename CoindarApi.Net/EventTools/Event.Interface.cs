using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odry.CoindarAPI.EventTools
{
    public interface IEvent
    {
        string Caption { get; }

        string Proof { get; }

        string CaptionRu { get; }
        string ProofRu { get; }

        DateTime PublicDate { get; }

        string StartDate { get; }

        string EndDate { get; }

        string CoinName { get; }

        string CoinSymbol { get; }
    }
}
