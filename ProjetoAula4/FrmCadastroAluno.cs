using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNITPAC.LTPV.Dados.Interfaces;

namespace ProjetoAula4
{
    public partial class FrmCadastroAluno : Form
    {
        private IAlunoRepositorio _repositorio;
        public FrmCadastroAluno()
        {
            InitializeComponent();
            _repositorio = Program.container.GetInstance<IAlunoRepositorio>();

            var registros = _repositorio.ObterTodos();
            dataGridView1.DataSource = registros;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
