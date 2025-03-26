using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Leitor_de_Barras
{
    internal class ReadControl
    {
        public void LerBarra(TextBox a)
        {
            a.Text = "Funcionou";
        }
    }

    public class Leitor 
    {


        public string LerBarra(string caminho_imagem)
        {
            // Definindo que o Bitmap(imagem) possui o endereço a função recebe
            Bitmap imagem = new Bitmap(caminho_imagem);
            // Definindo o Leitor de codigo de Barras
            BarcodeReader leitor = new BarcodeReader();

            // Guardando na variavel resultado, os dados lidos pelo leitor, com o seu metodo Decode
            var resultado = leitor.Decode(imagem);

            return resultado.Text;
        }     
    }
}
