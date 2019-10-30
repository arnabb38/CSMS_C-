using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMSRepository
{
    public class LoginRep
    {
        private string id;
        private string name;
        private string pass;
        private string status;

        public LoginRep()
        {
        }

        public LoginRep(string id, string name, string pass)
        {
            this.id = id;
            this.name = name;
            this.pass = pass;
        } 

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
