using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD_Basico
{
    public partial class Form1 : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        

        string strSql;

        public Form1()
        {
           
            InitializeComponent();
        }

        private void txtNovo_Click(object sender, EventArgs e)
        {

            try
            {
                conexao = new SqlConnection("Server=LAPTOP-DPAT0JHO\\SQLEXPRESS;Database=Cliente;User Id=AcessoCliente; Password = 123;");
                strSql = "INSERT INTO Cad_Cliente (NOME, NUMERO)  VALUES (@NOME, @NUMERO)";
                comando = new SqlCommand(strSql, conexao);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@NUMERO", txtNumero.Text);

                MessageBox.Show("Cadastro inserido com êxito!", "Cadastro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Open();
                comando.ExecuteNonQuery();
                txtNome.Clear();
                txtNumero.Clear();
                txtNome.Focus();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;

            }
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtExibir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=LAPTOP-DPAT0JHO\\SQLEXPRESS;Database=Cliente;User Id=AcessoCliente; Password = 123;");
                strSql = "SELECT * FROM Cad_Cliente";

                DataSet ds = new DataSet();
                da = new SqlDataAdapter(strSql, conexao);

                conexao.Open();
                da.Fill(ds);

                dgvDados.DataSource = ds.Tables[0];
                
                txtNome.Clear();
                txtNumero.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNumero.Clear();
        }

        private void txtConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=LAPTOP-DPAT0JHO\\SQLEXPRESS;Database=Cliente;User Id=AcessoCliente; Password = 123;");
                strSql = "SELECT * FROM CAD_CLIENTE WHERE ID = @ID";
                comando = new SqlCommand(strSql, conexao);
                comando.Parameters.AddWithValue("@ID", txtID.Text);


                conexao.Open();
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtNome.Text = (string)dr["nome"];
                    txtNumero.Text = Convert.ToString(dr["numero"]);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;

            }
        }
    }
}
