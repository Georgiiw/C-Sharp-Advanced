using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Investor
    {
        private List<Stock> portfolio;
        private string fullName;
        private string emailAddress;
        private decimal moneyToInvest;
        private string brokerName;
        public string FullName { get => fullName; set => fullName = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public decimal MoneyToInvest { get => moneyToInvest; set => moneyToInvest = value; }
        public string BrokerName { get => brokerName; set => brokerName = value; }
        public List<Stock> Portfolio { get => portfolio; set => portfolio = value; }

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            Portfolio = new List<Stock>();
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
        }
         public int Count => this.Portfolio.Count;
        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization >= 10000 && MoneyToInvest >= stock.MarketCapitalization)
            {
                this.Portfolio.Add(stock);
                MoneyToInvest -= stock.MarketCapitalization;
            }
        }
        public string SellStock(string companyName, decimal sellPrice)
        {
            
            foreach(Stock stock in this.Portfolio)
            {
                if (stock.CompanyName == companyName && stock.MarketCapitalization == sellPrice)
                {
                    if (sellPrice <= stock.PricePerShare)
                    {
                        return $"Cannot sell {companyName}.";
                    }
                    else
                    {
                        this.Portfolio.Remove(stock);
                        MoneyToInvest = stock.MarketCapitalization;
                        return $"{companyName} was sold.";
                    }
                }

            }

            return $"{companyName} does not exist.";
        }
        public Stock FindStock(string companyName)
        {
            foreach (var stock in Portfolio)
            {
                if (stock.CompanyName == companyName)
                {
                    return stock;
                }
            }
            return null;
        }
        public Stock FindBiggestCompany()
        {
            if (Portfolio.Any())
            {
                return this.Portfolio.Max();
            }
            return null;
        }
        public string InvestorInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"The investor {FullName} with a broker {BrokerName} has stocks:");
            Console.WriteLine($"The investor {FullName} with a broker {BrokerName} has stocks:");
            foreach (var stock in Portfolio)
            {

                sb.Append(stock);
            }
            return sb.ToString();
        }
    }
}
