using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pm_training
{
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
            tableParks.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableParks.Show();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parksDataSet.Park". При необходимости она может быть перемещена или удалена.
            this.parkTableAdapter.Fill(this.parksDataSet.Park);

        }
    }
}
