using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.CommonUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CSharp.CommonUtilities.Tests
{
    [TestClass()]
    public class AppSettingsTests
    {
        [TestMethod()]
        public void ReadAppSettingsTest()
        {
            IConfiguration configuration = CSharp.CommonUtilities.AppSettings.ReadAppSettings(".", "appsettings.json");
            string connstring = configuration.GetConnectionString("sqlite");
            Assert.IsTrue(connstring.Equals("Data Source=D:\\db_backup\\result.db"));
        }
    }
}