using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace QUANLYHOCSINH
{
     public class USERS
    {
        QUANLYHOCSINHEntities db;

        public USERS()
        {
            db = new QUANLYHOCSINHEntities();

        }
        public tb_User getItem(string username)
        {
            return db.tb_User.FirstOrDefault(x => x.Username == username);

        }
        public int Login(string username, string pass)
        {
            var user = db.tb_User.FirstOrDefault(x=>x.Username == username && x.Pass == pass);
            if(user != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}
