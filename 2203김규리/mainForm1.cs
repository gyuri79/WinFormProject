using MySql.Data.MySqlClient;
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
    public partial class mainForm1 : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;
        public mainForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;database=gsm;uid=root;pwd=kkgyrm";
            conn = new MySqlConnection(connStr);
            dataAdapter = new MySqlDataAdapter("SELECT * FROM 제품", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "제품");
            dataGridView1.DataSource = dataSet.Tables["제품"];

            SetSearchComboBox();
        }

        #region ComboBox 세팅
        // **** 검색 조건 ComboBox에 CountryCode 목록 세팅 ****
        private void SetSearchComboBox()
        {
            string sql = "SELECT distinct 등급 FROM 고객";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                // Class 목록 표시
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    CBClass.Items.Add(reader.GetString("등급"));
                }
                reader.Close();

                // Product 목록 표시
                sql = "SELECT distinct 제조업체 FROM 제품";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    CBProduct.Items.Add(reader.GetString("제조업체"));
                }
                reader.Close();

                sql = "SELECT distinct 제품명 FROM 제품";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    CBProductName.Items.Add(reader.GetString("제품명"));
                }
                reader.Close();

                sql = "SELECT distinct 제품번호 FROM 제품";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    CBProductNumber.Items.Add(reader.GetString("제품번호"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion              

        #region tables 선택
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataAdapter = new MySqlDataAdapter("SELECT * FROM 고객", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "고객");
            dataGridView1.DataSource = dataSet.Tables["고객"];

            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataAdapter = new MySqlDataAdapter("SELECT * FROM 제품", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "제품");
            dataGridView1.DataSource = dataSet.Tables["제품"];

            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataAdapter = new MySqlDataAdapter("SELECT * FROM 주문", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "주문");
            dataGridView1.DataSource = dataSet.Tables["주문"];

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
        }

        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            TBID.Clear();
            TBID2.Clear();
            TBName.Clear();
            CBClass.Text = "";
            CBProduct.Text = "";
            CBProductNumber.Text = "";
            CBProductName.Text = "";
        }

        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                customerForm2 Dig = new customerForm2();
                Dig.Owner = this;       // 새로운 폼의 부모가 Form1인스턴스임을 지정
                Dig.ShowDialog();       // 폼 띄우기(Modal)
                Dig.Dispose();
            }
            else if (radioButton2.Checked)
            {
                productForm3 Dig = new productForm3();
                Dig.Owner = this;       // 새로운 폼의 부모가 Form1인스턴스임을 지정
                Dig.ShowDialog();       // 폼 띄우기(Modal)
                Dig.Dispose();

            }
            else if (radioButton3.Checked)
            {
                orderForm4 Dig = new orderForm4();
                Dig.Owner = this;       // 새로운 폼의 부모가 Form1인스턴스임을 지정
                Dig.ShowDialog();       // 폼 띄우기(Modal)
                Dig.Dispose();

            }
        }

        /*고객*/
        public void InsertRow_customer(string[] rowDatas)
        {
            string queryStr = "INSERT INTO 고객 (고객아이디, 고객이름, 나이, 등급, 직업, 적립금)" +
                "VALUES(@고객아이디, @고객이름, @나이, @등급, @직업, @적립금)";
            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.Add("@고객아이디", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@고객이름", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@나이", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@등급", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@직업", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@적립금", MySqlDbType.Int32);

            #region Parameter를 이용한 처리
            dataAdapter.InsertCommand.Parameters["@고객아이디"].Value = rowDatas[0];
            dataAdapter.InsertCommand.Parameters["@고객이름"].Value = rowDatas[1];
            dataAdapter.InsertCommand.Parameters["@나이"].Value = rowDatas[2];
            dataAdapter.InsertCommand.Parameters["@등급"].Value = rowDatas[3];
            dataAdapter.InsertCommand.Parameters["@직업"].Value = rowDatas[4];
            dataAdapter.InsertCommand.Parameters["@적립금"].Value = rowDatas[5];

            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "고객");
                dataGridView1.DataSource = dataSet.Tables["고객"];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            #endregion
        }

        public void UpdateRow_customer(string[] rowDates)
        {
            string sql = "UPDATE 고객 SET 고객이름=@고객이름, " +
                "나이=@나이, 등급=@등급, 직업=@직업, 적립금=@적립금 WHERE 고객아이디=@고객아이디";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@고객아이디", rowDates[0]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@고객이름", rowDates[1]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@나이", rowDates[2]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@등급", rowDates[3]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@직업", rowDates[4]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@적립금", rowDates[5]);

            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "고객");
                dataGridView1.DataSource = dataSet.Tables["고객"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /*제품*/
        public void InsertRow_product(string[] rowDatas)
        {
            string queryStr = "INSERT INTO 제품 (제품번호, 제품명, 재고량, 단가, 제조업체)" +
                "VALUES(@제품번호, @제품명, @재고량, @단가, @제조업체)";
            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.Add("@제품번호", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@제품명", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@재고량", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@단가", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@제조업체", MySqlDbType.VarChar);

            #region Parameter를 이용한 처리
            dataAdapter.InsertCommand.Parameters["@제품번호"].Value = rowDatas[0];
            dataAdapter.InsertCommand.Parameters["@제품명"].Value = rowDatas[1];
            dataAdapter.InsertCommand.Parameters["@재고량"].Value = rowDatas[2];
            dataAdapter.InsertCommand.Parameters["@단가"].Value = rowDatas[3];
            dataAdapter.InsertCommand.Parameters["@제조업체"].Value = rowDatas[4];

            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "제품");
                dataGridView1.DataSource = dataSet.Tables["제품"];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            #endregion
        }

        public void UpdateRow_product(string[] rowDates)
        {
            string sql = "UPDATE 제품 SET 제품명=@제품명, " +
                "재고량=@재고량, 단가=@단가, 제조업체=@제조업체 WHERE 제품번호=@제품번호";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@제품번호", rowDates[0]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@제품명", rowDates[1]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@재고량", rowDates[2]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@단가", rowDates[3]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@제조업체", rowDates[4]);

            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "제품");
                dataGridView1.DataSource = dataSet.Tables["제품"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /*주문*/
        public void InsertRow_order(string[] rowDatas)
        {
            string queryStr = "INSERT INTO 주문 (주문번호, 주문고객, 제품번호, 수량, 배송지, 주문일자)" +
                "VALUES(@주문번호, @주문고객, @제품번호, @수량, @배송지, @주문일자)";
            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.Add("@주문번호", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@주문고객", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@제품번호", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@수량", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@배송지", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@주문일자", MySqlDbType.VarChar);

            #region Parameter를 이용한 처리
            dataAdapter.InsertCommand.Parameters["@주문번호"].Value = rowDatas[0];
            dataAdapter.InsertCommand.Parameters["@주문고객"].Value = rowDatas[1];
            dataAdapter.InsertCommand.Parameters["@제품번호"].Value = rowDatas[2];
            dataAdapter.InsertCommand.Parameters["@수량"].Value = rowDatas[3];
            dataAdapter.InsertCommand.Parameters["@배송지"].Value = rowDatas[4];
            dataAdapter.InsertCommand.Parameters["@주문일자"].Value = rowDatas[5];

            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "주문");
                dataGridView1.DataSource = dataSet.Tables["주문"];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            #endregion
        }

        public void UpdateRow_order(string[] rowDates)
        {
            string sql = "UPDATE 주문 SET 주문고객=@주문고객, " +
                "제품번호=@제품번호, 수량=@수량, 배송지=@배송지, 주문일자=@주문일자 WHERE 주문번호=@주문번호";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@주문번호", rowDates[0]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@주문고객", rowDates[1]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@제품번호", rowDates[2]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@수량", rowDates[3]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@배송지", rowDates[4]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@주문일자", rowDates[5]);

            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "주문");
                dataGridView1.DataSource = dataSet.Tables["주문"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // **** 고객 SELECT 버튼 클릭 ****  
        private void btnSelect_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked) // 고객
            {
                Select_QueryString_Select();
            }
            else if (radioButton2.Checked) //제품테이블
            {
                Select_Button2();
            }
            else if (radioButton3.Checked)
                Select_Button3();
        }
        #region 테이블 선택 조건
        private void Select_QueryString_Select()
        {
            string queryStr;

            #region Select QueryString Create
            string[] conditions = new string[3];
            conditions[0] = (TBID.Text != "") ? "고객아이디=@고객아이디" : null;
            conditions[1] = (TBName.Text != "") ? "고객이름=@고객이름" : null;
            conditions[2] = (CBClass.Text != "") ? "등급=@등급" : null;

            //Select QueryString 만들기
            if (conditions[0] != null || conditions[1] != null || conditions[2] != null)
            {
                queryStr = $"SELECT * FROM 고객 WHERE ";
                bool firstCondition = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM 고객";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@고객아이디", TBID.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@고객이름", TBName.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@등급", CBClass.Text);
            #endregion

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "고객") > 0)
                    dataGridView1.DataSource = dataSet.Tables["고객"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void Select_Button2()
        {
            string queryStr;

            #region Select QueryString Create
            string[] conditions = new string[2];
            conditions[0] = (CBProduct.Text != "") ? "제조업체=@제조업체" : null;
            conditions[1] = (CBProductName.Text != "") ? "제품명=@제품명" : null;

            //Select QueryString 만들기
            if (conditions[0] != null || conditions[1] != null)
            {
                queryStr = $"SELECT * FROM 제품 WHERE ";
                bool firstCondition = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM 제품";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@제조업체", CBProduct.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@제품명", CBProductName.Text);
            #endregion

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "제품") > 0)
                    dataGridView1.DataSource = dataSet.Tables["제품"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void Select_Button3()
        {
            string queryStr;

            #region Select QueryString Create
            string[] conditions = new string[2];
            conditions[0] = (TBID2.Text != "") ? "주문고객=@주문고객" : null;
            conditions[1] = (CBProductNumber.Text != "") ? "제품번호=@제품번호" : null;

            //Select QueryString 만들기
            if (conditions[0] != null || conditions[1] != null)
            {
                queryStr = $"SELECT * FROM 주문 WHERE ";
                bool firstCondition = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM 주문";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@주문고객", TBID2.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@제품번호", CBProductNumber.Text);
            #endregion

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "주문") > 0)
                    dataGridView1.DataSource = dataSet.Tables["주문"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string sql = "DELETE FROM 고객 WHERE 고객아이디=@고객아이디";
                dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
                dataAdapter.DeleteCommand.Parameters.Add("@고객아이디", MySqlDbType.VarChar);  // 그리드뷰에서 선택된 행 정보가져오기
                dataAdapter.DeleteCommand.Parameters["@고객아이디"].Value = dataGridView1.SelectedRows[0].Cells["고객아이디"].Value;

                try
                {
                    conn.Open();
                    dataAdapter.DeleteCommand.ExecuteNonQuery();

                    dataSet.Clear();
                    dataAdapter.Fill(dataSet, "고객");
                    dataGridView1.DataSource = dataSet.Tables["고객"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else if (radioButton2.Checked)
            {
                string sql = "DELETE FROM 제품 WHERE 제품번호=@제품번호";
                dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
                dataAdapter.DeleteCommand.Parameters.Add("@제품번호", MySqlDbType.VarChar);  // 그리드뷰에서 선택된 행 정보가져오기
                dataAdapter.DeleteCommand.Parameters["@제품번호"].Value = dataGridView1.SelectedRows[0].Cells["제품번호"].Value;

                try
                {
                    conn.Open();
                    dataAdapter.DeleteCommand.ExecuteNonQuery();

                    dataSet.Clear();
                    dataAdapter.Fill(dataSet, "제품");
                    dataGridView1.DataSource = dataSet.Tables["제품"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else if (radioButton3.Checked)
            {
                string sql = "DELETE FROM 주문 WHERE 주문번호=@주문번호";
                dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
                dataAdapter.DeleteCommand.Parameters.Add("@주문번호", MySqlDbType.VarChar);  // 그리드뷰에서 선택된 행 정보가져오기
                dataAdapter.DeleteCommand.Parameters["@주문번호"].Value = dataGridView1.SelectedRows[0].Cells["주문번호"].Value;

                try
                {
                    conn.Open();
                    dataAdapter.DeleteCommand.ExecuteNonQuery();

                    dataSet.Clear();
                    dataAdapter.Fill(dataSet, "주문");
                    dataGridView1.DataSource = dataSet.Tables["주문"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

        }
    }
}
