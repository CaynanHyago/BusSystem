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

namespace TCC0._1
{
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {
            //rdbFiscal.Checked = true;
        }

        private void AtualizaGrid()
        {
            // caso o fiscal seja clicado ele chama a classe fiscal e atualiza sua data grid view
            if (rdbFiscal.Checked == true)
            {
                CadastroFiscalNegocios cadastroClienteNegocios = new CadastroFiscalNegocios();
                FiscalColecao fiscalColecao = cadastroClienteNegocios.ConsultaFiscal(txtNome.Text.Trim());
                dgvCliente.DataSource = null;
                dgvCliente.DataSource = fiscalColecao;

                dgvCliente.Update();
                dgvCliente.Refresh();
                txtNome.Clear();
            }
            else
            {
                // senao ele chama a classe motorista e atualiza sua data grid view
                if (rdbMotorista.Checked == true)
                {
                    CadastroMotoristaNegocios cadastroMotoristaNegocios = new CadastroMotoristaNegocios();
                    MotoristaColecao motoristaColecao = cadastroMotoristaNegocios.ConsultaMotorista(txtNome.Text.Trim());
                    dgvCliente.DataSource = null;
                    dgvCliente.DataSource = motoristaColecao;
                    dgvCliente.Update();
                    dgvCliente.Refresh();
                    txtNome.Clear();
                }
            }

        }

       



        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //chama a classe para inserir informações
            CadastramentoCliente cadastramentoCliente = new CadastramentoCliente("inserir", null, null);
            cadastramentoCliente.ShowDialog();
            // chama o comando atualiza grid
            AtualizaGrid();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            // chama a tela principal
         
            TelaPrincipal tela = new TelaPrincipal();
            tela.ShowDialog();
            this.Close();


        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            // chama o comando atualiza grid
            AtualizaGrid();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {//manda uma mensagem caso o usuario não selecione um registro
            if (dgvCliente.SelectedRows.Count <= 0)
            {
                MessageBox.Show("É necessario selecionar um registro");
                return;
            }
            // manda uma mensagem para excluir o registro ou nao
            if (MessageBox.Show("Excluir registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (rdbFiscal.Checked == true)
                {
                    //gerar um novo objeto de acordo com a seleção

                    Fiscal click = dgvCliente.SelectedRows[0].DataBoundItem as Fiscal;

                    // chama a classe cadastro
                    CadastroFiscalNegocios cadastroClienteNegocios = new CadastroFiscalNegocios();
                    string retorno = cadastroClienteNegocios.ExcluirFiscal(click);
                    // manda uma mensagem caso o fiscal consiga ser excluido ou não
                    try
                    {
                        int num = Convert.ToInt32(retorno);
                        MessageBox.Show("Fiscal excluido" +
                            "," +
                            " com sucesso");
                        AtualizaGrid();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("erro" + retorno);

                    }
                }
                else
                {
                    if (rdbMotorista.Checked==true)
                    {
                        //gerar um novo objeto de acordo com a seleção

                        Motorista click = dgvCliente.SelectedRows[0].DataBoundItem as Motorista;

                        // chama a classe cadastro
                        CadastroMotoristaNegocios cadastroMotoristaNegocios = new CadastroMotoristaNegocios();
                        string retorno = cadastroMotoristaNegocios.ExcluirMotorista(click);
                        // manda uma mensagem caso o fiscal consiga ser excluido ou não
                        try
                        {
                            int num = Convert.ToInt32(retorno);
                            MessageBox.Show("Motorista excluido" +
                                "," +
                                " com sucesso");
                            AtualizaGrid();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("erro" + retorno);

                        }
                    }
                }
                
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (rdbFiscal.Checked == true)
            {
                //manda uma mensagem caso não tenha nenhum registro selecionado
                if (dgvCliente.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Selecione um fiscal");
                    return;
                }
                Fiscal FiscalClick = dgvCliente.SelectedRows[0].DataBoundItem as Fiscal;



                //altera as informações
                CadastramentoCliente cadastramentoCliente = new CadastramentoCliente("alterar", FiscalClick,null);
                cadastramentoCliente.ShowDialog();

                //atualiza a data grid view
                AtualizaGrid();
            }
            else
            {
                if (rdbMotorista.Checked == true)
                {
                    //manda uma mensagem caso não tenha nenhum registro selecionado
                    if (dgvCliente.SelectedRows.Count <= 0)
                    {
                        MessageBox.Show("Selecione um Motorista");
                        return;
                    }
                    Motorista MotoClick = dgvCliente.SelectedRows[0].DataBoundItem as Motorista;



                    //altera as informações
                    CadastramentoCliente cadastramentoCliente = new CadastramentoCliente("alterar",null ,MotoClick);
                    cadastramentoCliente.ShowDialog();

                    //atualiza a data grid view
                    AtualizaGrid();
                }
            }
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // chama a classe
           
            CadastramentoCliente ca = new CadastramentoCliente("inserir", null,null);
            ca.ShowDialog();
            this.Close();

        }

        private void btnConsultaRelatorio_Click(object sender, EventArgs e)
        { // chama a classe
            
            RelatorioDesingn re = new RelatorioDesingn();
            re.Show();
            this.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        { // chama a classe
          
            ConsultaCliente cc = new ConsultaCliente();
            cc.ShowDialog();
              this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        { // chama a classe
           
            EnvioInformacoes ei = new EnvioInformacoes("inserir", null);
            ei.ShowDialog();
             this.Close();

        }

        private void btnAjuda_Click(object sender, EventArgs e)
        { // chama a classe
            this.Close();
            Ajuda aj = new Ajuda();
            aj.Show();
            btnAjuda.BackColor = Color.Transparent;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            // minimiza o form
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // fecha a aplicação
            Application.Exit();
        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            //organiza o form
            btnCadastrar.Image = Properties.Resources.btncreateFunc;
            btnCadastrar.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {  //organiza o form
            btnCadastrar.Image = Properties.Resources.btnCadastrar;
            btnCadastrar.BackColor = Color.Transparent;
        }

        private void btnConsultaRelatorio_MouseEnter(object sender, EventArgs e)
        {  //organiza o form
            btnConsultaRelatorio.Image = Properties.Resources.btnSelectRelatoriosEnter1;
            btnConsultaRelatorio.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void btnConsultaRelatorio_MouseLeave(object sender, EventArgs e)
        {  //organiza o form
            btnConsultaRelatorio.Image = Properties.Resources.btnSelectRelatorios;
            btnConsultaRelatorio.BackColor = Color.Transparent;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {  //organiza o form
            button2.Image = Properties.Resources.btnSelectFuncEnter1;
            button2.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {  //organiza o form
            button2.Image = Properties.Resources.btnSelectFunc;
            button2.BackColor = Color.Transparent;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {  //organiza o form
            button1.Image = Properties.Resources.btnCreateRelatorioEnter1;
            button1.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {  //organiza o form
            button1.Image = Properties.Resources.btnCreateRelatorio;
            button1.BackColor = Color.Transparent;
        }

        private void btnMin_MouseEnter(object sender, EventArgs e)
        {  //organiza o form
            btnMin.BackColor = Color.FromArgb(255, 192, 0);
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {  //organiza os botoes
            btnMin.BackColor = Color.Transparent;
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        { //organiza os botoes
            btnSair.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        { //organiza os botoes
            btnSair.BackColor = Color.Transparent;
        }

        private void btnAjuda_MouseEnter(object sender, EventArgs e)
        { //organiza os botoes
            btnAjuda.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void btnAjuda_MouseLeave(object sender, EventArgs e)
        { //organiza os botoes
            btnAjuda.BackColor = Color.Transparent;
        }
    }    
}
