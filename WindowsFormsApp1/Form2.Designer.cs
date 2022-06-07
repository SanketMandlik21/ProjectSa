namespace WindowsFormsApp1
{
    partial class Form2
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
            this.txtEMP_ID = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.MaskedTextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblEMP_ID = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEMP_ID
            // 
            this.txtEMP_ID.Location = new System.Drawing.Point(487, 77);
            this.txtEMP_ID.Name = "txtEMP_ID";
            this.txtEMP_ID.Size = new System.Drawing.Size(159, 22);
            this.txtEMP_ID.TabIndex = 0;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(487, 135);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(159, 22);
            this.txtEmpName.TabIndex = 1;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(487, 198);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(159, 22);
            this.txtSalary.TabIndex = 2;
            // 
            // lblEMP_ID
            // 
            this.lblEMP_ID.AutoSize = true;
            this.lblEMP_ID.Location = new System.Drawing.Point(375, 77);
            this.lblEMP_ID.Name = "lblEMP_ID";
            this.lblEMP_ID.Size = new System.Drawing.Size(56, 16);
            this.lblEMP_ID.TabIndex = 3;
            this.lblEMP_ID.Text = "EMP_ID";
            this.lblEMP_ID.Click += new System.EventHandler(this.lblEMP_ID_Click);
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(374, 138);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(72, 16);
            this.lblEmpName.TabIndex = 4;
            this.lblEmpName.Text = "EmpName";
            this.lblEmpName.Click += new System.EventHandler(this.lblEmpName_Click);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(380, 204);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(46, 16);
            this.lblSalary.TabIndex = 5;
            this.lblSalary.Text = "Salary";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(487, 293);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(571, 293);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.lblEMP_ID);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEMP_ID);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEMP_ID;
        private System.Windows.Forms.MaskedTextBox txtEmpName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblEMP_ID;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
    }
}