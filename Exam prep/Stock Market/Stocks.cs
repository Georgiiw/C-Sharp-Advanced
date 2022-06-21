using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Stock
    {
        
        private string companyName;
        private string director;   
        private decimal pricePerShare;  
        private int totalNumberOfShares;
        private decimal marketCapitalization;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        public string Director
        {
            get { return director; }
            set { director = value; }
        }
        public decimal PricePerShare
        {
            get { return pricePerShare; }
            set { pricePerShare = value; }
        }
        public int TotalNumberOfShares
        {
            get { return totalNumberOfShares; }
            set { totalNumberOfShares = value; }
        }
        public decimal MarketCapitalization
        {
            get { return marketCapitalization; }
            set { marketCapitalization = value; }
        }
        public Stock(string companyName, string director, decimal pricePerShare, int totalNumberOfShares)
        {
            CompanyName = companyName;
            Director = director;
            PricePerShare = pricePerShare;
            TotalNumberOfShares = totalNumberOfShares;
            MarketCapitalization = pricePerShare * totalNumberOfShares;
           
        }
        
        public override string ToString()
        {
            return $"Compnay: {CompanyName}" +
                $"Director: {Director}" +
                $"Price per share: ${PricePerShare}" +
                $"Market capitalization: ${MarketCapitalization}";

        }
    }
}
