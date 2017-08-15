using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.ServiceBus.Messaging;
using Newtonsoft.Json;

namespace SharedInterface
{
    public class JobManager
    {
        QueueClient client;

        public JobManager()
        {
            var connectionString = "Endpoint=sb://excelexternalcalcnamespace.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=idAfA+5EnPjxl1kSw7BVtiosmwYZDEW+azbfy6JpqwI=";
            var queueName = "jobqueue";

            client = QueueClient.CreateFromConnectionString(connectionString, queueName);
        }

        public void AddJobToQueue(Job job)
        {
            var message = new BrokeredMessage(JsonConvert.SerializeObject(job, Formatting.None));
            client.Send(message);
        }

        public Job RetrieveNewJob()
        {
            var message = client.Receive();
            Job job = JsonConvert.DeserializeObject<Job>(message.GetBody<String>());
            message.Complete();

            return job;
        }
    }
}
