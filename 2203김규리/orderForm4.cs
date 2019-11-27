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
    public partial class orderForm4 : Form
    {
        public string ordernumber;
        public string ordercust;
        public string orderproductNum;
        public string ordernum;
        public string orderhouse;
        public string orderdate;

        public orderForm4()
        {
            InitializeComponent();
        }
        mainForm1 mainForm;
        private void Form4_Load(object sender, EventArgs e)
        {
            orderNumber.Text = ordernumber;
            orderCust.Text = ordercust;
            orderProductNum.Text = orderproductNum;
            orderNum.Text = ordernum;
            orderHouse.Text = orderhouse;
            orderDate.Text = orderdate;

            if (Owner != null)
                mainForm = Owner as mainForm1;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
               orderNumber.Text,
                orderCust.Text,
                orderProductNum.Text,
                orderNum.Text,
                orderHouse.Text,
                orderDate.Text};
            mainForm.InsertRow_order(rowDatas);
            this.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                orderNumber.Text,
                orderCust.Text,
                orderProductNum.Text,
                orderNum.Text,
                orderHouse.Text,
                orderDate.Text};
            mainForm.UpdateRow_order(rowDatas);
            this.Close();
        }
        private void btnTextBoxClear_Click(object sender, EventArgs e)
        {
            orderNumber.Clear();
            orderCust.Clear();
            orderProductNum.Clear();
            orderNum.Clear();
            orderHouse.Clear();
            orderDate.Clear();
        }


    }
}
