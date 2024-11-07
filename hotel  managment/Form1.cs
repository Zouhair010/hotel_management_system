using Microsoft.VisualBasic; // Namespace for Visual Basic functions
using MySql.Data.MySqlClient; // Namespace for MySQL database connectivity
using MySqlX.XDevAPI.Common; // Namespace for X DevAPI common classes
using System.Reflection.Metadata; // Namespace for handling metadata
using static System.Windows.Forms.VisualStyles.VisualStyleElement; // Namespace for Windows Forms visual styles
using System; // Basic namespace for common types
using System.Reflection.PortableExecutable;
using Google.Protobuf.WellKnownTypes; // Namespace for handling portable executable files

namespace hotel__managment // Namespace for hotel management application
{
    public partial class Hotel : Form // Partial class for the hotel form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=hotel_management;User ID=root;Password=1994z1025e;"); // Database connection string

        public Hotel() // Constructor for hotel class
        {
            InitializeComponent(); // Initialize form components
        }

        private void Form1_Load(object sender, EventArgs e) // Event handler for form load
        {

            // Setup custom date format for date pickers
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";

            connection.Open(); // Open database connection
            // SQL query to select client data from database
            string qry1 = "select Nom_Prenom,CIN,Adresse,Numero_Telephone,Date_Entrant,Date_Sortant,Numero_Chamber from clients;";
            MySqlCommand command1 = new MySqlCommand(qry1, connection); // Create command for the query
            MySqlDataReader reader1 = command1.ExecuteReader(); // Execute the query and get data reader
            while (reader1.Read()) // Read data from the reader
            {
                // Add each row of data to the DataGridView
                this.dataGridView1.Rows.Add(reader1[0], reader1[1], reader1[2], reader1[3], reader1[4], reader1[5], reader1[6]);
            }

            connection.Close(); // Close database connection
        }

        private void textBox6_TextChanged(object sender, EventArgs e) // Event handler for text box change
        {
            // Empty method for handling text changes in textBox6
        }

        private void btverifier_Click(object sender, EventArgs e) // Event handler for verifying available chambers
        {
            if (radioButton1.Checked) // Check if the first radio button is selected
            {

                connection.Open(); // Open database connection
                                   // SQL query to select available unique chambers
                string qry = "select Numero_Chamber from chamber where Typpe_Chamber = 'unique' and Etat_Chamber = 'dispo';";
                MySqlCommand command = new MySqlCommand(qry, connection); // Create command for the query
                MySqlDataReader reader = command.ExecuteReader(); // Execute the query
                var chamber_despo = new List<string> { "les chambers indeviduelle disponeble sont: " }; // List to hold available chambers
                if (reader.HasRows)
                {
                    while (reader.Read()) // Read data from the reader
                    {
                        string numChamber = reader.GetString(0); // Get chamber number
                        chamber_despo.Add(numChamber); // Add chamber number to list
                    }
                    connection.Close(); // Close database connection
                    string chambersString = string.Join(", ", chamber_despo); // Join list items for display
                    MessageBox.Show(chambersString); // Show available chambers in a message box
                }
                else
                {
                    MessageBox.Show("il n'y a pas de chamber individuelle disponible"); // Show available chambers in a message box
                }
                connection.Close(); // Close database connection

            }

            else if (radioButton2.Checked) // Check if the second radio button is selected
            {

                connection.Open(); // Open database connection
                                   // SQL query to select available family chambers
                string qry1 = "select Numero_Chamber from chamber where Typpe_Chamber = 'familial' and Etat_Chamber = 'dispo';";
                MySqlCommand command1 = new MySqlCommand(qry1, connection); // Create command for the query
                MySqlDataReader reader1 = command1.ExecuteReader(); // Execute the query
                var chamber_despo1 = new List<string> { "les chambers familialle disponeble sont  :" }; // List to hold available family chambers
                if (reader1.HasRows)
                {
                    while (reader1.Read()) // Read data from the reader
                    {
                        string numChamber1 = reader1.GetString(0); // Get chamber number
                        chamber_despo1.Add(numChamber1); // Add chamber number to list
                    }
                    connection.Close(); // Close database connection
                    string chambersString1 = string.Join(", ", chamber_despo1); // Join list items for display
                    MessageBox.Show(chambersString1); // Show available family chambers in a message box  
                }
                else
                {
                    MessageBox.Show("aucune chamber familiale n'est disponible"); // Show available chambers in a message box
                }
                connection.Close(); // Close database connection

            }
        }

        private void btreserver_Click(object sender, EventArgs e) // Event handler for reservation button click
        {
            int prix = 0; // Variable to hold price
            if (radioButton4.Checked) // Check if first price radio button is selected
            {
                if (txbnompren.Text != "" && txbcin.Text != "" && txbtel.Text != "" && txbaddres.Text != "" && txbnmchmbr.Text != "")
                {
                    prix = 70; // Set price for unique chamber
                    connection.Open(); // Open database connection
                                       // SQL command to insert new client reservation into the database
                    MySqlCommand command = new MySqlCommand("insert into clients(Nom_Prenom, CIN, Numero_Telephone, Adresse, Date_Entrant, Date_Sortant ,Numero_Chamber,prix) values('" + this.txbnompren.Text + "','" + this.txbcin.Text + "','" + this.txbtel.Text + "','" + this.txbaddres.Text + "','" + this.dateTimePicker1.Text + "','" + this.dateTimePicker2.Text + "','" + int.Parse(this.txbnmchmbr.Text) + "','" + prix + "')", connection);
                    command.ExecuteNonQuery(); // Execute the insert command
                                               // SQL command to update chamber status to 'indispo'
                    MySqlCommand command1 = new MySqlCommand("update chamber set Etat_Chamber='indispo' where Numero_Chamber=('" + int.Parse(this.txbnmchmbr.Text) + "')", connection);
                    command1.ExecuteNonQuery(); // Execute the update command
                    connection.Close(); // Close database connection
                    MessageBox.Show("resevation effectuer avec succes"); // Show success message
                }
                else
                {
                    MessageBox.Show("les information de client que vous avez saisies sont incompletes"); // Show success message
                }

            }
            else if (radioButton3.Checked) // Check if second price radio button is selected
            {
                if (txbnompren.Text != "" && txbcin.Text != "" && txbtel.Text != "" && txbaddres.Text != "" && txbnmchmbr.Text != "")
                {
                    prix = 150; // Set price for family chamber
                    connection.Open(); // Open database connection
                                       // SQL command to insert new client reservation into the database
                    MySqlCommand command = new MySqlCommand("insert into clients(Nom_Prenom, CIN, Numero_Telephone, Adresse, Date_Entrant, Date_Sortant ,Numero_Chamber,prix) values('" + this.txbnompren.Text + "','" + this.txbcin.Text + "','" + this.txbtel.Text + "','" + this.txbaddres.Text + "','" + this.dateTimePicker1.Text + "','" + this.dateTimePicker2.Text + "','" + int.Parse(this.txbnmchmbr.Text) + "','" + prix + "')", connection);
                    command.ExecuteNonQuery(); // Execute the insert command
                                               // SQL command to update chamber status to 'indispo'
                    MySqlCommand command1 = new MySqlCommand("update chamber set Etat_Chamber='indispo' where Numero_Chamber=('" + int.Parse(this.txbnmchmbr.Text) + "')", connection);
                    command1.ExecuteNonQuery(); // Execute the update command
                    connection.Close(); // Close database connection
                    MessageBox.Show("resevation effectuer avec succes"); // Show success message
                }
                else
                {
                    MessageBox.Show("les information de client que vous avez saisies sont incompletes"); // Show success message
                }
            }
            else
            {
                MessageBox.Show("vous devez saisir sont le type de chamber que le client souhaite reserver"); // Show success message
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) // Event handler for date picker value change
        {
            // Empty method for handling date changes
        }

        private void btfnreserv_Click(object sender, EventArgs e) // Event handler for finding reservations
        {

            connection.Open(); // Open database connection
                               // SQL query to select clients who are checking out today
                               //string qry2 = "select Nom_Prenom,CIN,Numero_Telephone,Numero_Chamber from clients where Date_Sortant = CURRENT_DATE();";
            string qry2 = "select c1.Nom_Prenom,c1.CIN,c1.Numero_Telephone,c1.Numero_Chamber from clients as c1 where c1.Date_Sortant = CURRENT_DATE() and not exists(select c2.Nom_Prenom, c2.CIN, c2.Numero_Telephone, c2.Numero_Chamber from clients as c2 where c1.Nom_Prenom <> c2.Nom_Prenom and c1.Date_Sortant <> c2.Date_Sortant and c1.Numero_Chamber = c2.Numero_Chamber and c2.Date_Entrant = CURRENT_DATE() );";
            MySqlCommand command2 = new MySqlCommand(qry2, connection); // Create command for the query
            MySqlDataReader reader2 = command2.ExecuteReader(); // Execute the query
            var clients = new List<string> { }; // List to hold clients
            var chambers = new List<string>();
            if (reader2.HasRows) // Check if there are any records #add Read() if doesn't work
            {
                while (reader2.Read()) // Read data from the reader
                {
                    //string client = reader2.GetString(0); // Get client information
                    int chamber = reader2.GetInt32(3);
                    clients.Add(reader2.GetString(0)); // Add client information to list
                    chambers.Add("" + chamber);

                }
                connection.Close(); // Close database connection
                string clientsString = string.Join("\n", clients); // Join client items for display
                MessageBox.Show(clientsString); // Show client information in a message box

                connection.Open(); // Open database connection
                foreach (string chamber in chambers)
                {
                    // SQL command to set chamber status to 'dispo'
                    MySqlCommand command = new MySqlCommand("update chamber set Etat_Chamber='dispo' where Numero_Chamber = '" + chamber + "' ", connection);
                    command.ExecuteNonQuery(); // Execute the update command                                     
                }
                connection.Close(); // Close database connection
            }
            else // No clients found
            {
                connection.Close(); // Close database connection
                MessageBox.Show("aucun client finir la reservation"); // Show message if no clients
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // Event handler for DataGridView cell click
        {
            // Empty method for handling cell clicks in DataGridView
        }

        private void btactualiser_Click(object sender, EventArgs e) // Event handler for refreshing DataGridView
        {

            this.dataGridView1.Rows.Clear(); // Clear existing rows in DataGridView
            connection.Open(); // Open database connection
                               // SQL query to select client data from database
            string qry1 = "select Nom_Prenom,CIN,Adresse,Numero_Telephone,Date_Entrant,Date_Sortant,Numero_Chamber from clients;";
            MySqlCommand command1 = new MySqlCommand(qry1, connection); // Create command for the query
            MySqlDataReader reader1 = command1.ExecuteReader(); // Execute the query
            if (reader1.HasRows) // Check if there are rows in the reader
            {
                while (reader1.Read()) // Read data from the reader
                {
                    this.dataGridView1.Rows.Add(reader1[0], reader1[1], reader1[2], reader1[3], reader1[4], reader1[5], reader1[6]); // Add rows to DataGridView
                }
                connection.Close(); // Close database connection
            }
            else // No clients found
            {
                connection.Close(); // Close database connection
                MessageBox.Show("il ya auccun client"); // Show message if no clients
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // Event handler for radio button 1 checked change
        {
            // Empty method for handling radio button change
        }

        private void label2_Click(object sender, EventArgs e) // Event handler for label click
        {
            // Empty method for handling label clicks
        }

        private void bttotal_Click(object sender, EventArgs e) // Event handler for total price button click
        {
            try
            {
                connection.Open(); // Open database connection
                // SQL query to get total price of today's reservations
                string qry = "select sum(prix) from clients where Date_Entrant = current_date();";
                MySqlCommand command = new MySqlCommand(qry, connection); // Create command for the query
                MySqlDataReader reader = command.ExecuteReader(); // Execute the query
                var total = new List<string> { "total des produits d'aujourdhui est :" }; // List to hold total price
                while (reader.Read()) // Read data from the reader
                {
                    decimal sum = reader.GetDecimal(0); // Get total price
                    total.Add(sum.ToString()); // Add total price to list
                }
                connection.Close(); // Close database connection
                string rotalString = string.Join("", total); // Join total items for display
                MessageBox.Show(rotalString); // Show total price in a message box

            }
            catch (Exception) // Catch any exceptions
            {
                connection.Close(); // Close connection on error
                MessageBox.Show("aucun produit pour aujourd'hui"); // Show error message
            }
        }

        private void txbdschmbr_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(100, Color.LightGray);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbaddres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbnompren_TextChanged(object sender, EventArgs e)
        {

        }
    }
}