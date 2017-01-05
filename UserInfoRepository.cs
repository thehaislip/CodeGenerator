using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CodeGenerator
{
    class UserInfoRepository
    {

        public string sysPath { get; set; }
        public string fileName { get; set; }
        public string filepath { get; set; }

        public UserInfoRepository()
        {
            sysPath = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            fileName = "CodeGen.json";
            filepath = Path.Combine(sysPath, fileName);
        }
        public string GetConnectionString(string databaseName)
        {
            return ListSettings().Where(e => e.Name == databaseName).Select(e => e.ConnectionString).FirstOrDefault();
        }
        public IEnumerable<string> ListDatabases()
        {
            return ListSettings().Select(e => e.Name);
        }
        public void saveConnection(string name, string connectioString, string nameSpace)
        {
            List<ConnectionSettings> data = new List<ConnectionSettings>();
            data = ListSettings();
            data.Add(new ConnectionSettings { Name = name, ConnectionString = connectioString, Namespace = nameSpace });
            File.WriteAllText(filepath, JsonConvert.SerializeObject(data));
        }

        private List<ConnectionSettings> ListSettings() {
            var fileText = "";
            List<ConnectionSettings> data = new List<ConnectionSettings>();
            if (File.Exists(filepath))
            {
                fileText = File.ReadAllText(filepath);
                data = JsonConvert.DeserializeObject<List<ConnectionSettings>>(fileText);
            }
            return data;
        }
    }
}
