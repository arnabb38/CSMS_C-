using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMSRepository
{
    public class LoginRepositoryDB
    {
        public bool UserLoginVerification(LoginRep l)
        {
            string query = "SELECT * from LoginBase WHERE ID= '" + l.ID + "' AND Password= '" + l.Pass + "'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                l.Name = sdr["Name"].ToString();
                l.Status = sdr["Status"].ToString();
                Console.WriteLine("heyy--"+l.Status);
                
                //emp.Salary = Convert.ToDouble(sdr["Salary"]);
                //emp.Designation = sdr["Designation"].ToString();
                dcc.CloseConnection();
                return true;
            }
            else
            {
                dcc.CloseConnection();
                return false;
            }
        }
    }
}
