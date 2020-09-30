using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

namespace NavegadorChromium
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();

            //Aplica o efeito que se utiliza no Chrome e Firefox
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }

        //Método de sobreescrita
        public override TitleBarTab CreateTab()
        {
            //retorna uma tabela, ou seja, uma aba (guia)
            return new TitleBarTab(this)
            {
                Content = new Form1 { Text = "Nova Aba" }
            };
        }
    }
}
