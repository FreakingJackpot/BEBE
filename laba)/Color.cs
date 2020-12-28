using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace laba_
{
    public class Color
    {
        public int Id { get; set; }
        [MaxLength(50)] [Index("FirstAndSecond", 1, IsUnique = true)] public string Name { get; set; }
        [MaxLength(50)] [Index("FirstAndSecond", 2, IsUnique = true)] public string type { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
