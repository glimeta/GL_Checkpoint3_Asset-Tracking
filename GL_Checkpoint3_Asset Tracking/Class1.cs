using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GL_Checkpoint3_Asset_Tracking
{
    class Asset
    {    
        public string Type            { get; set; }
        public string Brand            { get; set; }
        public string Model            { get; set; }
        public string Office           { get; set; }
        public DateTime PurchaseDate   { get; set; }
        public int PurchasePrice       { get; set; }
        public string Currency         { get; set; }
        public double ExchangeRate     { get; set; }
        

        public Asset(string type, string brand, string model, Office office, double purchasePrice, string currency, double exchangeRate, DateTime purchaseDate)
        {
            Brand = brand;
            Model = model;
            PurchaseDate = purchaseDate;
            Office = office;
            PurchasePrice = purchasePrice;
            Currency = currency;
            ExchangeRate = exchangeRate;
            Type = type;
        }





    }
}
