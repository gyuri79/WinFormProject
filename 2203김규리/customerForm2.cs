using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2203김규리
{
    public partial class customerForm2 : Form
    {
        public string custid;
        public string custname;
        public string custage;
        public string custclass;
        public string custjob;
        public string custpoint;
        public customerForm2()
        {
            InitializeComponent();
        }

        mainForm1 mainForm;
        private void Form2_Load(object sender, EventArgs e)
        {
            custID.Text = custid;
            custName.Text = custname;
            custAge.Text = custage;
            custClass.Text = custclass;
            custJob2.Text = custjob;
            custPoint.Text = custpoint;

            if (Owner != null)
                mainForm = Owner as mainForm1;
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            string[] rowDatas = {
                custID.Text,
                custName.Text,
                custAge.Text,
                custClass.Text,
                custJob2.Text,
                custPoint.Text };
            mainForm.InsertRow_customer(rowDatas);
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                custID.Text,
                custName.Text,
                custAge.Text,
                custClass.Text,
                custJob2.Text,
                custPoint.Text };
            mainForm.UpdateRow_customer(rowDatas);
            this.Close();
        }

        private void btnTextBoxClear_Click(object sender, EventArgs e)
        {
            custID.Clear();
            custName.Clear();
            custAge.Clear();
            custClass.Clear();
            custJob2.Clear();
            custPoint.Clear();
        }

        
    }


}
