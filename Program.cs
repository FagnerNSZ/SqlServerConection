using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;


namespace ConectionBdSqlServer
{
    class Program
    {


        static void Main(string[] args)
        {


            // DAL.DAL_Usuario.ListUsuario();
            DAL.DAL_Usuario.Listar();
            DAL.DAL_Usuario.Inserir("teste", "teste");
            DAL.DAL_Usuario.UpdateUsuario("te","te",1);

        }

        
    }
}
