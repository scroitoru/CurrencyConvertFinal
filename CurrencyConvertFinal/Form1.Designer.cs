
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
            this.titleLbl.Location = new System.Drawing.Point(83, 7);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(304, 26);
            this.titleLbl.TabIndex = 15;
            this.titleLbl.Text = "CURRENCY CONVERTER";
            this.titleLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // fromLbl
            // 
            this.fromLbl.AutoSize = true;
            this.fromLbl.ForeColor = System.Drawing.Color.Coral;
            this.fromLbl.Location = new System.Drawing.Point(58, 78);
            this.fromLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fromLbl.Name = "fromLbl";
            this.fromLbl.Size = new System.Drawing.Size(41, 20);
            this.fromLbl.TabIndex = 16;
            this.fromLbl.Text = "US$";
            // 
            // amountUsd
            // 
            this.amountUsd.Location = new System.Drawing.Point(156, 75);
            this.amountUsd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.amountUsd.Name = "amountUsd";
            this.amountUsd.Size = new System.Drawing.Size(76, 26);
            this.amountUsd.TabIndex = 17;
            this.amountUsd.TextChanged += new System.EventHandler(this.amountUsd_TextChanged);
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.ForeColor = System.Drawing.Color.Coral;
            this.toLbl.Location = new System.Drawing.Point(29, 117);
            this.toLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(123, 20);
            this.toLbl.TabIndex = 18;
            this.toLbl.Text = "Currency I want:";
            // 
            // toCurrency
            // 
            this.toCurrency.Location = new System.Drawing.Point(156, 117);
            this.toCurrency.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toCurrency.Name = "toCurrency";
            this.toCurrency.Size = new System.Drawing.Size(76, 26);
            this.toCurrency.TabIndex = 19;
            this.toCurrency.TextChanged += new System.EventHandler(this.toCurrency_TextChanged);
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.Linen;
            this.calculate.ForeColor = System.Drawing.Color.Coral;
            this.calculate.Location = new System.Drawing.Point(272, 66);
            this.calculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(92, 42);
            this.calculate.TabIndex = 20;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.BackColor = System.Drawing.Color.LightGray;
            this.resultLbl.Location = new System.Drawing.Point(315, 130);
            this.resultLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 20);
            this.resultLbl.TabIndex = 21;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.Linen;
            this.result.ForeColor = System.Drawing.SystemColors.ControlText;
            this.result.Location = new System.Drawing.Point(279, 114);
            this.result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(75, 31);
            this.result.TabIndex = 22;
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(478, 230);
            this.Controls.Add(this.result);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.toCurrency);
            this.Controls.Add(this.toLbl);
            this.Controls.Add(this.amountUsd);
            this.Controls.Add(this.fromLbl);
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Currency Converter";
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

