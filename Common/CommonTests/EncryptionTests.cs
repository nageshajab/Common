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
          //  Encryption.Securitykey = "securitykey";
            string encryptedText = Encryption.Encrypt("nagesh","securitykey"); 

            Assert.IsNotNull(encryptedText);
            System.Console.WriteLine(encryptedText);
            Assert.IsTrue(encryptedText == "rHBsqcyQp4zsYGNBBXnAgQ==");
        }

        [TestMethod()]
        public void DecryptTest()
        {
          
            string decryptedText =Encryption.Decrypt("rHBsqcyQp4zsYGNBBXnAgQ==","securitykey");

            Assert.IsNotNull(decryptedText);
            Assert.IsTrue(decryptedText == "nagesh");
        }
    }
}