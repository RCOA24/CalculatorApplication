
namespace CalculatorApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            this.txtboxinput1 = new System.Windows.Forms.TextBox();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.txtboxinput2 = new System.Windows.Forms.TextBox();
            this.btnEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Answer";
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.AutoSize = true;
            this.lblDisplayTotal.Location = new System.Drawing.Point(174, 157);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.Size = new System.Drawing.Size(117, 15);
            this.lblDisplayTotal.TabIndex = 3;
            this.lblDisplayTotal.Text = "______________________";
            // 
            // txtboxinput1
            // 
            this.txtboxinput1.Location = new System.Drawing.Point(179, 49);
            this.txtboxinput1.Name = "txtboxinput1";
            this.txtboxinput1.Size = new System.Drawing.Size(100, 23);
            this.txtboxinput1.TabIndex = 4;
            // 
            // cbOperator
            // 
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbOperator.Location = new System.Drawing.Point(191, 85);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(70, 23);
            this.cbOperator.TabIndex = 5;
            // 
            // txtboxinput2
            // 
            this.txtboxinput2.Location = new System.Drawing.Point(179, 123);
            this.txtboxinput2.Name = "txtboxinput2";
            this.txtboxinput2.Size = new System.Drawing.Size(100, 23);
            this.txtboxinput2.TabIndex = 6;
            this.txtboxinput2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(54, 207);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(237, 31);
            this.btnEqual.TabIndex = 7;
            this.btnEqual.Text = "Calculate";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 328);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.txtboxinput2);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.txtboxinput1);
            this.Controls.Add(this.lblDisplayTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDisplayTotal;
        private System.Windows.Forms.TextBox txtboxinput1;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.TextBox txtboxinput2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEqual;
    }
}

