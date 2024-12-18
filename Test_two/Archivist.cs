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
    public partial class Archivist : Form
    {
        public Archivist()
        {
            InitializeComponent();
        }

        private void Archivist_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "museumDBDataSet.Exhibitions". При необходимости она может быть перемещена или удалена.
            this.exhibitionsTableAdapter.Fill(this.museumDBDataSet.Exhibitions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "museumDBDataSet.Exhibits". При необходимости она может быть перемещена или удалена.
            this.exhibitsTableAdapter.Fill(this.museumDBDataSet.Exhibits);
            RefreshExhibitsData();
        }

        private void RefreshExhibitsData()
        {
            using (var context = new MuseumContext())
            {
                GridExhibit.DataSource = context.Exhibits.ToList();
            }
        }

        private void OpenAddExhibit_Click(object sender, EventArgs e)
        {
            Exhibit_Add Exhibit_Add = new Exhibit_Add();
            Exhibit_Add.ShowDialog(); // или Show() в зависимости от ваших потребностей
        }

        private void OpenEditExibit_Click(object sender, EventArgs e)
        {
            if (GridExhibit.SelectedRows.Count > 0)
            {
                var selectedExhibit = GridExhibit.SelectedRows[0].DataBoundItem as Exhibit;
                if (selectedExhibit != null)
                {
                    Exhibit_Edit exhibitEditForm = new Exhibit_Edit(selectedExhibit);

                    // Подписка на событие FormClosed
                    exhibitEditForm.FormClosed += (s, args) => RefreshExhibitsData();

                    exhibitEditForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Выберите экспонат для редактирования.");
            }
        }
    }
}
