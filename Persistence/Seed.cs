using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext dataContext) 
        {
            if(dataContext.Pumps.Any()) return;

            var pumps = new List<Pump>
            {
                new Pump
                {
                    PumpName = "Pump 1",
                    PumpDate = DateTime.UtcNow.AddMonths(-3),
                    PumpType = "Centrifugal pump",
                    PumpStatus = false
                },
                new Pump
                {
                    PumpName = "Pump 2",
                    PumpDate = DateTime.UtcNow.AddMonths(-2),
                    PumpType = "Piston pump",
                    PumpStatus = true
                },
                new Pump
                {
                    PumpName = "Pump 3",
                    PumpDate = DateTime.UtcNow.AddMonths(-1),
                    PumpType = "Gear pump",
                    PumpStatus = false
                },
                new Pump
                {
                    PumpName = "Pump 4",
                    PumpDate = DateTime.UtcNow.AddMonths(1),
                    PumpType = "Jet pump",
                    PumpStatus = false
                },
                new Pump
                {
                    PumpName = "Pump 5",
                    PumpDate = DateTime.UtcNow.AddMonths(2),
                    PumpType = "Centrifugal pump",
                    PumpStatus = true
                },
                new Pump
                {
                    PumpName = "Pump 6",
                    PumpDate = DateTime.UtcNow.AddMonths(3),
                    PumpType = "Jet pump",
                    PumpStatus = true
                },
                new Pump
                {
                    PumpName = "Pump 7",
                    PumpDate = DateTime.UtcNow.AddMonths(4),
                    PumpType = "Gear pump",
                    PumpStatus = true
                },
                new Pump
                {
                    PumpName = "Pump 8",
                    PumpDate = DateTime.UtcNow.AddMonths(5),
                    PumpType = "Centrifugal pump",
                    PumpStatus = false
                },
                new Pump
                {
                    PumpName = "Pump 9",
                    PumpDate = DateTime.UtcNow.AddMonths(6),
                    PumpType = "Piston pump",
                    PumpStatus = false
                },
                new Pump
                {
                    PumpName = "Pump 10",
                    PumpDate = DateTime.UtcNow.AddMonths(7),
                    PumpType = "Gear pump",
                    PumpStatus = true
                },
                new Pump
                {
                    PumpName = "Pump 11",
                    PumpDate = DateTime.UtcNow.AddMonths(8),
                    PumpType = "Jet pump",
                    PumpStatus = false
                },
                new Pump
                {
                    PumpName = "Pump 12",
                    PumpDate = DateTime.UtcNow.AddMonths(9),
                    PumpType = "Centrifugal pump",
                    PumpStatus = true
                },
                new Pump
                {
                    PumpName = "Pump 13",
                    PumpDate = DateTime.UtcNow.AddMonths(10),
                    PumpType = "Piston pump",
                    PumpStatus = false
                },
                new Pump
                {
                    PumpName = "Pump 14",
                    PumpDate = DateTime.UtcNow.AddMonths(-2),
                    PumpType = "Gear pump",
                    PumpStatus = false
                },
                new Pump
                {
                    PumpName = "Pump 15",
                    PumpDate = DateTime.UtcNow.AddMonths(-3),
                    PumpType = "Jet pump",
                    PumpStatus = false
                },
                new Pump
                {
                    PumpName = "Pump 16",
                    PumpDate = DateTime.UtcNow.AddMonths(-4),
                    PumpType = "Piston pump",
                    PumpStatus = true
                },
                new Pump
                {
                    PumpName = "Pump 17",
                    PumpDate = DateTime.UtcNow.AddMonths(1),
                    PumpType = "Centrifugal pump",
                    PumpStatus = true
                },
                new Pump
                {
                    PumpName = "Pump 18",
                    PumpDate = DateTime.UtcNow.AddMonths(3),
                    PumpType = "Gear pump",
                    PumpStatus = false
                },
                new Pump
                {
                    PumpName = "Pump 19",
                    PumpDate = DateTime.UtcNow.AddMonths(4),
                    PumpType = "Jet pump",
                    PumpStatus = true
                },
                new Pump
                {
                    PumpName = "Pump 20",
                    PumpDate = DateTime.UtcNow.AddMonths(5),
                    PumpType = "Piston pump",
                    PumpStatus = false
                },
            };

            await dataContext.Pumps.AddRangeAsync(pumps);
            await dataContext.SaveChangesAsync();
        }
    }
}