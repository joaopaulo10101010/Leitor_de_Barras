using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leitor_de_Barras
{
    
    public partial class Leitorinterface : Form
    {
        Leitor leitor = new Leitor();
        Sistema Sistema = new Sistema();

        
        public Leitorinterface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            saidanumero.Text = leitor.LerBarra(caminho.Text);
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkmanual.Checked)
            {
                btinserir.Enabled = true;
                caminho.ReadOnly = false;
                ArquivosLocais.Enabled = false;
            }
            else
            {
                btinserir.Enabled = false;
                caminho.Text = "";
                ArquivosLocais.Enabled = true;
                caminho.ReadOnly = true;
            }
        }

        private void ArquivosLocais_Click(object sender, EventArgs e)
        {
            caminho.Text = Sistema.LocalFiles();
            CarregarBarras();
        }

        

        private void saidacodigodebarrasp_Click(object sender, EventArgs e)
        {

        }

        private void btinserir_Click(object sender, EventArgs e)
        {
            CarregarBarras();
        }

        private void CarregarBarras()
        {
            saidanumero.Text = leitor.LerBarra(caminho.Text);
            saidacodigodebarrasp.Image = leitor.CriarBarras(saidanumero.Text);
            formato.Text = leitor.RetornarFormato();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void tipobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            imagemsaidacb.Image = leitor.CriarBarras(numerocodigoentrada.Text, Convert.ToString(tipobox.SelectedItem));
        }
    }
}
