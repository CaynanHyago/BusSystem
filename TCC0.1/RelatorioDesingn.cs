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
    public partial class RelatorioDesingn : Form
    {
        
        public RelatorioDesingn()
        {
            InitializeComponent();
        }

  

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
           
        }

        private void AtualizaGrid()
        {
            //Chama a classe RelatorioNegocios
            RelatorioNegocio relatorioNegocio = new RelatorioNegocio();

            // instancia a grid view com a classe relatorio coleção
            RelatorioColecao relatorioColecao = relatorioNegocio.ConsultaRelatorio();
            dgv_Listagem.DataSource = null;
            dgv_Listagem.DataSource = relatorioColecao;

            // atualiza a data grid e da um refresh nela
            dgv_Listagem.Update();
            dgv_Listagem.Refresh();

        }

        private void dgv_Listagem_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // atualiza a grid
            AtualizaGrid();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // chama a tela principal
            

            TelaPrincipal tela = new TelaPrincipal();
             tela.ShowDialog();
            this.Close();
             



        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Manda uma mensagem de aviso caso o usuario não selecione um relatorio
            if (dgv_Listagem.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione um relatorio");
                return;
            }

            //gerar um novo objeto de acordo com a seleção
            Relatorio relatorioClick = dgv_Listagem.SelectedRows[0].DataBoundItem as Relatorio;

            //abre a tela de enviar informações caso for clicado para alterar ela
            EnvioInformacoes envioInformacoes = new EnvioInformacoes("Alterar", relatorioClick);
            envioInformacoes.ShowDialog();

            // atualiza a grid view
            AtualizaGrid();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Manda uma mensagem de aviso caso o usuario não selecione um relatorio
            if (dgv_Listagem.SelectedRows.Count <= 0)
            {
                MessageBox.Show("É necessario selecionar um registro");
                return;
            }

            if (MessageBox.Show("Excluir registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //gerar um novo objeto de acordo com a seleção

                Relatorio relatorioClick = dgv_Listagem.SelectedRows[0].DataBoundItem as Relatorio;

                RelatorioNegocio relatorioNegocio = new RelatorioNegocio();
                string retorno = relatorioNegocio.ExcluirRelatorio(relatorioClick);

                // manda uma mensagem caso o relatorio seja excluido com sucesso ou haja algum erro
                try
                {
                    int num = Convert.ToInt32(retorno);
                    MessageBox.Show("relatorio excluido" +
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // chama o form de cadastro caso haja a inserção de dados
            
            CadastramentoCliente ca = new CadastramentoCliente("inserir", null,null);
            ca.ShowDialog();
            this.Close();
        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            // organizando as imagens
            btnCadastrar.Image = Properties.Resources.btncreateFunc;
            btnCadastrar.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            // organizando as imagens
            btnCadastrar.Image = Properties.Resources.btnCadastrar;
            btnCadastrar.BackColor = Color.Transparent;
        }

        private void btnConsultaRelatorio_Click(object sender, EventArgs e)
        {
            //chama a classe relatorio
          
            RelatorioDesingn re = new RelatorioDesingn();
            re.Show();
            this.Close();
        }

        private void btnConsultaRelatorio_MouseEnter(object sender, EventArgs e)
        {
            // organizando as imagens
            btnConsultaRelatorio.Image = Properties.Resources.btnSelectRelatoriosEnter1;
            btnConsultaRelatorio.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void btnConsultaRelatorio_MouseLeave(object sender, EventArgs e)
        {
            // organizando as imagens
            btnConsultaRelatorio.Image = Properties.Resources.btnSelectRelatorios;
            btnConsultaRelatorio.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // chama a classe consulta cliente
           
            ConsultaCliente cc = new ConsultaCliente();
            cc.ShowDialog();
             this.Close();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            // organizando as imagens
            button2.Image = Properties.Resources.btnSelectFuncEnter1;
            button2.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            // organizando as imagens
            button2.Image = Properties.Resources.btnSelectFunc;
            button2.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // chama a classe envio informações
            
            EnvioInformacoes ei = new EnvioInformacoes("inserir", null);
            ei.ShowDialog();
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // organizando as imagens
            button1.Image = Properties.Resources.btnCreateRelatorioEnter1;
            button1.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            // organizando as imagens
            button1.Image = Properties.Resources.btnCreateRelatorio;
            button1.BackColor = Color.Transparent;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            // organizando as imagens
            btnSair.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            // organizando as imagens
            btnSair.BackColor = Color.Transparent;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            //minimiza o form
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMin_MouseEnter(object sender, EventArgs e)
        {
            // organizando as imagens
            btnMin.BackColor = Color.FromArgb(255, 192, 0);
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            // organizando as imagens
            btnMin.BackColor = Color.Transparent;
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            // chama o form ajuda
            Ajuda aj = new Ajuda();
            aj.Show();
            btnAjuda.BackColor = Color.Transparent;
        }

        private void btnAjuda_MouseEnter(object sender, EventArgs e)
        {
            // organizando as imagens
            btnAjuda.BackColor = Color.FromArgb(28, 83, 121);
        }
    }
}
