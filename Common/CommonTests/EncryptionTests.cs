using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.CommonUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CommonUtilities.Tests
{
    [TestClass()]
    public class EncryptionTests
    {
        

        [TestMethod()]
        public void EncryptTest()
        {
            Encryption.Securitykey = "securitykey";
            string encryptedText = Encryption.Encrypt("nageshajab");

            Assert.IsNotNull(encryptedText);
            Assert.IsTrue(encryptedText == "DKsNCQB6Zyk0/EPe85AhLQ==");
        }

        [TestMethod()]
        public void DecryptTest()
        {
            Encryption.Securitykey = "securitykey";
            string decryptedText = Encryption.Decrypt("DKsNCQB6Zyk0/EPe85AhLQ==");

            Assert.IsNotNull(decryptedText);
            Assert.IsTrue(decryptedText == "nageshajab");
        }
    }
}