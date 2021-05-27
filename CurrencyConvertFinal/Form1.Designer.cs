
namespace CurrencyConvertFinal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.haveCurrency = new System.Windows.Forms.TextBox();
            this.btnGetQuote = new System.Windows.Forms.Button();
            this.lblFxRate = new System.Windows.Forms.Label();
            this.haveLbl = new System.Windows.Forms.Label();
            this.wantLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.amountLbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // haveCurrency
            // 
            this.haveCurrency.BackColor = System.Drawing.Color.White;
            this.haveCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haveCurrency.Location = new System.Drawing.Point(58, 119);
            this.haveCurrency.Margin = new System.Windows.Forms.Padding(6);
            this.haveCurrency.Name = "haveCurrency";
            this.haveCurrency.Size = new System.Drawing.Size(162, 31);
            this.haveCurrency.TabIndex = 4;
            this.haveCurrency.TextChanged += new System.EventHandler(this.tbCurrency_TextChanged);
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetQuote.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnGetQuote.Location = new System.Drawing.Point(219, 228);
            this.btnGetQuote.Margin = new System.Windows.Forms.Padding(6);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(150, 44);
            this.btnGetQuote.TabIndex = 6;
            this.btnGetQuote.Text = "Calculate";
            this.btnGetQuote.UseVisualStyleBackColor = true;
            this.btnGetQuote.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblFxRate
            // 
            this.lblFxRate.AutoSize = true;
            this.lblFxRate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblFxRate.Location = new System.Drawing.Point(411, 200);
            this.lblFxRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFxRate.Name = "lblFxRate";
            this.lblFxRate.Size = new System.Drawing.Size(36, 25);
            this.lblFxRate.TabIndex = 7;
            this.lblFxRate.Text = "    ";
            // 
            // haveLbl
            // 
            this.haveLbl.AutoSize = true;
            this.haveLbl.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haveLbl.ForeColor = System.Drawing.Color.White;
            this.haveLbl.Location = new System.Drawing.Point(53, 75);
            this.haveLbl.Name = "haveLbl";
            this.haveLbl.Size = new System.Drawing.Size(187, 29);
            this.haveLbl.TabIndex = 9;
            this.haveLbl.Text = "Currency I have:";
            this.haveLbl.Click += new System.EventHandler(this.title_Click);
            // 
            // wantLbl
            // 
            this.wantLbl.AutoSize = true;
            this.wantLbl.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wantLbl.ForeColor = System.Drawing.Color.White;
            this.wantLbl.Location = new System.Drawing.Point(342, 75);
            this.wantLbl.Name = "wantLbl";
            this.wantLbl.Size = new System.Drawing.Size(188, 29);
            this.wantLbl.TabIndex = 10;
            this.wantLbl.Text = "Currency I want:";
            this.wantLbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(347, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 31);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Font = new System.Drawing.Font("Consolas", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLbl.ForeColor = System.Drawing.Color.White;
            this.amountLbl.Location = new System.Drawing.Point(94, 166);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(94, 24);
            this.amountLbl.TabIndex = 12;
            this.amountLbl.Text = "Amount:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(58, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 31);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(390, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Amount:";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Verdana", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.Coral;
            this.titleLbl.Location = new System.Drawing.Point(92, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(402, 35);
            this.titleLbl.TabIndex = 15;
            this.titleLbl.Text = "CURRENCY CONVERTER";
            this.titleLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(637, 287);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.wantLbl);
            this.Controls.Add(this.haveLbl);
            this.Controls.Add(this.lblFxRate);
            this.Controls.Add(this.btnGetQuote);
            this.Controls.Add(this.haveCurrency);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox haveCurrency;
        private System.Windows.Forms.Button btnGetQuote;
        private System.Windows.Forms.Label lblFxRate;
        private System.Windows.Forms.Label haveLbl;
        private System.Windows.Forms.Label wantLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLbl;
    }
}

