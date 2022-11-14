using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GL_Checkpoint3_Asset_Tracking
{
    class ExchangeRate
    {
        public string Currency { get; set; }
        public double Rate { get; set; }

        public ExchangeRate(string currency, double rate)   // Constructor that gives data for currency and rate
        {
            Currency = currency;                      
            Rate = rate;
        }

       
    }

}
