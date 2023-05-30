using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LocadoraClassic.DAL
{
    public class Connection
    {
        private  MySqlConnection _instance;
        public  MySqlConnection Instance
        {   
            get 
            {
                if (_instance == null)
                {
                    _instance = new MySqlConnection(@"Server=127.0.0.1;Database=locadoraclassic;Uid=root;Pwd= ");
                }
                
                return _instance; 
            } 
        
        }
    }
}
