using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace laba_
{
    public class Engine
    {
        public int Id { get; set; }
        [Required] [MaxLength(50)] [Index(IsUnique = true)] public string Name { get; set; }
        [Required] public string FuelType { get; set; }
        [Required] public float FuelCapacity { get; set; }
        [Required] public float HorsePower { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
