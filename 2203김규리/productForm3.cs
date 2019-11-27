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
    public partial class productForm3 : Form
    {
        public string productnumber;
        public string productname;
        public string productinventory;
        public string productprice;
        public string productmanufacturer;

        public productForm3()
        {
            InitializeComponent();
        }
        mainForm1 mainForm;
        private void Form3_Load(object sender, EventArgs e)
        {
            productNumber.Text = productnumber;
            productName.Text = productname;
            productInventory.Text = productinventory;
            productPrice.Text = productprice;
            productManufacturer.Text = productmanufacturer;

            if (Owner != null)
                mainForm = Owner as mainForm1;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                productNumber.Text,
                productName.Text,
                productInventory.Text,
                productPrice.Text,
                productManufacturer.Text };
                mainForm.InsertRow_product(rowDatas);
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                productNumber.Text,
                productName.Text,
                productInventory.Text,
                productPrice.Text,
                productManufacturer.Text};
                mainForm.UpdateRow_product(rowDatas);
            this.Close();
        }

        private void btnTextBoxClear_Click(object sender, EventArgs e)
        {
            productNumber.Clear();
            productName.Clear();
            productInventory.Clear();
            productPrice.Clear();
            productManufacturer.Clear();
        }

       
    }
}
