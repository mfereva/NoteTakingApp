namespace NoteTakingApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Content = new System.Windows.Forms.RichTextBox();
            this.create = new System.Windows.Forms.Button();
            this.noteLabel = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.savedNotes = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notetitle = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.AccessibleDescription = "begin your note here";
            this.Content.BackColor = System.Drawing.SystemColors.Info;
            this.Content.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Content.Location = new System.Drawing.Point(55, 122);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(471, 86);
            this.Content.TabIndex = 2;
            this.Content.Text = "";
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.create.ForeColor = System.Drawing.SystemColors.Control;
            this.create.Location = new System.Drawing.Point(34, 379);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(142, 45);
            this.create.TabIndex = 3;
            this.create.Text = "Create a New Note";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(61, 100);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(80, 19);
            this.noteLabel.TabIndex = 4;
            this.noteLabel.Text = "New Note:";
            this.noteLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.Control;
            this.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save.Location = new System.Drawing.Point(364, 379);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(84, 45);
            this.save.TabIndex = 5;
            this.save.Text = "Save Note";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // savedNotes
            // 
            this.savedNotes.BackColor = System.Drawing.SystemColors.Info;
            this.savedNotes.CausesValidation = false;
            this.savedNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedNotes.GridLines = true;
            this.savedNotes.HideSelection = false;
            this.savedNotes.Location = new System.Drawing.Point(55, 254);
            this.savedNotes.Name = "savedNotes";
            this.savedNotes.Size = new System.Drawing.Size(471, 96);
            this.savedNotes.TabIndex = 7;
            this.savedNotes.UseCompatibleStateImageBehavior = false;
            this.savedNotes.View = System.Windows.Forms.View.List;
            this.savedNotes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.savedNotes_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Saved Notes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Migra Extrabold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Note Taking App";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "all your notes in one place";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // notetitle
            // 
            this.notetitle.AutoSize = true;
            this.notetitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.notetitle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notetitle.Location = new System.Drawing.Point(61, 68);
            this.notetitle.Name = "notetitle";
            this.notetitle.Size = new System.Drawing.Size(79, 19);
            this.notetitle.TabIndex = 11;
            this.notetitle.Text = "Note Title:";
            this.notetitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.Info;
            this.Title.Location = new System.Drawing.Point(146, 67);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(380, 20);
            this.Title.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.notetitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.savedNotes);
            this.Controls.Add(this.save);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.create);
            this.Controls.Add(this.Content);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox Content;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ListView savedNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label notetitle;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

