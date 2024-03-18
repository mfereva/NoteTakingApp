using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notetitle.Visible = false;
            Title.Visible = false;
            noteLabel.Visible = false;
            Content.Visible = false;
            savedNotes.Visible = true;
            save.Visible = false;

            updateList();

        }

        private void updateList()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9NUMRJG; Initial Catalog=NoteDB; Integrated Security=True;"))
                {
                    sqlCon.Open();
                    string query = "SELECT * FROM Notes";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            string ID = reader["NoteID"].ToString();
                            string Title = reader["Title"].ToString();
                            string Content = reader["Content"].ToString();
                            string Timestamp = reader["Timestamp"].ToString();

                            ListViewItem item = new ListViewItem(Title);
                            item.SubItems.Add(Content);
                            item.SubItems.Add(Timestamp);
                            item.SubItems.Add(ID);
                            savedNotes.Items.Add(item);
                        }
                        reader.Close();
                    }
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while loading notes: " + ex.Message);
            }

        }
        private void create_Click(object sender, EventArgs e)
        {
            notetitle.Visible = true;
            Title.Visible = true;
            noteLabel.Visible = true;
            Content.Visible = true;
            save.Visible = true;


        }

        private void save_Click(object sender, EventArgs e)
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
                        DateTime timestamp = DateTime.Now;
                        string Content = this.Content.Text;
                        string Title = this.Title.Text;

                        sqlCon.Open();
                        string query = "INSERT INTO Notes (Content, Title, Timestamp) VALUES (@Content, @Title, GETDATE())";

                        using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                        {
                            cmd.Parameters.AddWithValue("@Content", Content);
                            cmd.Parameters.AddWithValue("@Title", Title);
                            cmd.Parameters.AddWithValue("@Timestamp", timestamp);
                            cmd.ExecuteNonQuery();
                        }


                    }

                    MessageBox.Show("Note saved successfully!");
                    Content.Clear();
                    Title.Clear();

                    savedNotes.Clear();
                    updateList();
                }

                catch (SqlException ex)
                {

                    MessageBox.Show("An error occurred while saving the note: " + ex.Message);
                }
            }

            
            
        }

        

        private void savedNotes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ListViewItem item = savedNotes.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    // Extract the information from the clicked item
                    string Title = item.SubItems[0].Text; // Assuming title is in the first column
                    string Content = item.SubItems[1].Text; // Assuming content is in the second column
                    string Timestamp = item.SubItems[2].Text; // Assuming timestamp is in the third column
                    int ID = Convert.ToInt32(item.SubItems[3].Text);

                    Form2 Form2 = new Form2(Title, DateTime.Parse(Timestamp), Content, ID);
                    Form2.Show();
                    this.Hide();
                }
            }
        }
    }
        
}
