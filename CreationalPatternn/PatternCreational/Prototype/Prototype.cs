using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Prototype
{
    public class Report : Document
    {
        public int PageCount { get; set; }
        public string ReportType { get; set; }
        
        public Report(string title, string content, int pageCount, string reportType = "Standard") : base(title, content)
        {
            PageCount = pageCount;
            ReportType = reportType;
        }
        
        public override void DisplayInfo()
        {
            Console.WriteLine($"Report Type: {ReportType}");
            Console.WriteLine($"Page Count: {PageCount}");
            Console.WriteLine($"Created: {CreatedDate.ToShortDateString()}");
        }
        
        public override IPrototype Clone()
        {
            return new Report(Title, Content, PageCount, ReportType)
            {
                CreatedDate = this.CreatedDate
            };
        }
    }
    
    public class Contract : Document
    {
        public string ProviderName { get; set; }
        public string ClientName { get; set; }
        public int Duration { get; set; }
        public decimal Value { get; set; }
        
        public Contract(string title, string content, string providerName, string clientName, int duration, decimal value = 0) 
            : base(title, content)
        {
            ProviderName = providerName;
            ClientName = clientName;
            Duration = duration;
            Value = value;
        }
        
        public override void DisplayInfo()
        {
            Console.WriteLine($"Provider: {ProviderName}");
            Console.WriteLine($"Client: {ClientName}");
            Console.WriteLine($"Duration: {Duration} months");
            Console.WriteLine($"Value: ${Value:N2}");
            Console.WriteLine($"Created: {CreatedDate.ToShortDateString()}");
        }
        
        public override IPrototype Clone()
        {
            return new Contract(Title, Content, ProviderName, ClientName, Duration, Value)
            {
                CreatedDate = this.CreatedDate
            };
        }
    }
    
    public class Invoice : Document
    {
        public string InvoiceNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public string CustomerName { get; set; }
        
        public Invoice(string title, string content, string invoiceNumber, decimal amount, string customerName, int dueDays = 30) 
            : base(title, content)
        {
            InvoiceNumber = invoiceNumber;
            Amount = amount;
            CustomerName = customerName;
            DueDate = DateTime.Now.AddDays(dueDays);
        }
        
        public override void DisplayInfo()
        {
            Console.WriteLine($"Invoice Number: {InvoiceNumber}");
            Console.WriteLine($"Customer: {CustomerName}");
            Console.WriteLine($"Amount: ${Amount:N2}");
            Console.WriteLine($"Due Date: {DueDate.ToShortDateString()}");
            Console.WriteLine($"Created: {CreatedDate.ToShortDateString()}");
        }
        
        public override IPrototype Clone()
        {
            return new Invoice(Title, Content, InvoiceNumber, Amount, CustomerName)
            {
                CreatedDate = this.CreatedDate,
                DueDate = this.DueDate
            };
        }
    }
}