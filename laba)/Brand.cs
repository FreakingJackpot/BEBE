using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace laba_
{
    public class Brand
    {
        public int Id { get; set; }
        [MaxLength(50)] [Index(IsUnique = true)] public string Name { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
