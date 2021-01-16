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
    public partial class EnvioInformacoes : Form
    {
        // cria uma variavel global
        string tipoacaoglobal;



        public EnvioInformacoes(string tipoacao, Relatorio relatorio)
        {
            
            InitializeComponent();
            
            //caso a variavel receba null ela insere informações senao ela altera 
            tipoacaoglobal = tipoacao;
            if (relatorio == null)
            {
                this.Text = "";

            }
            else
            {
                this.Text = "Alterar";
                txtCodigo.Text = relatorio.CodRelatorio.ToString();
                txtLinha.Text = relatorio.Linha;
                txtTabela.Text = relatorio.Tabela;
            }
        }

       
        private void EnvioInformacoes_Load(object sender, EventArgs e)
        {
            
            //chama a classe acessa dados
            AcessaDadosSQL acessaDadosSQL = new AcessaDadosSQL();
            //faz uma consulta no banco
            DataTable dataTableMotorista = acessaDadosSQL.ExecutaConsulta(System.Data.CommandType.StoredProcedure, "uspConsultaMotoristaCodigo");
            //insere informações na combobox
            cbbNomeMotorista.DataSource = dataTableMotorista;
            cbbNomeMotorista.ValueMember = "CodMotorista";
            cbbNomeMotorista.DisplayMember = "NomeMotorista";
            cbbNomeMotorista.Text = ("Selecione um motorista");

            //faz uma consulta no banco
            DataTable dataTableFiscal = acessaDadosSQL.ExecutaConsulta(System.Data.CommandType.StoredProcedure, "uspConsultaFiscalCodigo");

            //insere informações na combobox
            Fiscal fiscal = new Fiscal();
            FiscalColecao fiscalColecao = new FiscalColecao();
            cbbNomeFiscal.DataSource = dataTableFiscal;
            cbbNomeFiscal.ValueMember = "CodFiscal";
            cbbNomeFiscal.DisplayMember = "NomeFiscal";
            cbbNomeFiscal.Text = ("Selecione um Fiscal");
        }
      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
            //chama a classe relatorio e insere seus dados
            Relatorio relatorio = new Relatorio();
            relatorio.DiaHora = Convert.ToDateTime(dtpHorario.Value);
            relatorio.Tabela = txtTabela.Text.Trim();
            relatorio.Linha = txtLinha.Text.Trim();
            relatorio.CodFiscal = Convert.ToInt32(cbbNomeFiscal.SelectedValue);
            relatorio.CodMotorista = Convert.ToInt32(cbbNomeMotorista.SelectedValue);


            // chama a classe relatorio
            RelatorioNegocio relatorioNegocio = new RelatorioNegocio();
            //se a variavel receber inserir ela insere um novo relatorio
            if(tipoacaoglobal == "inserir")
            {
                string retorno = relatorioNegocio.InserirRelatorio(relatorio);
                // manda uma mensagem para o usuario caso a insersao seja concluida ou nao
                try
                {
                    int num = Convert.ToInt32(retorno);
                    MessageBox.Show("relatorio inserido com sucesso");
                }
                catch (Exception)
                {

                    MessageBox.Show("Erro" + retorno);
                }
            }
            else
            {
                // caso a variavel nao receba a insersao ela altera as informações
                relatorio.CodRelatorio = Convert.ToInt32(txtCodigo.Text);
                string retorno = relatorioNegocio.AlterarRelatorio(relatorio);
                try
                {
                    int num = Convert.ToInt32(retorno);
                    MessageBox.Show("Relatorio alterado com sucesso");
                }
                catch (Exception)
                {
                    MessageBox.Show("erro" + retorno);

                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // chama o form

            this.Close();

            TelaPrincipal tela = new TelaPrincipal();
            tela.ShowDialog();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            //chama o form
            Ajuda aj = new Ajuda();
            aj.Show();
            btnAjuda.BackColor = Color.Transparent;
        }

        private void btnAjuda_MouseEnter(object sender, EventArgs e)
        {
            btnAjuda.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void btnAjuda_MouseLeave(object sender, EventArgs e)
        {
            btnAjuda.BackColor = Color.Transparent;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // fecha a aplicação
           // Application.Exit();
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            //modela os botoes
            btnAjuda.BackColor = Color.Transparent;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            // minimiza o form
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMin_MouseEnter(object sender, EventArgs e)
        {     //modela os botoes
            btnMin.BackColor = Color.FromArgb(255, 192, 0);
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            //modela os botoes
            btnMin.BackColor = Color.Transparent;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //chama o form

          
            EnvioInformacoes ei = new EnvioInformacoes("inserir", null);
            ei.ShowDialog();
             this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {    //chama o form

          
            ConsultaCliente cc = new ConsultaCliente();
            cc.ShowDialog();
              this.Close();
        }

        private void btnConsultaRelatorio_Click(object sender, EventArgs e)
        {    //chama o form

           
            RelatorioDesingn re = new RelatorioDesingn();
            re.Show();
             this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {    //chama o form
          
            CadastramentoCliente ca = new CadastramentoCliente("inserir", null,null);
            ca.ShowDialog();
              this.Close();
        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        { //modela os botoes
            btnCadastrar.Image = Properties.Resources.btncreateFunc;
            btnCadastrar.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        { //modela os botoes
            btnCadastrar.Image = Properties.Resources.btnCadastrar;
            btnCadastrar.BackColor = Color.Transparent;
        }

        private void btnConsultaRelatorio_MouseEnter(object sender, EventArgs e)
        { //modela os botoes
            btnConsultaRelatorio.Image = Properties.Resources.btnSelectRelatoriosEnter1;
            btnConsultaRelatorio.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void btnConsultaRelatorio_MouseLeave(object sender, EventArgs e)
        { //modela os botoes
            btnConsultaRelatorio.Image = Properties.Resources.btnSelectRelatorios;
            btnConsultaRelatorio.BackColor = Color.Transparent;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        { //modela os botoes
            button2.Image = Properties.Resources.btnSelectFuncEnter1;
            button2.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        { //modela os botoes
            button2.Image = Properties.Resources.btnSelectFunc;
            button2.BackColor = Color.Transparent;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        { //modela os botoes
            button1.Image = Properties.Resources.btnCreateRelatorioEnter1;
            button1.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        { //modela os botoes
            button1.Image = Properties.Resources.btnCreateRelatorio;
            button1.BackColor = Color.Transparent;
        }
    }
}

