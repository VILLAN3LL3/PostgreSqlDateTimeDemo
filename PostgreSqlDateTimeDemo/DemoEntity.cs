using System;

namespace PostgreSqlDateTimeDemo
{
    public class DemoEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
