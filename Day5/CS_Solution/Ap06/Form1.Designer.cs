namespace Ap06
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoNo1 = new System.Windows.Forms.RadioButton();
            this.rdoNo2 = new System.Windows.Forms.RadioButton();
            this.rdoNo3 = new System.Windows.Forms.RadioButton();
            this.chkCream = new System.Windows.Forms.CheckBox();
            this.chkPie = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNo3);
            this.groupBox1.Controls.Add(this.rdoNo2);
            this.groupBox1.Controls.Add(this.rdoNo1);
            this.groupBox1.Location = new System.Drawing.Point(59, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "餐點";
            // 
            // rdoNo1
            // 
            this.rdoNo1.AutoSize = true;
            this.rdoNo1.Location = new System.Drawing.Point(41, 60);
            this.rdoNo1.Name = "rdoNo1";
            this.rdoNo1.Size = new System.Drawing.Size(111, 28);
            this.rdoNo1.TabIndex = 0;
            this.rdoNo1.TabStop = true;
            this.rdoNo1.Text = "No1(95)";
            this.rdoNo1.UseVisualStyleBackColor = true;
            // 
            // rdoNo2
            // 
            this.rdoNo2.AutoSize = true;
            this.rdoNo2.Location = new System.Drawing.Point(41, 108);
            this.rdoNo2.Name = "rdoNo2";
            this.rdoNo2.Size = new System.Drawing.Size(122, 28);
            this.rdoNo2.TabIndex = 1;
            this.rdoNo2.TabStop = true;
            this.rdoNo2.Text = "No2(105)";
            this.rdoNo2.UseVisualStyleBackColor = true;
            // 
            // rdoNo3
            // 
            this.rdoNo3.AutoSize = true;
            this.rdoNo3.Location = new System.Drawing.Point(41, 155);
            this.rdoNo3.Name = "rdoNo3";
            this.rdoNo3.Size = new System.Drawing.Size(122, 28);
            this.rdoNo3.TabIndex = 2;
            this.rdoNo3.TabStop = true;
            this.rdoNo3.Text = "No3(120)";
            this.rdoNo3.UseVisualStyleBackColor = true;
            // 
            // chkCream
            // 
            this.chkCream.AutoSize = true;
            this.chkCream.Location = new System.Drawing.Point(100, 292);
            this.chkCream.Name = "chkCream";
            this.chkCream.Size = new System.Drawing.Size(169, 28);
            this.chkCream.TabIndex = 2;
            this.chkCream.Text = "Ice Cream(15)";
            this.chkCream.UseVisualStyleBackColor = true;
            // 
            // chkPie
            // 
            this.chkPie.AutoSize = true;
            this.chkPie.Location = new System.Drawing.Point(100, 338);
            this.chkPie.Name = "chkPie";
            this.chkPie.Size = new System.Drawing.Size(163, 28);
            this.chkPie.TabIndex = 3;
            this.chkPie.Text = "Apple Pie(25)";
            this.chkPie.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "小計:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(127, 402);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(130, 36);
            this.txtTotal.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(124, 462);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 37);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "計算";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 529);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkPie);
            this.Controls.Add(this.chkCream);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNo3;
        private System.Windows.Forms.RadioButton rdoNo2;
        private System.Windows.Forms.RadioButton rdoNo1;
        private System.Windows.Forms.CheckBox chkCream;
        private System.Windows.Forms.CheckBox chkPie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnOk;
    }
}

