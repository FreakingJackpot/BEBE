using System.ComponentModel.DataAnnotations;
namespace laba_
{
    public class Car
    {
        public int Id { get; set; }
        [Required] public int BrandId { get; set; }
        [Required] public int ModelId { get; set; }
        [Required] public int ColorId { get; set; }
        public float Price { get; set; }
        public int Year { get; set; }
        [Required] public int EngineId { get; set; }
        [Required] public int TiresId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Model Model { get; set; }
        public virtual Color Color { get; set; }
        public virtual Engine Engine { get; set; }
        public virtual Tires Tires { get; set; }
    }
}
