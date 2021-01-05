using System.Linq;
using System.Windows.Forms;

namespace laba_
{
    class ComboboxesAutoAdders
    {
        public static void BrandName(object sender)
        {
            using (var context = new MYDBCONTEXT())
            {
                var brands = context.Brands.Select(c => c.Name).ToList();
                ComboBox combo = sender as ComboBox;
                combo.Items.Clear();
                combo.Items.Add("");
                foreach (var item in brands)
                {
                    combo.Items.Add(item);
                }
            }
        }

        public static void HeadCompany(object sender)
        {
            using (var context = new MYDBCONTEXT())
            {
                var brands = context.Brands.Select(c => c.HeadCompany).ToHashSet();
                ComboBox combo = sender as ComboBox;
                combo.Items.Clear();
                combo.Items.Add("");
                foreach (var item in brands)
                {
                    combo.Items.Add(item);
                }
            }
        }

        public static void ModelName(object sender)
        {
            using (var context = new MYDBCONTEXT())
            {
                var models = context.Models.Select(c => c.Name).ToHashSet();
                ComboBox combo = sender as ComboBox;
                combo.Items.Clear();
                combo.Items.Add("");
                foreach (var item in models)
                {
                    combo.Items.Add(item);
                }
            }
        }

        public static void ColorName(object sender)
        {
            using (var context = new MYDBCONTEXT())
            {
                var colors = context.Colors.Select(c => c.Name).ToHashSet();
                ComboBox combo = sender as ComboBox;
                combo.Items.Clear();
                combo.Items.Add("");
                foreach (var item in colors)
                {
                    combo.Items.Add(item);
                }
            }
        }

        public static void EngineName(object sender)
        {
            using (var context = new MYDBCONTEXT())
            {
                var engines = context.Engines.Select(c => c.Name).ToHashSet();
                ComboBox combo = sender as ComboBox;
                combo.Items.Clear();
                combo.Items.Add("");
                foreach (var item in engines)
                {
                    combo.Items.Add(item);
                }
            }
        }

        public static void TiresBrand(object sender)
        {
            using (var context = new MYDBCONTEXT())
            {
                var engines = context.Tires.Select(c => c.Brand).ToHashSet();
                ComboBox combo = sender as ComboBox;
                combo.Items.Clear();
                combo.Items.Add("");
                foreach (var item in engines)
                {
                    combo.Items.Add(item);
                }
            }
        }

        public static void FullBrandInf(object sender)
        {
            using (var context = new MYDBCONTEXT())
            {
                var engines = context.Brands.ToList();
                ComboBox combo = sender as ComboBox;
                combo.Items.Clear();
                foreach (var item in engines)
                {
                    string it = item.Id + " | " + item.Name + " | " + item.HeadCompany;
                    combo.Items.Add(it);
                }
            }
        }
        public static void FullModelInf(object sender)
        {
            using (var context = new MYDBCONTEXT())
            {
                var engines = context.Models.ToList();
                ComboBox combo = sender as ComboBox;
                combo.Items.Clear();
                foreach (var item in engines)
                {
                    string it = item.Id + " | " + item.Name + " | " + item.DriveUnit + " | " + item.Body;
                    combo.Items.Add(it);
                }
            }
        }
        public static void FullColorInf(object sender)
        {
            using (var context = new MYDBCONTEXT())
            {
                var engines = context.Colors.OrderBy(c => c.Id).ToList();
                ComboBox combo = sender as ComboBox;
                combo.Items.Clear();
                foreach (var item in engines)
                {
                    string it = item.Id + " | " + item.Name + " | " + item.Type;
                    combo.Items.Add(it);
                }
            }
        }
        public static void FullEnginesInf(object sender)
        {
            using (var context = new MYDBCONTEXT())
            {
                var engines = context.Engines.ToList();
                ComboBox combo = sender as ComboBox;
                combo.Items.Clear();
                foreach (var item in engines)
                {
                    string it = item.Id + " | " + item.Name + " | " + item.FuelType + " | " + item.FuelCapacity + " | " +
                                item.HorsePower;
                    combo.Items.Add(it);
                }
            }
        }

        public static void FullTiresInf(object sender)
        {
            using (var context = new MYDBCONTEXT())
            {
                var engines = context.Tires.ToList();
                ComboBox combo = sender as ComboBox;
                combo.Items.Clear();
                foreach (var item in engines)
                {
                    string it = item.Id + " | " + item.Brand + " | " + item.Width + " | " + item.Diameter;
                    combo.Items.Add(it);
                }
            }
        }
    }
}
