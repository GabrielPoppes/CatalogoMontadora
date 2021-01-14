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

namespace CatalogoMontadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox_modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Array que vai conter o nome dos modelos dos carros
            // Directory.GetFile = Pegar os arquivos do diretorio e adicionar no array
            // usamos o @ no diretório para usar a barra invertida
            string[] nomeModelosDosCarros = Directory.GetFiles(@"E:\Programmer\7. Linguagem C#\0.1 Projetos\InterfaceGrafica\CatalogoMontadora\CatalogoMontadora\CARROS");

            foreach(string imgCarros in nomeModelosDosCarros)
            {
                // vamos separar o diretório por barra, porem, não podemos usar somente uma barra
                // pois a IDE confunde com o cmd \n, por isso, usamos duas barras que ele entende o que queremos!
                string[] separador = imgCarros.Split('\\');

                // Agora, vamos querer somente o separador na posição 8, que é após a oitava barra
                // ou seja, somente o nome do carro, e vamos separa-lo da extensão da imagem
                // pra isso usamos o split('.') separando a partir do ponto
                // gerando então duas posições: [0] é o nome do carro [1] é a extensão .png
                string[] nomeCarro = separador[8].Split('.');

                // Se o modelo selecionado for = ao nome da imagem
                if(comboBox_modelo.Text == nomeCarro[0])
                {
                    // Localizamos a imagem, lembrando que "imagensCarros" é o combo box da imagem da aplicação
                    imagensCarros.ImageLocation = $@"E:\Programmer\7. Linguagem C#\0.1 Projetos\InterfaceGrafica\CatalogoMontadora\CatalogoMontadora\CARROS\{nomeCarro[0]}.jpg";
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            imagensCarros.ImageLocation = null;
            // se o texto da combo box for == Marca
            if (comboBox_marca.Text == "CHEVROLET")
            {
                // "Items" é o campo onde adicionamos as opções na box
                // o mesmo que está nas propriedades
                comboBox_modelo.Items.Clear();
                comboBox_modelo.ResetText();
                comboBox_modelo.Items.Add("CRUZE");
                comboBox_modelo.Items.Add("ONIX");
                comboBox_modelo.Items.Add("TRACKER");
            }

            if(comboBox_marca.Text == "CHERRY")
            {
                // Clear limpa a lista de modelos
                comboBox_modelo.Items.Clear();
                // ResetText limpa os modelos selecionados
                comboBox_modelo.ResetText();
                comboBox_modelo.Items.Add("TIGGO 5X");
            }

            if(comboBox_marca.Text == "FORD")
            {
                comboBox_modelo.Items.Clear();
                comboBox_modelo.ResetText();
                comboBox_modelo.Items.Add("ECO SPORT");
            }

            if(comboBox_marca.Text == "PEUGEOT")
            {
                comboBox_modelo.Items.Clear();
                comboBox_modelo.ResetText();
                comboBox_modelo.Items.Add("2008");
            }

            if(comboBox_marca.Text == "TOYOTA"){
                comboBox_modelo.Items.Clear();
                comboBox_modelo.ResetText();
                comboBox_modelo.Items.Add("COROLLA CROSS");
                comboBox_modelo.Items.Add("RAV4");
            }

            if(comboBox_marca.Text == "VOLKSWAGEN")
            {
                comboBox_modelo.Items.Clear();
                comboBox_modelo.ResetText();
                comboBox_modelo.Items.Add("NIVUS");
                comboBox_modelo.Items.Add("POLO");
                comboBox_modelo.Items.Add("T-CROSS");
                comboBox_modelo.Items.Add("VIRTUS");
            }
        }
    }
}
