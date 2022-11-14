using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GL_Checkpoint3_Asset_Tracking
{
    class Attribute
    {    
        public string Brand            { get; set; }
        public string Model            { get; set; }
        public string Office           { get; set; }
        public DateTime PurchaseDate   { get; set; }
        public double PurchasePrice    { get; set; }
        public string Currency         { get; set; }
        public double ExchangeRate     { get; set; }

     }
}
