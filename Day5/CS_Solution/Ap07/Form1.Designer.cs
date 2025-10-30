namespace Ap07
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
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.btnDog = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnLion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
            this.SuspendLayout();
            // 
            // pct1
            // 
            this.pct1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct1.Image = global::Ap07.Properties.Resources.dog;
            this.pct1.Location = new System.Drawing.Point(52, 48);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(306, 269);
            this.pct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct1.TabIndex = 0;
            this.pct1.TabStop = false;
            // 
            // btnDog
            // 
            this.btnDog.Location = new System.Drawing.Point(381, 58);
            this.btnDog.Name = "btnDog";
            this.btnDog.Size = new System.Drawing.Size(170, 57);
            this.btnDog.TabIndex = 1;
            this.btnDog.Text = "Dog";
            this.btnDog.UseVisualStyleBackColor = true;
            this.btnDog.Click += new System.EventHandler(this.btnDog_Click);
            // 
            // btnCat
            // 
            this.btnCat.Location = new System.Drawing.Point(381, 121);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(170, 57);
            this.btnCat.TabIndex = 2;
            this.btnCat.Text = "Cat";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // btnLion
            // 
            this.btnLion.Location = new System.Drawing.Point(381, 184);
            this.btnLion.Name = "btnLion";
            this.btnLion.Size = new System.Drawing.Size(170, 57);
            this.btnLion.TabIndex = 3;
            this.btnLion.Text = "Lion";
            this.btnLion.UseVisualStyleBackColor = true;
            this.btnLion.Click += new System.EventHandler(this.btnLion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 600);
            this.Controls.Add(this.btnLion);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.btnDog);
            this.Controls.Add(this.pct1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pct1;
        private System.Windows.Forms.Button btnDog;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.Button btnLion;
    }
}

