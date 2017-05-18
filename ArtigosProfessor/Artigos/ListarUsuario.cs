using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artigos
{
    public partial class ListarUsuario : Form
    {
        public string UsuarioSelecionado = "";

        public ListarUsuario()
        {
            InitializeComponent();
        }

        private void ListarUsuario_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new Conexao().ConnectToDatabase();
            //Buscar todos usuários cadastrados
            string sql = "Select * from usuarios ";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            dataAdapter.Fill(dataTable);
            
            //numero de linhas maior que 0
            if(dataTable.Rows.Count > 0)
            {
                //tabela do Form recebe dados do BD
                dataGridView1.DataSource = dataTable;
            }
        }

        //metodo de seleção de celula
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //celula selecionada menor que 0
            if (e.RowIndex < 0)
                return;

            //Recuperar a linha selecionada
            UsuarioSelecionado = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //Fechar a tela
            Hide();
        }
    }
}
