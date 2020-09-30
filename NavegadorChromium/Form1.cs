using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegadorChromium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Evento para a tecla ENTER
            if (e.KeyChar == (char)13)
                navegador.Load(txtUrl.Text);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //Carrega a URL
            navegador.Load(txtUrl.Text);
        }

        //Variável do tipo Chromium
        ChromiumWebBrowser navegador;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Instancia um novo navegador iniciando com a URL específica
            navegador = new ChromiumWebBrowser(txtUrl.Text);

            //Aplica controlador
            navegador.Dock = DockStyle.Fill;

            //Adiciona uma nova janela
            this.pConteudo.Controls.Add(navegador);
        }
    }
}
