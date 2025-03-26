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
        string formato = "";

        public string LerBarra(string caminho_imagem)
        {
            // Garantindo que ele não ira trabalhar com valores nulos ou vazios
            if(string.IsNullOrEmpty(caminho_imagem) == true) 
            {
                return "Caminho Vazio";
            }
            // Definindo que o Bitmap(imagem) possui o endereço a função recebe
            Bitmap imagem = new Bitmap(caminho_imagem);
            // Definindo o Leitor de codigo de Barras
            BarcodeReader leitor = new BarcodeReader();

            // Guardando na variavel resultado, os dados lidos pelo leitor, com o seu metodo Decode
            var resultado = leitor.Decode(imagem);

            return resultado.Text;
        }
        
        public Bitmap CriarBarras(string numeros_da_barra)
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter();

            barcodeWriter.Format = BarcodeFormat.CODE_128;
            Bitmap codigo_de_barras = barcodeWriter.Write(numeros_da_barra);

            formato = Convert.ToString(barcodeWriter.Format);
            return codigo_de_barras;
        }
        public string RetornarFormato()
        {
            return formato;
        }

    }

    public class Sistema
    {
        public string LocalFiles()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            return openFileDialog.FileName;
        }
    }
}
