namespace SantaNaughtyNiceUI
{
    partial class frmMain
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
            label1 = new Label();
            FirstNameEntry = new TextBox();
            LastNameEntry = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lblYearlyANNS = new TextBox();
            lblHistoricalANNS = new TextBox();
            label4 = new Label();
            btnLookUpChild = new Button();
            btnAddChild = new Button();
            btnRecordActivity = new Button();
            btnChristmasList = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 41);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // FirstNameEntry
            // 
            FirstNameEntry.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirstNameEntry.Location = new Point(196, 33);
            FirstNameEntry.Name = "FirstNameEntry";
            FirstNameEntry.Size = new Size(185, 33);
            FirstNameEntry.TabIndex = 1;
            // 
            // LastNameEntry
            // 
            LastNameEntry.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastNameEntry.Location = new Point(196, 82);
            LastNameEntry.Name = "LastNameEntry";
            LastNameEntry.Size = new Size(185, 33);
            LastNameEntry.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 90);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 134);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 4;
            label3.Text = "YearlyANNS";
            // 
            // lblYearlyANNS
            // 
            lblYearlyANNS.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYearlyANNS.Location = new Point(196, 134);
            lblYearlyANNS.Name = "lblYearlyANNS";
            lblYearlyANNS.Size = new Size(185, 33);
            lblYearlyANNS.TabIndex = 5;
            // 
            // lblHistoricalANNS
            // 
            lblHistoricalANNS.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHistoricalANNS.Location = new Point(196, 191);
            lblHistoricalANNS.Name = "lblHistoricalANNS";
            lblHistoricalANNS.Size = new Size(185, 33);
            lblHistoricalANNS.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 194);
            label4.Name = "label4";
            label4.Size = new Size(146, 25);
            label4.TabIndex = 6;
            label4.Text = "Historical ANNS";
            // 
            // btnLookUpChild
            // 
            btnLookUpChild.Location = new Point(105, 238);
            btnLookUpChild.Name = "btnLookUpChild";
            btnLookUpChild.Size = new Size(196, 68);
            btnLookUpChild.TabIndex = 8;
            btnLookUpChild.Text = "Look Up Child";
            btnLookUpChild.UseVisualStyleBackColor = true;
            btnLookUpChild.Click += btnLookUpChild_Click;
            // 
            // btnAddChild
            // 
            btnAddChild.Location = new Point(529, 33);
            btnAddChild.Name = "btnAddChild";
            btnAddChild.Size = new Size(196, 68);
            btnAddChild.TabIndex = 9;
            btnAddChild.Text = "Add Child";
            btnAddChild.UseVisualStyleBackColor = true;
            btnAddChild.Click += btnAddChild_Click;
            // 
            // btnRecordActivity
            // 
            btnRecordActivity.Location = new Point(529, 134);
            btnRecordActivity.Name = "btnRecordActivity";
            btnRecordActivity.Size = new Size(196, 68);
            btnRecordActivity.TabIndex = 10;
            btnRecordActivity.Text = "Record Activity";
            btnRecordActivity.UseVisualStyleBackColor = true;
            btnRecordActivity.Click += btnRecordActivity_Click;
            // 
            // btnChristmasList
            // 
            btnChristmasList.Location = new Point(529, 238);
            btnChristmasList.Name = "btnChristmasList";
            btnChristmasList.Size = new Size(196, 68);
            btnChristmasList.TabIndex = 11;
            btnChristmasList.Text = "Christmas List Gerneration";
            btnChristmasList.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 350);
            Controls.Add(btnChristmasList);
            Controls.Add(btnRecordActivity);
            Controls.Add(btnAddChild);
            Controls.Add(btnLookUpChild);
            Controls.Add(lblHistoricalANNS);
            Controls.Add(label4);
            Controls.Add(lblYearlyANNS);
            Controls.Add(label3);
            Controls.Add(LastNameEntry);
            Controls.Add(label2);
            Controls.Add(FirstNameEntry);
            Controls.Add(label1);
            Name = "frmMain";
            Text = "Santa Naughty Nice Tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox FirstNameEntry;
        private TextBox LastNameEntry;
        private Label label2;
        private Label label3;
        private TextBox lblYearlyANNS;
        private TextBox lblHistoricalANNS;
        private Label label4;
        private Button btnLookUpChild;
        private Button btnAddChild;
        private Button btnRecordActivity;
        private Button btnChristmasList;
    }
}
