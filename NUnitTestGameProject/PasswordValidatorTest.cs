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
    public class PasswordValidatorTest
    {
        PasswordValidator passwordvalidator;

        [SetUp]
        public void TestSetup()
        {
            passwordvalidator = new PasswordValidator();
        }

        [Test]
        public void test_if_password_is_valid()
        {
            bool ifpasswordvalid = passwordvalidator.PasswordValidate("asdasd123@");

            Assert.IsTrue(ifpasswordvalid);
        }

        [Test]
        public void test_if_password_is_not_valid()
        {
            bool ifpasswordnotvalid = passwordvalidator.PasswordValidate("asdasd1");

            Assert.IsFalse(ifpasswordnotvalid);
        }
    }
}
