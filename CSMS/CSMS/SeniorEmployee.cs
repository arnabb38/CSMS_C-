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
    public partial class SeniorEmployee : Form
    {
        private string n;
        private string g;
        private string id;
        private string add;
        private string m;
        private string p;
        private string c;
        private string s;

        Random r = new Random();
        private int rand;
        private string x;

        public SeniorEmployee(string n, string g, string id, string add, string m, string p, string c, string s)
        {
            InitializeComponent();

            button14.Text = n;
            groupBox4.Text = n;
            label1.Text = n;
            label2.Text = label2.Text+id;
            label6.Text = s;

        }
        

        private void gmailButton_Click(object sender, EventArgs e)
        {
            //reffer to gmail
            System.Diagnostics.Process.Start("https://mail.google.com");
        
        }

        private void fbButton_click(object sender, EventArgs e)
        {
            //reffer to facebook
            System.Diagnostics.Process.Start("http://www.facebook.com");
        }

        private void twitterButton_click(object sender, EventArgs e)
        {
            //reffer to twitter
            System.Diagnostics.Process.Start("https://twitter.com");
        }

        private void exit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        

        private void adminInfoView_click(object sender, EventArgs e)
        {
            Console.WriteLine("heeeeyyy!!");
            groupBox4.Hide();
        }

        private void adminClcik(object sender, EventArgs e)
        {
            
            groupBox4.Show();
            //cltimgBox.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            //groupBox4.Hide();
            groupBox5.Hide();

            //clientPanel.Hide();
            vehiclePanel.Hide();
            manuPanel.Hide();
            panelInsSEmp.Hide();
        }

        /*private void employeeClcik(object sender, EventArgs e)
        {
            cltimgBox.Show();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
        }*/

        private void dealerClick(object sender, EventArgs e)
        {
            groupBox2.Show();
           //cltimgBox.Hide();
            //groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();

            //clientPanel.Hide();
            vehiclePanel.Hide();
            manuPanel.Hide();
            panelInsSEmp.Hide();
        }

        private void clientClick(object sender, EventArgs e)
        {
            groupBox3.Show();
            //cltimgBox.Hide();
            groupBox2.Hide();
            //groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();

            //clientPanel.Hide();
            vehiclePanel.Hide();
            manuPanel.Hide();
            panelInsSEmp.Hide();
        }

        private void vehicleClick(object sender, EventArgs e)
        {
            groupBox5.Show();
            //groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            //groupBox5.Hide();

            //clientPanel.Hide();
            vehiclePanel.Hide();
            manuPanel.Hide();
            panelInsSEmp.Hide();
        }

        private void adminupdateInfo(object sender, EventArgs e)
        {
            groupBox4.Hide();
        }

        private void addSEmp_click(object sender, EventArgs e)
        {
            if(label6.Text == "Employee")
            {
                statusBox.Items.Remove("Senior Employee");
                statusBox.Items.Remove("Manufacturer");
            }

            panelInsSEmp.Dock = DockStyle.Fill;
            groupBox4.Hide();
            panelInsSEmp.Show();

            manuPanel.Hide();
            vehiclePanel.Hide();
            //panelInsSEmp.Hide();
            //clientPanel.Hide();



        }

        private void dropPSE(object sender, EventArgs e)
        {
            panelInsSEmp.Hide();
        }

        private void insertBDClick(object sender, EventArgs e)
        {
            if (statusBox.Text == "Senior Employee")
            {
                if (passBox.Text == cpassBox.Text && nameBox.Text.Length != 0 && mailBox.Text.Contains("@") == true && contactBox.Text.Length != 0)
                {

                    rand = r.Next(00000, 99999);
                    IdBox.Text = "se" + rand;

                    SeniorEmployeeRep ser = new SeniorEmployeeRep();

                    ser.SeniorEmployeename = this.nameBox.Text;
                    ser.Gender = this.sexBox.Text;
                    ser.SeniorEmployeeaddress = this.addBox.Text;
                    ser.Email = this.mailBox.Text;
                    ser.Status = this.statusBox.Text;
                    ser.Contacts = this.contactBox.Text;
                    ser.Password = this.passBox.Text;
                    ser.SeniorEmployeeid = this.IdBox.Text;
                    ser.Salary = this.salaryBox.Text;

                    SeniorEmployeeRepositoryDB serdb = new SeniorEmployeeRepositoryDB();

                    if (serdb.Insert(ser))
                    {
                        MessageBox.Show("Insert Completed!", "Succeed");
                        //button7.Visible = true;
                    }

                    else
                    {
                        MessageBox.Show("Insert Not Complete", "Error");
                    }
                }

                else
                {
                    MessageBox.Show("Invalid!", "Error");
                }
            }

            
            else if (statusBox.Text == "Employee")
            {
                if (passBox.Text == cpassBox.Text && nameBox.Text.Length != 0 && mailBox.Text.Contains("@") == true && contactBox.Text.Length != 0)
                {

                    rand = r.Next(00000, 99999);
                    IdBox.Text = "emp" + rand;

                    EmployeeRep er = new EmployeeRep();

                    er.Employeename = this.nameBox.Text;
                    er.Gender = this.sexBox.Text;
                    er.Address = this.addBox.Text;
                    er.Email = this.mailBox.Text;
                    er.Status = this.statusBox.Text;
                    er.Contacts = this.contactBox.Text;
                    er.Password = this.passBox.Text;
                    er.Employeeid = this.IdBox.Text;
                    er.Salary = this.salaryBox.Text;

                    EmployeeRepositoryDB erdb = new EmployeeRepositoryDB();

                    if (erdb.Insert(er))
                    {
                        MessageBox.Show("Insert Completed!", "Succeed");
                        //button7.Visible = true;
                    }

                    else
                    {
                        MessageBox.Show("Insert Not Complete", "Error");
                    }
                }

                else
                {
                    MessageBox.Show("Invalid!", "Error");
                }
            }

            else if (statusBox.Text == "Manufacturer")
            {
                if (passBox.Text == cpassBox.Text && nameBox.Text.Length != 0 && mailBox.Text.Contains("@") == true && contactBox.Text.Length != 0)
                {

                    rand = r.Next(00000, 99999);
                    IdBox.Text = "man" + rand;

                    ManufacturerRep mr = new ManufacturerRep();

                    mr.Name = this.nameBox.Text;
                    //mr.Gender = this.sexBox.Text;
                    mr.Address = this.addBox.Text;
                    mr.Email = this.mailBox.Text;
                    mr.Status = this.statusBox.Text;
                    mr.Contacts = this.contactBox.Text;
                    //mr.Password = this.passBox.Text;
                    mr.Id = this.IdBox.Text;
                    //mr.Salary = this.salaryBox.Text;

                    ManufacturerRepositoryDB mrdb = new ManufacturerRepositoryDB();

                    if (mrdb.Insert(mr))
                    {
                        MessageBox.Show("Insert Completed!", "Succeed");
                        //button7.Visible = true;
                    }

                    else
                    {
                        MessageBox.Show("Insert Not Complete", "Error");
                    }
                }

                else
                {
                    MessageBox.Show("Invalid!", "Error");
                }
            }

        }

        private void addClientClick(object sender, EventArgs e)
        {
            

            //clientPanel.Dock = DockStyle.Fill;
            groupBox3.Hide();
            //clientPanel.Show();

            manuPanel.Hide();
            vehiclePanel.Hide();
            panelInsSEmp.Hide();
            //clientPanel.Hide();
        }

        private void clientInsert(object sender, EventArgs e)
        {
           /* if (statusBoxC.Text == "Client")
            {
                if (passBoxC.Text == cpassBoxC.Text && nameBoxC.Text.Length != 0 && mailBoxC.Text.Contains("@") == true && contactBoxC.Text.Length != 0)
                {

                    rand = r.Next(00000, 99999);
                    idBoxC.Text = "clt" + rand;

                    ClientRep cr = new ClientRep();

                    cr.Id = this.idBoxC.Text;
                    cr.Name = this.nameBoxC.Text;
                    cr.Gender = this.sexBox.Text;
                    cr.Address = this.addBoxC.Text;
                    cr.Email = this.mailBoxC.Text;
                    cr.Status = this.statusBoxC.Text;
                    Console.WriteLine(cr.Status + " " + cr.Id);
                    cr.Contacts = this.contactBoxC.Text;
                    cr.Password = this.passBox.Text;
                    cr.Occupation = this.occBox.Text;

                    ClientRepositoryDB crdb = new ClientRepositoryDB();

                    if (crdb.Insert(cr))
                    {
                        MessageBox.Show("Insert Completed!", "Succeed");
                        button32.Visible = true;
                    }

                    else
                    {
                        MessageBox.Show("Insert Not Complete", "Error");
                    }
                }

                else
                {
                    MessageBox.Show("Invalid!", "Error");
                }
            }*/
        }

        private void manuInsert(object sender, EventArgs e)
        {
            if (statusBoxM.Text == "Manufacturer")
            {
                if (this.nameBoxM.Text.Length != 0 && mailBoxM.Text.Contains("@") == true && contactBoxM.Text.Length != 0)
                {

                    rand = r.Next(00000, 99999);
                    idBoxM.Text = "man" + rand;

                    ManufacturerRep mr = new ManufacturerRep();

                    mr.Name = this.nameBoxM.Text;
                    //mr.Gender = this.sexBox.Text;
                    mr.Address = this.addBoxM.Text;
                    mr.Email = this.mailBoxM.Text;
                    mr.Status = this.statusBoxM.Text;
                    mr.Contacts = this.contactBoxM.Text;
                    //mr.Password = this.passBox.Text;
                    mr.Id = this.idBoxM.Text;
                    //mr.Salary = this.salaryBox.Text;

                    ManufacturerRepositoryDB mrdb = new ManufacturerRepositoryDB();

                    if (mrdb.Insert(mr))
                    {
                        MessageBox.Show("Insert Completed!", "Succeed");
                        //button39.Visible = true;
                    }

                    else
                    {
                        MessageBox.Show("Insert Not Complete", "Error");
                    }
                }

                else
                {
                    MessageBox.Show("Invalid!", "Error");
                }
            }
        }

        private void manClick(object sender, EventArgs e)
        {
            manuPanel.Dock = DockStyle.Fill;
            groupBox2.Hide();
            manuPanel.Show();

            vehiclePanel.Hide();
            panelInsSEmp.Hide();
            //clientPanel.Hide();
        }

        private void insertVehicle(object sender, EventArgs e)
        {
            vehiclePanel.Dock = DockStyle.Fill;
            groupBox5.Hide();
            vehiclePanel.Show();

            panelInsSEmp.Hide();
            //clientPanel.Hide();
            manuPanel.Hide();
        }

        private void vPanelInsertClick(object sender, EventArgs e)
        {
           
                /*if (costBox.Text.Length != 0 && modelBox.Text.Length != 0)
                {

                    rand = r.Next(111111, 999999);
                    carIdBox.Text = "vehicle" + rand;

                    VehicleRep vr = new VehicleRep();

                    vr.CarID = this.carIdBox.Text;
                    vr.Category = this.catBox.Text;
                    vr.ModelName = this.modelBox.Text;
                    //vr.CarClass = this.classBox.Text;
                    //vr.Fuel = this.fuelBox.Text;
                    vr.Engine = this.engineBox.Text;
                    //Console.WriteLine(cr.Status + " " + cr.Id);
                    //vr.Release = this.reBox.Text;
                    vr.Color = this.colorBox.Text;
                    vr.Cost = this.costBox.Text;
                    vr.Seat = this.seatBox.Text;

                    VehicleRepositoryDB vrdb = new VehicleRepositoryDB();

                    if (vrdb.Insert(vr))
                    {
                        MessageBox.Show("Insert Completed!", "Succeed");
                        button45.Visible = true;
                    }

                    else
                    {
                        MessageBox.Show("Insert Not Complete", "Error");
                    }
                }

                else
                {
                    MessageBox.Show("Invalid!", "Error");
                }*/
            

        }
    }
}
