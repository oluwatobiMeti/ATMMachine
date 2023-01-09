namespace tobisAtm
{
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ReceiptBtn = new System.Windows.Forms.Button();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.okBtn = new System.Windows.Forms.Button();
            this.downClearBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.doubleTwoBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.dotBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.FiveBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.TwoBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.downEnter = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Deposite = new System.Windows.Forms.RadioButton();
            this.falseBtn = new System.Windows.Forms.RadioButton();
            this.trueBtn = new System.Windows.Forms.RadioButton();
            this.instructLabl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BackBtn);
            this.panel1.Controls.Add(this.ClearBtn);
            this.panel1.Controls.Add(this.ReceiptBtn);
            this.panel1.Controls.Add(this.EnterBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 243);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 33);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount";
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackBtn.Location = new System.Drawing.Point(22, 185);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(157, 43);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearBtn.Location = new System.Drawing.Point(22, 127);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(157, 43);
            this.ClearBtn.TabIndex = 2;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ReceiptBtn
            // 
            this.ReceiptBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReceiptBtn.Location = new System.Drawing.Point(298, 185);
            this.ReceiptBtn.Name = "ReceiptBtn";
            this.ReceiptBtn.Size = new System.Drawing.Size(157, 43);
            this.ReceiptBtn.TabIndex = 1;
            this.ReceiptBtn.Text = "Receipt";
            this.ReceiptBtn.UseVisualStyleBackColor = true;
            this.ReceiptBtn.Click += new System.EventHandler(this.ReceiptBtn_Click);
            // 
            // EnterBtn
            // 
            this.EnterBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterBtn.Location = new System.Drawing.Point(298, 127);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(157, 43);
            this.EnterBtn.TabIndex = 0;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.okBtn);
            this.panel2.Controls.Add(this.downClearBtn);
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Controls.Add(this.doubleTwoBtn);
            this.panel2.Controls.Add(this.zeroBtn);
            this.panel2.Controls.Add(this.dotBtn);
            this.panel2.Controls.Add(this.sevenBtn);
            this.panel2.Controls.Add(this.eightBtn);
            this.panel2.Controls.Add(this.fourBtn);
            this.panel2.Controls.Add(this.FiveBtn);
            this.panel2.Controls.Add(this.nineBtn);
            this.panel2.Controls.Add(this.sixBtn);
            this.panel2.Controls.Add(this.oneBtn);
            this.panel2.Controls.Add(this.TwoBtn);
            this.panel2.Controls.Add(this.threeBtn);
            this.panel2.Controls.Add(this.downEnter);
            this.panel2.Location = new System.Drawing.Point(0, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 227);
            this.panel2.TabIndex = 1;
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.okBtn.Location = new System.Drawing.Point(367, 178);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(97, 35);
            this.okBtn.TabIndex = 15;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // downClearBtn
            // 
            this.downClearBtn.BackColor = System.Drawing.Color.Yellow;
            this.downClearBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.downClearBtn.Location = new System.Drawing.Point(367, 128);
            this.downClearBtn.Name = "downClearBtn";
            this.downClearBtn.Size = new System.Drawing.Size(97, 35);
            this.downClearBtn.TabIndex = 14;
            this.downClearBtn.Text = "Clear";
            this.downClearBtn.UseVisualStyleBackColor = false;
            this.downClearBtn.Click += new System.EventHandler(this.downClearBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.Location = new System.Drawing.Point(367, 73);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(97, 35);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // doubleTwoBtn
            // 
            this.doubleTwoBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.doubleTwoBtn.Location = new System.Drawing.Point(218, 178);
            this.doubleTwoBtn.Name = "doubleTwoBtn";
            this.doubleTwoBtn.Size = new System.Drawing.Size(97, 35);
            this.doubleTwoBtn.TabIndex = 12;
            this.doubleTwoBtn.Text = "00";
            this.doubleTwoBtn.UseVisualStyleBackColor = true;
            this.doubleTwoBtn.Click += new System.EventHandler(this.doubleTwoBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zeroBtn.Location = new System.Drawing.Point(115, 178);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(97, 35);
            this.zeroBtn.TabIndex = 11;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = true;
            this.zeroBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // dotBtn
            // 
            this.dotBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dotBtn.Location = new System.Drawing.Point(12, 178);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Size = new System.Drawing.Size(97, 35);
            this.dotBtn.TabIndex = 10;
            this.dotBtn.Text = ".";
            this.dotBtn.UseVisualStyleBackColor = true;
            this.dotBtn.Click += new System.EventHandler(this.dotBtn_Click);
            // 
            // sevenBtn
            // 
            this.sevenBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sevenBtn.Location = new System.Drawing.Point(12, 126);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(97, 35);
            this.sevenBtn.TabIndex = 9;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = true;
            this.sevenBtn.Click += new System.EventHandler(this.sevenBtn_Click);
            // 
            // eightBtn
            // 
            this.eightBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eightBtn.Location = new System.Drawing.Point(115, 126);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(97, 35);
            this.eightBtn.TabIndex = 8;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = true;
            this.eightBtn.Click += new System.EventHandler(this.eightBtn_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fourBtn.Location = new System.Drawing.Point(12, 73);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(97, 35);
            this.fourBtn.TabIndex = 7;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = true;
            this.fourBtn.Click += new System.EventHandler(this.fourBtn_Click);
            // 
            // FiveBtn
            // 
            this.FiveBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FiveBtn.Location = new System.Drawing.Point(115, 73);
            this.FiveBtn.Name = "FiveBtn";
            this.FiveBtn.Size = new System.Drawing.Size(97, 35);
            this.FiveBtn.TabIndex = 6;
            this.FiveBtn.Text = "5";
            this.FiveBtn.UseVisualStyleBackColor = true;
            this.FiveBtn.Click += new System.EventHandler(this.FiveBtn_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nineBtn.Location = new System.Drawing.Point(218, 126);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(97, 35);
            this.nineBtn.TabIndex = 5;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = true;
            this.nineBtn.Click += new System.EventHandler(this.nineBtn_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sixBtn.Location = new System.Drawing.Point(218, 73);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(97, 35);
            this.sixBtn.TabIndex = 4;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = true;
            this.sixBtn.Click += new System.EventHandler(this.sixBtn_Click);
            // 
            // oneBtn
            // 
            this.oneBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oneBtn.Location = new System.Drawing.Point(12, 18);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(97, 35);
            this.oneBtn.TabIndex = 3;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;
            this.oneBtn.Click += new System.EventHandler(this.oneBtn_Click);
            // 
            // TwoBtn
            // 
            this.TwoBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TwoBtn.Location = new System.Drawing.Point(115, 18);
            this.TwoBtn.Name = "TwoBtn";
            this.TwoBtn.Size = new System.Drawing.Size(97, 35);
            this.TwoBtn.TabIndex = 2;
            this.TwoBtn.Text = "2";
            this.TwoBtn.UseVisualStyleBackColor = true;
            this.TwoBtn.Click += new System.EventHandler(this.TwoBtn_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.threeBtn.Location = new System.Drawing.Point(218, 18);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(97, 35);
            this.threeBtn.TabIndex = 1;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;
            this.threeBtn.Click += new System.EventHandler(this.threeBtn_Click);
            // 
            // downEnter
            // 
            this.downEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.downEnter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.downEnter.Location = new System.Drawing.Point(367, 20);
            this.downEnter.Name = "downEnter";
            this.downEnter.Size = new System.Drawing.Size(97, 35);
            this.downEnter.TabIndex = 0;
            this.downEnter.Text = "Enter";
            this.downEnter.UseVisualStyleBackColor = false;
            this.downEnter.Click += new System.EventHandler(this.downEnter_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Deposite);
            this.panel3.Controls.Add(this.falseBtn);
            this.panel3.Controls.Add(this.trueBtn);
            this.panel3.Controls.Add(this.instructLabl);
            this.panel3.Location = new System.Drawing.Point(483, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 243);
            this.panel3.TabIndex = 2;
            // 
            // Deposite
            // 
            this.Deposite.AutoSize = true;
            this.Deposite.Location = new System.Drawing.Point(103, 185);
            this.Deposite.Name = "Deposite";
            this.Deposite.Size = new System.Drawing.Size(14, 13);
            this.Deposite.TabIndex = 3;
            this.Deposite.TabStop = true;
            this.Deposite.UseVisualStyleBackColor = true;
            // 
            // falseBtn
            // 
            this.falseBtn.AutoSize = true;
            this.falseBtn.Location = new System.Drawing.Point(220, 185);
            this.falseBtn.Name = "falseBtn";
            this.falseBtn.Size = new System.Drawing.Size(94, 19);
            this.falseBtn.TabIndex = 2;
            this.falseBtn.Text = "radioButton1";
            this.falseBtn.UseVisualStyleBackColor = true;
            // 
            // trueBtn
            // 
            this.trueBtn.AutoSize = true;
            this.trueBtn.Location = new System.Drawing.Point(3, 185);
            this.trueBtn.Name = "trueBtn";
            this.trueBtn.Size = new System.Drawing.Size(94, 19);
            this.trueBtn.TabIndex = 1;
            this.trueBtn.Text = "radioButton1";
            this.trueBtn.UseVisualStyleBackColor = true;
            this.trueBtn.CheckedChanged += new System.EventHandler(this.trueBtn_CheckedChanged);
            // 
            // instructLabl
            // 
            this.instructLabl.Dock = System.Windows.Forms.DockStyle.Top;
            this.instructLabl.Location = new System.Drawing.Point(0, 0);
            this.instructLabl.Name = "instructLabl";
            this.instructLabl.Size = new System.Drawing.Size(317, 170);
            this.instructLabl.TabIndex = 0;
            this.instructLabl.Text = "label2";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(483, 249);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(318, 224);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 224);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private Button BackBtn;
        private Button ClearBtn;
        private Button ReceiptBtn;
        private Button EnterBtn;
        private Panel panel2;
        private Button okBtn;
        private Button downClearBtn;
        private Button cancelBtn;
        private Button doubleTwoBtn;
        private Button zeroBtn;
        private Button dotBtn;
        private Button sevenBtn;
        private Button eightBtn;
        private Button fourBtn;
        private Button FiveBtn;
        private Button nineBtn;
        private Button sixBtn;
        private Button oneBtn;
        private Button TwoBtn;
        private Button threeBtn;
        private Button downEnter;
        private Panel panel3;
        private Label instructLabl;
        private RadioButton falseBtn;
        private RadioButton trueBtn;
        private Panel panel4;
        private Label label3;
        private RadioButton Deposite;
    }
}