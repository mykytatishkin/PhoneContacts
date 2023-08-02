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
            OkButton.Location = new Point(22, 165);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(75, 23);
            OkButton.TabIndex = 0;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(242, 165);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 36);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 2;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 74);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 117);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "Birth Date";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(117, 33);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(200, 23);
            FullNameTextBox.TabIndex = 5;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(117, 74);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(200, 23);
            PhoneTextBox.TabIndex = 6;
            // 
            // BirthDateTimePicker
            // 
            BirthDateTimePicker.Location = new Point(117, 111);
            BirthDateTimePicker.Name = "BirthDateTimePicker";
            BirthDateTimePicker.Size = new Size(200, 23);
            BirthDateTimePicker.TabIndex = 7;
            // 
            // FormAddContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 204);
            Controls.Add(BirthDateTimePicker);
            Controls.Add(PhoneTextBox);
            Controls.Add(FullNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Name = "FormAddContact";
            Text = "FormAddContact";
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