namespace PhoneContacts
{
    partial class FormAddContact
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
            OkButton = new Button();
            CancelButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            FullNameTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            BirthDateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // OkButton
            // 
            OkButton.BackColor = Color.FromArgb(37, 105, 53);
            OkButton.FlatStyle = FlatStyle.Flat;
            OkButton.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OkButton.ForeColor = SystemColors.ControlLightLight;
            OkButton.Location = new Point(23, 152);
            OkButton.Margin = new Padding(3, 4, 3, 4);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(89, 52);
            OkButton.TabIndex = 0;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = false;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(105, 41, 37);
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CancelButton.ForeColor = SystemColors.ControlLightLight;
            CancelButton.Location = new Point(235, 152);
            CancelButton.Margin = new Padding(3, 4, 3, 4);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(82, 48);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(98, 23);
            label1.TabIndex = 2;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 3;
            label2.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 4;
            label3.Text = "Birth Date";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.BackColor = Color.FromArgb(24, 30, 54);
            FullNameTextBox.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FullNameTextBox.ForeColor = Color.White;
            FullNameTextBox.Location = new Point(117, 36);
            FullNameTextBox.Margin = new Padding(3, 4, 3, 4);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(200, 26);
            FullNameTextBox.TabIndex = 5;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.BackColor = Color.FromArgb(24, 30, 54);
            PhoneTextBox.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneTextBox.ForeColor = Color.White;
            PhoneTextBox.Location = new Point(117, 76);
            PhoneTextBox.Margin = new Padding(3, 4, 3, 4);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(200, 26);
            PhoneTextBox.TabIndex = 6;
            // 
            // BirthDateTimePicker
            // 
            BirthDateTimePicker.AccessibleRole = AccessibleRole.TitleBar;
            BirthDateTimePicker.CalendarFont = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BirthDateTimePicker.CalendarForeColor = Color.White;
            BirthDateTimePicker.CalendarMonthBackground = Color.FromArgb(24, 30, 54);
            BirthDateTimePicker.Location = new Point(117, 122);
            BirthDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            BirthDateTimePicker.Name = "BirthDateTimePicker";
            BirthDateTimePicker.Size = new Size(200, 23);
            BirthDateTimePicker.TabIndex = 7;
            // 
            // FormAddContact
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(331, 218);
            Controls.Add(BirthDateTimePicker);
            Controls.Add(PhoneTextBox);
            Controls.Add(FullNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAddContact";
            Text = "Fill Contact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OkButton;
        private Button CancelButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox FullNameTextBox;
        private TextBox PhoneTextBox;
        private DateTimePicker BirthDateTimePicker;
    }
}