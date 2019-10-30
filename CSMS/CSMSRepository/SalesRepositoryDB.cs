using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CSMSRepository
{
    public class SalesRepositoryDB
    {
        public bool Insert(SalesRep sr)
        {
            try
            {
                string query = "INSERT into Sales VALUES ('" + sr.SalesID + "', '" + sr.CustName + "', '" + sr.CustAddress + "', '" + sr.CustContacts+ "', '" + sr.CustMail + "', '" + sr.VecModel + "', '" + sr.VecNetCost + "','" + sr.Payment + "','" + sr.Date + "','" + sr.SalesInvoice + "')";
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

        public List<SalesRep> GetAllSales()
        {
            string query = "SELECT * from Sales";
            List<SalesRep> crList = new List<SalesRep>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                SalesRep cr = new SalesRep();
                //a.AccountId = sdr["AccountId"].ToString();
                //a.AccountHolderName = sdr["AccountHolderName"].ToString();
                //a.Balance = Convert.ToDouble(sdr["Balance"]);

                cr.SalesID = sdr["ID"].ToString();
                cr.CustName = sdr["Name"].ToString();
                //cr.Gender =
                //se.SeniorEmployeename = sdr["Name"].ToString();
                //cr.CustGender = sdr["Gender"].ToString();
                cr.CustAddress = sdr["Address"].ToString();
                cr.CustMail = sdr["Email"].ToString();
                //cr.Status = sdr["Status"].ToString();
                cr.CustContacts = sdr["Contact"].ToString();
                cr.Payment = sdr["Payment"].ToString();
                cr.VecModel = sdr["VehicleModel"].ToString();
                cr.VecNetCost = sdr["NetCost"].ToString();
                cr.Date = sdr["PurchaseDate"].ToString();
                cr.SalesInvoice = sdr["SalesInvoice"].ToString();

                crList.Add(cr);
            }
            return crList;
        }


        public List<SalesRep> GetAllSalesByEmp(string i)
        {
            string query = "SELECT * from Sales WHERE SalesInvoice = 'i'";
            List<SalesRep> crList = new List<SalesRep>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                SalesRep cr = new SalesRep();
                //a.AccountId = sdr["AccountId"].ToString();
                //a.AccountHolderName = sdr["AccountHolderName"].ToString();
                //a.Balance = Convert.ToDouble(sdr["Balance"]);

                cr.SalesID = sdr["ID"].ToString();
                cr.CustName = sdr["Name"].ToString();
                //cr.Gender =
                //se.SeniorEmployeename = sdr["Name"].ToString();
                //cr.CustGender = sdr["Gender"].ToString();
                cr.CustAddress = sdr["Address"].ToString();
                cr.CustMail = sdr["Email"].ToString();
                //cr.Status = sdr["Status"].ToString();
                cr.CustContacts = sdr["Contact"].ToString();
                cr.Payment = sdr["Payment"].ToString();
                cr.VecModel = sdr["VehicleModel"].ToString();
                cr.VecNetCost = sdr["NetCost"].ToString();
                cr.Date = sdr["PurchaseDate"].ToString();
                cr.SalesInvoice = sdr["SalesInvoice"].ToString();

                crList.Add(cr);
            }
            return crList;
        }
    }
}
