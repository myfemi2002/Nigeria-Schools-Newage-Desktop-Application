using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace NigeriaSchoolsNewage
{
    public partial class Form1 : Form
    {
        Customer model = new Customer();
        public Form1()
        {
            InitializeComponent();
        }

       private void LoadData()
        {
            dataGridView.AutoGenerateColumns = false;
            using (NewageEntities db = new NewageEntities())
            {
                dataGridView.DataSource = db.Customers.ToList<Customer>();
            }
        }
        private void BtnSaVE_Click(object sender, EventArgs e)
        {
            model.Name = TxtName.Text.Trim();
            model.Address = TxtAddress.Text.Trim();
            model.Phone  = TxtPhone.Text.Trim();
            model.Email  = TxtEmail.Text.Trim();
            model.Website  = TxtWebsite.Text.Trim();
            model.geo_zone_ID = Txtgeo_zone_ID.Text.Trim();
            model.state_ID  = TxtStateID.Text.Trim();
            model. lga_ID = TxtLgaID.Text.Trim();
            model. year_established = TxtYearEstablished.Text.Trim();
            model. school_ownership_ID = TxtSchool_Ownership.Text.Trim();
            model.school_type_ID  = TxtSchool_Type_ID.Text.Trim();
            model. school_subtype_ID = TxtSchool_Subtype_ID.Text.Trim();

            using (NewageEntities  db = new NewageEntities ())
            {
                if (model.ID == 0) //insert
                    db.Customers.Add(model);
                else
                    db.Entry(model).State = EntityState.Modified;
                        //EntityState.Modified;
                db.SaveChanges();

            }
            LoadData();
            Clear();
            MessageBox.Show("Submitted Successfully");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            this.ActiveControl = TxtName;
            LoadData();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            //= Txtgeo_zone_ID.Text
            // = TxtStateID.Text
            //= TxtLgaID.Text
            //= TxtSchool_Ownership.Text 
            //= TxtSchool_Type_ID.Text = TxtSchool_Subtype_ID.Text 

            TxtName.Text = TxtAddress.Text = TxtPhone.Text = TxtEmail.Text = TxtWebsite.Text = TxtYearEstablished.Text = "";
            BtnSave.Text = "Save";
            BtnDelete.Enabled = false;
            model.ID = 0;
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(dataGridView.CurrentRow.Cells["dgID"].Value);
                using (NewageEntities db = new NewageEntities())
                {
                    model = db.Customers.Where(x => x.ID == model.ID).FirstOrDefault();

                    TxtName.Text = model.Name;
                    TxtAddress.Text = model.Address;
                    TxtPhone.Text = model.Phone;
                    TxtEmail.Text = model.Email;
                    TxtWebsite.Text = model.Website;
                    Txtgeo_zone_ID.Text = model.geo_zone_ID;
                    TxtStateID.Text = model.state_ID;
                    TxtLgaID.Text = model.lga_ID;
                    TxtYearEstablished.Text = model.year_established;
                    TxtSchool_Ownership.Text = model.school_ownership_ID;
                    TxtSchool_Type_ID.Text = model.school_type_ID;
                    TxtSchool_Subtype_ID.Text = model.school_subtype_ID;

                }
                BtnSave.Text = "Update";
                BtnDelete.Enabled = true;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete This Record", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (NewageEntities db = new NewageEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Customers.Attach(model);
                        db.Customers.Remove(model);
                        db.SaveChanges();
                        LoadData();
                        Clear();
                        MessageBox.Show("Deleted Successfully");
                    }
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
           this.Close();

        }

        private void TxtSchool_Subtype_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void TxtSchool_Type_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void TxtSchool_Ownership_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void TxtYearEstablished_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void TxtLgaID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TxtStateID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Txtgeo_zone_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TxtWebsite_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
