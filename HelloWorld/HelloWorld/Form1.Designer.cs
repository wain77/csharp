namespace HelloWorld
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
            this.lblGivenName = new System.Windows.Forms.Label();
            this.txtboxGivenName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtboxSurname = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGivenName
            // 
            this.lblGivenName.AutoSize = true;
            this.lblGivenName.Location = new System.Drawing.Point(12, 9);
            this.lblGivenName.Name = "lblGivenName";
            this.lblGivenName.Size = new System.Drawing.Size(57, 13);
            this.lblGivenName.TabIndex = 0;
            this.lblGivenName.Text = "Forename:";
            this.lblGivenName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGivenName.Click += new System.EventHandler(this.lblGivenName_Click);
            // 
            // txtboxGivenName
            // 
            this.txtboxGivenName.Location = new System.Drawing.Point(75, 6);
            this.txtboxGivenName.Name = "txtboxGivenName";
            this.txtboxGivenName.Size = new System.Drawing.Size(169, 20);
            this.txtboxGivenName.TabIndex = 1;
            this.txtboxGivenName.TextChanged += new System.EventHandler(this.txtboxGivenName_TextChanged);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(250, 9);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname:";
            this.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSurname.Click += new System.EventHandler(this.lblGivenName_Click);
            // 
            // txtboxSurname
            // 
            this.txtboxSurname.Location = new System.Drawing.Point(313, 6);
            this.txtboxSurname.Name = "txtboxSurname";
            this.txtboxSurname.Size = new System.Drawing.Size(169, 20);
            this.txtboxSurname.TabIndex = 1;
            this.txtboxSurname.TextChanged += new System.EventHandler(this.txtboxGivenName_TextChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(488, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check now";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 576);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtboxSurname);
            this.Controls.Add(this.txtboxGivenName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblGivenName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGivenName;
        private System.Windows.Forms.TextBox txtboxGivenName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtboxSurname;
        private System.Windows.Forms.Button btnCheck;
    }
}

