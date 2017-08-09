using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedInterface;
using System.Threading;

namespace MessageConsumer
{
    class MessageConsumer
    {
        static void Main(string[] args)
        {
            JobStateManager jsm = new JobStateManager();
            JobManager mc = new JobManager();

            while (true)
            {
                Console.Out.WriteLine("waiting for messages");

                Thread.Sleep(10000);

                Job job = mc.RetrieveNewJob();

                Console.Out.WriteLine("Job:");
                Console.Out.WriteLine("\t name: " + job.name);
                Console.Out.WriteLine("\t from: " + job.from);
                Console.Out.WriteLine("\t query: " + job.query);
                Console.Out.WriteLine("\t to: " + job.to);

                JobState js = new JobState(job.id, job.name);
                jsm.AddNewJob(js);
                jsm.AddNewState(js, "Received");

                Thread.Sleep(10000);

                jsm.AddNewState(js, "In progress");

                Thread.Sleep(10000);

                jsm.AddNewState(js, "Done");

                Thread.Sleep(10000);
            }
        }
    }
}
