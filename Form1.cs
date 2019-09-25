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

        }

        private void butt_RentalInsurance_Click(object sender, EventArgs e)
        {

        }

        private void butt_AutoInsurance_Click(object sender, EventArgs e)
        {

        }

        private void butt_Apply_Click(object sender, EventArgs e)
        {
            double tmpBalance = 0;

            SqlCommand cmdRead = new SqlCommand("Select tmpBalance FROM BudgetLog " +
                "WHERE Date = " + DBNull.Value + " and Vendor = " + DBNull.Value + " and Cost = " + DBNull.Value + " and Balance = " + DBNull.Value, con);
            con.Open();
            SqlDataReader dr = cmdRead.ExecuteReader();
            if (dr.Read())
            {
                tmpBalance = Convert.ToDouble(dr["tmpBalance"].ToString());
            }
            con.Close();

            SqlCommand cmdUpdate = new SqlCommand("Update BudgetLog Set date = @date, vendor = @vendor, Cost = @cost, Balance = @Balance", con);
            con.Open();
            cmdUpdate.Parameters.Add("@date", SqlDbType.VarChar).Value = txt_Date.Text;
            cmdUpdate.Parameters.Add("@vendor", SqlDbType.VarChar).Value = splitButton_Vendor.Text;
            cmdUpdate.Parameters.Add("@cost", SqlDbType.Float).Value = Convert.ToDouble(txt_Cost.Text);
            cmdUpdate.Parameters.Add("@Balance", SqlDbType.Float).Value = (tmpBalance - Convert.ToDouble(txt_Cost.Text));
            con.Open();
            cmdUpdate.ExecuteNonQuery();
            con.Close();

            SqlCommand cmdInsert = new SqlCommand("Insert Into BudgetLog (tmpBalance) Values (@tmpBalance) " +
                "Where date = " + DBNull.Value + " and Vendor = " + DBNull.Value + " and Cost = " + DBNull.Value + " and Balance = " + DBNull.Value, con);
            cmdInsert.Parameters.Add("@tmpBalance", SqlDbType.Float).Value = (tmpBalance - Convert.ToDouble(txt_Cost.Text));
            con.Open();
            cmdInsert.ExecuteNonQuery();
            con.Close();

            /*
            SqlCommand cmd = new SqlCommand("Insert Into BudgetLog (Date, Vendor, Cost) Values (@date, @vendor, @Cost)", con);
            cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = txt_Date.Text;
            cmd.Parameters.Add("@vendor", SqlDbType.VarChar).Value = splitButton_Vendor.Text;
            cmd.Parameters.Add("@Cost", SqlDbType.VarChar).Value = Convert.ToDouble(txt_Cost.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            */
            this.budgetLogTableAdapter.Fill(this.budgetAutomateDataSet.BudgetLog);
        }

        private void ExitApp (object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
