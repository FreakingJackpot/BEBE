using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace laba_
{
    public class Model
    {
        public int Id { get; set; }
        [MaxLength(50)] [Index("IX_FirstAndSecond", 1, IsUnique = true)] public string Name { get; set; }
        [MaxLength(50)] [Index("IX_FirstAndSecond", 2, IsUnique = true)] public string DriveUnit { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
