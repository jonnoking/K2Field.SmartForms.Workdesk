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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnInit = new System.Windows.Forms.Button();
            this.txtDatabaseOwner = new System.Windows.Forms.TextBox();
            this.lblDatabaseOwner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTasksWorkdeskId = new System.Windows.Forms.TextBox();
            this.txtManagementWorkdeskId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(260, 93);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(115, 23);
            this.btnInit.TabIndex = 0;
            this.btnInit.Text = "Create Workdesk Database";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // txtDatabaseOwner
            // 
            this.txtDatabaseOwner.Location = new System.Drawing.Point(164, 58);
            this.txtDatabaseOwner.Name = "txtDatabaseOwner";
            this.txtDatabaseOwner.Size = new System.Drawing.Size(211, 20);
            this.txtDatabaseOwner.TabIndex = 2;
            this.txtDatabaseOwner.Text = "denallix\\k2service";
            // 
            // lblDatabaseOwner
            // 
            this.lblDatabaseOwner.AutoSize = true;
            this.lblDatabaseOwner.Location = new System.Drawing.Point(12, 61);
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
            this.label1.Size = new System.Drawing.Size(386, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "WARNING: This will attempt to drop your K2Workdesk database and recreate it.";
            // 
            // txtTasksWorkdeskId
            // 
            this.txtTasksWorkdeskId.Location = new System.Drawing.Point(164, 134);
            this.txtTasksWorkdeskId.Name = "txtTasksWorkdeskId";
            this.txtTasksWorkdeskId.ReadOnly = true;
            this.txtTasksWorkdeskId.Size = new System.Drawing.Size(211, 20);
            this.txtTasksWorkdeskId.TabIndex = 5;
            // 
            // txtManagementWorkdeskId
            // 
            this.txtManagementWorkdeskId.Location = new System.Drawing.Point(164, 169);
            this.txtManagementWorkdeskId.Name = "txtManagementWorkdeskId";
            this.txtManagementWorkdeskId.ReadOnly = true;
            this.txtManagementWorkdeskId.Size = new System.Drawing.Size(211, 20);
            this.txtManagementWorkdeskId.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tasks Workdesk Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Management Workdesk Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(387, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Be sure to close all existing database connections or manually drop the database";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 206);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtManagementWorkdeskId);
            this.Controls.Add(this.txtTasksWorkdeskId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDatabaseOwner);
            this.Controls.Add(this.txtDatabaseOwner);
            this.Controls.Add(this.btnInit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox txtTasksWorkdeskId;
        private System.Windows.Forms.TextBox txtManagementWorkdeskId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

