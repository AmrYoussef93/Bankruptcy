using System.Collections.Generic;

namespace Bankruptcy.Domain.Entities
{
    public class Department : BaseEntity
    {
        public Department()
        {
            Students = new HashSet<Student>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Student> Students { get; }
    }
}
