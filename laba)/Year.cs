using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace laba_
{
    public class Year
    {
        public int Id { get; set; }
        [Index(IsUnique = true)] public int Value { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
