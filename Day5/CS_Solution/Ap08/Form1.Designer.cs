namespace Ap08
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAsk = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(27, 28);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(133, 47);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAsk
            // 
            this.btnAsk.Location = new System.Drawing.Point(27, 130);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(133, 47);
            this.btnAsk.TabIndex = 1;
            this.btnAsk.Text = "Ask";
            this.btnAsk.UseVisualStyleBackColor = true;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(293, 240);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(133, 47);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(178, 138);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(248, 36);
            this.txtAns.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 325);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnAsk);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAsk;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox txtAns;
    }
}

