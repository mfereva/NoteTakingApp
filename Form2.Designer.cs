namespace NoteTakingApp
{
    partial class Form2
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
            this.notetitle = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.Content = new System.Windows.Forms.RichTextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.created = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notetitle
            // 
            this.notetitle.AutoSize = true;
            this.notetitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.notetitle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notetitle.Location = new System.Drawing.Point(42, 55);
            this.notetitle.Name = "notetitle";
            this.notetitle.Size = new System.Drawing.Size(79, 19);
            this.notetitle.TabIndex = 15;
            this.notetitle.Text = "Note Title:";
            this.notetitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(42, 87);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(46, 19);
            this.noteLabel.TabIndex = 14;
            this.noteLabel.Text = "Note:";
            this.noteLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Content
            // 
            this.Content.AccessibleDescription = "begin your note here";
            this.Content.BackColor = System.Drawing.SystemColors.Info;
            this.Content.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Content.Location = new System.Drawing.Point(36, 109);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(471, 86);
            this.Content.TabIndex = 13;
            this.Content.Text = "";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.Info;
            this.Title.Location = new System.Drawing.Point(127, 54);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(380, 20);
            this.Title.TabIndex = 16;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(57, 221);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 17;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(138, 221);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 18;
            this.delete.Text = "Delete Note";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(219, 221);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(75, 23);
            this.goBack.TabIndex = 19;
            this.goBack.Text = "Go Back";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // created
            // 
            this.created.AutoSize = true;
            this.created.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.created.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.created.Location = new System.Drawing.Point(42, 20);
            this.created.Name = "created";
            this.created.Size = new System.Drawing.Size(83, 19);
            this.created.TabIndex = 21;
            this.created.Text = "Timestamp";
            this.created.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 280);
            this.Controls.Add(this.created);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.notetitle);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.Content);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label notetitle;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.RichTextBox Content;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Label created;
    }
}