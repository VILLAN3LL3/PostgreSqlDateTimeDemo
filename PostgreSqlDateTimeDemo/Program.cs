using System;
using System.Linq;

namespace PostgreSqlDateTimeDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var context = new DemoContext())
            {

                var std = new DemoEntity()
                {
                    Start = new DateTime(2021, 12, 1, 14, 12, 15, 11),
                    End = new DateTime(2021, 12, 6, 20, 18, 5, 3)
                };

                context.DemoEntities.Add(std);
                context.SaveChanges();

                DateTime rangeStartTime = new DateTime(2021, 12, 1, 17, 50, 12).Date;
                var rangeEndTime = new DateTime(2021, 12, 31, 9, 16, 57);

                var foo = context.DemoEntities
                    .Where(a => a.End <= rangeEndTime && a.End >= rangeStartTime || a.End > rangeEndTime && a.Start <= rangeEndTime)
                    .ToList();
            }
        }
    }
}
