using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_two
{
    public partial class Exhibit_Add : Form
    {
        public Exhibit_Add()
        {
            InitializeComponent();
        }

        private bool ValidateExhibitData()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtYearCreated.Text) ||
                string.IsNullOrWhiteSpace(txtType.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return false;
            }

            if (!int.TryParse(txtYearCreated.Text, out _))
            {
                MessageBox.Show("Введите корректный год создания.");
                return false;
            }

            return true;
        }

        private void AddExhibit_Click(object sender, EventArgs e)
        {
            if (!ValidateExhibitData())
                return;

            using (var context = new MuseumContext())
            {
                var newExhibit = new Exhibit
                {
                    Title = txtTitle.Text,
                    Author = txtAuthor.Text,
                    YearCreated = int.Parse(txtYearCreated.Text),
                    Type = txtType.Text,
                    Description = txtDescription.Text
                };

                context.Exhibits.Add(newExhibit);
                context.SaveChanges();

                MessageBox.Show("Экспонат успешно добавлен!");
            }
        }
    }
}
