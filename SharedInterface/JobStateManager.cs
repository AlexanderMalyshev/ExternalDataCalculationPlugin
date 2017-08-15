using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using Microsoft.Azure; // Namespace for CloudConfigurationManager
using Microsoft.WindowsAzure.Storage; // Namespace for CloudStorageAccount
using Microsoft.WindowsAzure.Storage.Table; // Namespace for Table storage types

namespace SharedInterface
{
    public class JobStateManager
    {
        CloudTable table;

        public JobStateManager()
        {
            var storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=excelexternalcalcstorage;" +
                "AccountKey=QbIQCjVSz023E9YM54l00JVBAHwVj9TP7EgAacbFF0AzNyADZKIR7AtohUS74sQXfxE4czqrgH5snQfboSQmmQ==;EndpointSuffix=core.windows.net");
            var tableClient = storageAccount.CreateCloudTableClient();
            table = tableClient.GetTableReference("jobstate");
        }

        public List<JobState> GetListOfJobWithLastState()
        {
            TableQuery<JobState> tq = new TableQuery<JobState>();
            return table.ExecuteQuery(tq).ToList<JobState>();
        }

        public void AddNewJob(JobState js)
        {
            TableOperation insertOperation = TableOperation.Insert(js);
            table.Execute(insertOperation);
        }

        public void AddNewState(JobState js, string state)
        {
            js.states.Add(state, DateTime.Now);

            TableOperation mergeOperation = TableOperation.Merge(js);
            table.Execute(mergeOperation);
        }
    }
}
