using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employment_Services_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Employment_Services_System.Tests
{
    [TestClass]
    public class business_streamTests : DataTestBase
    {
        [TestMethod]
        public void business_streamPropertiesWork()
        {
            business_stream bs1 = new business_stream()
            {
                id = 1,
                business_stream_name = "Stream Name 1"
            };

            company _company = new company()
            {
                id = 1,
                company_name = "Name1",
                business_stream_id = 1,
                company_website_url = "name1.com",
                establishment_date = DateTime.Now,
                profile_description = "desc1"
            };

            bs1.company.Add(_company);

            employmentDataContext.business_stream.Add(bs1);
            Xunit.Assert.NotEqual(0, employmentDataContext.SaveChanges());

            bs1 = employmentDataContext.business_stream.Find(bs1.id);

            Xunit.Assert.NotNull(bs1);
            Xunit.Assert.NotNull(bs1.company);

        }
    }
}