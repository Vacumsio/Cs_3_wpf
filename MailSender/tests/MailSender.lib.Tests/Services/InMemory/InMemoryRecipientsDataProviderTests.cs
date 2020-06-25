using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MailSender.lib.Entities;
using MailSender.lib.Services.InMemory;

namespace MailSender.lib.Tests.Services.InMemory
{
    /// <summary>
    /// Сводное описание для InMemoryRecipientsDataProviderTests
    /// </summary>
    [TestClass]
    public class InMemoryRecipientsDataProviderTests
    {
        [AssemblyInitialize]
        public static void TestAssembly_Initialize(TestContext context) { }
        [ClassInitialize]
        public static void TestClass_Initialize(TestContext context) { }
        [TestInitialize]
        public void Test_Initialize() { }
        [TestCleanup]
        public void CleanUp() { }
        [TestCleanup]
        public static void TestClass_CleanUp() { }
        [AssemblyCleanup]
        public static void TestAssembly_CleanUp() { }

        [TestMethod]
        public void CreateNewRecipientinEmptyProvider()
        {
            var data_provider = new InMemoryRecipientsDataProvider();

            var expected_recipient_name = "Получатель 1";
            var expected_recipient_address = "recipient@sender.ru";
            var expected_id = 1;

            var new_recipient = new Recipient
            {
                Name = expected_recipient_name,
                Address = expected_recipient_address
            };

            data_provider.Create(new_recipient);

            var actual_id = new_recipient.Id;

            var actual_recipient = data_provider.GetById(expected_id);

            Assert.AreEqual(expected_id, actual_id);
            Assert.AreEqual(expected_recipient_name, actual_recipient.Name);
            Assert.AreEqual(expected_recipient_address, actual_recipient.Address);
        }
    }
}
