using System.Collections.Generic;
using System.Windows.Forms;

namespace laba_
{
    class GridFillers
    {
        public static void Cars(DataGridView dataGrid, List<Car> result)
        {
            dataGrid.Rows.Clear();
            for (int i = 0; i < result.Count; i++)
            {
                dataGrid.Rows.Add();
                var row = dataGrid.Rows[i];
                row.Cells["id"].Value = result[i].Id;
                row.Cells["BrandName"].Value = result[i].Brand.Name;
                row.Cells["HeadCompany"].Value = result[i].Brand.HeadCompany;
                row.Cells["ModelName"].Value = result[i].Model.Name;
                row.Cells["DriveUnit"].Value = result[i].Model.DriveUnit;
                row.Cells["Body"].Value = result[i].Model.Body;
                row.Cells["Color"].Value = result[i].Color.Name;
                row.Cells["Type"].Value = result[i].Color.Type;
                row.Cells["EngineName"].Value = result[i].Engine.Name;
                row.Cells["FuelType"].Value = result[i].Engine.FuelType;
                row.Cells["Capacity"].Value = result[i].Engine.FuelCapacity;
                row.Cells["HorsePower"].Value = result[i].Engine.HorsePower;
                row.Cells["Tires"].Value = result[i].Tires.Brand;
                row.Cells["Width"].Value = result[i].Tires.Width;
                row.Cells["Diameter"].Value = result[i].Tires.Diameter;
                row.Cells["Year"].Value = result[i].Year;
                row.Cells["Price"].Value = result[i].Price;
            }
        }

        public static void Brands(DataGridView dataGrid, List<Brand> result)
        {
            dataGrid.Rows.Clear();
            for (int i = 0; i < result.Count; i++)
            {
                dataGrid.Rows.Add();
                var row = dataGrid.Rows[i];
                row.Cells["id"].Value = result[i].Id;
                row.Cells["Brand"].Value = result[i].Name;
                row.Cells["HeadCompany"].Value = result[i].HeadCompany;
            }
        }

        public static void Model(DataGridView dataGrid, List<Model> result)
        {
            dataGrid.Rows.Clear();
            for (int i = 0; i < result.Count; i++)
            {
                dataGrid.Rows.Add();
                var row = dataGrid.Rows[i];
                row.Cells["id"].Value = result[i].Id;
                row.Cells["Model"].Value = result[i].Name;
                row.Cells["DriveUnit"].Value = result[i].DriveUnit;
                row.Cells["Body"].Value = result[i].Body;
            }
        }

        public static void Colors(DataGridView view, List<Color> result)
        {
            view.Rows.Clear();
            for (int i = 0; i < result.Count; i++)
            {
                view.Rows.Add();
                var row = view.Rows[i];
                row.Cells["id"].Value = result[i].Id;
                row.Cells["Color"].Value = result[i].Name;
                row.Cells["Type"].Value = result[i].Type;
            }
        }

        public static void Engines(DataGridView dataGrid, List<Engine> result)
        {
            dataGrid.Rows.Clear();
            for (int i = 0; i < result.Count; i++)
            {
                dataGrid.Rows.Add();
                var row = dataGrid.Rows[i];
                row.Cells["id"].Value = result[i].Id;
                row.Cells["Engine"].Value = result[i].Name;
                row.Cells["FuelType"].Value = result[i].FuelType;
                row.Cells["FuelCapacity"].Value = result[i].FuelCapacity;
                row.Cells["HorsePower"].Value = result[i].HorsePower;
            }
        }

        public static void Tires(DataGridView dataGrid, List<Tires> result)
        {
            dataGrid.Rows.Clear();
            for (int i = 0; i < result.Count; i++)
            {
                dataGrid.Rows.Add();
                var row = dataGrid.Rows[i];
                row.Cells["id"].Value = result[i].Id;
                row.Cells["Brand"].Value = result[i].Brand;
                row.Cells["Width"].Value = result[i].Width;
                row.Cells["Diameter"].Value = result[i].Diameter;
            }
        }
    }
}
