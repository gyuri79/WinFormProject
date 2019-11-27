namespace _2203김규리
{
    partial class mainForm1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBID = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.lable4 = new System.Windows.Forms.Label();
            this.CBClass = new System.Windows.Forms.ComboBox();
            this.lable3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBProductName = new System.Windows.Forms.ComboBox();
            this.CBProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TBID2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBProductNumber = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 240);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(876, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("나눔고딕", 13F);
            this.btnInsert.Location = new System.Drawing.Point(700, 104);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(192, 46);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert && Update";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsertUpdate_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("나눔고딕", 13F);
            this.btnSelect.Location = new System.Drawing.Point(532, 104);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(143, 46);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TBID);
            this.groupBox1.Controls.Add(this.TBName);
            this.groupBox1.Controls.Add(this.lable4);
            this.groupBox1.Controls.Add(this.CBClass);
            this.groupBox1.Controls.Add(this.lable3);
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(496, 201);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색 조건 - 고객";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(117, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID :";
            // 
            // TBID
            // 
            this.TBID.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TBID.Location = new System.Drawing.Point(163, 57);
            this.TBID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TBID.Name = "TBID";
            this.TBID.Size = new System.Drawing.Size(194, 30);
            this.TBID.TabIndex = 14;
            this.TBID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBName
            // 
            this.TBName.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TBName.Location = new System.Drawing.Point(163, 97);
            this.TBName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(194, 30);
            this.TBName.TabIndex = 5;
            this.TBName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lable4.Location = new System.Drawing.Point(82, 104);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(83, 23);
            this.lable4.TabIndex = 4;
            this.lable4.Text = "Name : ";
            // 
            // CBClass
            // 
            this.CBClass.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CBClass.FormattingEnabled = true;
            this.CBClass.Location = new System.Drawing.Point(163, 137);
            this.CBClass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CBClass.Name = "CBClass";
            this.CBClass.Size = new System.Drawing.Size(194, 31);
            this.CBClass.TabIndex = 3;
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lable3.Location = new System.Drawing.Point(84, 141);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(73, 23);
            this.lable3.TabIndex = 2;
            this.lable3.Text = "Class : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CBProductName);
            this.groupBox2.Controls.Add(this.CBProduct);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("나눔고딕", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(496, 201);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "검색 조건 - 제품";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(50, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "ProductName :";
            // 
            // CBProductName
            // 
            this.CBProductName.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CBProductName.FormattingEnabled = true;
            this.CBProductName.Location = new System.Drawing.Point(205, 121);
            this.CBProductName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CBProductName.Name = "CBProductName";
            this.CBProductName.Size = new System.Drawing.Size(155, 31);
            this.CBProductName.TabIndex = 10;
            // 
            // CBProduct
            // 
            this.CBProduct.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CBProduct.FormattingEnabled = true;
            this.CBProduct.Location = new System.Drawing.Point(205, 68);
            this.CBProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CBProduct.Name = "CBProduct";
            this.CBProduct.Size = new System.Drawing.Size(155, 31);
            this.CBProduct.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(105, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Product :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TBID2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.CBProductNumber);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("나눔고딕", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(16, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox3.Size = new System.Drawing.Size(496, 201);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "검색 조건 - 주문";
            // 
            // TBID2
            // 
            this.TBID2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TBID2.Location = new System.Drawing.Point(207, 73);
            this.TBID2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TBID2.Name = "TBID2";
            this.TBID2.Size = new System.Drawing.Size(155, 30);
            this.TBID2.TabIndex = 7;
            this.TBID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(158, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID :  ";
            // 
            // CBProductNumber
            // 
            this.CBProductNumber.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CBProductNumber.FormattingEnabled = true;
            this.CBProductNumber.Location = new System.Drawing.Point(207, 117);
            this.CBProductNumber.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CBProductNumber.Name = "CBProductNumber";
            this.CBProductNumber.Size = new System.Drawing.Size(155, 31);
            this.CBProductNumber.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(32, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "ProductNumber :";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("나눔고딕", 13F);
            this.btnClear.Location = new System.Drawing.Point(700, 170);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(192, 46);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButton3);
            this.groupBox.Controls.Add(this.radioButton1);
            this.groupBox.Controls.Add(this.radioButton2);
            this.groupBox.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox.Location = new System.Drawing.Point(532, 15);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(360, 71);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Tables";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("나눔고딕", 10F);
            this.radioButton3.Location = new System.Drawing.Point(232, 32);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 24);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "주문";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("나눔고딕", 10F);
            this.radioButton1.Location = new System.Drawing.Point(15, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 24);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "고객";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("나눔고딕", 10F);
            this.radioButton2.Location = new System.Drawing.Point(120, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 24);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "제품";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("나눔고딕", 13F);
            this.button1.Location = new System.Drawing.Point(532, 170);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // mainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 542);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("나눔고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBClass;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox TBID2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBProductName;
        private System.Windows.Forms.ComboBox CBProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CBProductNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBID;
    }
}

