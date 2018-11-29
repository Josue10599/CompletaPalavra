using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompletaNome
{
    class Banco
    {
        private MySqlConnection conn;
        private MySqlCommand command;
        private string server;
        private string port;
        private string database;
        private string table;
        private string usuario;
        private string senha;

        public Banco(string server, string port, string database, string usuario, string senha, string table)
        {
            this.server = server;
            this.port = port;
            this.database = database;
            this.usuario = usuario;
            this.senha = senha;
            this.table = table;
            string connString = "server=" + server + "; " +
                "port=" + port + "; database=" + database + "; User Id=" + usuario + "; " +
                "password=" + senha + "; Allow User Variables = True; ";
            conn = new MySqlConnection(connString);
            command = conn.CreateCommand();
        }

        private void executaQuery(string query)
        {
            conn.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void OrdenaCod()
        {
            executaQuery("SET @count =0;  UPDATE `" + table + "` SET `" + table + "`.`cod` = @count:= @count +1");
        }

        public ArrayList LoadList(int coluna)
        {
            ArrayList valores = new ArrayList();
            OrdenaCod();
            conn.Open();
            command.CommandText = "SELECT * FROM " + table +" ORDER BY cod ";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    valores.Add(reader[coluna].ToString());
                }
            }
            conn.Close();
            return valores;
        }

        public void DeleteWord(string id)
        {
            if (id != "")
            {
                executaQuery("DELETE FROM " + table + " WHERE cod =('" + id + "')");
                MessageBox.Show("Deletado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        public void UpdateWord(string id, string palavra)
        {
            if (palavra != "" && id !="")
            {
                executaQuery("UPDATE " + table + " SET pal ='" + palavra + "' WHERE cod='" + id + "'");
                MessageBox.Show("Atualizado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }              
        }

        public void AddWord(string palavra)
        {            
            if (palavra != "")
            {
                executaQuery("INSERT INTO " + table + " (pal) VALUES ('" + palavra + "')");
                MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        public String SourceWord(string id) {
            string palavra = "";
            try
            {                
                conn.Open();               
                command.CommandText = "SELECT pal FROM "+ table +" WHERE cod = "+id ;
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    palavra = reader["pal"].ToString();
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Falha na conexão");                
            }
            return palavra;
        }
        
    }

}
