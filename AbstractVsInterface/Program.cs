namespace AbstractVsInterface
{
    public class Program
    {
        static void Main(string[] args)
        {
            // interface => Aggrement - canAbleTo

            var sqlDb = new SqlServerDb();

            sqlDb.ExecuteSql("");

            var oracleDb = new OracleDb();
            oracleDb.ExecuteSql("");
            var version = oracleDb.GetDbVersion();


            var car = new Car();
            car.Go();
            car.Stop();

            var plane = new Plane();
            plane.Go();
            plane.Stop();
            plane.Soar();

            var bike = new Bike();
            bike.Go();
            bike.Stop();
            bike.Ride();

            // var baseCar = new BaseVehicle();
            // abstract classtır yeni bir instance oluşturulamaz

        }
    }
}
