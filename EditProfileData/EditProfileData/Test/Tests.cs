using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace EditProfileData.Test
{
    [TestFixture]
    class Tests
    {
        Model.Employee e1 = new Model.Employee();
        
        Logic.UserValidation tempUserValidation;

        [TestFixtureSetUp]
        public void init()
        {
            e1.setId(1001);
            e1.setUserName("georgi123");
            e1.setPassword("654321");
            e1.setFirstName("Georgi");
            e1.setSecondName("Georgiev");
            e1.setLastName("Gogov");
            e1.setAcademicType("щат");
            e1.setFaculty("FKSU");
            e1.setSpeciality("OS");
            e1.setAcademicDepartment("CS");
            e1.setIsMemberInManagement(false);

            Data.Store.insertUser(e1);
            e1.setTempUserData();
            tempUserValidation = new Logic.UserValidation(Model.Employee.tempUser);

        }

        [Test]
        public void validateUserNameTest()
        {

            Assert.True(tempUserValidation.validateUserName());
        }

        [Test]
        public void validateUserPasswordTest()
        {
            Assert.True(tempUserValidation.validatePassword());
        }

        [Test]
        public void validateUserFirstNameTest()
        {
            Assert.True(tempUserValidation.validateFirstName());
        }

        [Test]
        public void validateUserSecondNameTest()
        {
            Assert.True(tempUserValidation.validateSecondName());
        }

        [Test]
        public void validateUserLastNameTest()
        {
            Assert.True(tempUserValidation.validateLastName());
        }

        [Test]
        public void validateUserTypeTest()
        {
            Assert.True(tempUserValidation.validateUserType());
        }

        [Test]
        public void validateUserAcademicTypeTest()
        {
            Assert.True(tempUserValidation.validateAcademicType());
        }

        [Test]
        public void validateUserAcademicDepartmentTest()
        {
            Assert.True(tempUserValidation.validateAcademicDepartment());
        }

        [Test]
        public void validateUserFacultyTest()
        {
            Assert.True(tempUserValidation.validateFaculty());
        }

        [Test]
        public void validateUserSpecialityTest()
        {
            Assert.True(tempUserValidation.validateSpeciality());
        }

        [Test]
        public void validateManagingStructTest()
        {
            Assert.True(tempUserValidation.validateManagingStruct());
        }

        [Test]
        public void validateTempUserTest()
        {
            Assert.True(e1.validateTempUser());
        }

        [Test]
        public void submitChangesTest()
        {
            e1.submitChanges();
            Assert.AreEqual(e1.getUserName(), Model.Employee.tempUser.getUserName());
            Assert.AreEqual(e1.getPassword(), Model.Employee.tempUser.getPassword());
            Assert.AreEqual(e1.getFirstName(), Model.Employee.tempUser.getFirstName());
        }

        [Test]
        public void ignoreChangesTest()
        {
            e1.ignoreAll();
            Assert.AreEqual(e1.getUserName(), Model.Employee.tempUser.getUserName());
            Assert.AreEqual(e1.getPassword(), Model.Employee.tempUser.getPassword());
            Assert.AreEqual(e1.getFirstName(), Model.Employee.tempUser.getFirstName());
        }


    }
}
