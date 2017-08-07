﻿using System;
using SharedInterface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace IntegrationTests
{
    [TestClass]
    public class MainSuite
    {
        [TestMethod]
        public void TestMessageQueue()
        {
            JobManager jm = new JobManager();
            jm.AddJobToQueue(new Job("MyJob", "SQL", "select * from main_table", "azure_tale"));

            Job job = jm.RetrieveNewJob();

            StringAssert.Equals(job.name, "MyJob");
            StringAssert.Equals(job.from, "SQL");
            StringAssert.Equals(job.query, "select * from main_table");
            StringAssert.Equals(job.to, "azure_tale");
        }

        [TestMethod]
        public void TestJobStateTable()
        {
            var jsm = new JobStateManager();
            var js = new JobState(new Random().Next(), "MyJob");

            jsm.AddNewJob(js);

            List<JobState> lj = jsm.GetListOfJobWithLastState();
                
            Assert.IsTrue(lj.Contains(js));

            jsm.AddNewState(js, "Started");

            Assert.IsTrue(lj.Contains(js));
        }
    }
}