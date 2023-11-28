using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Inventory_System
{
    internal class connections
    {
        private string strserver = Properties.Settings.Default.server;
        private string strport = Properties.Settings.Default.port;
        private string strusername = Properties.Settings.Default.username;
        private string strpassword = Properties.Settings.Default.password;
        private string strdatabase = Properties.Settings.Default.database;

        public MySqlConnection con = new MySqlConnection();

        public void Connect()
        {
            string Constring = "server = " + strserver + "; port = " + strport + "; username = " + strusername + "; password =" + strpassword + "; database = " + strdatabase + "; charset=utf8";
         con = new MySqlConnection(Constring);
         con.Open();
        }
        public void Disconnect()
        {
            con.Close();
        }
    }
}
