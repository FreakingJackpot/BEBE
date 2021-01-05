using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace laba_
{
    public class Model
    {
        public int Id { get; set; }
        [Required] [MaxLength(50)] [Index("IX_FirstSecondThird", 1, IsUnique = true)] public string Name { get; set; }
        [Required] [MaxLength(50)] [Index("IX_FirstSecondThird", 2, IsUnique = true)] public string DriveUnit { get; set; }
        [Required] [MaxLength(50)] [Index("IX_FirstSecondThird", 3, IsUnique = true)] public string Body { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
