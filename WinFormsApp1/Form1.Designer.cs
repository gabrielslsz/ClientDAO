namespace WinFormsApp1
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
            label1 = new Label();
            btnAddCliente = new Button();
            button1 = new Button();
            button2 = new Button();
            clientsTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)clientsTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 31);
            label1.TabIndex = 0;
            label1.Text = "List of Clients";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAddCliente
            // 
            btnAddCliente.Location = new Point(12, 61);
            btnAddCliente.Name = "btnAddCliente";
            btnAddCliente.Size = new Size(94, 29);
            btnAddCliente.TabIndex = 1;
            btnAddCliente.Text = "Add Client";
            btnAddCliente.UseVisualStyleBackColor = true;
            btnAddCliente.Click += btnAddCliente_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(561, 63);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Edit Client";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(661, 63);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Delete";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // clientsTable
            // 
            clientsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clientsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsTable.Location = new Point(4, 99);
            clientsTable.MultiSelect = false;
            clientsTable.Name = "clientsTable";
            clientsTable.RowHeadersVisible = false;
            clientsTable.RowHeadersWidth = 51;
            clientsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientsTable.Size = new Size(788, 343);
            clientsTable.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 449);
            Controls.Add(clientsTable);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAddCliente);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Clients Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)clientsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAddCliente;
        private Button button1;
        private Button button2;
        private DataGridView clientsTable;
    }
}
