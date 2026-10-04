namespace BasicFrom2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;

        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtContact;

        private RadioButton Male;
        private RadioButton Female;

        private ComboBox Country;

        private Button Add;
        private Button button2;

        private DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            Edit = new Button();
            txtID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            Add = new Button();
            Country = new ComboBox();
            Female = new RadioButton();
            Male = new RadioButton();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            Update = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 497);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(727, 410);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.InactiveCaption;
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(360, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(367, 410);
            panel5.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(367, 410);
            dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(Update);
            panel4.Controls.Add(Edit);
            panel4.Controls.Add(txtID);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(Add);
            panel4.Controls.Add(Country);
            panel4.Controls.Add(Female);
            panel4.Controls.Add(Male);
            panel4.Controls.Add(txtContact);
            panel4.Controls.Add(txtEmail);
            panel4.Controls.Add(txtName);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(360, 410);
            panel4.TabIndex = 0;
            // 
            // Edit
            // 
            Edit.Location = new Point(281, 346);
            Edit.Name = "Edit";
            Edit.Size = new Size(71, 29);
            Edit.TabIndex = 15;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(121, 40);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(183, 27);
            txtID.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 295);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 14;
            label7.Text = "Country :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 243);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 13;
            label6.Text = "Gender :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 197);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 12;
            label5.Text = "Contact no :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 148);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 11;
            label4.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 98);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 10;
            label3.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 43);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 9;
            label2.Text = "ID :";
            // 
            // button2
            // 
            button2.Location = new Point(121, 346);
            button2.Name = "button2";
            button2.Size = new Size(77, 27);
            button2.TabIndex = 8;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Add
            // 
            Add.Location = new Point(46, 346);
            Add.Name = "Add";
            Add.Size = new Size(69, 29);
            Add.TabIndex = 7;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Country
            // 
            Country.DropDownStyle = ComboBoxStyle.DropDownList;
            Country.FormattingEnabled = true;
            Country.Location = new Point(121, 294);
            Country.Name = "Country";
            Country.Size = new Size(183, 28);
            Country.TabIndex = 6;
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.Location = new Point(220, 243);
            Female.Name = "Female";
            Female.Size = new Size(78, 24);
            Female.TabIndex = 5;
            Female.TabStop = true;
            Female.Text = "Female";
            Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            Male.AutoSize = true;
            Male.Location = new Point(135, 243);
            Male.Name = "Male";
            Male.Size = new Size(63, 24);
            Male.TabIndex = 4;
            Male.TabStop = true;
            Male.Text = "Male";
            Male.UseVisualStyleBackColor = true;
            Male.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(121, 190);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(183, 27);
            txtContact.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(121, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(121, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(183, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(727, 87);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(148, 28);
            label1.Name = "label1";
            label1.Size = new Size(429, 46);
            label1.TabIndex = 0;
            label1.Text = "Welcome to User Info page";
            label1.Click += label1_Click;
            // 
            // Update
            // 
            Update.Location = new Point(203, 344);
            Update.Name = "Update";
            Update.Size = new Size(72, 29);
            Update.TabIndex = 16;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 497);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Information";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Edit;
        private Button Update;
    }
}