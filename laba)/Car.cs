namespace laba_
{
    public class Car
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public int ColorId { get; set; }
        public float Price { get; set; }
        public int YearId { get; set; }
        public int EngineId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Model Model { get; set; }
        public virtual Color Color { get; set; }
        public virtual Year Year { get; set; }
        public virtual Engine Engine { get; set; }
    }
}
