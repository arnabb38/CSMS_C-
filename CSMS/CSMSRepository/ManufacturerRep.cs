using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMSRepository
{
    public class ManufacturerRep
    {
        private string name;
        private string id;
        //private string gender;
        private string address;
        private string email;
        //private string password;
        private string contacts;
        private string status;
        //private string salary;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Address
        {
            set { address = value; }
            get { return address; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        /*public string Gender
        {
            set { gender = value; }
            get { return gender; }
        }

        public string Password
        {
            set { password = value; }
            get { return password; }
        }*/

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

        /*public string Salary
        {
            set { salary = value; }
            get { return salary; }
        }*/
    }
}
