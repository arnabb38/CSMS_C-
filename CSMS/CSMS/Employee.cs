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
    public partial class Employee : Form
    {
        Random r = new Random();
        int rand, randPass;
        string i;

        public Employee(string n, string g, string id, string add, string m, string p, string c, string s)
        {
            InitializeComponent();

            label1.Text = n;
            label2.Text = label2.Text + id;
            label6.Text = s;

            i = id;
        }

        private void InsertSalesInfo(object sender, EventArgs e)
        {
            rand = r.Next(111111, 999999);
            salesIDBox.Text = "sales"+rand;

            SalesRep sr = new SalesRep();

            sr.SalesID = this.salesIDBox.Text;
            sr.CustName = this.custnameBox.Text;
            sr.CustAddress = this.custadbox.Text;
            sr.CustContacts = this.custcontactBox.Text;
            sr.CustMail = this.custmailBox.Text;
            sr.VecModel = this.modelBox.Text;
            sr.VecNetCost = this.costBox.Text;
            sr.Payment = this.combopaymentBox.Text;
            sr.Date = this.dateTimePicker2.Text;
            sr.SalesInvoice = i;

            Console.WriteLine(i);

            SalesRepositoryDB srdb = new SalesRepositoryDB();

            if (srdb.Insert(sr))
            {
                MessageBox.Show("Insert Completed!", "Succeed");
            }

            else
            {
                MessageBox.Show("Insert Not Complete", "Error");
            }

        }

        private void salesInvoiceClick(object sender, EventArgs e)
        {
            salesPanel.Dock = DockStyle.Fill;
            salesPanel.Show();

            viewClientPanel.Hide();
            vehiclePanel.Hide();
            clientPanel.Hide();
            panelTrans.Hide();

        }

        private void vehicleClick(object sender, EventArgs e)
        {
            groupBox5.Show();
            groupBox3.Hide();

            viewClientPanel.Hide();
            vehiclePanel.Hide();
            salesPanel.Hide();
            panelTrans.Hide();
            clientPanel.Hide();
        }

        private void updateVecClick(object sender, EventArgs e)
        {
            groupBox5.Hide();

            vehiclePanel.Dock = DockStyle.Fill;
            vehiclePanel.Show();

            //dateTimePicker1 = (DateTime.Now).ToString();
            dateTimePicker1.Text = (DateTime.Now.ToString("dd/MM/yyyy"));

            clientPanel.Hide();
            salesPanel.Hide();
            panelTrans.Hide();
        }

        private void clientClick(object sender, EventArgs e)
        {
            groupBox3.Show();
            groupBox5.Hide();

            vehiclePanel.Hide();
            salesPanel.Hide();
            panelTrans.Hide();
            clientPanel.Hide();
            viewClientPanel.Hide();
        }

        private void insertclientClick(object sender, EventArgs e)
        {
            // client inser button

            groupBox5.Hide();

            clientPanel.Dock = DockStyle.Fill;
            clientPanel.Show();

            datetextBox4.Text = (DateTime.Now.ToString("dd/MM/yyyy"));

            vehiclePanel.Hide();
            salesPanel.Hide();
            panelTrans.Hide();
        }

        private void transClick(object sender, EventArgs e)
        {
            groupBox5.Hide();
            groupBox3.Hide();

            empIdBoxC.Text = i;

            SalesRepositoryDB cltdb = new SalesRepositoryDB();
            List<SalesRep> clientList = cltdb.GetAllSalesByEmp(i);
            this.dataGridView2.DataSource = clientList;


            panelTrans.Show();
            panelTrans.Dock = DockStyle.Fill;
            viewClientPanel.Hide(); 
            clientPanel.Hide();
            vehiclePanel.Hide();
            salesPanel.Hide();


            //string x = DateTime.Now;
            


        }

        private void inseertVecclick(object sender, EventArgs e)
        {
            if (costBox.Text.Length != 0 && modelBox.Text.Length != 0)
            {

                rand = r.Next(111111, 999999);
                carIdBox.Text = "vehicle" + rand;

                VehicleRep vr = new VehicleRep();

                vr.CarID = this.carIdBox.Text;
                vr.Category = this.catBox.Text;
                vr.ModelName = this.modelBox.Text;
                vr.Date = this.dateTimePicker1.Text;
                //vr.CarClass = this.modelBox.Text;
                //vr.Fuel = this.engineBox.Text;
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
                    //button45.Visible = true;
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

        private void salescancelClick(object sender, EventArgs e)
        {
            salesPanel.Hide();
        }

        private void vecinsCancelClick(object sender, EventArgs e)
        {
            vehiclePanel.Hide();
        }

        private void clientcanelClick(object sender, EventArgs e)
        {
            clientPanel.Hide();
        }

        private void clientInsertClick(object sender, EventArgs e)
        {
                if (nameBoxC.Text.Length != 0 && mailBoxC.Text.Contains("@") == true && contactBoxC.Text.Length != 0)
                {

                    rand = r.Next(00000, 99999);
                    idBoxC.Text = "clt" + rand;
                    empIdBoxC.Text = i;
                    passBoxC.Text = (r.Next(123456, 999999)).ToString();
                    
                    ClientRep cr = new ClientRep();

                    cr.Id = this.idBoxC.Text;
                    cr.Name = this.nameBoxC.Text;
                    cr.Gender = this.sexBoxC.Text;
                    cr.Address = this.addBoxC.Text;
                    cr.Email = this.mailBoxC.Text;
                    cr.AddedBy = this.empIdBoxC.Text;
                    //Console.WriteLine(cr.Status + " " + cr.Id);
                    cr.Contacts = this.contactBoxC.Text;
                    cr.Password = this.passBoxC.Text;
                    cr.Occupation = this.occBox.Text;

                    ClientRepositoryDB crdb = new ClientRepositoryDB();

                    if (crdb.Insert(cr))
                    {
                        MessageBox.Show("Insert Completed!", "Succeed");
                        //button32.Visible = true;
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

        private void logoutemp(object sender, EventArgs e)
        {

            //logout button

            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //net cost clculation part
       

        private void generateNetCostClick(object sender, EventArgs e)
        {

            double sc, v, d, nc;
            
            if (textBox11.Text.Length != 0 && textBox6.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                //if (textBox2.Text == "")
                //{
                //    textBox2.Text = "0";
                //}

                //if (textBox6.Text == "")
                //{
                //    textBox6.Text = "0";
                //}
                    
                
                sc = Convert.ToDouble(textBox11.Text);
                v = Convert.ToDouble(textBox6.Text);
                d = Convert.ToDouble(textBox2.Text);



                // nc = (double.Parse(sc) + ((double.Parse(sc)*double.Parse(v)) / 100) - ((double.Parse(sc) * double.Parse(d)) / 100)).ToString();
                nc = sc + ((sc * v) / 100) - ((sc * d) / 100);
                saleCostBox.Text = nc.ToString();
                
            }

            else
            {
                MessageBox.Show("Error Occured!", "Error!");
            }
            
            
        }

        private void salesPaymentPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
            {

            }

            else
            {
                //e.Handled = e.KeyChar != (char)Keys.Back;
                MessageBox.Show("Takes Only Numaric Value!", "Warning", MessageBoxButtons.OK);
            }
        }

        private void loadClick(object sender, EventArgs e)
        {
            //SalesRepositoryDB cltdb = new SalesRepositoryDB();
            // List<SalesRep> clientList = cltdb.GetAllSales();
            //this.dataGridView1.DataSource = clientList;

            ClientRepositoryDB cltdb = new ClientRepositoryDB();
            List<ClientRep> cltrp = cltdb.GetAllClient();
            this.dataGridView1.DataSource = cltrp;
        }

        private void viewClient(object sender, EventArgs e)
        {
            groupBox3.Hide();

            ClientRepositoryDB cltdb = new ClientRepositoryDB();
            List<ClientRep> cltrp = cltdb.GetAllClient();
            this.dataGridView1.DataSource = cltrp;

            viewClientPanel.Dock = DockStyle.Fill;
            viewClientPanel.Show();

            panelTrans.Hide();
            clientPanel.Hide();
            vehiclePanel.Hide();
            salesPanel.Hide();


        }

        private void searchClient(object sender, EventArgs e)
        {
            string text = clientSearchBox.Text;

            ClientRepositoryDB cltdb = new ClientRepositoryDB();
            List<ClientRep> cltrp = cltdb.SearchClient(text);
            this.dataGridView1.DataSource = cltrp;

        }

        private void vecView(object sender, EventArgs e)
        {
            groupBox5.Hide();

            dateTimePicker3.Text = DateTime.Now.ToString("dd/MM/yyyy");
            VehicleRepositoryDB cltdb = new VehicleRepositoryDB();
            List<VehicleRep> cltrp = cltdb.GetAllVehicle();
            this.dataGridView3.DataSource = cltrp;

            vehicleShow.Dock = DockStyle.Fill;
            vehicleShow.Show();

            viewClientPanel.Hide();
            clientPanel.Hide();
            salesPanel.Hide();
            panelTrans.Hide();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            VehicleRepositoryDB cltdb = new VehicleRepositoryDB();
            List<VehicleRep> cltrp = cltdb.GetAllVehicle();
            this.dataGridView3.DataSource = cltrp;
        }

        

        //private void button34_Click(object sender, EventArgs e)
        //{
        //    //insert client into database

        //    passBoxC.Text = 

        //}

        private void button23_Click(object sender, EventArgs e)
        {
            //search button


        }

        //private void button20_Click(object sender, EventArgs e)
        //{

        //}
    }
}
