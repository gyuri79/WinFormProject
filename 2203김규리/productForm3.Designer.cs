﻿namespace _2203김규리
{
    partial class productForm3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.productManufacturer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productInventory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnTextBoxClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.productManufacturer);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.productPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.productInventory);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.productName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.productNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 242);
            this.panel1.TabIndex = 0;
            // 
            // productManufacturer
            // 
            this.productManufacturer.Location = new System.Drawing.Point(119, 193);
            this.productManufacturer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productManufacturer.Name = "productManufacturer";
            this.productManufacturer.Size = new System.Drawing.Size(129, 27);
            this.productManufacturer.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "제조업체";
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(119, 146);
            this.productPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(129, 27);
            this.productPrice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "단가";
            // 
            // productInventory
            // 
            this.productInventory.Location = new System.Drawing.Point(119, 102);
            this.productInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productInventory.Name = "productInventory";
            this.productInventory.Size = new System.Drawing.Size(129, 27);
            this.productInventory.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "재고량";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(119, 61);
            this.productName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(129, 27);
            this.productName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "제품명";
            // 
            // productNumber
            // 
            this.productNumber.Location = new System.Drawing.Point(119, 20);
            this.productNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productNumber.Name = "productNumber";
            this.productNumber.Size = new System.Drawing.Size(129, 27);
            this.productNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "제품번호";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.btnInsert.Location = new System.Drawing.Point(332, 110);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(212, 42);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(332, 171);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(212, 42);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTextBoxClear
            // 
            this.btnTextBoxClear.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.btnTextBoxClear.Location = new System.Drawing.Point(332, 237);
            this.btnTextBoxClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTextBoxClear.Name = "btnTextBoxClear";
            this.btnTextBoxClear.Size = new System.Drawing.Size(212, 42);
            this.btnTextBoxClear.TabIndex = 6;
            this.btnTextBoxClear.Text = "textBoxClear";
            this.btnTextBoxClear.UseVisualStyleBackColor = true;
            this.btnTextBoxClear.Click += new System.EventHandler(this.btnTextBoxClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(142, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "제품 Insert and Update";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 326);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTextBoxClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("나눔고딕", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productInventory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnTextBoxClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox productManufacturer;
        private System.Windows.Forms.Label label4;
    }
}