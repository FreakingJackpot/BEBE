namespace laba_
{
    public class SearchModels
    {

        public class BrandSearchModel
        {
            public string Name { get; set; }
            public string HeadCompany { get; set; }
        }

        public class ModelSearchModel
        {
            public string Name { get; set; }
            public string DriveUnit { get; set; }
            public string Body { get; set; }
        }

        public class ColorSearchModel
        {
            public string Name { get; set; }
            public string Type { get; set; }
        }

        public class EngineSearchModel
        {
            public string Name { get; set; }
            public string FuelType { get; set; }
            public float? FuelCapacityMax { get; set; }
            public float? FuelCapacityMin { get; set; }
            public float? HorsePowerMax { get; set; }
            public float? HorsePowerMin { get; set; }
        }

        public class TiresSearchModel
        {
            public string Brand { get; set; }
            public float? WidthMax { get; set; }
            public float? WidthMin { get; set; }
            public float? DiameterMax { get; set; }
            public float? DiameterMin { get; set; }
        }
    }

}
