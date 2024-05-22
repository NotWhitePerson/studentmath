using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using VizsgaCommon;

namespace VizsgaGyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2) 
            {
                Console.WriteLine("A paraméterek száma nem megfelelő!");
                return;
            }
            if (args[0] != "-InputFile")
            {
                Console.WriteLine("A paraméterek nem megfelelőek!");
                return;
            }
            if (!File.Exists(args[1])) 
            {
                Console.WriteLine($"A fájl {args[1]} nem található!");
                return;
            }
            string[] lines = File.ReadAllLines(args[1]);
            SQL.ConnectionString = "Server=localhost;Database=VizsgaGyak;User=sa;Password=titok;TrustServerCertificate=true;";
            SQL sql = new SQL();
            /*if (!sql.Database.CanConnect()) {
                throw new Exception("Nem lehet kapcsolódni a szerverhez!!!!");
            } */
                using (sql)
                {
                    foreach (string line in lines[1..])
                    {
                        string[] d = line.Split(";");
                        LogEntry log = new LogEntry()
                        {
                            Id = int.Parse(d[0]),
                            CorrelationId = Guid.Parse(d[1]),
                            DateUtc = DateTime.Parse(d[2]),
                            Thread = int.Parse(d[3]),
                            Level = d[4],
                            Logger = d[5],
                            Message = d[6],
                            Exception = d[7]
                        };
                        sql.Logs.Add(log);
                    }
                    sql.SaveChanges();
                }
                Console.WriteLine($"Fájl neve: {args[1]}");
                Console.WriteLine($"Fájlban lévő sorok száma: {lines.Length}");
                Console.WriteLine($"Beolvasott sorok száma: {lines[1..].Length}");
            }
        

    }
}