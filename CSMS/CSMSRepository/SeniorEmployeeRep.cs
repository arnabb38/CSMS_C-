using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMSRepository
{
    public class SeniorEmployeeRep
    {
        private string seniorEmployeeName;
        private string seniorEmployeeID;
        private string gender;
        private string seniorEmployeeAddress;
        private string email;
        private string password;
        private string contacts;
        private string status;
        private string salary;

        public string SeniorEmployeename
        {
            set { seniorEmployeeName = value; }
            get { return seniorEmployeeName; }
        }

        public string SeniorEmployeeid
        {
            set { seniorEmployeeID = value; }
            get { return seniorEmployeeID; }
        }

        public string SeniorEmployeeaddress
        {
            set { seniorEmployeeAddress = value; }
            get { return seniorEmployeeAddress; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        public string Gender
        {
            set { gender = value; }
            get { return gender; }
        }

        public string Password
        {
            set { password = value; }
            get { return password; }
        }

        public string Contacts
        {
            set { contacts = value; }
            get { return contacts; }
        }

        public string Status
        {
            set { status = value; }
            get { return status; }
        }

        public string Salary
        {
            set { salary = value; }
            get { return salary; }
        }
    }
}
