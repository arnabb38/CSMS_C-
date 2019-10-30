using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMSRepository
{
    public class SalesRep
    {
        
        private string salesId;
        private string date;

        private string custName;
        private string custGender;
        private string custAddress;
        private string custemail;
        private string custcontacts;

        private string vecModel;
        private string vecNetCost;
        private string payment;

        private string salesInvoice;

        public string CustName
        {
            set { custName = value; }
            get { return custName; }
        }

        public string SalesID
        {
            set { salesId = value; }
            get { return salesId; }
        }

        public string CustAddress
        {
            set { custAddress = value; }
            get { return custAddress; }
        }

        public string CustMail
        {
            set { custemail = value; }
            get { return custemail; }
        }

        public string CustGender
        {
            set { custGender = value; }
            get { return custGender; }
        }

        
        public string CustContacts
        {
            set { custcontacts = value; }
            get { return custcontacts; }
        }

       

        public string VecNetCost
        {
            get
            {
                return vecNetCost;
            }

            set
            {
                vecNetCost = value;
            }
        }

        public string Payment
        {
            get
            {
                return payment;
            }

            set
            {
                payment = value;
            }
        }

        public string VecModel
        {
            get
            {
                return vecModel;
            }

            set
            {
                vecModel = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string SalesInvoice
        {
            get
            {
                return salesInvoice;
            }

            set
            {
                salesInvoice = value;
            }
        }
    }
}
