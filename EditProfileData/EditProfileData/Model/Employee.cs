using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EditProfileData.Model;

namespace EditProfileData.Model
{
    class Employee : User
    {
        private string academicType = string.Empty;
        private string academicDepartment = string.Empty;
        private string faculty = string.Empty;
        private string speciality = string.Empty;
        private bool isMemberInManagement = false;
        private string managingStruct = string.Empty;
        public static Employee tempUser = new Employee();
        public Logic.UserValidation tempUserValidation;

        public Employee()
        {
            base.setType(UserType.EMPLOYEE);
        }

        public string getAcademicType()
        {
            return this.academicType;
        }

        public void setAcademicType(string aType)
        {
            this.academicType = aType;
        }

        public string getFaculty()
        {
            return this.faculty;
        }

        public void setFaculty(string faculty)
        {
            this.faculty = faculty;
        }

        public string getAcademicDepartment()
        {
            return this.academicDepartment;
        }

        public void setAcademicDepartment(string academicDepartment)
        {
            this.academicDepartment = academicDepartment;
        }

        public string getSpeciality()
        {
            return this.speciality;
        }

        public void setSpeciality(string speciality)
        {
            this.speciality = speciality;
        }

        public bool getIsMemberInManagement()
        {
            return this.isMemberInManagement;
        }

        public void setIsMemberInManagement(bool isMemberInManagement)
        {
            this.isMemberInManagement = isMemberInManagement;
        }

        public string getManagingStruct()
        {
            return this.managingStruct;
        }

        public void setManagingStruct(string managingStruct)
        {
            this.managingStruct = managingStruct;
        }

        public void setTempUserData()
        {
            tempUser.setUserName("ivan11");
            tempUser.setFirstName("Valery");
            tempUser.setPassword("qwerty");
            tempUser.setSecondName("Radoslavov");
            tempUser.setLastName("Maznev");
            tempUser.setSpeciality("OS");
            tempUser.setFaculty("FKSU");
            tempUser.setAcademicDepartment("CS");
            tempUser.setAcademicType("щат");
            tempUser.setIsMemberInManagement(false);
            tempUserValidation = new Logic.UserValidation(tempUser);
        }

        public bool validateTempUser()
        {
            if (tempUserValidation.validateUserName() == false)
                return false;
            if (tempUserValidation.validatePassword() == false)
                return false;
            if (tempUserValidation.validateFirstName() == false)
                return false;
            if (tempUserValidation.validateSecondName() == false)
                return false;
            if (tempUserValidation.validateLastName() == false)
                return false;
            if (tempUserValidation.validateUserType() == false)
                return false;
            if (tempUserValidation.validateAcademicType() == false)
                return false;
            if (tempUserValidation.validateAcademicDepartment() == false)
                return false;
            if (tempUserValidation.validateFaculty() == false)
                return false;
            if (tempUserValidation.validateSpeciality() == false)
                return false;
            if (tempUserValidation.validateManagingStruct() == false)
                return false;
            return true;
        }

        public void submitChanges()
        {
            this.setUserName(tempUser.getUserName());
            this.setPassword(tempUser.getPassword());
            this.setFirstName(tempUser.getFirstName());
            this.setSecondName(tempUser.getSecondName());
            this.setLastName(tempUser.getLastName());
            this.setFaculty(tempUser.getFaculty());
            this.setAcademicType(tempUser.getAcademicType());
            this.setAcademicDepartment(tempUser.getAcademicDepartment());
            this.setSpeciality(tempUser.getSpeciality());
            this.setIsMemberInManagement(tempUser.getIsMemberInManagement());
            Data.Store.updateUser(this);
        }

        public void ignoreAll()
        {
            tempUser.setUserName(this.getUserName());
            tempUser.setPassword(this.getPassword());
            tempUser.setFirstName(this.getFirstName());
            tempUser.setSecondName(this.getSecondName());
            tempUser.setLastName(this.getLastName());
            tempUser.setFaculty(this.getFaculty());
            tempUser.setAcademicType(this.getAcademicType());
            tempUser.setAcademicDepartment(this.getAcademicDepartment());
            tempUser.setSpeciality(this.getSpeciality());
            tempUser.setIsMemberInManagement(this.getIsMemberInManagement());
        }
            
    }
}
