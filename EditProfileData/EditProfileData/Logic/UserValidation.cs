using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EditProfileData.Model;

namespace EditProfileData.Logic
{
    class UserValidation
    {
        Employee user;

        public UserValidation(Employee user)
        {
            this.user = user;
        }

        public bool validateUserName()
        {
            if (!(user.getUserName().Length < 6))
                return true;
            if (Data.Store.getUserByUserName(user.getUserName()) == null)
            {
                return true;
            }
            return false;
        }

        public bool validatePassword()
        {
            if (user.getPassword().Length < 6)
            {
                return false;
            }
            return true;
        }

        public bool validateFirstName()
        {
            if (user.getFirstName().Length < 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validateSecondName()
        {
            if (user.getSecondName().Length < 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validateLastName()
        {
            if (user.getLastName().Length < 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validateUserType()
        {
            if (user.getType().Equals(UserType.EMPLOYEE))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool validateAcademicType()
        {
            if (user.getAcademicType().Equals("щат", StringComparison.OrdinalIgnoreCase)
                || user.getAcademicType().Equals("хонорар", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool validateFaculty()
        {
            if (user.getFaculty().Length < 2)
            {
                return false;
            }
            return true;
        }

        public bool validateAcademicDepartment()
        {
            if (user.getAcademicDepartment().Length < 2)
            {
                return false;
            }
            return true;
        }

        public bool validateSpeciality()
        {
            if (user.getSpeciality().Length < 2)
            {
                return false;
            }
            return true;
        }

        public bool validateManagingStruct()
        {
            if (user.getIsMemberInManagement() == true)
            {
                if (user.getManagingStruct().Length < 2)
                {
                    return false;
                }
                return true;
            }
            else
            {
                if (user.getManagingStruct().Equals(string.Empty))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
