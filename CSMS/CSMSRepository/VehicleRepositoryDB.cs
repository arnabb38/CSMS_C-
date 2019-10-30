using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CSMSRepository
{
    public class VehicleRepositoryDB
    {
        public bool Insert(VehicleRep vr)
        {
            try
            { 
                string query = "INSERT into Vehicle VALUES ('" + vr.CarID + "', '" + vr.Category + "', '" + vr.ModelName + "','" + vr.Date + "','" + vr.Engine + "','" + vr.Color + "','" + vr.Cost + "','" + vr.Seat + "' )";
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

        /*public bool Update(SeniorEmployeeRep se)
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


        public List<VehicleRep> GetAllVehicle()
        {
            string query = "SELECT * from Vehicle";
            List<VehicleRep> crList = new List<VehicleRep>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                VehicleRep cr = new VehicleRep();
                //a.AccountId = sdr["AccountId"].ToString();
                //a.AccountHolderName = sdr["AccountHolderName"].ToString();
                //a.Balance = Convert.ToDouble(sdr["Balance"]);

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
                //cr.SalesInvoice = sdr["SalesInvoice"].ToString();

                cr.CarID = sdr["Id"].ToString();
                cr.Category = sdr["Category"].ToString();
                cr.ModelName = sdr["ModelName"].ToString();
                cr.Date = sdr["Added Date"].ToString();
                cr.Engine = sdr["EngineType"].ToString();
                cr.Color = sdr["Color"].ToString();
                cr.Cost = sdr["Cost"].ToString();
                cr.Seat = sdr["Seat"].ToString();

                crList.Add(cr);
            }
            return crList;
        }
    }
}
