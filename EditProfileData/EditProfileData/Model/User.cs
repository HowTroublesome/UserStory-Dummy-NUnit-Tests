using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EditProfileData.Model
{
    class User
    {
        public int id;
        public string userName = string.Empty;
        public string password = string.Empty;
        public UserType type;
        private string firstName = string.Empty;
        private string secondName = string.Empty;
        private string lastName = string.Empty;

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getUserName()
        {
            return this.userName;
        }

        public void setUserName(string uName)
        {
            this.userName = uName;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string pass)
        {
            this.password = pass;
        }

        public UserType getType()
        {
            return this.type;
        }

        public void setType(UserType u)
        {
            this.type = u;
        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public void setFirstName(string fName)
        {
            this.firstName = fName;
        }

        public string getSecondName()
        {
            return this.secondName;
        }

        public void setSecondName(string sName)
        {
            this.secondName = sName;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public void setLastName(string lName)
        {
            this.lastName = lName;
        }
    }
}
