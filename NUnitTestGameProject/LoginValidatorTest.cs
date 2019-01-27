using NUnit.Framework;
using RefactoredGameProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestGameProject
{
    [TestFixture]
    public class LoginValidatorTest
    {
        LoginValidator loginvalidator;

        [SetUp]
        public void TestSetup()
        {
            loginvalidator = new LoginValidator();
        }

        [Test]
        public void test_if_login_is_valid()
        {
            bool ifloginvalid = loginvalidator.LoginValidate("asdasd123");

            Assert.IsTrue(ifloginvalid);
        }

        [Test]
        public void test_if_login_is_not_valid()
        {
            bool ifloginnotvalid = loginvalidator.LoginValidate("asdasd123@");

            Assert.IsFalse(ifloginnotvalid);
        }
    }
}
