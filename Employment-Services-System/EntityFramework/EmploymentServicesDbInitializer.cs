using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Employment_Services_System.Migrations;
using Employment_Services_System.Models;

namespace Employment_Services_System.EntityFramework
{
    internal sealed class EmploymentServicesDbInitializer : MigrateDatabaseToLatestVersion<EmploymentServicesDatabaseContext, Configuration>
    {
    }
}