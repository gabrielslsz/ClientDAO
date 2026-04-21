namespace WinFormsApp1
{
    partial class CreateEditForm
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
            lbTitle = new Label();
            label1 = new Label();
            lbID = new Label();
            lbLastName = new Label();
            tbFirstName = new TextBox();
            lbEmail = new Label();
            lbPhone = new Label();
            lbAdress = new Label();
            tbLastName = new TextBox();
            tbEmail = new TextBox();
            tbPhone = new TextBox();
            tbAdress = new TextBox();
            lbFirstName = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AllowDrop = true;
            lbTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(12, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(776, 25);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Create Client";
            lbTitle.TextAlign = ContentAlignment.TopCenter;
            lbTitle.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 119);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "Client ID";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(415, 176);
            lbID.Name = "lbID";
            lbID.Size = new Size(0, 20);
            lbID.TabIndex = 2;
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Location = new Point(101, 182);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(79, 20);
            lbLastName.TabIndex = 3;
            lbLastName.Text = "Last Name";
            lbLastName.Click += label2_Click;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(225, 146);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(348, 27);
            tbFirstName.TabIndex = 4;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(101, 212);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 6;
            lbEmail.Text = "Email";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(101, 245);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(50, 20);
            lbPhone.TabIndex = 7;
            lbPhone.Text = "Phone";
            // 
            // lbAdress
            // 
            lbAdress.AutoSize = true;
            lbAdress.Location = new Point(101, 281);
            lbAdress.Name = "lbAdress";
            lbAdress.Size = new Size(62, 20);
            lbAdress.TabIndex = 8;
            lbAdress.Text = "Address";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(225, 179);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(348, 27);
            tbLastName.TabIndex = 9;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(226, 212);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(348, 27);
            tbEmail.TabIndex = 10;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(225, 245);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(348, 27);
            tbPhone.TabIndex = 11;
            // 
            // tbAdress
            // 
            tbAdress.Location = new Point(225, 278);
            tbAdress.Name = "tbAdress";
            tbAdress.Size = new Size(348, 27);
            tbAdress.TabIndex = 12;
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Location = new Point(101, 153);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(80, 20);
            lbFirstName.TabIndex = 13;
            lbFirstName.Text = "First Name";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(235, 323);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 31);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(365, 323);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 31);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 370);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lbFirstName);
            Controls.Add(tbAdress);
            Controls.Add(tbPhone);
            Controls.Add(tbEmail);
            Controls.Add(tbLastName);
            Controls.Add(lbAdress);
            Controls.Add(lbPhone);
            Controls.Add(lbEmail);
            Controls.Add(tbFirstName);
            Controls.Add(lbLastName);
            Controls.Add(lbID);
            Controls.Add(label1);
            Controls.Add(lbTitle);
            Name = "CreateEditForm";
            Text = "Create Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label label1;
        private Label lbID;
        private Label lbLastName;
        private TextBox tbFirstName;
        private Label lbEmail;
        private Label lbPhone;
        private Label lbAdress;
        private TextBox tbLastName;
        private TextBox tbEmail;
        private TextBox tbPhone;
        private TextBox tbAdress;
        private Label lbFirstName;
        private Button btnSave;
        private Button btnCancel;
    }
}