using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox_meses
{
    public partial class FormFechas : Form
    {
        public FormFechas()
        {
            InitializeComponent();
        }
    
        private void Btncalcular_Click(object sender, EventArgs e)
        {
            TimeSpan Year = Convert.ToDateTime(cmbinicio.Text) - Convert.ToDateTime(cmbfin.Text);
            Txtresultado.Text = Convert.ToString(Year.TotalDays / 365);
            
        }
    }
}
