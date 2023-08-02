using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneContacts
{
    public partial class FormAddContact : Form
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        public FormAddContact(string fullName, string phoneNumber, DateTime dateOfBirth)
        {
            InitializeComponent();

            // Заполняем поля значениями из параметров
            FullName = fullName;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;

            // Обновляем значения полей на форме
            FullNameTextBox.Text = FullName;
            PhoneTextBox.Text = PhoneNumber;
            BirthDateTimePicker.Value = DateOfBirth;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            FullName = FullNameTextBox.Text;
            PhoneNumber = PhoneTextBox.Text;
            DateOfBirth = BirthDateTimePicker.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
