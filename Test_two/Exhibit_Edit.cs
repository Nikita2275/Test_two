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
    public partial class Exhibit_Edit : Form
    {
        private Exhibit _exhibit;

        public Exhibit_Edit(Exhibit exhibit)
        {
            InitializeComponent();
            _exhibit = exhibit;
            this.Load += Exhibit_Edit_Load;
        }

        private void Exhibit_Edit_Load(object sender, EventArgs e)
        {
            txtTitle.Text = _exhibit.Title;
            txtAuthor.Text = _exhibit.Author;
            txtYearCreated.Text = _exhibit.YearCreated.ToString();
            txtType.Text = _exhibit.Type;
            txtDescription.Text = _exhibit.Description;
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

        private void EditExhibit_Click(object sender, EventArgs e)
        {
            if (!ValidateExhibitData())
                return;

            using (var context = new MuseumContext())
            {
                var exhibitToUpdate = context.Exhibits.Find(_exhibit.ExhibitId);
                if (exhibitToUpdate != null)
                {
                    exhibitToUpdate.Title = txtTitle.Text;
                    exhibitToUpdate.Author = txtAuthor.Text;
                    exhibitToUpdate.YearCreated = int.Parse(txtYearCreated.Text);
                    exhibitToUpdate.Type = txtType.Text;
                    exhibitToUpdate.Description = txtDescription.Text;

                    context.SaveChanges();
                    MessageBox.Show("Экспонат успешно обновлен!");
                    this.Close();
                }
            }
        }
    }
}
