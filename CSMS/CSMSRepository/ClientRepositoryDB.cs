using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace CSMSRepository
{
    public class ClientRepositoryDB
    {
        public bool Insert(ClientRep cr)
        {
            try
            {
                string query = "INSERT into Client VALUES ('" + cr.Id + "', '" + cr.Name + "', '" + cr.Gender + "', '" + cr.Address + "', '" + cr.Email + "', '" + cr.Contacts + "', '" + cr.Password + "','" + cr.Occupation + "','" + cr.AddedBy + "')";
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


        public List<ClientRep> GetAllClient()
        {
            string query = "SELECT * from Client";
            List<ClientRep> crList = new List<ClientRep>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                ClientRep cr = new ClientRep();
                
                ////a.AccountId = sdr["AccountId"].ToString();
                ////a.AccountHolderName = sdr["AccountHolderName"].ToString();
                ////a.Balance = Convert.ToDouble(sdr["Balance"]);

                //cr.SalesID = sdr["ID"].ToString();
                //cr.CustName = sdr["Name"].ToString();
                ////cr.Gender =
                ////se.SeniorEmployeename = sdr["Name"].ToString();
                ////cr.CustGender = sdr["Gender"].ToString();
                //cr.CustAddress = sdr["Address"].ToString();
                //cr.CustMail = sdr["Email"].ToString();
                ////cr.Status = sdr["Status"].ToString();
                //cr.CustContacts = sdr["Contact"].ToString();
                //cr.Payment = sdr["Payment"].ToString();
                //cr.VecModel = sdr["VehicleModel"].ToString();
                //cr.VecNetCost = sdr["NetCost"].ToString();
                //cr.Date = sdr["PurchaseDate"].ToString();

                cr.Id = sdr["Id"].ToString();
                cr.Name = sdr["Name"].ToString();
                cr.Address = sdr["Address"].ToString();
                cr.Email = sdr["Email"].ToString();
                cr.Contacts = sdr["Contact"].ToString();
                cr.Occupation = sdr["Occupation"].ToString();

                crList.Add(cr);
            }
            return crList;
        }


        public List<ClientRep> SearchClient(string text)
        {
            string query = "SELECT * from Client WHERE Name LIKE '%" + text + "%'"; //OR AccountHolderName LIKE '%" + text + "%'";
            List<ClientRep> aList = new List<ClientRep>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                ClientRep a = new ClientRep();
                //a.AccountId = sdr["AccountId"].ToString();
                //a.AccountHolderName = sdr["AccountHolderName"].ToString();
                //a.Balance = Convert.ToDouble(sdr["Balance"]);

                a.Id = sdr["Id"].ToString();
                a.Name = sdr["Name"].ToString();
                a.Address = sdr["Address"].ToString();
                a.Email = sdr["Email"].ToString();
                a.Contacts = sdr["Contact"].ToString();


                aList.Add(a);
            }
            return aList;
        }

    }

    
}
