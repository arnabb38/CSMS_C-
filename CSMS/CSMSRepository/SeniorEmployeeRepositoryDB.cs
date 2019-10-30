using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMSRepository
{
    public class SeniorEmployeeRepositoryDB
    {
        public bool Insert(SeniorEmployeeRep se)
        {
            try
            { 
                string query = "INSERT into SeniorEmployee VALUES ('" + se.SeniorEmployeeid + "', '" + se.SeniorEmployeename + "', '" + se.Gender + "', '" + se.SeniorEmployeeaddress + "', '" + se.Email + "', '" + se.Contacts + "', '" + se.Status + "','" + se.Password + "','" + se.Salary + "')";
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

        public bool Update(SeniorEmployeeRep se)
        {
            try
            {
                string query = "UPDATE SeniorEmployee SET Name = '" + se.SeniorEmployeename + "', Gender = " + se.Gender + ", Address = '" + se.SeniorEmployeeaddress + "', Email = '" + se.Email + "', Contacts = '" + se.Contacts + "', Status = '" + se.Status + "', Password = '" + se.Password + "', Salary = '" + se.Salary + "' WHERE Id= '" + se.SeniorEmployeeid + "'";
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
        }

        /*public Employee GetEmployee(string employeeId)
        {
            string query = "SELECT * from Employees WHERE EmployeeId= '" + employeeId + "'";
            Employee emp = null;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            if (sdr.Read())
            {
                emp = new Employee();
                emp.EmployeeId = sdr["EmployeeId"].ToString();
                emp.Password = sdr["Password"].ToString();
                emp.EmployeeName = sdr["EmployeeName"].ToString();
                emp.Salary = Convert.ToDouble(sdr["Salary"]);
                emp.Designation = sdr["Designation"].ToString();
            }
            dcc.CloseConnection();
            return emp;
        }

        public List<Employee> GetAllEmployees()
        {
            string query = "SELECT * from Employees";
            List<Employee> empList = new List<Employee>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Employee emp = new Employee();
                emp.EmployeeId = sdr["EmployeeId"].ToString();
                emp.Password = sdr["Password"].ToString();
                emp.EmployeeName = sdr["EmployeeName"].ToString();
                emp.Salary = Convert.ToDouble(sdr["Salary"]);
                emp.Designation = sdr["Designation"].ToString();
            }
            dcc.CloseConnection();
            return empList;
        }*/

        public bool UserLoginVerification(SeniorEmployeeRep se)
        {
            string query = "SELECT * from SeniorEmployee WHERE Id= '" + se.SeniorEmployeeid + "' AND Password= '" + se.Password + "'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                se.SeniorEmployeename = sdr["Name"].ToString();
                se.Gender = sdr["Gender"].ToString();
                se.SeniorEmployeeaddress = sdr["Address"].ToString();
                se.Email = sdr["Email"].ToString();
                se.Status = sdr["Status"].ToString();
                se.Contacts = sdr["Contact"].ToString();
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
