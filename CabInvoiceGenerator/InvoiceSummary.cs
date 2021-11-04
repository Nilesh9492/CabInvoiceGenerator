using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        private int noOfRides;
        private double totalFare;
        private double averageFare;

        public InvoiceSummary(int numberOfRides, double totalFare)
        {
            this.noOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.averageFare = this.totalFare / this.noOfRides;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is InvoiceSummary))
                return false;
            InvoiceSummary invoiceObj = (InvoiceSummary)obj;
            return this.noOfRides == invoiceObj.noOfRides && this.totalFare == invoiceObj.totalFare && this.averageFare == invoiceObj.averageFare;
        }

        public override int GetHashCode()
        {
            return this.noOfRides.GetHashCode() ^ this.totalFare.GetHashCode() ^ this.averageFare.GetHashCode();
        }
    }
}
