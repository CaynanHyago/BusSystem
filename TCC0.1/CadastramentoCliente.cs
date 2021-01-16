using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferenciasDeObjetos;
using Negocios;
using ConectaBancoDados;


namespace TCC0._1
{
    public partial class CadastramentoCliente : Form
    {
        string tipoacaoglobal;

        public CadastramentoCliente(string tipoacao, Fiscal fiscal,Motorista motorista)
        {
            InitializeComponent();
            // cria uma variavel global
            
            tipoacaoglobal = tipoacao;
            // se o fiscal receber null ele insere os dados se nao ele altera
            if (fiscal == null)
            {
                this.Text = "";

            }
            else
            {
                this.Text = "Alterar Fiscal";
                txtCod.Text = fiscal.CodFiscal.ToString();
                txtLogin.Text = fiscal.Nome;
                txtSenha.Text = fiscal.Chapa.ToString();
                rdbFiscal.Checked = true;
                rdbMotorista.Visible = false;
            }

         
           
            // se o fiscal receber null ele insere os dados se nao ele altera
            if (motorista == null)
            {
                this.Text = "";

            }
            else
            {
                this.Text = "Alterar motorista";
                txtCod.Text = motorista.CodMotorista.ToString();
                txtLogin.Text = motorista.Nome;
                txtSenha.Text = motorista.Chapa.ToString();
                rdbMotorista.Checked = true;
                rdbFiscal.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // chama a tela princiapal
           

            TelaPrincipal tela = new TelaPrincipal();
            tela.ShowDialog();
            this.Close();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //se o radio button for fiscal ele insere no banco do fiscal 
           
                 if (rdbFiscal.Checked == true)
                {


                    Fiscal fiscal = new Fiscal();
                    fiscal.Nome = txtLogin.Text.Trim();
                    fiscal.Chapa = Convert.ToInt32(txtSenha.Text.Trim());

                    CadastroFiscalNegocios cadastroClienteNegocios = new CadastroFiscalNegocios();

                    if (tipoacaoglobal == "inserir")
                    {
                        string retorno = cadastroClienteNegocios.InserirFiscal(fiscal);
                        try
                        {
                            int num = Convert.ToInt32(retorno);
                            MessageBox.Show("Fiscal cadastrado com sucesso");
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Erro" + retorno);
                        }
                    }
                    // se for alterar ele altera o fiscal
                    else
                    {
                        fiscal.CodFiscal = Convert.ToInt32(txtCod.Text);

                        string retorno = cadastroClienteNegocios.AlterarFiscal(fiscal);
                        try
                        {
                            int num = Convert.ToInt32(retorno);
                            MessageBox.Show("Fiscal alterado com sucesso");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("erro" + retorno);

                        }
                    }
                }
                 // chama a classe motorista e seus dados
                else
                {
                    Motorista motorista = new Motorista();
                    motorista.Nome = txtLogin.Text.Trim();
                    motorista.Chapa = Convert.ToInt32(txtSenha.Text.Trim());
                    motorista.CodOnibus = Convert.ToInt32(cbbOnibus.SelectedValue);

                // chama a clase cadastro motorista negocios
                    CadastroMotoristaNegocios cadastroMotoristaNegocios = new CadastroMotoristaNegocios();

                // se for inserir ele inseri no banco do motorista se nao ele altera
                    if (tipoacaoglobal == "inserir")
                    {
                        string retorno = cadastroMotoristaNegocios.InserirMotorista(motorista);
                        try
                        {
                            int num = Convert.ToInt32(retorno);
                            MessageBox.Show("Motorista cadastrado com sucesso");
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Erro" + retorno);
                        }
                    }
                    else
                    {
                        motorista.CodMotorista = Convert.ToInt32(txtCod.Text);

                        string retorno = cadastroMotoristaNegocios.AlterarMotorista(motorista);
                        try
                        {
                            int num = Convert.ToInt32(retorno);
                            MessageBox.Show("Motorista alterado com sucesso");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("erro" + retorno);

                        }
                    }
                }
            }
        
    
        private void rdbMotorista_CheckedChanged(object sender, EventArgs e)
        {
            //deixa os botões visiveis
            label1.Visible = true;
            cbbOnibus.Visible = true;
            // chama a class de conexao com o banco
            AcessaDadosSQL acessaDadosSQL = new AcessaDadosSQL();
            // faz uma nova consulta no banco
            DataTable dataTableOnibus = acessaDadosSQL.ExecutaConsulta(System.Data.CommandType.StoredProcedure, "uspConsultaOnibus");
            cbbOnibus.DataSource = dataTableOnibus;
            cbbOnibus.ValueMember = "CodOnibus";
            cbbOnibus.DisplayMember = "Numero";
            cbbOnibus.Text = ("Selecione um ônibus");
        }

        private void rdbFiscal_CheckedChanged(object sender, EventArgs e)
        {
            // desabilita os botões
            cbbOnibus.Visible = false;
            label1.Visible = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // chama o form
           
            CadastramentoCliente ca = new CadastramentoCliente("inserir", null, null);
            ca.ShowDialog();
             this.Close();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            // chama o form
            this.Hide();
            RelatorioDesingn re = new RelatorioDesingn();
            re.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // chama o form
           
            ConsultaCliente cc = new ConsultaCliente();
            cc.ShowDialog();
             this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // chama o form
           
            EnvioInformacoes ei = new EnvioInformacoes("inserir", null);
            ei.ShowDialog();
            this.Close();
        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            // organiza o design
            btnCadastrar.Image = Properties.Resources.btncreateFunc;
            btnCadastrar.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            // organiza o design
            btnCadastrar.Image = Properties.Resources.btnCadastrar;
            btnCadastrar.BackColor = Color.Transparent;
        }

        private void btnRelatorio_MouseEnter(object sender, EventArgs e)
        {
            // organiza o design
            btnRelatorio.Image = Properties.Resources.btnSelectRelatoriosEnter1;
            btnRelatorio.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void btnRelatorio_MouseLeave(object sender, EventArgs e)
        {
            // organiza o design
            btnRelatorio.Image = Properties.Resources.btnSelectRelatorios;
            btnRelatorio.BackColor = Color.Transparent;
        }



        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.Transparent;
        }

        private void btnMin_MouseEnter(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.FromArgb(255, 192, 0);
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.Transparent;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAjuda_MouseEnter(object sender, EventArgs e)
        {
            btnAjuda.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void btnAjuda_MouseLeave(object sender, EventArgs e)
        {
            btnAjuda.BackColor = Color.Transparent;
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            Ajuda aj = new Ajuda();
            aj.Show();
            btnAjuda.BackColor = Color.Transparent;
        }

        private void btnConsultaRelatorio_MouseEnter(object sender, EventArgs e)
        {
            btnConsultaRelatorio.Image = Properties.Resources.btnSelectRelatoriosEnter1;
            btnConsultaRelatorio.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.btnCreateRelatorioEnter1;
            button1.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.btnCreateRelatorio;
            button1.BackColor = Color.Transparent;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.btnSelectFuncEnter1;
            button2.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.btnSelectFunc;
            button2.BackColor = Color.Transparent;
        }

        private void btnConsultaRelatorio_MouseLeave(object sender, EventArgs e)
        {
            btnConsultaRelatorio.Image = Properties.Resources.btnSelectRelatorios;
            btnConsultaRelatorio.BackColor = Color.Transparent;
        }

        private void btnConsultaRelatorio_Click(object sender, EventArgs e)
        {
            
            RelatorioDesingn re = new RelatorioDesingn();
            re.Show();
           this.Close();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
