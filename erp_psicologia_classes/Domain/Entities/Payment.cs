using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Value { get; private set; }
        public decimal Amount_Paid { get; private set; }
        public bool Paid { get; set; }
        public DateTime Date { get; private set; }
        public string Description { get; set; }
        public int SessionId { get; set; }
        public Session Session { get; set; }
        public Payment() { }

        public Payment(decimal value, decimal amount_Paid, bool paid, DateTime date, string description, int sessionId)
        {
            SetValue(value);
            SetAmountPaid(amount_Paid);
            Paid = paid;
            SetDate(date);
            Description = description;
            SessionId = sessionId;
        }
        public void SetValue(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Invalid Value {value}");
            }
            Value = value;
        }
        public void SetAmountPaid(decimal amountPaid)
        {
            if (amountPaid < 0)
            {
                throw new ArgumentException($"Invalid Amount Paid {amountPaid}");

            }
            Amount_Paid = amountPaid;
        }
        public void SetDate(DateTime date)
        {
            if (date < DateTime.MinValue)
            {
                throw new ArgumentException($"Invalid Date {date.ToString()}");
            }
            Date = date;
        }
    }
}
