
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.fromLbl = new System.Windows.Forms.Label();
            this.amountUsd = new System.Windows.Forms.TextBox();
            this.toLbl = new System.Windows.Forms.Label();
            this.toCurrency = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Verdana", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.Coral;
            this.titleLbl.Location = new System.Drawing.Point(111, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(402, 35);
            this.titleLbl.TabIndex = 15;
            this.titleLbl.Text = "CURRENCY CONVERTER";
            this.titleLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // fromLbl
            // 
            this.fromLbl.AutoSize = true;
            this.fromLbl.Location = new System.Drawing.Point(78, 97);
            this.fromLbl.Name = "fromLbl";
            this.fromLbl.Size = new System.Drawing.Size(123, 25);
            this.fromLbl.TabIndex = 16;
            this.fromLbl.Text = "From USD$";
            // 
            // amountUsd
            // 
            this.amountUsd.Location = new System.Drawing.Point(208, 94);
            this.amountUsd.Name = "amountUsd";
            this.amountUsd.Size = new System.Drawing.Size(100, 31);
            this.amountUsd.TabIndex = 17;
            this.amountUsd.TextChanged += new System.EventHandler(this.amountUsd_TextChanged);
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.Location = new System.Drawing.Point(35, 142);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(167, 25);
            this.toLbl.TabIndex = 18;
            this.toLbl.Text = "Currency I want:";
            // 
            // toCurrency
            // 
            this.toCurrency.Location = new System.Drawing.Point(208, 139);
            this.toCurrency.Name = "toCurrency";
            this.toCurrency.Size = new System.Drawing.Size(100, 31);
            this.toCurrency.TabIndex = 19;
            this.toCurrency.TextChanged += new System.EventHandler(this.toCurrency_TextChanged);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(362, 83);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(123, 52);
            this.calculate.TabIndex = 20;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.BackColor = System.Drawing.Color.LightGray;
            this.resultLbl.Location = new System.Drawing.Point(420, 163);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 25);
            this.resultLbl.TabIndex = 21;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(366, 147);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 23);
            this.result.TabIndex = 22;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(637, 287);
            this.Controls.Add(this.result);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.toCurrency);
            this.Controls.Add(this.toLbl);
            this.Controls.Add(this.amountUsd);
            this.Controls.Add(this.fromLbl);
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label fromLbl;
        private System.Windows.Forms.TextBox amountUsd;
        private System.Windows.Forms.Label toLbl;
        private System.Windows.Forms.TextBox toCurrency;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Label result;
    }
}

