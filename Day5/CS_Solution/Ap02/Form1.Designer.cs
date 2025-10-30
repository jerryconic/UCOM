namespace Ap02;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        txtA = new TextBox();
        txtB = new TextBox();
        label2 = new Label();
        txtAns = new TextBox();
        label3 = new Label();
        btnAdd = new Button();
        btnSub = new Button();
        btnMul = new Button();
        btnDiv = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(56, 33);
        label1.Name = "label1";
        label1.Size = new Size(32, 20);
        label1.TabIndex = 0;
        label1.Text = "A=";
        // 
        // txtA
        // 
        txtA.Location = new Point(94, 30);
        txtA.Name = "txtA";
        txtA.Size = new Size(100, 28);
        txtA.TabIndex = 1;
        // 
        // txtB
        // 
        txtB.Location = new Point(94, 64);
        txtB.Name = "txtB";
        txtB.Size = new Size(100, 28);
        txtB.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(56, 67);
        label2.Name = "label2";
        label2.Size = new Size(31, 20);
        label2.TabIndex = 2;
        label2.Text = "B=";
        // 
        // txtAns
        // 
        txtAns.Location = new Point(94, 98);
        txtAns.Name = "txtAns";
        txtAns.ReadOnly = true;
        txtAns.Size = new Size(100, 28);
        txtAns.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(39, 101);
        label3.Name = "label3";
        label3.Size = new Size(49, 20);
        label3.TabIndex = 4;
        label3.Text = "Ans=";
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(26, 139);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(42, 33);
        btnAdd.TabIndex = 6;
        btnAdd.Text = "+";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnSub
        // 
        btnSub.Location = new Point(74, 139);
        btnSub.Name = "btnSub";
        btnSub.Size = new Size(42, 33);
        btnSub.TabIndex = 7;
        btnSub.Text = "-";
        btnSub.UseVisualStyleBackColor = true;
        btnSub.Click += btnSub_Click;
        // 
        // btnMul
        // 
        btnMul.Location = new Point(122, 139);
        btnMul.Name = "btnMul";
        btnMul.Size = new Size(42, 33);
        btnMul.TabIndex = 8;
        btnMul.Text = "*";
        btnMul.UseVisualStyleBackColor = true;
        btnMul.Click += btnMul_Click;
        // 
        // btnDiv
        // 
        btnDiv.Location = new Point(170, 139);
        btnDiv.Name = "btnDiv";
        btnDiv.Size = new Size(42, 33);
        btnDiv.TabIndex = 9;
        btnDiv.Text = "/";
        btnDiv.UseVisualStyleBackColor = true;
        btnDiv.Click += btnDiv_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(248, 192);
        Controls.Add(btnDiv);
        Controls.Add(btnMul);
        Controls.Add(btnSub);
        Controls.Add(btnAdd);
        Controls.Add(txtAns);
        Controls.Add(label3);
        Controls.Add(txtB);
        Controls.Add(label2);
        Controls.Add(txtA);
        Controls.Add(label1);
        Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
        Margin = new Padding(4);
        Name = "Form1";
        Text = "簡單計算機";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtA;
    private TextBox txtB;
    private Label label2;
    private TextBox txtAns;
    private Label label3;
    private Button btnAdd;
    private Button btnSub;
    private Button btnMul;
    private Button btnDiv;
}
