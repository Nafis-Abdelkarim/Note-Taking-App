namespace Note_Taking_App
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
            title = new Label();
            note = new Label();
            titleBox = new TextBox();
            noteBox = new TextBox();
            save = new Button();
            dataGridView = new DataGridView();
            clear = new Button();
            read = new Button();
            delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(108, 36);
            title.Name = "title";
            title.Size = new Size(51, 24);
            title.TabIndex = 0;
            title.Text = "Title";
            title.Click += label1_Click;
            // 
            // note
            // 
            note.AutoSize = true;
            note.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            note.Location = new Point(108, 94);
            note.Name = "note";
            note.Size = new Size(54, 24);
            note.TabIndex = 1;
            note.Text = "Note";
            // 
            // titleBox
            // 
            titleBox.Location = new Point(183, 36);
            titleBox.Multiline = true;
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(468, 35);
            titleBox.TabIndex = 2;
            // 
            // noteBox
            // 
            noteBox.Location = new Point(183, 94);
            noteBox.Multiline = true;
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(468, 85);
            noteBox.TabIndex = 3;
            // 
            // save
            // 
            save.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            save.Location = new Point(306, 193);
            save.Name = "save";
            save.Size = new Size(94, 32);
            save.TabIndex = 4;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(183, 245);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(468, 188);
            dataGridView.TabIndex = 5;
            // 
            // clear
            // 
            clear.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clear.Location = new Point(183, 193);
            clear.Name = "clear";
            clear.Size = new Size(94, 32);
            clear.TabIndex = 6;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // read
            // 
            read.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            read.Location = new Point(435, 193);
            read.Name = "read";
            read.Size = new Size(94, 32);
            read.TabIndex = 7;
            read.Text = "Read";
            read.UseVisualStyleBackColor = true;
            read.Click += read_Click;
            // 
            // delete
            // 
            delete.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            delete.Location = new Point(557, 193);
            delete.Name = "delete";
            delete.Size = new Size(94, 32);
            delete.TabIndex = 8;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delete);
            Controls.Add(read);
            Controls.Add(clear);
            Controls.Add(dataGridView);
            Controls.Add(save);
            Controls.Add(noteBox);
            Controls.Add(titleBox);
            Controls.Add(note);
            Controls.Add(title);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label note;
        private TextBox titleBox;
        private TextBox noteBox;
        private Button save;
        private DataGridView dataGridView;
        private Button clear;
        private Button read;
        private Button delete;
    }
}