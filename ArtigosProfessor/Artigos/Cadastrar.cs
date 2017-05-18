using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Data;


namespace Artigos
{
    public partial class Cadastrar : Form
    {

        public bool logado = false;
        private Conexao conn;
        private SqlConnection ConnectOpen;
        private SqlCommand command;
        private string perfilSelecionado;

        public Cadastrar()
        {
            InitializeComponent();
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDatabase();
        }
        
        //metodo botao cadastrar    
        private void button1_Click(object sender, EventArgs e)
        {
            //incluir o using System.Text
            //sql é a variavel para comando SQL
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into usuarios(Usuario, senha, perfil) ");
            sql.Append("Values (@usuario, @senha, @perfil)");
            command = null;

            //verifica qual perfil foi selecionado
            int perfilSeleted = getPerfilNumero(cmbPerfil.Text);
            try
            {
                /**inicia comando sql com a construção do SQLCommand e adiciona os parametros
                 * e adiciona pelo metodo Parameters.Add(new SqlParameter(campo do comando sql, campo do Form))
                 */
                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@usuario", txtUsuario.Text));
                command.Parameters.Add(new SqlParameter("@senha", txtSenha.Text));
                command.Parameters.Add(new SqlParameter("@perfil", perfilSeleted));
                //executa comando SQL
                command.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com sucesso!");
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);
                throw;
            }
        }

        //metodo do botao listar
        private void button3_Click(object sender, EventArgs e)
        {
            //instancia o form ListarUsuario e exibe como Dialog
            var listarUsuario = new ListarUsuario();
            listarUsuario.ShowDialog();


            //Verificar se foi selecionado algum item
            if (listarUsuario.UsuarioSelecionado == "")
                return;

            var conn = new Conexao().ConnectToDatabase();

            //Buscar Usuario
            string sql = "Select * from usuarios where Usuario = '" + listarUsuario.UsuarioSelecionado + "'";

            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            dataAdapter.Fill(dataTable);

            //Linha 0, Coluna 0
            txtUsuario.Text = dataTable.Rows[0][0].ToString();

            //Linha 0, Coluna 1
            txtSenha.Text = dataTable.Rows[0][1].ToString();
            
            getPerfilTexto(dataTable.Rows[0][2].ToString());
            cmbPerfil.Text = perfilSelecionado;
            //muda nome de botao cadastrar para "alterar"
            button1.Text = "Alterar";
            if(button1.Text == "Alterar")
            {
                this.button1.Click -= new System.EventHandler(this.button1_Click);
                this.button1.Click += new System.EventHandler(this.btnAtualizar_Click);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            atualizarDados();
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {
            if(Login.perfilUsuario == 3)
            {
                lblPerfil.Visible = true;
                cmbPerfil.Visible = true;
                btnListar.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void atualizarDados()
        {
            var conn = new Conexao().ConnectToDatabase();
            string sql = "UPDATE USUARIOS SET senha = @senha, perfil = @perfil where usuario = @usuario";
            try
            {
                command = new SqlCommand(sql, conn);
                command.Parameters.Add(new SqlParameter("@senha", txtSenha.Text));
                var perfilNumero = getPerfilNumero(cmbPerfil.Text);
                command.Parameters.Add(new SqlParameter("@perfil", perfilNumero));
                command.Parameters.Add(new SqlParameter("@usuario", txtUsuario.Text));
                command.ExecuteNonQuery();

                MessageBox.Show("Usuario alterado com sucesso");
                limparCampos();
                configuraBtnCadastrar();
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao alterar usuario!");
            }
        }

        private void configuraBtnCadastrar()
        {
            button1.Text = "Cadastrar";
            this.button1.Click -= new System.EventHandler(this.btnAtualizar_Click);
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        private void limparCampos()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            cmbPerfil.Text = "Selecione um perfil";
        }

        private int getPerfilNumero(string txtPerfil)
        {
            switch (txtPerfil)
            {
                case "Autores":
                    return 1;
                case "Revisores":
                    return 2;
                case "Gerente":
                    return 3;
                default:
                    return 0;
            }
        }

        private void getPerfilTexto(string txtPerfil)
        {
            switch (txtPerfil)
            {
                case "1":
                    this.perfilSelecionado = "Autores";
                    break;
                case "2":
                    this.perfilSelecionado = "Revisores";
                    break;
                case "3":
                    this.perfilSelecionado = "Gerente";
                    break;
                default:
                    this.perfilSelecionado = "Autores";
                    break;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Deseja realmente excluir o usuário?", "Excluir usuário", MessageBoxButtons.YesNo))
                excluirUsuario();
        }

        private void excluirUsuario()
        {
            var conn = new Conexao().ConnectToDatabase();
            string sql = "DELETE FROM USUARIOS WHERE USUARIO = @usuario";
            try
            {
                command = new SqlCommand(sql, conn);
                command.Parameters.Add(new SqlParameter("@usuario", txtUsuario.Text));
                command.ExecuteNonQuery();

                MessageBox.Show("Usuário Excluido!");
                limparCampos();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao excluir usuário!");
            }
            
        }
    }
}
