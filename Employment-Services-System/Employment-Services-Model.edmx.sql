
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/11/2018 16:24:56
-- Generated from EDMX file: D:\KPI\Курсовая\Employment Services\Employment-Services-System\Employment-Services-System\Employment-Services-Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TestData];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_company_business_stream]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[company] DROP CONSTRAINT [FK_company_business_stream];
GO
IF OBJECT_ID(N'[dbo].[FK_company_image_company]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[company_image] DROP CONSTRAINT [FK_company_image_company];
GO
IF OBJECT_ID(N'[dbo].[FK_job_post_company]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[job_post] DROP CONSTRAINT [FK_job_post_company];
GO
IF OBJECT_ID(N'[dbo].[FK_educ_dtl_seeker_profile]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[education_detail] DROP CONSTRAINT [FK_educ_dtl_seeker_profile];
GO
IF OBJECT_ID(N'[dbo].[FK_exp_dtl_seeker_profile]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[experience_detail] DROP CONSTRAINT [FK_exp_dtl_seeker_profile];
GO
IF OBJECT_ID(N'[dbo].[FK_job_post_job_location]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[job_post] DROP CONSTRAINT [FK_job_post_job_location];
GO
IF OBJECT_ID(N'[dbo].[FK_job_post_activity_job_post]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[job_post_activity] DROP CONSTRAINT [FK_job_post_activity_job_post];
GO
IF OBJECT_ID(N'[dbo].[FK_job_post_job_type]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[job_post] DROP CONSTRAINT [FK_job_post_job_type];
GO
IF OBJECT_ID(N'[dbo].[FK_job_post_skill_set_job_post]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[job_post_skill_set] DROP CONSTRAINT [FK_job_post_skill_set_job_post];
GO
IF OBJECT_ID(N'[dbo].[FK_job_post_user_register]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[job_post] DROP CONSTRAINT [FK_job_post_user_register];
GO
IF OBJECT_ID(N'[dbo].[FK_job_post_act_user_register]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[job_post_activity] DROP CONSTRAINT [FK_job_post_act_user_register];
GO
IF OBJECT_ID(N'[dbo].[FK_job_post_skill_set_skill_set]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[job_post_skill_set] DROP CONSTRAINT [FK_job_post_skill_set_skill_set];
GO
IF OBJECT_ID(N'[dbo].[FK_seeker_profile_user_register]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[seeker_profile] DROP CONSTRAINT [FK_seeker_profile_user_register];
GO
IF OBJECT_ID(N'[dbo].[FK_skill_set_seeker_profile]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[seeker_skill_set] DROP CONSTRAINT [FK_skill_set_seeker_profile];
GO
IF OBJECT_ID(N'[dbo].[FK_seeker_skill_set_skill_set]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[seeker_skill_set] DROP CONSTRAINT [FK_seeker_skill_set_skill_set];
GO
IF OBJECT_ID(N'[dbo].[FK_use_log_user_register]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[user_log] DROP CONSTRAINT [FK_use_log_user_register];
GO
IF OBJECT_ID(N'[dbo].[FK_user_register_user_type]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[user_account] DROP CONSTRAINT [FK_user_register_user_type];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[business_stream]', 'U') IS NOT NULL
    DROP TABLE [dbo].[business_stream];
GO
IF OBJECT_ID(N'[dbo].[company]', 'U') IS NOT NULL
    DROP TABLE [dbo].[company];
GO
IF OBJECT_ID(N'[dbo].[company_image]', 'U') IS NOT NULL
    DROP TABLE [dbo].[company_image];
GO
IF OBJECT_ID(N'[dbo].[education_detail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[education_detail];
GO
IF OBJECT_ID(N'[dbo].[experience_detail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[experience_detail];
GO
IF OBJECT_ID(N'[dbo].[job_location]', 'U') IS NOT NULL
    DROP TABLE [dbo].[job_location];
GO
IF OBJECT_ID(N'[dbo].[job_post]', 'U') IS NOT NULL
    DROP TABLE [dbo].[job_post];
GO
IF OBJECT_ID(N'[dbo].[job_post_activity]', 'U') IS NOT NULL
    DROP TABLE [dbo].[job_post_activity];
GO
IF OBJECT_ID(N'[dbo].[job_post_skill_set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[job_post_skill_set];
GO
IF OBJECT_ID(N'[dbo].[job_type]', 'U') IS NOT NULL
    DROP TABLE [dbo].[job_type];
GO
IF OBJECT_ID(N'[dbo].[seeker_profile]', 'U') IS NOT NULL
    DROP TABLE [dbo].[seeker_profile];
GO
IF OBJECT_ID(N'[dbo].[seeker_skill_set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[seeker_skill_set];
GO
IF OBJECT_ID(N'[dbo].[skill_set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[skill_set];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[user_account]', 'U') IS NOT NULL
    DROP TABLE [dbo].[user_account];
GO
IF OBJECT_ID(N'[dbo].[user_log]', 'U') IS NOT NULL
    DROP TABLE [dbo].[user_log];
GO
IF OBJECT_ID(N'[dbo].[user_type]', 'U') IS NOT NULL
    DROP TABLE [dbo].[user_type];
GO
IF OBJECT_ID(N'[dbo].[View_1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[View_1];
GO
IF OBJECT_ID(N'[dbo].[View_Seekers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[View_Seekers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'business_stream'
CREATE TABLE [dbo].[business_stream] (
    [id] int  NOT NULL,
    [business_stream_name] varchar(100)  NOT NULL
);
GO

-- Creating table 'company'
CREATE TABLE [dbo].[company] (
    [id] int  NOT NULL,
    [company_name] varchar(100)  NOT NULL,
    [profile_description] varchar(1000)  NOT NULL,
    [business_stream_id] int  NOT NULL,
    [establishment_date] datetime  NOT NULL,
    [company_website_url] varchar(500)  NOT NULL
);
GO

-- Creating table 'company_image'
CREATE TABLE [dbo].[company_image] (
    [id] int  NOT NULL,
    [company_id] int  NOT NULL,
    [company_image1] varbinary(max)  NOT NULL
);
GO

-- Creating table 'education_detail'
CREATE TABLE [dbo].[education_detail] (
    [user_account_id] int  NOT NULL,
    [certificate_degree_name] varchar(50)  NOT NULL,
    [major] varchar(50)  NOT NULL,
    [starting_date] datetime  NOT NULL,
    [completion_date] datetime  NULL,
    [percentage] int  NULL,
    [cgpa] int  NULL,
    [institute_university_name] varchar(50)  NOT NULL
);
GO

-- Creating table 'experience_detail'
CREATE TABLE [dbo].[experience_detail] (
    [user_account_id] int  NOT NULL,
    [is_current_job] char(1)  NOT NULL,
    [start_date] datetime  NOT NULL,
    [end_date] datetime  NOT NULL,
    [job_title] varchar(50)  NOT NULL,
    [company_name] varchar(100)  NOT NULL,
    [job_location_city] varchar(50)  NOT NULL,
    [job_location_state] varchar(50)  NOT NULL,
    [job_location_country] varchar(50)  NOT NULL,
    [description] varchar(4000)  NOT NULL
);
GO

-- Creating table 'job_location'
CREATE TABLE [dbo].[job_location] (
    [id] int  NOT NULL,
    [street_address] varchar(100)  NOT NULL,
    [city] varchar(50)  NOT NULL,
    [state] varchar(50)  NOT NULL,
    [country] varchar(50)  NOT NULL,
    [zip] varchar(50)  NOT NULL
);
GO

-- Creating table 'job_post'
CREATE TABLE [dbo].[job_post] (
    [id] int  NOT NULL,
    [posted_by_id] int  NOT NULL,
    [job_type_id] int  NOT NULL,
    [company_id] int  NOT NULL,
    [is_company_name_hidden] char(1)  NOT NULL,
    [created_date] datetime  NOT NULL,
    [job_description] varchar(500)  NOT NULL,
    [job_location_id] int  NOT NULL,
    [is_active] char(1)  NOT NULL
);
GO

-- Creating table 'job_post_activity'
CREATE TABLE [dbo].[job_post_activity] (
    [user_account_id] int  NOT NULL,
    [job_post_id] int  NOT NULL,
    [apply_date] datetime  NOT NULL
);
GO

-- Creating table 'job_post_skill_set'
CREATE TABLE [dbo].[job_post_skill_set] (
    [skill_set_id] int  NOT NULL,
    [job_post_id] int  NOT NULL,
    [skill_level] int  NOT NULL
);
GO

-- Creating table 'job_type'
CREATE TABLE [dbo].[job_type] (
    [id] int  NOT NULL,
    [job_type1] varchar(20)  NOT NULL
);
GO

-- Creating table 'seeker_profile'
CREATE TABLE [dbo].[seeker_profile] (
    [user_account_id] int  NOT NULL,
    [first_name] varchar(50)  NOT NULL,
    [last_name] varchar(50)  NOT NULL,
    [current_salary] int  NULL,
    [is_annually_monthly] char(1)  NULL,
    [currency] varchar(50)  NULL
);
GO

-- Creating table 'seeker_skill_set'
CREATE TABLE [dbo].[seeker_skill_set] (
    [user_account_id] int  NOT NULL,
    [skill_set_id] int  NOT NULL,
    [skill_level] int  NOT NULL
);
GO

-- Creating table 'skill_set'
CREATE TABLE [dbo].[skill_set] (
    [id] int  NOT NULL,
    [skill_set_name] varchar(50)  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'user_account'
CREATE TABLE [dbo].[user_account] (
    [id] int  NOT NULL,
    [user_type_id] int  NOT NULL,
    [email] varchar(255)  NOT NULL,
    [password] varchar(100)  NOT NULL,
    [date_of_birth] datetime  NOT NULL,
    [gender] char(1)  NOT NULL,
    [is_active] char(1)  NOT NULL,
    [contact_number] int  NOT NULL,
    [sms_notification_active] char(1)  NOT NULL,
    [email_notification_active] char(1)  NOT NULL,
    [user_image] varbinary(max)  NULL,
    [registration_date] datetime  NOT NULL
);
GO

-- Creating table 'user_log'
CREATE TABLE [dbo].[user_log] (
    [user_account_id] int  NOT NULL,
    [last_login_date] datetime  NOT NULL,
    [last_job_apply_date] datetime  NULL
);
GO

-- Creating table 'user_type'
CREATE TABLE [dbo].[user_type] (
    [id] int  NOT NULL,
    [user_type_name] varchar(20)  NOT NULL
);
GO

-- Creating table 'View_1'
CREATE TABLE [dbo].[View_1] (
    [id] int  NOT NULL,
    [job_type] varchar(20)  NOT NULL,
    [company_name] varchar(100)  NOT NULL,
    [job_description] varchar(500)  NOT NULL,
    [street_address] varchar(100)  NOT NULL,
    [skill_level] int  NULL,
    [skill_set_name] varchar(50)  NULL
);
GO

-- Creating table 'View_Seekers'
CREATE TABLE [dbo].[View_Seekers] (
    [id] int  NOT NULL,
    [is_company_name_hidden] char(1)  NOT NULL,
    [created_date] datetime  NOT NULL,
    [job_description] varchar(500)  NOT NULL,
    [is_active] char(1)  NOT NULL,
    [skill_level] int  NOT NULL,
    [job_type] varchar(20)  NOT NULL,
    [email] varchar(255)  NOT NULL,
    [user_image] varbinary(max)  NULL,
    [registration_date] datetime  NOT NULL,
    [company_name] varchar(100)  NOT NULL,
    [street_address] varchar(100)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'business_stream'
ALTER TABLE [dbo].[business_stream]
ADD CONSTRAINT [PK_business_stream]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'company'
ALTER TABLE [dbo].[company]
ADD CONSTRAINT [PK_company]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'company_image'
ALTER TABLE [dbo].[company_image]
ADD CONSTRAINT [PK_company_image]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [user_account_id], [certificate_degree_name], [major] in table 'education_detail'
ALTER TABLE [dbo].[education_detail]
ADD CONSTRAINT [PK_education_detail]
    PRIMARY KEY CLUSTERED ([user_account_id], [certificate_degree_name], [major] ASC);
GO

-- Creating primary key on [user_account_id], [start_date], [end_date] in table 'experience_detail'
ALTER TABLE [dbo].[experience_detail]
ADD CONSTRAINT [PK_experience_detail]
    PRIMARY KEY CLUSTERED ([user_account_id], [start_date], [end_date] ASC);
GO

-- Creating primary key on [id] in table 'job_location'
ALTER TABLE [dbo].[job_location]
ADD CONSTRAINT [PK_job_location]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'job_post'
ALTER TABLE [dbo].[job_post]
ADD CONSTRAINT [PK_job_post]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [user_account_id], [job_post_id] in table 'job_post_activity'
ALTER TABLE [dbo].[job_post_activity]
ADD CONSTRAINT [PK_job_post_activity]
    PRIMARY KEY CLUSTERED ([user_account_id], [job_post_id] ASC);
GO

-- Creating primary key on [skill_set_id], [job_post_id] in table 'job_post_skill_set'
ALTER TABLE [dbo].[job_post_skill_set]
ADD CONSTRAINT [PK_job_post_skill_set]
    PRIMARY KEY CLUSTERED ([skill_set_id], [job_post_id] ASC);
GO

-- Creating primary key on [id] in table 'job_type'
ALTER TABLE [dbo].[job_type]
ADD CONSTRAINT [PK_job_type]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [user_account_id] in table 'seeker_profile'
ALTER TABLE [dbo].[seeker_profile]
ADD CONSTRAINT [PK_seeker_profile]
    PRIMARY KEY CLUSTERED ([user_account_id] ASC);
GO

-- Creating primary key on [user_account_id], [skill_set_id] in table 'seeker_skill_set'
ALTER TABLE [dbo].[seeker_skill_set]
ADD CONSTRAINT [PK_seeker_skill_set]
    PRIMARY KEY CLUSTERED ([user_account_id], [skill_set_id] ASC);
GO

-- Creating primary key on [id] in table 'skill_set'
ALTER TABLE [dbo].[skill_set]
ADD CONSTRAINT [PK_skill_set]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [id] in table 'user_account'
ALTER TABLE [dbo].[user_account]
ADD CONSTRAINT [PK_user_account]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [user_account_id] in table 'user_log'
ALTER TABLE [dbo].[user_log]
ADD CONSTRAINT [PK_user_log]
    PRIMARY KEY CLUSTERED ([user_account_id] ASC);
GO

-- Creating primary key on [id] in table 'user_type'
ALTER TABLE [dbo].[user_type]
ADD CONSTRAINT [PK_user_type]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id], [job_type], [company_name], [job_description], [street_address] in table 'View_1'
ALTER TABLE [dbo].[View_1]
ADD CONSTRAINT [PK_View_1]
    PRIMARY KEY CLUSTERED ([id], [job_type], [company_name], [job_description], [street_address] ASC);
GO

-- Creating primary key on [id], [is_company_name_hidden], [created_date], [job_description], [is_active], [skill_level], [job_type], [email], [registration_date], [company_name], [street_address] in table 'View_Seekers'
ALTER TABLE [dbo].[View_Seekers]
ADD CONSTRAINT [PK_View_Seekers]
    PRIMARY KEY CLUSTERED ([id], [is_company_name_hidden], [created_date], [job_description], [is_active], [skill_level], [job_type], [email], [registration_date], [company_name], [street_address] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [business_stream_id] in table 'company'
ALTER TABLE [dbo].[company]
ADD CONSTRAINT [FK_company_business_stream]
    FOREIGN KEY ([business_stream_id])
    REFERENCES [dbo].[business_stream]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_company_business_stream'
CREATE INDEX [IX_FK_company_business_stream]
ON [dbo].[company]
    ([business_stream_id]);
GO

-- Creating foreign key on [company_id] in table 'company_image'
ALTER TABLE [dbo].[company_image]
ADD CONSTRAINT [FK_company_image_company]
    FOREIGN KEY ([company_id])
    REFERENCES [dbo].[company]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_company_image_company'
CREATE INDEX [IX_FK_company_image_company]
ON [dbo].[company_image]
    ([company_id]);
GO

-- Creating foreign key on [company_id] in table 'job_post'
ALTER TABLE [dbo].[job_post]
ADD CONSTRAINT [FK_job_post_company]
    FOREIGN KEY ([company_id])
    REFERENCES [dbo].[company]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_job_post_company'
CREATE INDEX [IX_FK_job_post_company]
ON [dbo].[job_post]
    ([company_id]);
GO

-- Creating foreign key on [user_account_id] in table 'education_detail'
ALTER TABLE [dbo].[education_detail]
ADD CONSTRAINT [FK_educ_dtl_seeker_profile]
    FOREIGN KEY ([user_account_id])
    REFERENCES [dbo].[seeker_profile]
        ([user_account_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [user_account_id] in table 'experience_detail'
ALTER TABLE [dbo].[experience_detail]
ADD CONSTRAINT [FK_exp_dtl_seeker_profile]
    FOREIGN KEY ([user_account_id])
    REFERENCES [dbo].[seeker_profile]
        ([user_account_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [job_location_id] in table 'job_post'
ALTER TABLE [dbo].[job_post]
ADD CONSTRAINT [FK_job_post_job_location]
    FOREIGN KEY ([job_location_id])
    REFERENCES [dbo].[job_location]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_job_post_job_location'
CREATE INDEX [IX_FK_job_post_job_location]
ON [dbo].[job_post]
    ([job_location_id]);
GO

-- Creating foreign key on [job_post_id] in table 'job_post_activity'
ALTER TABLE [dbo].[job_post_activity]
ADD CONSTRAINT [FK_job_post_activity_job_post]
    FOREIGN KEY ([job_post_id])
    REFERENCES [dbo].[job_post]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_job_post_activity_job_post'
CREATE INDEX [IX_FK_job_post_activity_job_post]
ON [dbo].[job_post_activity]
    ([job_post_id]);
GO

-- Creating foreign key on [job_type_id] in table 'job_post'
ALTER TABLE [dbo].[job_post]
ADD CONSTRAINT [FK_job_post_job_type]
    FOREIGN KEY ([job_type_id])
    REFERENCES [dbo].[job_type]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_job_post_job_type'
CREATE INDEX [IX_FK_job_post_job_type]
ON [dbo].[job_post]
    ([job_type_id]);
GO

-- Creating foreign key on [job_post_id] in table 'job_post_skill_set'
ALTER TABLE [dbo].[job_post_skill_set]
ADD CONSTRAINT [FK_job_post_skill_set_job_post]
    FOREIGN KEY ([job_post_id])
    REFERENCES [dbo].[job_post]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_job_post_skill_set_job_post'
CREATE INDEX [IX_FK_job_post_skill_set_job_post]
ON [dbo].[job_post_skill_set]
    ([job_post_id]);
GO

-- Creating foreign key on [posted_by_id] in table 'job_post'
ALTER TABLE [dbo].[job_post]
ADD CONSTRAINT [FK_job_post_user_register]
    FOREIGN KEY ([posted_by_id])
    REFERENCES [dbo].[user_account]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_job_post_user_register'
CREATE INDEX [IX_FK_job_post_user_register]
ON [dbo].[job_post]
    ([posted_by_id]);
GO

-- Creating foreign key on [user_account_id] in table 'job_post_activity'
ALTER TABLE [dbo].[job_post_activity]
ADD CONSTRAINT [FK_job_post_act_user_register]
    FOREIGN KEY ([user_account_id])
    REFERENCES [dbo].[user_account]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [skill_set_id] in table 'job_post_skill_set'
ALTER TABLE [dbo].[job_post_skill_set]
ADD CONSTRAINT [FK_job_post_skill_set_skill_set]
    FOREIGN KEY ([skill_set_id])
    REFERENCES [dbo].[skill_set]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [user_account_id] in table 'seeker_profile'
ALTER TABLE [dbo].[seeker_profile]
ADD CONSTRAINT [FK_seeker_profile_user_register]
    FOREIGN KEY ([user_account_id])
    REFERENCES [dbo].[user_account]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [user_account_id] in table 'seeker_skill_set'
ALTER TABLE [dbo].[seeker_skill_set]
ADD CONSTRAINT [FK_skill_set_seeker_profile]
    FOREIGN KEY ([user_account_id])
    REFERENCES [dbo].[seeker_profile]
        ([user_account_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [skill_set_id] in table 'seeker_skill_set'
ALTER TABLE [dbo].[seeker_skill_set]
ADD CONSTRAINT [FK_seeker_skill_set_skill_set]
    FOREIGN KEY ([skill_set_id])
    REFERENCES [dbo].[skill_set]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_seeker_skill_set_skill_set'
CREATE INDEX [IX_FK_seeker_skill_set_skill_set]
ON [dbo].[seeker_skill_set]
    ([skill_set_id]);
GO

-- Creating foreign key on [user_account_id] in table 'user_log'
ALTER TABLE [dbo].[user_log]
ADD CONSTRAINT [FK_use_log_user_register]
    FOREIGN KEY ([user_account_id])
    REFERENCES [dbo].[user_account]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [user_type_id] in table 'user_account'
ALTER TABLE [dbo].[user_account]
ADD CONSTRAINT [FK_user_register_user_type]
    FOREIGN KEY ([user_type_id])
    REFERENCES [dbo].[user_type]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_user_register_user_type'
CREATE INDEX [IX_FK_user_register_user_type]
ON [dbo].[user_account]
    ([user_type_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------