using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace CSMSRepository
{
    public class ManufacturerRepositoryDB
    {
        public bool Insert(ManufacturerRep mr)
        {
            try
            {  
                string query = "INSERT into Manufacturer VALUES ('" + mr.Id + "', '" + mr.Name + "', '" + mr.Address + "', '" + mr.Email + "', '" + mr.Contacts + "', '" + mr.Status + "')";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /*public bool Update(ManufacturerRep mr)
        {
            try
            {
                string query = "UPDATE SeniorEmployee SET Name = '" + se.SeniorEmployeename + "', Address = " + se.SeniorEmployeeaddress + ", Contacts = '" + se.Contacts + "' WHERE Id= '" + se.SeniorEmployeeid + "'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(string seniorEmployeeID)
        {
            try
            {
                string query = "DELETE from SeniorEmployee WHERE Id = '" + seniorEmployeeID + "'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }*/
    }
}
