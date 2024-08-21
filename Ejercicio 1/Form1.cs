using Ejercicio_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        Formb registro = new Formb();
        Formc resultados = new Formc();
        ProcesoEncuesta consultas = new ProcesoEncuesta();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEncuesta_Click(object sender, EventArgs e)
        {
            if (registro.ShowDialog() == DialogResult.OK)
            {
                bool bici = registro.cbBici.Checked;
                bool auto = registro.cbAuto.Checked;
                bool publi = registro.cbPublico.Checked;
                double dist = Convert.ToDouble(registro.tbDist.Text);
                bool contac = registro.cbCont.Checked;
                string email = registro.tbEmail.Text;
                Encuesta actual = new Encuesta(bici, auto, publi, email, dist, contac);
                consultas.RegistrarEncuesta(actual, contac);
                registro.cbBici.Checked = false;
                registro.cbAuto.Checked = false;
                registro.cbPublico.Checked = false;
                registro.tbDist.Clear();
                registro.cbCont.Checked = false;
                registro.tbEmail.Clear();
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        { Encuesta actua;
            if (consultas.cantcontactables > 0)
            {
                consultas.OrdenarEncuestables();
                for (int i = 0; i < consultas.cantcontactables; i++)
                {
                    actua = consultas.VerContactables(i);
                    resultados.lbLista.Items.Add($"Email: {actua.email}, Distancia: {actua.distancia}km");
                    resultados.lbLista.Items.Add("----------------------------------");
                }
                
            }
            else
            {
                resultados.lbLista.Items.Add("Aun no hay contactables");
            }

            resultados.ShowDialog();
            resultados.lbLista.Items.Clear();
        }
    }
}
