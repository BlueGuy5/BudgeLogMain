using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BudgeLogMain
{
    public partial class Office2010Form1 : Syncfusion.Windows.Forms.Office2010Form
    {
        public Office2010Form1()
        {           
            InitializeComponent();
            this.Grid_BudgetLog.TableControlCellClick += new GridTableControlCellClickEventHandler(this.GridGroupingControlClick);
            this.FormClosed += ExitApp;
        }

        const string source = "Data Source=Desktop-60BSQ2I;Initial Catalog=BudgetAutomate;Integrated Security=True";
        SqlConnection con = new SqlConnection(source);
        Syncfusion.Windows.Forms.Tools.toolstripitem toolstripitem_VendorName;
        System.Windows.Forms.ListView DropDownitem_VendorName;

        //DateTime Date = DateTime.Now;

        private void Office2010Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'budgetAutomateDataSet1_tbl_reminders.tbl_Reminders' table. You can move, or remove it, as needed.
            this.tbl_RemindersTableAdapter.Fill(this.budgetAutomateDataSet1_tbl_reminders.tbl_Reminders);
            this.budgetLogTableAdapter.Fill(this.budgetAutomateDataSet.BudgetLog);
            txt_Date.Text = monthCalendar1.TodayDate.ToString("MM/dd/yyyy");
            Fill_Vendor_Toolstrip();
            this.Grid_BudgetLog.EnableAutoSize = true;
            //Disable the default empty row
            this.Grid_BudgetLog.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.Grid_BudgetLog.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = false;
            this.Grid_Reminders.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.Grid_Reminders.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = false;

            Load_LogEntries();
        }

        private void Load_LogEntries()
        {
            SqlCommand readlog = new SqlCommand("Select strDate, Vendor, strDescription FROM Log_Entries", con);
            con.Open();
            SqlDataReader dr = readlog.ExecuteReader();
            while (dr.Read())
            {
                txt_Log_Entries.AppendText("Date:" + dr["strDate"].ToString() + "\t" + "Vendor:" + dr["Vendor"].ToString() + "\r\n" + "Description:" + dr["strDescription"].ToString() + "\r\n" + "\r\n");
            }
            con.Close();
        }

        private void Fill_Vendor_Toolstrip()
        {
            SqlCommand cmd = new SqlCommand("Select * From VendorTable", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
         
            DropDownitem_VendorName = new System.Windows.Forms.ListView();
            this.DropDown_Vendor.PopupControl = DropDownitem_VendorName;
            DropDownitem_VendorName.View = View.Details;
            DropDownitem_VendorName.Sort();
            DropDownitem_VendorName.Scrollable = true;
            DropDownitem_VendorName.Columns.Add("Vendor", 300);
            this.DropDownitem_VendorName.Click += new System.EventHandler(this.DropDownitem_VendorName_Click);         

            while (dr.Read())
            {
                
                toolstripitem_VendorName = new Syncfusion.Windows.Forms.Tools.toolstripitem();
                toolstripitem_VendorName.Name = "Vendor";
                toolstripitem_VendorName.Size = new System.Drawing.Size(23, 23);
                toolstripitem_VendorName.Text = dr["Vendor"].ToString();
                splitButton_Vendor.DropDownItems.Add(toolstripitem_VendorName);
                
                
                DropDownitem_VendorName.Items.Add(dr["Vendor"].ToString());
            }
            con.Close();
        }

        private void splitButton_Vendor_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            splitButton_Vendor.Text = e.ClickedItem.Text;
            txt_Descript.Text = string.Empty;
        }

        private void DropDownitem_VendorName_Click(object sender, EventArgs e)
        {
                DropDown_Vendor.Text = DropDownitem_VendorName.SelectedItems[0].SubItems[0].Text;
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

        private void butt_Internet_Click(object sender, EventArgs e)
        {
            SqlCommand cmdInsert = new SqlCommand("Insert Into BudgetLog (Date, Vendor, Cost, Balance) Values (@date, @vendor, @cost, @balance)", con);
            cmdInsert.Parameters.Add("@date", SqlDbType.VarChar).Value = txt_Date.Text;
            cmdInsert.Parameters.Add("@vendor", SqlDbType.VarChar).Value = lbl_Internet.Text;
            cmdInsert.Parameters.Add("@cost", SqlDbType.VarChar).Value = "-" + Convert.ToDouble(txt_internet.Text);
            cmdInsert.Parameters.Add("@balance", SqlDbType.VarChar).Value = ReadCurrentBalance() - Convert.ToDouble(txt_internet.Text);
            con.Open();
            cmdInsert.ExecuteNonQuery();
            con.Close();
            UpdateCurrentBudget(Convert.ToDouble(txt_internet.Text));
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
                double pay = 14.75;
                SqlCommand cmdInsert = new SqlCommand("Insert Into BudgetLog (Date, Vendor, Cost, Balance) Values (@date, @vendor, @cost, @balance)", con);
                cmdInsert.Parameters.Add("@date", SqlDbType.VarChar).Value = txt_Date.Text;
                cmdInsert.Parameters.Add("@vendor", SqlDbType.VarChar).Value = splitButton_Vendor.Text;
                cmdInsert.Parameters.Add("@cost", SqlDbType.VarChar).Value = "+" + (Convert.ToDouble(txt_Cost.Text) * pay);
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
                SqlCommand cmdInsert = new SqlCommand("Insert Into BudgetLog (Date, Vendor, Cost, Balance, Descript) Values (@date, @vendor, @cost, @balance, @Descript)", con);
                cmdInsert.Parameters.Add("@date", SqlDbType.VarChar).Value = txt_Date.Text;
                cmdInsert.Parameters.Add("@vendor", SqlDbType.VarChar).Value = splitButton_Vendor.Text;
                cmdInsert.Parameters.Add("@cost", SqlDbType.VarChar).Value = "-" + Convert.ToDouble(txt_Cost.Text);
                cmdInsert.Parameters.Add("@balance", SqlDbType.VarChar).Value = ReadCurrentBalance() - Convert.ToDouble(txt_Cost.Text);
                cmdInsert.Parameters.Add("@Descript", SqlDbType.VarChar).Value = txt_Descript.Text;
                con.Open();
                cmdInsert.ExecuteNonQuery();
                con.Close();

                UpdateCurrentBudget(Convert.ToDouble(txt_Cost.Text));
                this.budgetLogTableAdapter.Fill(this.budgetAutomateDataSet.BudgetLog);
            }
        }
        private void butt_Save_Click(object sender, EventArgs e)
        {
            SqlCommand insertEntries = new SqlCommand("Insert INTO Log_Entries (strDate,Vendor,strDescription) Values (@strDate,@Vendor,@strDescription)",con);
            con.Open();
            insertEntries.Parameters.Add("@strDate", SqlDbType.VarChar).Value = DTcalendar.Value;
            insertEntries.Parameters.Add("@vendor",SqlDbType.VarChar).Value = DropDown_Vendor.Text;
            insertEntries.Parameters.Add("@strDescription", SqlDbType.VarChar).Value = txt_Description.Text;
            insertEntries.ExecuteNonQuery();
            con.Close();
            txt_Description.Text = "";
            txt_Log_Entries.Text = "";
            Load_LogEntries(); //Reload txt_log_Entries.text
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
        private string GetSelectedID(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellClickEventArgs e)
        {
            GridTableCellStyleInfo style = (GridTableCellStyleInfo)e.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex);
            Record currentRecord = style.TableCellIdentity.DisplayElement.GetRecord();

            var getrecord = new List<int>();
            var GetRecords = Grid_BudgetLog.Table.Records;

            foreach (Record i in GetRecords)
            {
                getrecord.Add(i.Id);
            }

            var QueryID = new Dictionary<int, string>();
            int tbl_cnt = 0;

            SqlCommand readID = new SqlCommand("Select ID From BudgetLog", con);
            con.Open();
            SqlDataReader drID = readID.ExecuteReader();
            while (drID.Read())
            {
                QueryID.Add(getrecord[tbl_cnt], drID["ID"].ToString());
                tbl_cnt++;
            }
            con.Close();

            foreach (KeyValuePair<int, string> kvp in QueryID)
            {
                if (kvp.Key == currentRecord.Id)
                {
                    return kvp.Value;
                }
            }
            return "0";
        }

        private void GridGroupingControlClick(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellClickEventArgs e)
        {
            string GetID = GetSelectedID(sender, e);
         
            SqlCommand readBudgetTable = new SqlCommand("Select Date,Vendor,Cost,Descript From BudgetLog Where ID = " + GetID, con);
            con.Open();
            SqlDataReader dr = readBudgetTable.ExecuteReader();
            if (dr.Read())
            {
                txt_Date.Text = dr["Date"].ToString();
                splitButton_Vendor.Text = dr["Vendor"].ToString();
                txt_Cost.Text = dr["Cost"].ToString();
                txt_Descript.Text = dr["Descript"].ToString();
            }
            con.Close();
            
        }
        private void ExitApp(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
