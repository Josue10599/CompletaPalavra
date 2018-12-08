using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace CompletaNome
{
    class Banco
    {
        private SQLiteConnection conn;
        private SQLiteCommand command;
        private string database;
        private string table;

        public Banco()
        {            
            database = "bancopal.db";
            table = "banpal";
            if (!File.Exists(database))
            {
                SQLiteConnection.CreateFile(database);
                conn = new SQLiteConnection("Data Source=bancopal.db");
                conn.Open();
                
                string sql ="CREATE TABLE IF NOT EXISTS " + table + " ( cod INT NOT NULL, pal VARCHAR(250) NOT NULL);";

                command = new SQLiteCommand(sql, conn);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar o banco de dados: " + ex.Message);
                    throw;
                }
                
            }
            else
            {
                try
                {
                    conn = new SQLiteConnection("Data Source=bancopal.db");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao SQLite: " + ex.Message);
                    throw;
                }
            }     
        }

        private bool executaQuery(string query)
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            command = new SQLiteCommand(query, conn);
            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Erro ao executar comando: " + query + "\nMensagem de erro:"+ ex.Message);
                throw;
            }
        }

        private void OrdenaCod(string id_excluido)
        {
            executaQuery("UPDATE " + table + " SET cod = cod - 1 WHERE cod >" + id_excluido + ";");
        }

        public ArrayList LoadList(int coluna)
        {
            ArrayList valores = new ArrayList();

            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            command = new SQLiteCommand("SELECT * FROM " + table + " ORDER BY cod", conn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                valores.Add(reader[coluna].ToString());
            }
                
            conn.Close();
            return valores;
        }

        public void DeleteWord(string cod)
        {
            if (cod != "")
            {
                if (executaQuery("DELETE FROM " + table + " WHERE cod =('" + cod + "')"))
                {
                    OrdenaCod(cod);
                    MessageBox.Show("Deletado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }            
        }

        public void UpdateWord(string cod, string palavra)
        {
            if (palavra != "" && cod !="")
            {
                if(executaQuery("UPDATE " + table + " SET pal ='" + palavra + "' WHERE cod='" + cod + "'"))
                    MessageBox.Show("Atualizado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }              
        }

        public void AddWord(string cod,string palavra)
        {
            if (palavra != "")
            {
                if(executaQuery("INSERT INTO " + table + " (cod, pal) VALUES ('" + cod + "','" + palavra + "')"))
                    MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public String SourceWord(string cod)
        {
            string palavra = "";
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();               
                command = new SQLiteCommand("SELECT pal FROM " + table +" WHERE cod = "+cod, conn);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    palavra = reader["pal"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao buscar palavra: " + ex.Message);                
            }
            return palavra;
        }
        
    }

}
