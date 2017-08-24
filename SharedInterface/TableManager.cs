using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedInterface
{
    public class TableManager
    {
        CloudTable table;

        public TableManager(string name)
        {
            var storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=excelexternalcalcstorage;" +
                "AccountKey=QbIQCjVSz023E9YM54l00JVBAHwVj9TP7EgAacbFF0AzNyADZKIR7AtohUS74sQXfxE4czqrgH5snQfboSQmmQ==;EndpointSuffix=core.windows.net");
            var tableClient = storageAccount.CreateCloudTableClient();
            table = tableClient.GetTableReference(name);
        }

        public List<List<string>> GetData()
        {
            var tq = new TableQuery();
            var res = new List<List<string>>();
            table.ExecuteQuery(tq).ToList().ForEach(row => 
            {
                var rowList = new List<string>();
                row.Properties.ToList().ForEach(value =>
                {
                    rowList.Add(value.Value.StringValue);
                });
                res.Add(rowList);
            });
            return res;
        }
    }
}
