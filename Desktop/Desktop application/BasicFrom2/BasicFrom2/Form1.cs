namespace BasicFrom2
{
    public partial class Form1 : Form
    {
        private int nextID = 1;

        public Form1()
        {
            InitializeComponent();

            // Add countries to ComboBox
            Country.Items.Add("Nepal");
            Country.Items.Add("India");
            Country.Items.Add("China");
            Country.Items.Add("USA");
            Country.Items.Add("UK");

            // Select first country
            Country.SelectedIndex = 0;

            // Create DataGridView columns
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Contact", "Contact");
            dataGridView1.Columns.Add("Gender", "Gender");
            dataGridView1.Columns.Add("Country", "Country");

            // Display first ID
            txtID.Text = nextID.ToString();
        }

        // Add button
        private void Add_Click(object sender, EventArgs e)
        {
            // Check name
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your name.");
                txtName.Focus();
                return;
            }

            // Check email
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your email.");
                txtEmail.Focus();
                return;
            }

            // Check contact
            if (txtContact.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your contact number.");
                txtContact.Focus();
                return;
            }

            // Get gender
            string gender = "";

            if (Male.Checked)
            {
                gender = "Male";
            }
            else if (Female.Checked)
            {
                gender = "Female";
            }

            // Check gender
            if (gender == "")
            {
                MessageBox.Show("Please select your gender.");
                return;
            }

            // Create User object
            User user = new User();

            // Store form data inside User object
            user.ID = nextID;
            user.Name = txtName.Text;
            user.Email = txtEmail.Text;
            user.Contact = txtContact.Text;
            user.Gender = gender;
            user.Country = Country.Text;

            // Add User object data to DataGridView
            dataGridView1.Rows.Add(
                user.ID,
                user.Name,
                user.Email,
                user.Contact,
                user.Gender,
                user.Country
            );

            MessageBox.Show("User added successfully!");

            // Increase ID
            nextID++;

            // Show new ID
            txtID.Text = nextID.ToString();

            // Clear form
            ClearFields();
        }

        // Clear button
        private void button2_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Clear all input fields
        private void ClearFields()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtContact.Clear();

            Male.Checked = false;
            Female.Checked = false;

            if (Country.Items.Count > 0)
            {
                Country.SelectedIndex = 0;
            }

            txtName.Focus();
        }

        // Label click event
        private void label1_Click(object sender, EventArgs e)
        {
        }

        // Name textbox event
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        // Male radio button event
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                txtID.Text = row.Cells["ID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtContact.Text = row.Cells["Contact"].Value.ToString();

                string gender = row.Cells["Gender"].Value.ToString();
                Male.Checked = (gender == "Male");
                Female.Checked = (gender == "Female");

                Country.Text = row.Cells["Country"].Value.ToString();
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                row.Cells["ID"].Value = txtID.Text;
                row.Cells["Name"].Value = txtName.Text;
                row.Cells["Email"].Value = txtEmail.Text;
                row.Cells["Contact"].Value = txtContact.Text;

                string gender = Male.Checked ? "Male" : (Female.Checked ? "Female" : "");
                row.Cells["Gender"].Value = gender;

                row.Cells["Country"].Value = Country.Text;

                MessageBox.Show("Row updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}