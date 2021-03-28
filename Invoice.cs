using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet5AndCSharp9Tests
{
    public class Invoice
    {
        public Invoice(Guid id, decimal total, Address deliverAdress)
        {
            Id = id;
            Total = total;
            DeliverAdress = deliverAdress;
        }

        public Guid Id { get; private set; }
        public decimal Total { get; private set; }
        public Address DeliverAdress { get; private set; }

        public override string ToString()
        {
            return $"Your Invoice has a Total $ {Total} and will be delivered at {DeliverAdress}.";
        }

        internal void ChangeDeliverAddress(Address deliverAdress2)
        {
            DeliverAdress = deliverAdress2;
        }
    }
}
