
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSMSRepository;

namespace CSMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cancel_click(object sender, EventArgs e)
        {
            Home hm = new Home();
            //hm.Enabled = true;
            this.Close();
            
            hm.Show();

        }

        private void signin_click(object sender, EventArgs e)
        {
            /*LoginRep lr = new LoginRep();
            lr.ID = this.idBox.Text;
            lr.Pass = this.passBox.Text;

            LoginRepositoryDB lRepDB = new LoginRepositoryDB();

            if (lRepDB.UserLoginVerification(lr))
            {
                string n = lr.Name;
                string s = lr.Status;
                string id = lr.ID;
                Console.WriteLine(n + "  " + s);

                SeniorEmployee se = new SeniorEmployee(s, n, id);
                //SeniorEmployee se = new SeniorEmployee(n, s);
                se.Show();
                this.Hide();

                
            }

            else
            {
                MessageBox.Show("Not Found", "Error");
            }*/

            if (this.idBox.Text.Contains("se") == true)
            {
                //MessageBox.Show("hello!");
                SeniorEmployeeRep ser = new SeniorEmployeeRep();
                ser.SeniorEmployeeid = this.idBox.Text;
                ser.Password = this.passBox.Text;

                SeniorEmployeeRepositoryDB serdb = new SeniorEmployeeRepositoryDB();

                if (serdb.UserLoginVerification(ser))
                {
                    string n = ser.SeniorEmployeename;
                    string g = ser.Gender;
                    string id = ser.SeniorEmployeeid;
                    string add = ser.SeniorEmployeeaddress;
                    string m = ser.Email;
                    string p = ser.Password;
                    string c = ser.Contacts;
                    string s = ser.Status;

                    Console.WriteLine(n + "  " + s);

                    SeniorEmployee se = new SeniorEmployee(n, g, id, add, m, p, c, s);
                    //SeniorEmployee se = new SeniorEmployee(n, s);
                    se.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Not Found!!", "Error");
                }
            }

            else if (this.idBox.Text.Contains("emp") == true)
            {
                //MessageBox.Show("hello!");
                EmployeeRep er = new EmployeeRep();
                er.Employeeid = this.idBox.Text;
                er.Password = this.passBox.Text;

                EmployeeRepositoryDB erdb = new EmployeeRepositoryDB();

                if (erdb.UserLoginVerification(er))
                {
                    string n = er.Employeename;
                    string g = er.Gender;
                    string id = er.Employeeid;
                    string add = er.Address;
                    string m = er.Email;
                    string p = er.Password;
                    string c = er.Contacts;
                    string s = er.Status;

                    Console.WriteLine(n + "  " + s);

                    //SeniorEmployee se = new SeniorEmployee(n, g, id, add, m, p, c, s);
                    //SeniorEmployee se = new SeniorEmployee(n, s);
                    Employee emp = new Employee(n, g, id, add, m, p, c, s);
                    emp.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Not Found!!", "Error");
                }
            }

            else
            {
                MessageBox.Show("Invalid UserID or Password!!", "Error");
            }
        }
        

        private void getAccountEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Blue;
        }

        private void getAccountLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(208, 20, 44);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //exit buttn click

            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //get a new account click

            Registration rg = new Registration();
            rg.Show();
            this.Hide();
        }
    }
}
