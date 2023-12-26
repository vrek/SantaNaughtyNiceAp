namespace SantaNaughtyNiceUI
{
    partial class frmRecordActivity
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
            label1 = new Label();
            label2 = new Label();
            cmbFirstName = new ComboBox();
            cmbActivity = new ComboBox();
            btnOK = new Button();
            btnCancel = new Button();
            cmbLastName = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 41);
            label1.Name = "label1";
            label1.Size = new Size(166, 30);
            label1.TabIndex = 0;
            label1.Text = "Child First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(130, 125);
            label2.Name = "label2";
            label2.Size = new Size(81, 30);
            label2.TabIndex = 1;
            label2.Text = "Activity";
            // 
            // cmbFirstName
            // 
            cmbFirstName.AllowDrop = true;
            cmbFirstName.FormattingEnabled = true;
            cmbFirstName.Location = new Point(239, 48);
            cmbFirstName.Name = "cmbFirstName";
            cmbFirstName.Size = new Size(121, 23);
            cmbFirstName.TabIndex = 1;
            cmbFirstName.SelectedIndexChanged += cngFirstName;
            // 
            // cmbActivity
            // 
            cmbActivity.AllowDrop = true;
            cmbActivity.FormattingEnabled = true;
            cmbActivity.Location = new Point(239, 134);
            cmbActivity.Name = "cmbActivity";
            cmbActivity.Size = new Size(121, 23);
            cmbActivity.TabIndex = 2;
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(57, 178);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 48);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(251, 178);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(143, 48);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbLastName
            // 
            cmbLastName.AllowDrop = true;
            cmbLastName.FormattingEnabled = true;
            cmbLastName.Location = new Point(239, 89);
            cmbLastName.Name = "cmbLastName";
            cmbLastName.Size = new Size(121, 23);
            cmbLastName.TabIndex = 6;
            cmbLastName.SelectionChangeCommitted += cngLastName;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 82);
            label3.Name = "label3";
            label3.Size = new Size(165, 30);
            label3.TabIndex = 5;
            label3.Text = "Child Last Name";
            // 
            // frmRecordActivity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 287);
            Controls.Add(cmbLastName);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(cmbActivity);
            Controls.Add(cmbFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRecordActivity";
            Text = "frmRecordActivity";
            Load += frmRecordActivityLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbFirstName;
        private ComboBox cmbActivity;
        private Button btnOK;
        private Button btnCancel;
        private ComboBox cmbLastName;
        private Label label3;
    }
}