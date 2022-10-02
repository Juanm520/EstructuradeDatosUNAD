using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Fase1JuanRodriguez
{
    public partial class Reporte : Form
    {
        
        public Reporte()
        {
            InitializeComponent();
        }

        public void Reporte_Load(object sender, EventArgs e)
        {

        }

        private void bt_retornar_Click(object sender, EventArgs e)
        {
            Registro WinReporte = new Registro();
            WinReporte.Show();
            this.Close();
        }
    }
}
