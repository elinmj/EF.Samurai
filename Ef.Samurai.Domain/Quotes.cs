using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
    public class Quotes
    {
        public int Id { get; set; }
        public string Quote { get; set; }
        public string QuoteType { get; set; }
        public string Haircut { get; set; }
        public Samurai Samurai { get; set; }
    }
}
