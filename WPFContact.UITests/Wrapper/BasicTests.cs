using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPFContact.UI.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFContact.Model;

namespace WPFContact.UI.Wrapper.Tests
{
    [TestClass()]
    public class BasicTests
    {
        private Contact _contact;

        [TestInitialize]
        public void Initialize()
        {
            _contact = new Contact
            {
                FirstName = "Steve Jobs",
            };
        }

        [TestMethod()]
        public void ShouldContainModelInModelProperty()
        {
            var wrapper = new ContactWrapper(_contact);
            Assert.AreEqual(_contact, wrapper.Model);           
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldThrowArgumentNullExceptionIfModeIsNull()
        {
            try
            {
                var wrapper = new ContactWrapper(null);
            }
            catch (ArgumentNullException exception)
            {
                Assert.AreEqual("model", exception.ParamName);
                throw;
            }

        }

        [TestMethod]
        public void ShouldGetValueOfUnderlyingModelProperty()
        {
            var wrapper = new ContactWrapper(_contact);
            Assert.AreEqual(_contact.FirstName, wrapper.FirstName);
        }

        [TestMethod]
        public void ShouldSetValueOfUnderlyingModelProperty()
        {
            var wrapper = new ContactWrapper(_contact);
            wrapper.FirstName = "Julia";
            Assert.AreEqual("Julia", _contact.FirstName);
               
        }


    }
}