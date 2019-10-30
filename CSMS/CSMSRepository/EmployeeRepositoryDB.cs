using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CSMSRepository
{
    public class EmployeeRepositoryDB
    {
        public bool Insert(EmployeeRep emp)
        {
            try
            {
                string query = "INSERT into Employee VALUES ('" + emp.Employeeid + "', '" + emp.Employeename + "', '" + emp.Gender + "', '" + emp.Address + "', '" + emp.Email + "', '" + emp.Contacts + "', '" + emp.Status + "','" + emp.Password + "','" + emp.Salary + "')";
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

        /*public bool Update(EmployeeRep emp)
        {
            try
            {
                string query = "UPDATE Employees SET EmployeeName = '" + emp.EmployeeName + "', Salary = " + emp.Salary + ", Designation = '" + emp.Designation + "' WHERE EmployeeId= '" + emp.EmployeeId + "'";
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
        public bool Delete(string employeeId)
        {
            try
            {
                string query = "DELETE from Employees WHERE EmployeeId = '" + employeeId + "'";
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

        public bool UserLoginVerification(EmployeeRep emp)
        {
            string query = "SELECT * from Employee WHERE Id= '" + emp.Employeeid + "' AND Password= '" + emp.Password + "'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                emp.Employeename = sdr["Name"].ToString();
                emp.Gender = sdr["Gender"].ToString();
                emp.Address = sdr["Address"].ToString();
                emp.Email = sdr["Email"].ToString();
                emp.Status = sdr["Status"].ToString();
                emp.Contacts = sdr["Contact"].ToString();

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
