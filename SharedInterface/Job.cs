using System;
using System.Collections.Generic;
using System.Text;

namespace SharedInterface
{
    public class Job
    {
        public int id { get; set; }
        public string name { get; set; }
        public string from { get; set; }
        public string query { get; set; }
        public string to { get; set; }

        public Job(int _id, string _name, string _from, string _query, string _to)
        {
            id = _id;
            name = _name;
            from = _from;
            query = _query;
            to = _to;
        }
    }
}
