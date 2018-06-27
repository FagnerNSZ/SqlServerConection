using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace ConectionBdSqlServer.Entity
{
    [DataObject]
    public class EntityUsuario
    {
        public EntityUsuario()
        { }
        private int _IdUsuario;
        [DataObjectField(true, true)]
        public int IdUsuario
        {
            get { return _IdUsuario; }

            set { _IdUsuario = value; }
        }
        private string _NmUsuario;
        [DataObjectField(false)]
        public string NmUsuario
        {
            get { return _NmUsuario; }
            set { _NmUsuario = value; }
        }


        private string _PassUsuario;
        [DataObjectField(false)]
        public string PassUsuario
        {
            get { return _PassUsuario; }
            set { _PassUsuario = value; }
        }



    }
}
