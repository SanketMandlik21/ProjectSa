namespace WindowsFormsApp1
{
    partial class Form5
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
            this.btnCreateFo = new System.Windows.Forms.Button();
            this.btnCreateFi = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblEnterDeparment = new System.Windows.Forms.Label();
            this.lblDeparmentName = new System.Windows.Forms.Label();
            this.lblDeparmentLoction = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreateFo
            // 
            this.btnCreateFo.Location = new System.Drawing.Point(631, 91);
            this.btnCreateFo.Name = "btnCreateFo";
            this.btnCreateFo.Size = new System.Drawing.Size(147, 23);
            this.btnCreateFo.TabIndex = 0;
            this.btnCreateFo.Text = "Create Folder";
            this.btnCreateFo.UseVisualStyleBackColor = true;
            this.btnCreateFo.Click += new System.EventHandler(this.btnCreateFo_Click);
            // 
            // btnCreateFi
            // 
            this.btnCreateFi.Location = new System.Drawing.Point(631, 170);
            this.btnCreateFi.Name = "btnCreateFi";
            this.btnCreateFi.Size = new System.Drawing.Size(147, 23);
            this.btnCreateFi.TabIndex = 1;
            this.btnCreateFi.Text = "Create File";
            this.btnCreateFi.UseVisualStyleBackColor = true;
            this.btnCreateFi.Click += new System.EventHandler(this.btnCreateFi_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(415, 268);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(100, 23);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(553, 268);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(92, 23);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // lblEnterDeparment
            // 
            this.lblEnterDeparment.AutoSize = true;
            this.lblEnterDeparment.Location = new System.Drawing.Point(166, 76);
            this.lblEnterDeparment.Name = "lblEnterDeparment";
            this.lblEnterDeparment.Size = new System.Drawing.Size(108, 16);
            this.lblEnterDeparment.TabIndex = 4;
            this.lblEnterDeparment.Text = "Enter Deparment";
            // 
            // lblDeparmentName
            // 
            this.lblDeparmentName.AutoSize = true;
            this.lblDeparmentName.Location = new System.Drawing.Point(166, 133);
            this.lblDeparmentName.Name = "lblDeparmentName";
            this.lblDeparmentName.Size = new System.Drawing.Size(114, 16);
            this.lblDeparmentName.TabIndex = 5;
            this.lblDeparmentName.Text = "Deparment Name";
            // 
            // lblDeparmentLoction
            // 
            this.lblDeparmentLoction.AutoSize = true;
            this.lblDeparmentLoction.Location = new System.Drawing.Point(166, 201);
            this.lblDeparmentLoction.Name = "lblDeparmentLoction";
            this.lblDeparmentLoction.Size = new System.Drawing.Size(128, 16);
            this.lblDeparmentLoction.TabIndex = 6;
            this.lblDeparmentLoction.Text = "Deparment Location";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(308, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(308, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(308, 195);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 22);
            this.textBox3.TabIndex = 9;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDeparmentLoction);
            this.Controls.Add(this.lblDeparmentName);
            this.Controls.Add(this.lblEnterDeparment);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnCreateFi);
            this.Controls.Add(this.btnCreateFo);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFo;
        private System.Windows.Forms.Button btnCreateFi;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblEnterDeparment;
        private System.Windows.Forms.Label lblDeparmentName;
        private System.Windows.Forms.Label lblDeparmentLoction;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}