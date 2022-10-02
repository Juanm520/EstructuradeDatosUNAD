using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase1JuanRodriguez
{
    public partial class Registro : Form
    {
        public List<Spa> Registros = new List<Spa>();
        public int id_service = 0;
        public Registro()
        {
            InitializeComponent();
            bt_reporte.Enabled = false;
        }

        private void bt_registro_Click(object sender, EventArgs e)
        {
            //Crea objeto para la lista de clientes registrados.
            Spa RegistroCliente = new Spa();

            //Toma los datos para el objeto.
            RegistroCliente.Id_owner = Int32.Parse(in_id_owner.Text);
            RegistroCliente.Name_owner = in_name_owner.Text;
            RegistroCliente.Name_pet = in_name_pet.Text;
            int estrato = Int32.Parse((inlist_estrato.SelectedItem.ToString()));
            RegistroCliente.Estrato = estrato;
            RegistroCliente.Id_service = id_service;
            RegistroCliente.Date = DateTime.Now;            
            RegistroCliente.Cost_service = Int32.Parse(out_Cost_service.Text);
            RegistroCliente.TserviceCost = RegistroCliente.Tservice(estrato, RegistroCliente.Cost_service);
            RegistroCliente.Discount = RegistroCliente.Cost_service - RegistroCliente.TserviceCost;

            //Agrega objeto a la lista
            Registros.Add(RegistroCliente);

            //Agregar un label que indique que el usuario se ha registrado, activatr el boton reporte y costo a pagar. 
            out_registercomplete.Text = "Registro exitoso.";
            bt_reporte.Enabled = true;
            out_Cost_service.Text = RegistroCliente.TserviceCost.ToString();

        }

        private void inrd_service1_CheckedChanged(object sender, EventArgs e)
        {
            if (inrd_service1.Checked == true)
            {
                id_service = 1;
                out_Cost_service.Text = "45000";
            }      

        }

        private void inrd_service2_CheckedChanged(object sender, EventArgs e)
        {
            if (inrd_service2.Checked == true)
            {
                id_service = 2;
                out_Cost_service.Text = "80000";
            }
        }

        private void inrd_service3_CheckedChanged(object sender, EventArgs e)
        {
            if (inrd_service3.Checked == true)
            {
                id_service = 3;
                out_Cost_service.Text = "100000";
            }
        }

        private void bt_reporte_Click(object sender, EventArgs e)
        {
            Reporte WinReporte = new Reporte();
            WinReporte.Show();
            this.Hide();
            WinReporte.out_Tservicecost.Text = "Precio total: " + Registros[0].TserviceCost.ToString();
            WinReporte.out_Name_owner.Text = "Nombre del Propietario: " + Registros[0].Name_owner;
            WinReporte.out_Name_pet.Text = "Nombre de la Mascota: " + Registros[0].Name_pet;
            //identifica e imprime el servicio facturado.
            switch(id_service)
            {

                case 1:
                    WinReporte.out_id_service.Text = "Tipo de Servicio: Baño y corte.";
                    break;

                case 2:
                    WinReporte.out_id_service.Text = "Tipo de Servicio: Baño, corte y vacuna antigarrapatas.";
                    break;

                case 3:
                    WinReporte.out_id_service.Text = "Tipo de Servicio: Baño, corte, vacuna antigarrapatas y antiparasitos.";
                    break;

            }
            WinReporte.out_estrato.Text = "Estrato socioeconomico: " + Registros[0].Estrato.ToString();
            WinReporte.out_Cost_service.Text = "Costo bruto: " + Registros[0].Cost_service.ToString();
            WinReporte.out_discount.Text = "Descuento total: " + Registros[0].Discount.ToString();
            WinReporte.out_date.Text = "Fecha de Registro: " + Registros[0].Date.ToString();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

