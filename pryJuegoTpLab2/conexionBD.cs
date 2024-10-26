using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryJuegoTpLab2
{
    public class conexionBD
    {
        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        string cadena;
        public conexionBD()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./Jugadores.accdb;";
        }

        public void imprimirUsuarios(DataGridView dgvUsuarios)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Jugadores";

                DataTable tablaUsuarios = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaUsuarios);

                dgvUsuarios.DataSource = tablaUsuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void agregarUsuario(string usuario, int puntos)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"INSERT INTO Jugadores(Jugador, Puntaje) VALUES('{usuario}', '{puntos}')";

                conexion.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*finally
            {
                conexion.Close();
            }*/
        }
        public void actualizarUsuario(string usuario, int puntos)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"UPDATE Jugadores SET Puntaje = Puntaje + {puntos} WHERE Jugador = '{usuario}'";
                conexion.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool verificarUsuario(string usuario)
        {
            try
            {
                // Using es para asegurarse que cuando salga se cierra la conexion
                // Se crea una instancia OleDbConnection con el parametro de la cadena de conexion
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    // La consulta cuenta todos los registros de la tabla comparando la columna Jugador
                    // con el valor del parametro usuario y se guarda en string query
                    string query = "SELECT COUNT(*) FROM Jugadores WHERE Jugador = @usuario";

                    //objeto comando con la query y la conexion
                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        // Esta linea es para agregar un parametro al comando (este caso usuario)
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        conexion.Open();

                        // ExecuteScalar() ejectua la query y devuelve la cantidad de veces que
                        // se encontro el usuario en la tabla y se guarda en int contador
                        int contador = (int)comando.ExecuteScalar();

                        // Si contador es mayor a 0 devuelve true, osea existe el juggador
                        // Si es menor a 0 devuelve false, no existe
                        return contador > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar usuario: " + ex.Message);
                return false;
            }
        }
        public List<string> jugadoresExistentes()
        {
            List<string> jugadores = new List<string>();
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT Jugador FROM Jugadores";

                DataTable tablaJugadores = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaJugadores);

                foreach(DataRow fila in tablaJugadores.Rows)
                {
                    jugadores.Add(fila["Jugador"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return jugadores;
        }
    }
}
