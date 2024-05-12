using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class TaxBracket:Entity
    {
        public long Br_from { get;private set; }
        public long Br_to { get;private set;}
        public float Br_percent { get;private set; }
        private  TaxBracket()
        {

        }
        public TaxBracket(Guid id,long from , long to , float percent):base(id)
        {
            this.Br_from = from;
            this.Br_to = to;
            this.Br_percent = percent;
        }
    }
}
