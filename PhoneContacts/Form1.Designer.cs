namespace PhoneContacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView = new DataGridView();
            AddButton = new Button();
            UpdateButton = new Button();
            deleteButton = new Button();
            RefreshButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.FromArgb(24, 30, 54);
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.GridColor = Color.FromArgb(24, 30, 54);
            dataGridView.Location = new Point(12, 12);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(444, 454);
            dataGridView.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(24, 30, 54);
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.ForeColor = SystemColors.ControlLightLight;
            AddButton.Location = new Point(462, 12);
            AddButton.Margin = new Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 56);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.FromArgb(24, 30, 54);
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateButton.ForeColor = SystemColors.ControlLightLight;
            UpdateButton.Location = new Point(462, 76);
            UpdateButton.Margin = new Padding(3, 4, 3, 4);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(75, 56);
            UpdateButton.TabIndex = 2;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(24, 30, 54);
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.ForeColor = SystemColors.ControlLightLight;
            deleteButton.Location = new Point(460, 139);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 56);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.FromArgb(24, 30, 54);
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RefreshButton.ForeColor = SystemColors.ControlLightLight;
            RefreshButton.Location = new Point(460, 202);
            RefreshButton.Margin = new Padding(3, 4, 3, 4);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(75, 56);
            RefreshButton.TabIndex = 4;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(548, 480);
            Controls.Add(RefreshButton);
            Controls.Add(deleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(dataGridView);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Contact List";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Button AddButton;
        private Button UpdateButton;
        private Button deleteButton;
        private Button RefreshButton;
    }
}