using System;
using System.Text;
using Microsoft.WindowsAzure.Storage.Table;
using System.Collections.Generic;
using Microsoft.WindowsAzure.Storage;

namespace SharedInterface
{
    public class JobState : TableEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public Dictionary<string, DateTime> states { get; set; }

        public JobState()
        {
            states = new Dictionary<string, DateTime>();
        }

        public JobState(int _id, string _name) : base(_id.ToString(), _id.ToString())
        {
            id = _id;
            name = _name;
            states = new Dictionary<string, DateTime>();
        }

        public override IDictionary<string, EntityProperty> WriteEntity(OperationContext operationContext)
        {
            var results = base.WriteEntity(operationContext);
            foreach (var item in states)
            {
                results.Add("State_" + item.Key, new EntityProperty(item.Value));
            }
            return results;
        }

        public override void ReadEntity(IDictionary<string, EntityProperty> properties, OperationContext operationContext)
        {
            base.ReadEntity(properties, operationContext);

            states = new Dictionary<string, DateTime>();

            foreach (var item in properties)
            {
                if (item.Key.StartsWith("State_"))
                {
                    string key = item.Key.Substring(6);
                    states[key] = item.Value.DateTime.Value;
                }
            }
        }

        public override bool Equals(Object obj)
        {
            return true;
        }
    }
}
