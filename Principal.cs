using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_Frete_C__Zatec
{
    public partial class Principal : Form
    {

        float kmRodados = 0;
        float KmAutonomia = 0;
        float QtdCombustivel = 0;
        double ValorCombustivel,CustoCombustivel ;
        

        public Principal()
        {
            InitializeComponent();
        }

        private void txtVeiculo_Leave(object sender, EventArgs e)
        {
            string veiculo = txtVeiculo.Text.Trim().ToLower();

            if (veiculo == "carro")
            {
                imgVeiculo.Image = Properties.Resources.carro;
            }
            else if (veiculo == "moto")
            {
                imgVeiculo.Image = Properties.Resources.moto;
            }
            else if (veiculo == "caminhao")
            {
                imgVeiculo.Image = Properties.Resources.caminhao;
            }
            else
            {
                MessageBox.Show("Digite o Veiculo Desejado.");
                txtVeiculo.Clear();
                txtVeiculo.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtVeiculo.Clear();//limpar o veiculo
            txtDistancia.Clear();//limpar a distancia
            txtAutonomia.Clear();//limpar a autonomia
            txtValorporLitro.Clear();//limpar o valor do litro

            //Limpa os resultados 
            txtDespesaCombustivel.Clear();
            txtConsumoDeCombustivel.Clear();
            txtKmRodado.Clear();
            txtCustoKM.Clear();
            txtTotal.Clear();
            txtVeiculo.Focus();//foca no veiculo

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Pega a distância e trata ponto/vírgula
            float kmRodados = float.Parse(txtDistancia.Text.Replace(".", ","));

            // 2. Verifica se é ida e volta
            float kmDobrado = 0;
            if (checkIdaVolta.Checked)
            {
                kmDobrado = kmRodados * 2;
            }
            else
            {
                kmDobrado = kmRodados;
            }
            txtKmRodado.Text = kmDobrado.ToString("N2");

            //  Calcula o Consumo e a Despesa de Combustível (Seu custo interno)
            float autonomia = float.Parse(txtAutonomia.Text.Replace(".", ","));
            float QtdCombustivel = kmDobrado / autonomia;
            txtConsumoDeCombustivel.Text = QtdCombustivel.ToString("N2");

            double valorPorLitro = double.Parse(txtValorporLitro.Text.Replace(".", ","));
            double CustoCombustivel = valorPorLitro * QtdCombustivel;
            txtDespesaCombustivel.Text = CustoCombustivel.ToString("N2");

            
            // CÁLCULO DO FRETE (O QUE VOCÊ COBRA DO CLIENTE)
          

            // Pega o valor do KM do ComboBox ( 3 ou 2,50)
            double valorPorKMCobrado = double.Parse(comboBox1.Text.Replace(".", ",")); //

            // Força a caixa de texto a exibir exatamente o valor do KM cobrado 
            txtCustoKM.Text = valorPorKMCobrado.ToString("N2");

            // Calcula o Total do Frete: KM Total x Valor do KM cobrado (Ex: 70 x 3 = 210)
            double valorTotalFrete = kmDobrado * valorPorKMCobrado;
            txtTotal.Text = valorTotalFrete.ToString("N2");
        }
    }
}
