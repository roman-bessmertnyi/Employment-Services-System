using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employment_Services_System;
using System.Data.Entity;

namespace Employment_Services_System.Tests
{
    /// <summary>
    /// Summary description for DataTestBase
    /// </summary>
    [TestClass]
    public class DataTestBase : IDisposable
    {
        public EmploymentDataContext employmentDataContext;

        public DataTestBase()
        {
            employmentDataContext = new EmploymentDataContext("TestConnection");
            CleanDatabase();
        }

        public void CleanDatabase()
        {
            employmentDataContext.business_stream.RemoveRange(employmentDataContext.business_stream);
            employmentDataContext.company.RemoveRange(employmentDataContext.company);
            employmentDataContext.company_image.RemoveRange(employmentDataContext.company_image);
            employmentDataContext.education_detail.RemoveRange(employmentDataContext.education_detail);
            employmentDataContext.experience_detail.RemoveRange(employmentDataContext.experience_detail);
            employmentDataContext.job_location.RemoveRange(employmentDataContext.job_location);
            employmentDataContext.job_post.RemoveRange(employmentDataContext.job_post);
            employmentDataContext.job_post_activity.RemoveRange(employmentDataContext.job_post_activity);
            employmentDataContext.job_post_skill_set.RemoveRange(employmentDataContext.job_post_skill_set);
            employmentDataContext.job_type.RemoveRange(employmentDataContext.job_type);
            employmentDataContext.seeker_profile.RemoveRange(employmentDataContext.seeker_profile);
            employmentDataContext.seeker_skill_set.RemoveRange(employmentDataContext.seeker_skill_set);
            employmentDataContext.skill_set.RemoveRange(employmentDataContext.skill_set);
            employmentDataContext.user_account.RemoveRange(employmentDataContext.user_account);
            employmentDataContext.user_log.RemoveRange(employmentDataContext.user_log);
            employmentDataContext.user_type.RemoveRange(employmentDataContext.user_type);
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    employmentDataContext.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
