using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC0._1
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //fecha o programa
            Application.Exit();
        }

        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            //chama o form e fecha o atual
            RelatorioDesingn re = new RelatorioDesingn();
            re.Show();
            this.Visible= false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //chama o form e fecha o atual
            CadastramentoCliente ca = new CadastramentoCliente("inserir",null,null);
            ca.ShowDialog();
            this.Visible = false;
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            //chama o form e fecha o atual
            Ajuda aj = new Ajuda();
            aj.Show();
            btnAjuda.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chama o form e fecha o atual
            EnvioInformacoes ei = new EnvioInformacoes("inserir", null);
            ei.ShowDialog();
        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            //organiza o design
            btnCadastrar.Image = Properties.Resources.btncreateFunc;
            btnCadastrar.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            //organiza o design
           btnCadastrar.Image = Properties.Resources.btnCadastrar;
           btnCadastrar.BackColor = Color.Transparent;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //chama o form e fecha o atual
            EnvioInformacoes ei = new EnvioInformacoes("inserir", null);
            ei.ShowDialog();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //chama o form e fecha o atual
            ConsultaCliente cc = new ConsultaCliente();
            cc.ShowDialog();
            this.Visible = true;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {  //organiza o design
            button1.Image = Properties.Resources.btnCreateRelatorioEnter1;
            button1.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {  //organiza o design
            button1.Image = Properties.Resources.btnCreateRelatorio;
            button1.BackColor = Color.Transparent;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {  //organiza o design
            btnConsultaFunc.Image = Properties.Resources.btnSelectFuncEnter1;
            btnConsultaFunc.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {  //organiza o design
            btnConsultaFunc.Image = Properties.Resources.btnSelectFunc;
            btnConsultaFunc.BackColor = Color.Transparent;
        }

        private void btnRelatorio_MouseEnter(object sender, EventArgs e)
        {  //organiza o design
            btnRelatorio.Image = Properties.Resources.btnSelectRelatoriosEnter1;
            btnRelatorio.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void btnRelatorio_MouseLeave(object sender, EventArgs e)
        {  //organiza o design
            btnRelatorio.Image = Properties.Resources.btnSelectRelatorios;
            btnRelatorio.BackColor = Color.Transparent;
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {  //organiza o design
            btnSair.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {  //organiza o design
            btnSair.BackColor = Color.Transparent;
        }


        private void btnMin_MouseEnter(object sender, EventArgs e)
        {  //organiza o design
            btnMin.BackColor = Color.FromArgb(255, 192, 0);
        }
        private void btnMin_MouseLeave(object sender, EventArgs e)
        {   //organiza o design
            btnMin.BackColor = Color.Transparent;
        }



        //BOTÕES MINIMIZAR - AÇÃO.

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //MOUSE ENTRANDO E SAINDO DE CIMA DO BOTÃO.
        private void btnAjuda_MouseEnter(object sender, EventArgs e)
        {
            btnAjuda.BackColor = Color.FromArgb(28, 83, 121);
        }

        private void btnAjuda_MouseLeave(object sender, EventArgs e)
        {
            //organiza o design
            btnAjuda.BackColor = Color.Transparent;
        }
    }
}
