﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace AccesoDatos
{
    public class AccesoBase
    {
        MySqlConnection _conn;
        public AccesoBase(string s, string u, string p, string b, uint po)
        {
            _conn = new MySqlConnection(string.Format("server={0}; user={1}; password={2}; database = {3}; port = {4}", s, u, p,
                b, po));
        }
        public string Comando(string q)
        {
            try
            {
                MySqlCommand c = new MySqlCommand(q, _conn);
                _conn.Open();
                c.ExecuteNonQuery();
                _conn.Close();
                return "Correcto";
            }
            catch (Exception ex)
            {
                _conn.Close();

                return ex.Message;
            }

        }
        public DataSet Mostrar(string q, string tabla)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(q, _conn);
                _conn.Open();
                da.Fill(ds, tabla);
                _conn.Close();
                return ds;
            }
            catch (Exception)
            {
                _conn.Close();
                return ds;
            }
        }
    }
}
