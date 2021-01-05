using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace laba_
{
    public class Brand
    {
        public int Id { get; set; }
        [Required] [MaxLength(50)] [Index(IsUnique = true)] public string Name { get; set; }
        [Required] [MaxLength(50)] public string HeadCompany { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
