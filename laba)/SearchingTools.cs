using System.Collections.Generic;
using System.Linq;

namespace laba_
{
    public class SearchingTools
    {
        public List<Brand> SearchByBrandAttributes(SearchModels.BrandSearchModel brand)
        {
            using (var context = new MYDBCONTEXT())
            {

                var result = context.Brands.AsQueryable();
                if (brand != null)
                {
                    if (!string.IsNullOrEmpty(brand.Name))
                        result = result.Where(x => x.Name.Equals(brand.Name));
                    if (!string.IsNullOrEmpty(brand.HeadCompany))
                        result = result.Where(x => x.HeadCompany.Equals(brand.HeadCompany));
                }
                return result.OrderBy(x => x.Id).ToList();
            }
        }

        public List<Model> SearchByModelAttributes(SearchModels.ModelSearchModel model)
        {
            using (var context = new MYDBCONTEXT())
            {

                var result = context.Models.AsQueryable();
                if (model != null)
                {
                    if (!string.IsNullOrEmpty(model.Name))
                        result = result.Where(x => x.Name.Equals(model.Name));
                    if (!string.IsNullOrEmpty(model.DriveUnit))
                        result = result.Where(x => x.DriveUnit.Equals(model.DriveUnit));
                    if (!string.IsNullOrEmpty(model.Body))
                        result = result.Where(x => x.Body.Equals(model.Body));
                }
                return result.OrderBy(x => x.Id).ToList();
            }
        }

        public List<Color> SearchByColorAttributes(SearchModels.ColorSearchModel model)
        {
            using (var context = new MYDBCONTEXT())
            {

                var result = context.Colors.AsQueryable();
                if (model != null)
                {
                    if (!string.IsNullOrEmpty(model.Name))
                        result = result.Where(x => x.Name.Equals(model.Name));
                    if (!string.IsNullOrEmpty(model.Type))
                        result = result.Where(x => x.Type.Equals(model.Type));
                }
                return result.OrderBy(c => c.Id).ToList();
            }
        }

        public List<Engine> SearchByEngineAttributes(SearchModels.EngineSearchModel model)
        {
            using (var context = new MYDBCONTEXT())
            {

                var result = context.Engines.AsQueryable();
                if (model != null)
                {
                    if (!string.IsNullOrEmpty(model.Name))
                        result = result.Where(x => x.Name.Equals(model.Name));
                    if (!string.IsNullOrEmpty(model.FuelType))
                        result = result.Where(x => x.FuelType.Equals(model.FuelType));
                    if (model.FuelCapacityMax != 0)
                        result = result.Where(x => x.FuelCapacity <= model.FuelCapacityMax);
                    if (model.FuelCapacityMin != 0)
                        result = result.Where(x => x.FuelCapacity >= model.FuelCapacityMin);
                    if (model.HorsePowerMax != 0)
                        result = result.Where(x => x.HorsePower <= model.HorsePowerMax);
                    if (model.HorsePowerMin != 0)
                        result = result.Where(x => x.HorsePower >= model.HorsePowerMin);
                }
                return result.OrderBy(x => x.Id).ToList();
            }
        }

        public List<Tires> SearchByTiresAttributes(SearchModels.TiresSearchModel model)
        {
            using (var context = new MYDBCONTEXT())
            {

                var result = context.Tires.AsQueryable();
                if (model != null)
                {
                    if (!string.IsNullOrEmpty(model.Brand))
                        result = result.Where(x => x.Brand.Equals(model.Brand));
                    if (model.WidthMax != 0)
                        result = result.Where(x => x.Width <= model.WidthMax);
                    if (model.WidthMin != 0)
                        result = result.Where(x => x.Width >= model.WidthMin);
                    if (model.DiameterMax != 0)
                        result = result.Where(x => x.Diameter <= model.DiameterMax);
                    if (model.DiameterMin != 0)
                        result = result.Where(x => x.Diameter >= model.DiameterMin);
                }
                return result.OrderBy(x => x.Id).ToList();
            }
        }

        public List<Car> SearchByCarAttributes(SearchModels.BrandSearchModel brand, SearchModels.ModelSearchModel model,
                                               SearchModels.ColorSearchModel color, SearchModels.EngineSearchModel engine,
                                               SearchModels.TiresSearchModel tires, float pricemax, float pricemin,
                                               int yearmax, int yearmin, MYDBCONTEXT context)
        {

            var r1 = SearchByBrandAttributes(brand).Select(x => x.Id).ToList();
            var r2 = SearchByModelAttributes(model).Select(x => x.Id).ToList();
            var r3 = SearchByColorAttributes(color).Select(x => x.Id).ToList();
            var r4 = SearchByEngineAttributes(engine).Select(x => x.Id).ToList();
            var r5 = SearchByTiresAttributes(tires).Select(x => x.Id).ToList();

            var result = context.Cars.AsQueryable();

            result = result.Where(x => r1.Contains(x.BrandId));
            result = result.Where(x => r2.Contains(x.ModelId));
            result = result.Where(x => r3.Contains(x.ColorId));
            result = result.Where(x => r4.Contains(x.EngineId));
            result = result.Where(x => r5.Contains(x.TiresId));
            if (pricemin != 0)
                result = result.Where(x => x.Price >= pricemin);
            if (pricemax != 0)
                result = result.Where(x => x.Price <= pricemax);
            if (yearmax != 0)
                result = result.Where(x => x.Year <= yearmax);
            if (yearmin != 0)
                result = result.Where(x => x.Year >= yearmin);

            return result.OrderBy(c => c.Id).ToList();
        }
    }
}
