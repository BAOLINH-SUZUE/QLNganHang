using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNganHang
{
    internal class account
    {
        public account(string userName, string citizenID, int type, string password = null)
        {
            this.UserName = userName;
            this.CitizenID = citizenID;
            this.Type = type;
            this.Password = password;
        }

        public account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.CitizenID = row["citizenID"].ToString();
            this.Type = (int)row["type"];
            this.Password = row["password"].ToString();
        }

        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string citizenID;

        public string CitizenID
        {
            get { return citizenID; }
            set { citizenID = value; }
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}
