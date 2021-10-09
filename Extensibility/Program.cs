namespace Extensibility
{

    class Program
    {
        static void Main(string[] args)
        {
            //Can easily change implementation. using new ConsoleLogger()
            var dbMigrator = new DbMigrator(new FileLogger("C:\\Users\\power\\Documents\\testFileOutput.txt"));
            dbMigrator.Migrate();
            
        }
    }
}
