using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicioWebRonnyCliente
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region PROPIEDADES
        ServicioWebAreas.WebService1SoapClient ClienteSoap = new ServicioWebAreas.WebService1SoapClient();
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = ClienteSoap.AreaCuadrado(Convert.ToDecimal(LadoCuadradoTextBox.Text));
            ResultadoLabel.Text = resultado.ToString(); 
        }

        private void BotonTriangulo_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = ClienteSoap.AreaTriangulo(Convert.ToDecimal(BaseTextBox.Text), Convert.ToDecimal(AlturaTextBox.Text)).ToString();
        }

        private void BotonCirculo_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = ClienteSoap.AreaCirculo(Convert.ToDecimal(RadioTextBox.Text)).ToString();
                
        }
    }
}
