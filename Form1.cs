using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String movil = txtMovil.Text;
            String telefono = txtTelefono.Text;
            String direccion = txtDireccion.Text;
            String correo = txtCorreo.Text;
            String estado = Convert.ToString(cmbEstado.SelectedValue);
            String genero = Convert.ToString(cmbEstado.SelectedValue);
            String nacimiento = dtNacimiento.Text;
            string sql = "INSERT INTO datos (nombre, apellido, movil, telefono, direccion, correo, estado_civil, genero, " +
                "fecha_de_nacimiento) VALUES ('" + nombre + "','" + apellido + "','" + movil + "','" + telefono + "','" + direccion + "','" + correo + "'," +
                "'" + estado + "','" + genero + "','" + nacimiento + "')";
            MySqlConnection conexionbd = new MySqlConnection();
            
            try
            {
                conexionbd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionbd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Datos Agregados");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error"+ex.Message) ;
                throw;
            
            }
            finally
            {
                conexionbd.Close(); 
            }

        }
    }
}
