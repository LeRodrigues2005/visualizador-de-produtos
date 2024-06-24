using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizadorProdutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;

            if (comboBox1.Text == "FIAT")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("UNO");
                comboBox2.Items.Add("PALIO");               
            }
            else if (comboBox1.Text == "FORD")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ECOSPORT");
                comboBox2.Items.Add("KA");
            }
            else if (comboBox1.Text == "CHEVROLET")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("CELTA");
                comboBox2.Items.Add("AGILE");
            }
            else if (comboBox1.Text == "VOLKSWAGEN")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("GOL");
                comboBox2.Items.Add("POLO");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] fotosDosCarros = Directory.GetFiles("C:\\INFORMATIC\\C#\\VisualizadorProdutos\\imagens");  // diretório das imagens

            foreach (string carro in fotosDosCarros) 
            {
                string[] separador = carro.Split('\\');
                string[] selecionado = separador[5].Split('.');  // separa o nome do carro [posição 0] da extensão [posição 1] (.jpg) 

                if (comboBox2.Text == selecionado[0])
                {
                    pictureBox2.BringToFront();
                    pictureBox2.ImageLocation = "C:\\INFORMATIC\\C#\\VisualizadorProdutos\\imagens\\" + comboBox2.Text + ".jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}
