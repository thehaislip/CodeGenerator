using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    class UserInfoRepository
    {
        Context cn;
        public UserInfoRepository()
        {
            cn = new Context();
        }
        public string GetConnectionString(int id) {
            return cn.Databases.FirstOrDefault(e => e.Id == id).ConnectionString;
        }
        public IEnumerable<Database> ListDatabases() {
            return cn.Databases.ToList();
        }
        public void saveConnection(string name, string connectioString,string nameSpace)
        {
            cn.Entry(new Database() { Name = name, ConnectionString = connectioString }).State = System.Data.Entity.EntityState.Added;
            cn.SaveChanges();
        }
    }
}
