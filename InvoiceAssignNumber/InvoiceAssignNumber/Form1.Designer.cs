namespace InvoiceAssignNumber
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.shopcode = new System.Windows.Forms.Label();
            this.terminalcode = new System.Windows.Forms.Label();
            this.invoice = new System.Windows.Forms.Label();
            this.txtShopCode = new System.Windows.Forms.TextBox();
            this.txtTerminalCode = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnQuickSetting = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnSetting = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDBLoc = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label2.ForeColor = System.Drawing.Color.Red;
            label2.Location = new System.Drawing.Point(19, 27);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(233, 20);
            label2.TabIndex = 7;
            label2.Text = "設定發票字軌:XX+機號+流水號";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Location = new System.Drawing.Point(41, 6);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(185, 20);
            label3.TabIndex = 10;
            label3.Text = "請填入完整發票字軌資訊";
            // 
            // shopcode
            // 
            this.shopcode.AutoSize = true;
            this.shopcode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.shopcode.Location = new System.Drawing.Point(31, 24);
            this.shopcode.Name = "shopcode";
            this.shopcode.Size = new System.Drawing.Size(77, 20);
            this.shopcode.TabIndex = 0;
            this.shopcode.Text = "門市店號:";
            // 
            // terminalcode
            // 
            this.terminalcode.AutoSize = true;
            this.terminalcode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.terminalcode.Location = new System.Drawing.Point(31, 63);
            this.terminalcode.Name = "terminalcode";
            this.terminalcode.Size = new System.Drawing.Size(77, 20);
            this.terminalcode.TabIndex = 1;
            this.terminalcode.Text = "收銀機號:";
            // 
            // invoice
            // 
            this.invoice.AutoSize = true;
            this.invoice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.invoice.Location = new System.Drawing.Point(18, 38);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(77, 20);
            this.invoice.TabIndex = 2;
            this.invoice.Text = "發票字軌:";
            // 
            // txtShopCode
            // 
            this.txtShopCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShopCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtShopCode.Location = new System.Drawing.Point(111, 22);
            this.txtShopCode.MaxLength = 6;
            this.txtShopCode.Name = "txtShopCode";
            this.txtShopCode.ReadOnly = true;
            this.txtShopCode.Size = new System.Drawing.Size(117, 29);
            this.txtShopCode.TabIndex = 3;
            this.txtShopCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTerminalCode
            // 
            this.txtTerminalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTerminalCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTerminalCode.Location = new System.Drawing.Point(111, 57);
            this.txtTerminalCode.MaxLength = 1;
            this.txtTerminalCode.Name = "txtTerminalCode";
            this.txtTerminalCode.ReadOnly = true;
            this.txtTerminalCode.Size = new System.Drawing.Size(117, 29);
            this.txtTerminalCode.TabIndex = 4;
            this.txtTerminalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox2.Location = new System.Drawing.Point(101, 83);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 27);
            this.textBox2.TabIndex = 5;
            // 
            // btnQuickSetting
            // 
            this.btnQuickSetting.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuickSetting.Location = new System.Drawing.Point(6, 82);
            this.btnQuickSetting.Name = "btnQuickSetting";
            this.btnQuickSetting.Size = new System.Drawing.Size(256, 41);
            this.btnQuickSetting.TabIndex = 6;
            this.btnQuickSetting.Text = "快速設定";
            this.btnQuickSetting.UseVisualStyleBackColor = true;
            this.btnQuickSetting.Click += new System.EventHandler(this.BtnQuickSetting_Click);
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox1.Location = new System.Drawing.Point(101, 34);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 27);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(159, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "~";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(21, 131);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(282, 201);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(label2);
            this.tabPage1.Controls.Add(this.btnQuickSetting);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(274, 168);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "快速設定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnSetting);
            this.tabPage2.Controls.Add(label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.invoice);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(274, 168);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "自訂字軌";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnSetting
            // 
            this.BtnSetting.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnSetting.Location = new System.Drawing.Point(6, 121);
            this.BtnSetting.Name = "BtnSetting";
            this.BtnSetting.Size = new System.Drawing.Size(256, 41);
            this.BtnSetting.TabIndex = 11;
            this.BtnSetting.Text = "設定";
            this.BtnSetting.UseVisualStyleBackColor = true;
            this.BtnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(31, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "DB位置：";
            // 
            // txtDBLoc
            // 
            this.txtDBLoc.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDBLoc.Location = new System.Drawing.Point(111, 93);
            this.txtDBLoc.Name = "txtDBLoc";
            this.txtDBLoc.Size = new System.Drawing.Size(192, 23);
            this.txtDBLoc.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(338, 345);
            this.Controls.Add(this.txtDBLoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTerminalCode);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtShopCode);
            this.Controls.Add(this.shopcode);
            this.Controls.Add(this.terminalcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "電子發票配號小工具";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shopcode;
        private System.Windows.Forms.Label terminalcode;
        private System.Windows.Forms.Label invoice;
        private System.Windows.Forms.TextBox txtShopCode;
        private System.Windows.Forms.TextBox txtTerminalCode;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnQuickSetting;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnSetting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDBLoc;
    }
}

