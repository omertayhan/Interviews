using System.Data;

namespace AbstractVsInterface
{
    // Abstraction 
    // Ortak noktalar tespit edildi 
    // Temel amaçları: Ortaklaştırmak ve Soyutlamak
    public abstract class BaseDb // Bu classtan yeni bir instance istemiyoruz dolayısıyla Abstract tanımlıyoruz
    {
        public BaseDb()
        {
            // kendi constructerları olabilir fakat interfacelerde böyle bir durum yoktur
        }

        // hem bir sözleşme olarak kullanabiliyoruz hem de gereken ortak metotları yazabiliyoruz
        public abstract string GetDbVersion(); // Rule, Aggrement tanımlıyoruz sadece, bu classı kullanan classlar artık bu classı override ederek kullanmak zorunda

        public DataTable ExecuteSql(string sql)
        {
            // generate sql 
            return new DataTable(sql);
        }
    }

    public class MySqlDb : BaseDb
    {
        public override string GetDbVersion() => "MySql Database";

        public string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS WHERE ID = {id}";
        }
    }

    public class SqlServerDb : BaseDb
    {
        public override string GetDbVersion() => "SqlServer 2012";

        public string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS WITH(NOLOCK) WHERE ID = {id}";
        }
    }

    public class OracleDb : BaseDb
    {
        public override string GetDbVersion() => "Oracle 18c";

        public string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS WHERE USER_ID = {id}";
        }
    }
}

