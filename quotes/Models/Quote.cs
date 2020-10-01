using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quotes.Models
{
    public class Quote
    {
        string Text { get; set; }
        DateTime Date { get; set; }
        [JsonIgnore]
        ICollection<QuoteTag> Tags { get; set; }
    }
}
