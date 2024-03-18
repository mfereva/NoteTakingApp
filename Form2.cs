using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NoteTakingApp
{
    public partial class Form2 : Form
    {
        private string title;
        private DateTime timepstamp;
        private string content;
        private int ID;
        public Form2(string title, DateTime timestamp, string content, int iD)
        {
            InitializeComponent();
            this.title = title;
            this.timepstamp = timestamp;
            Title.Text = this.title;
            Content.Text = content;
            this.content = content;
            created.Text = "Created on: " + timestamp.ToString();
            ID = iD;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (Title.Text == String.Empty)
            {
                MessageBox.Show("Please Enter a title :) ");
            }
            else
            {

                try
                {
                    using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9NUMRJG; Initial Catalog=NoteDB; Integrated Security=True;"))
                    {
                        sqlCon.Open();

                        string query = "UPDATE Notes SET Title = @newTitle, Content = @newContent WHERE NoteID = @NoteID";

                        using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                        {

                            cmd.Parameters.AddWithValue("@NoteID", ID);
                            cmd.Parameters.AddWithValue("@newTitle", Title.Text);
                            cmd.Parameters.AddWithValue("@newContent", Content.Text);
                            cmd.ExecuteNonQuery();
                        }

                    }

                    MessageBox.Show("Note updated successfully!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while loading notes: " + ex.Message);
                }
            }
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            Hide();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9NUMRJG; Initial Catalog=NoteDB; Integrated Security=True;"))
                {
                    sqlCon.Open();

                    string query = "DELETE From Notes Where NoteID = @NoteID";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {

                        cmd.Parameters.AddWithValue("@NoteID", ID);
                
                        cmd.ExecuteNonQuery();
                    }

                    Form1 Form1 = new Form1();
                    Form1.Show();
                    Hide();

                }

                MessageBox.Show("Note deleted successfully!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while loading notes: " + ex.Message);
            }

          

        }
    }
}
