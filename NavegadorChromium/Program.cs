using EasyTabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace NavegadorChromium
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //Criamos um novo Objeto
            AppContainer conteudo = new AppContainer();

            //Juntamos a aba inicial ao executar
            conteudo.Tabs.Add(new EasyTabs.TitleBarTab(conteudo)
            {
                Content = new Form1
                {
                    Text = "Nova Aba"
                }
            });

            //Index 0
            conteudo.SelectedTabIndex = 0;

            //Criamos um objeto para o contexto
            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();

            //Inicia nosso conteúdo com Chromium
            applicationContext.Start(conteudo);

            //Executar
            Application.Run(applicationContext);
        }
    }
}
