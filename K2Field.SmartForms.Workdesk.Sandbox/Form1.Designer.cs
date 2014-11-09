namespace K2Field.SmartForms.Workdesk.Sandbox
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
            this.btnInit = new System.Windows.Forms.Button();
            this.txtDatabaseOwner = new System.Windows.Forms.TextBox();
            this.lblDatabaseOwner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(236, 70);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(115, 23);
            this.btnInit.TabIndex = 0;
            this.btnInit.Text = "Create Workdesk Database";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // txtDatabaseOwner
            // 
            this.txtDatabaseOwner.Location = new System.Drawing.Point(164, 35);
            this.txtDatabaseOwner.Name = "txtDatabaseOwner";
            this.txtDatabaseOwner.Size = new System.Drawing.Size(187, 20);
            this.txtDatabaseOwner.TabIndex = 2;
            this.txtDatabaseOwner.Text = "denallix\\k2service";
            // 
            // lblDatabaseOwner
            // 
            this.lblDatabaseOwner.AutoSize = true;
            this.lblDatabaseOwner.Location = new System.Drawing.Point(12, 38);
            this.lblDatabaseOwner.Name = "lblDatabaseOwner";
            this.lblDatabaseOwner.Size = new System.Drawing.Size(90, 13);
            this.lblDatabaseOwner.TabIndex = 3;
            this.lblDatabaseOwner.Text = "Database Owner:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "WARNING: This will drop your Workdesk database and recreate it.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 102);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDatabaseOwner);
            this.Controls.Add(this.txtDatabaseOwner);
            this.Controls.Add(this.btnInit);
            this.Name = "Form1";
            this.Text = "Provision Workdesk Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.TextBox txtDatabaseOwner;
        private System.Windows.Forms.Label lblDatabaseOwner;
        private System.Windows.Forms.Label label1;
    }
}

