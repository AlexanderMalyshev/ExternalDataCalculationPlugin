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
        const int TMO = 20000;
        static void Main(string[] args)
        {
            JobStateManager jsm = new JobStateManager();
            JobManager mc = new JobManager();

            while (true)
            {
                Console.Out.WriteLine("waiting for messages");

                Thread.Sleep(TMO);

                Job job = mc.RetrieveNewJob();
                if (job.id == 0)
                    continue;

                Console.Out.WriteLine("Job:");
                Console.Out.WriteLine("\t name: " + job.name);
                Console.Out.WriteLine("\t from: " + job.from);
                Console.Out.WriteLine("\t query: " + job.query);
                Console.Out.WriteLine("\t to: " + job.to);

                JobState js = new JobState(job.id, job.name);


                jsm.AddNewJob(js);
                jsm.AddNewState(js, "Added");

                Thread.Sleep(TMO);

                jsm.AddNewState(js, "Going");

                Thread.Sleep(TMO);

                jsm.AddNewState(js, "Done");

                Thread.Sleep(TMO);
            }
        }
    }
}
