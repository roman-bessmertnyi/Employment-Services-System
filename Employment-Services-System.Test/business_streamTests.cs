using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employment_Services_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Employment_Services_System.Tests
{
    
    public class business_streamTests
    {
        [Fact]
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
                profile_description = "desc1",
                business_stream = bs1
                
            };

            bs1.companies.Add(_company);

            Xunit.Assert.NotNull(bs1);
            Xunit.Assert.NotNull(bs1.companies);

        }
    }
}