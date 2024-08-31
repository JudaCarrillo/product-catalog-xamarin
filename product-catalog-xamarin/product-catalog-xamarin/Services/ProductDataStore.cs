using System;
using System.Collections.Generic;
using System.Text;
using product_catalog_xamarin.Models;

namespace product_catalog_xamarin.Services
{
    public class ProductDataStore
    {
        // Campo estático que contiene la única instancia del singleton
        private static readonly Lazy<ProductDataStore> instance = new Lazy<ProductDataStore>(() => new ProductDataStore());

        // Propiedad para acceder a la instancia
        public static ProductDataStore Instance => instance.Value;

        // Lista para almacenar productos en memoria
        public List<Product> Products { get; private set; }

        // Constructor privado para evitar instanciación externa
        private ProductDataStore()
        {
            // Puedes inicializar aquí los productos o cualquier otro dato que quieras mantener en memoria
            Products = new List<Product>{
                new Product { Name = "LEFT 4 DEAD 2 (PC)", Image = "left.png", Price = "S/. 5", OriginalPrice = "S/. 22.00" },
                new Product { Name = "MINECRAFT J & B (PC)", Image = "minecraft.png", Price = "S/. 42", OriginalPrice = "S/. 100.00" },
                new Product { Name = "FC 25 (PC)", Image = "fifa.png", Price = "S/. 160", OriginalPrice = "S/. 200.00" },
                new Product { Name = "FC 24 (PC)", Image = "fifa24.png", Price = "S/. 140", OriginalPrice = "S/. 180.00" },
                new Product { Name = "DESTINY (PC)", Image = "destiny.png", Price = "S/. 45", OriginalPrice = "S/. 85.00" },
                new Product { Name = "CALL OF DUTY BACK OPS 6 (PC)", Image = "call_of_duty.png", Price = "S/. 250", OriginalPrice = "S/. 450.00" },
                new Product { Name = "DIABLO IV (PC)", Image = "diavlo.png", Price = "S/. 100", OriginalPrice = "S/. 125.00" },
                new Product { Name = "DEAD ISLAND (PC)", Image = "dead_island.png", Price = "S/. 145", OriginalPrice = "S/. 160.00" },
                new Product { Name = "IT TAKES TWO (PC)", Image = "takes_two.png", Price = "S/. 70", OriginalPrice = "S/. 100.00" },
                new Product { Name = "PROJECT ZOMBOID (PC)", Image = "zomboid.png", Price = "S/. 100", OriginalPrice = "S/. 145.00" },
                new Product { Name = "THE LAST OF US PART II (PC)", Image = "the_last_of_us_ii.png", Price = "S/. 150", OriginalPrice = "S/. 220.00" },
                new Product { Name = "SPECS ON THE LINE (PC)", Image = "spec_os.png", Price = "S/. 25", OriginalPrice = "S/. 50.00" },
                new Product { Name = "RED DEAD REDEMPTION II (PC)", Image = "red_dead.png", Price = "S/. 135", OriginalPrice = "S/. 200.00" }
            };
        }

        // Método para agregar productos (u otras entidades) a la lista
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        // Método para obtener todos los productos
        public List<Product> GetAllProducts()
        {
            return Products;
        }

    }
}
