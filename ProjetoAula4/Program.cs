using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleInjector;
using UNITPAC.LTPV.Dados.Interfaces;
using UNITPAC.LTPV.Dados.Repositorios;

namespace ProjetoAula4
{
    static class Program
    {
        public static Container container;

        private static void Bootstrap()
        {
            container = new Container();
            container.Register<IAlunoRepositorio, AlunoRepositorio>();
            container.Verify();
        }
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(new FrmPrincipal());
        }
    }
}
