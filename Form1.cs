using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Calcular_Frete
{
    public partial class Form1 : Form
    {
        float KmRodado;
        float quantCombustivel;
        double custoCombustivel;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            float KmValor;

            if (txtVeiculo.Text.Length > 0 && txtLocalidade.Text.Length > 0 && txtDistKm.Text.Length > 0 && txtValorCombus.Text.Length > 0 && cbxTabela.Text.Length > 0 && txtAutonomia.Text.Length > 0)
            {
                KmRodado = float.Parse(txtDistKm.Text);

                if (chbxIdaVolta.Checked == true)
                {
                    KmValor = KmRodado * 2; // ida e volta
                }
                else
                {
                    KmValor = KmRodado; // só ida
                }

                quantCombustivel = KmValor / float.Parse(txtAutonomia.Text);
                custoCombustivel = (double.Parse(txtValorCombus.Text) * quantCombustivel);

                txtDespesaCom.Text = "R$" + custoCombustivel.ToString("C");
                txtTotal.Text = "R$" + (custoCombustivel * int.Parse(cbxTabela.Text)).ToString("C");
                txtConsumoCom.Text = "R$" + custoCombustivel.ToString("C");
                txtKmRodado.Text = "R$" + KmValor.ToString("C");
                txtCustoKm.Text = "R$" + quantCombustivel.ToString("C");
            }
            else
            {
                if (txtVeiculo.Text.Length == 0) {

                    MessageBox.Show("Coleque qual o veículo!");
                    label1.ForeColor = Color.Red;
                    txtVeiculo.Text = "";
                    imgVeiculo.Image = Calcular_Frete.Properties.Resources.NADA;

                }
                if (txtLocalidade.Text.Length == 0) {

                    MessageBox.Show("Coleque a localidade!");
                    label2.ForeColor = Color.Red;
                    txtLocalidade.Text = "";

                }
                if (txtDistKm.Text.Length == 0) {

                    MessageBox.Show("Digite a distancia em Km!");
                    label3.ForeColor = Color.Red;
                    txtDistKm.Text = "";

                }
                if (txtValorCombus.Text.Length == 0) {

                    MessageBox.Show("Digite o valor do combustível!");
                    label12.ForeColor = Color.Red;
                    txtValorCombus.Text = "";

                }
                if (cbxTabela.Text.Length == 0) {

                    MessageBox.Show("Coleque qual o veículo!");
                    label5.ForeColor = Color.Red;
                    cbxTabela.Text = "";

                }
                if (txtAutonomia.Text.Length == 0) {

                    MessageBox.Show("Digite qual a autonimia do veículo!");
                    label4.ForeColor = Color.Red;
                    txtAutonomia.Text = "";

                }
            }
        }

        private void txtVeiculo_Leave(object sender, EventArgs e)
        {
            string veiculo;

            if (txtVeiculo.Text.Length > 0)
            {
                veiculo = txtVeiculo.Text.ToUpper();


                if (veiculo == "CARRO" || veiculo == "CAMINHAO" || veiculo == "CAMINHÃO" || veiculo == "MOTO")
                {
                    label1.ForeColor = Color.Black;

                    if (veiculo == "CARRO")
                    {
                        imgVeiculo.Image = Calcular_Frete.Properties.Resources.CARRO;

                    }
                    else if (veiculo == "CAMINHAO" || veiculo == "CAMINHÃO")
                    {
                        imgVeiculo.Image = Calcular_Frete.Properties.Resources.CAMINHAO;

                    }
                    else
                    {
                        imgVeiculo.Image = Calcular_Frete.Properties.Resources.MOTO;
                    }
                }
                else
                {
                    MessageBox.Show("Nome do Veículo está errado! " + veiculo);
                    label1.ForeColor = Color.Red;
                    txtVeiculo.Text = "";
                    txtVeiculo.Focus();
                    imgVeiculo.Image = Calcular_Frete.Properties.Resources.NADA;
                }

            }
            else
            {
                label1.ForeColor = Color.Red;
                imgVeiculo.Image = Calcular_Frete.Properties.Resources.NADA;
            }

        }

        private void txtLocalidade_Leave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void txtDistKm_Leave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void txtValorCombus_Leave(object sender, EventArgs e)
        {
            label12.ForeColor = Color.Black;
        }

        private void cbxTabela_Leave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void txtAutonomia_Leave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }
    }
}
