using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BudgeLogMain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += ExitApp;

        }
        const string source = "Data Source=DESKTOP-AC927C3;Initial Catalog=BudgetAutomate;Integrated Security=True";
        SqlConnection con = new SqlConnection(source);
        Syncfusion.Windows.Forms.Tools.toolstripitem toolstripitem_VendorName;
        //DateTime Date = DateTime.Now;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.budgetLogTableAdapter.Fill(this.budgetAutomateDataSet.BudgetLog);
            txt_Date.Text = monthCalendar1.TodayDate.ToString("MM/dd/yyyy");
            Fill_Vendor_Toolstrip();
            this.Grid_BudgetLog.EnableAutoSize = true;
            //Disable the default empty row
            this.Grid_BudgetLog.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.Grid_BudgetLog.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = false;
        }

        private void Fill_Vendor_Toolstrip()
        {
            SqlCommand cmd = new SqlCommand("Select * From VendorTable", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                toolstripitem_VendorName = new Syncfusion.Windows.Forms.Tools.toolstripitem();
                toolstripitem_VendorName.Name = "Vendor";
                toolstripitem_VendorName.Size = new System.Drawing.Size(23, 23);
                toolstripitem_VendorName.Text = dr["Vendor"].ToString();
                splitButton_Vendor.DropDownItems.Add(toolstripitem_VendorName);
            }
            con.Close();
        }

        private void splitButton_Vendor_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            splitButton_Vendor.Text = e.ClickedItem.Text;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txt_Date.Text = e.Start.ToString("MM/dd/yyyy");
        }

        private void butt_Rent_Click(object sender, EventArgs e)
        {
            SqlCommand cmdInsert = new SqlCommand("Insert Into BudgetLog (Date, Vendor, Cost, Balance) Values (@date, @vendor, @cost, @balance)", con);
            cmdInsert.Parameters.Add("@date", SqlDbType.VarChar).Value = txt_Date.Text;
            cmdInsert.Parameters.Add("@vendor", SqlDbType.VarChar).Value = lbl_Rent.Text;
            cmdInsert.Parameters.Add("@cost", SqlDbType.VarChar).Value = "-" + Convert.ToDouble(txt_rent.Text);
            cmdInsert.Parameters.Add("@balance", SqlDbType.VarChar).Value = ReadCurrentBalance() - Convert.ToDouble(txt_rent.Text);
            con.Open();
            cmdInsert.ExecuteNonQuery();
            con.Close();        
            UpdateCurrentBudget(Convert.ToDouble(txt_rent.Text));
            this.budgetLogTableAdapter.Fill(this.budgetAutomateDataSet.BudgetLog);
        }

        private void butt_RentalInsurance_Click(object sender, EventArgs e)
        {
            SqlCommand cmdInsert = new SqlCommand("Insert Into BudgetLog (Date, Vendor, Cost, Balance) Values (@date, @vendor, @cost, @balance)", con);
            cmdInsert.Parameters.Add("@date", SqlDbType.VarChar).Value = txt_Date.Text;
            cmdInsert.Parameters.Add("@vendor", SqlDbType.VarChar).Value = lbl_RentalInsurance.Text;
            cmdInsert.Parameters.Add("@cost", SqlDbType.VarChar).Value = "-" + Convert.ToDouble(txt_RentalInsurance.Text);
            cmdInsert.Parameters.Add("@balance", SqlDbType.VarChar).Value = ReadCurrentBalance() - Convert.ToDouble(txt_RentalInsurance.Text);
            con.Open();
            cmdInsert.ExecuteNonQuery();
            con.Close();
            UpdateCurrentBudget(Convert.ToDouble(txt_RentalInsurance.Text));
            this.budgetLogTableAdapter.Fill(this.budgetAutomateDataSet.BudgetLog);
        }

        private void butt_AutoInsurance_Click(object sender, EventArgs e)
        {
            SqlCommand cmdInsert = new SqlCommand("Insert Into BudgetLog (Date, Vendor, Cost, Balance) Values (@date, @vendor, @cost, @balance)", con);
            cmdInsert.Parameters.Add("@date", SqlDbType.VarChar).Value = txt_Date.Text;
            cmdInsert.Parameters.Add("@vendor", SqlDbType.VarChar).Value = lbl_AutoInsurance.Text;
            cmdInsert.Parameters.Add("@cost", SqlDbType.VarChar).Value = "-" + Convert.ToDouble(txt_AutoInsurance.Text);
            cmdInsert.Parameters.Add("@balance", SqlDbType.VarChar).Value = ReadCurrentBalance() - Convert.ToDouble(txt_AutoInsurance.Text);
            con.Open();
            cmdInsert.ExecuteNonQuery();
            con.Close();
            UpdateCurrentBudget(Convert.ToDouble(txt_AutoInsurance.Text));
            this.budgetLogTableAdapter.Fill(this.budgetAutomateDataSet.BudgetLog);
        }

        private void butt_Apply_Click(object sender, EventArgs e)
        {
            if (splitButton_Vendor.Text == "(Select)")
            {
                MessageBox.Show("Please Select a Vendor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (splitButton_Vendor.Text == "Beyondsoft")
            {
                double pay = 13.25;
                SqlCommand cmdInsert = new SqlCommand("Insert Into BudgetLog (Date, Vendor, Cost, Balance) Values (@date, @vendor, @cost, @balance)", con);
                cmdInsert.Parameters.Add("@date", SqlDbType.VarChar).Value = txt_Date.Text;
                cmdInsert.Parameters.Add("@vendor", SqlDbType.VarChar).Value = splitButton_Vendor.Text;
                cmdInsert.Parameters.Add("@cost", SqlDbType.VarChar).Value = "+" + (Convert.ToDouble(txt_Cost.Text)*pay);
                cmdInsert.Parameters.Add("@balance", SqlDbType.VarChar).Value = ReadCurrentBalance() + (Convert.ToDouble(txt_Cost.Text) * pay);
                con.Open();
                cmdInsert.ExecuteNonQuery();
                con.Close();

                SqlCommand cmdUpdate = new SqlCommand("Update CurrentBudget Set CurrentBalance = @currentbalance", con);
                cmdUpdate.Parameters.Add("@currentbalance", SqlDbType.Float).Value = ReadCurrentBalance() + (Convert.ToDouble(txt_Cost.Text) * pay);
                con.Open();
                cmdUpdate.ExecuteNonQuery();
                con.Close();

                this.budgetLogTableAdapter.Fill(this.budgetAutomateDataSet.BudgetLog);
            }
            else
            {               
                SqlCommand cmdInsert = new SqlCommand("Insert Into BudgetLog (Date, Vendor, Cost, Balance) Values (@date, @vendor, @cost, @balance)", con);
                cmdInsert.Parameters.Add("@date", SqlDbType.VarChar).Value = txt_Date.Text;
                cmdInsert.Parameters.Add("@vendor", SqlDbType.VarChar).Value = splitButton_Vendor.Text;
                cmdInsert.Parameters.Add("@cost", SqlDbType.VarChar).Value = "-" + Convert.ToDouble(txt_Cost.Text);
                cmdInsert.Parameters.Add("@balance", SqlDbType.VarChar).Value = ReadCurrentBalance() - Convert.ToDouble(txt_Cost.Text);
                con.Open();
                cmdInsert.ExecuteNonQuery();
                con.Close();

                UpdateCurrentBudget(Convert.ToDouble(txt_Cost.Text));
                this.budgetLogTableAdapter.Fill(this.budgetAutomateDataSet.BudgetLog);
            }
        }
        private double ReadCurrentBalance()
        {
            double tmpCurrentBalance = 0;

            SqlCommand cmdRead = new SqlCommand("Select CurrentBalance FROM CurrentBudget", con);
            con.Open();
            SqlDataReader dr = cmdRead.ExecuteReader();
            if (dr.Read())
            {
                tmpCurrentBalance = Convert.ToDouble(dr["CurrentBalance"].ToString());
                con.Close();
                return tmpCurrentBalance;             
            }
            return 0;        
        }
        
        private void UpdateCurrentBudget(double Cost)
        {
            SqlCommand cmdUpdate = new SqlCommand("Update CurrentBudget Set CurrentBalance = @currentbalance", con);
            cmdUpdate.Parameters.Add("@currentbalance", SqlDbType.Float).Value = ReadCurrentBalance() - Cost;
            con.Open();
            cmdUpdate.ExecuteNonQuery();
            con.Close();
        }

        private void ExitApp (object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
