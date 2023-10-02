namespace FormUygulaması.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static Repository()
        {
            _categories.Add(new Category{CategoryId = 1, Name = "Telefon"});
            _categories.Add(new Category{CategoryId = 2, Name = "Bilgisayar"});
            _categories.Add(new Category{CategoryId = 3, Name = "Televizyon"});
            _categories.Add(new Category{CategoryId = 4, Name = "Ev Ürünleri"});

            _products.Add(new Product{ProductId = 1, Name = "IPhone X", Price = 12790, Stock = 7, Image ="iphone-10.jpg", CategoryId =1 });
            _products.Add(new Product{ProductId = 2, Name = "IPhone 11", Price = 21988, Stock = 22, Image ="iphone-11.jpg", CategoryId =1 });
            _products.Add(new Product{ProductId = 3, Name = "IPhone 12", Price = 28579, Stock = 66, Image ="iphone-12.jpg", CategoryId =1 });
            _products.Add(new Product{ProductId = 4, Name = "IPhone 13", Price = 36999, Stock = 122, Image ="iphone-13.jpg", CategoryId =1 });
            _products.Add(new Product{ProductId = 5, Name = "IPhone 14", Price = 43999, Stock = 34, Image ="iphone-14.jpg", CategoryId =1 });
            _products.Add(new Product{ProductId = 6, Name = "IPhone 15", Price = 49999, Stock = 13, Image ="iphone-15.jpg", CategoryId =1 });
            _products.Add(new Product{ProductId = 7, Name = "Samsung Galaxy a34", Price = 11299, Stock = 275, Image ="samsung-galaxy-a34.jpg", CategoryId =1 });
            _products.Add(new Product{ProductId = 8, Name = "Samsung Galaxy a72", Price = 19199, Stock = 48, Image ="samsung-galaxy-a72.jpg", CategoryId =1 });
            _products.Add(new Product{ProductId = 9, Name = "Samsung Galaxy m51", Price = 11400, Stock = 32, Image ="samsung-galaxy-m51.jpg", CategoryId =1 });
            _products.Add(new Product{ProductId = 9, Name = "Samsung Galaxy s22", Price = 22999, Stock = 73, Image ="samsung-galaxy-s22.jpg", CategoryId =1 });
            _products.Add(new Product{ProductId = 10, Name = "Samsung Galaxy Z Fold 3", Price = 36999, Stock = 23, Image ="samsung-galaxy-z-fold3.jpg", CategoryId =1 });
            _products.Add(new Product{ProductId = 18, Name = "Huawei Nova 9", Price = 8999, Stock = 88, Image ="huawei-nova-9.jpg", CategoryId =1 });
            _products.Add(new Product{ProductId = 19, Name = "Huawei Nova y91", Price = 11499, Stock = 69, Image ="huawei-nova-y91.jpg", CategoryId =1 });

            _products.Add(new Product{ProductId = 11, Name = "MacBook Air", Price = 25999, Stock = 34, Image ="macbook-air.jpg", CategoryId =2 });
            _products.Add(new Product{ProductId = 12, Name = "MacBook Pro", Price = 36999, Stock = 11, Image ="macbook-pro.jpg", CategoryId =2 });
            _products.Add(new Product{ProductId = 13, Name = "Monster Abra a5 v17", Price = 34999, Stock = 19, Image ="monster-abra-a5-v17.jpg", CategoryId =2 });
            _products.Add(new Product{ProductId = 14, Name = "Monster Tulpar t7 v25", Price = 42199, Stock = 46, Image ="monster-tulpar-t7-v25.jpg", CategoryId =2 });
            _products.Add(new Product{ProductId = 15, Name = "MSI Gf63 Thin 9 sc", Price = 35199, Stock = 8, Image ="msı-gf63-thin-9sc.jpg", CategoryId =2 });
            _products.Add(new Product{ProductId = 16, Name = "MSI Prestige 14 Evo", Price = 49499, Stock = 21, Image ="msı-prestige-14-evo.jpg", CategoryId =2 });
            _products.Add(new Product{ProductId = 17, Name = "MSI Titan gt77", Price = 163499, Stock = 10, Image ="msı-tıtan-gt77.jpg", CategoryId =2 });

            _products.Add(new Product{ProductId = 20, Name = "Samsung 32 inç TV", Price = 9199, Stock = 35, Image ="samsung-32.jpg", CategoryId =3 });
            _products.Add(new Product{ProductId = 21, Name = "Samsung 50 inç TV", Price = 16199, Stock = 23, Image ="samsung-50.jpg", CategoryId =3 });
            _products.Add(new Product{ProductId = 22, Name = "Samsung 65 inç TV", Price = 26499, Stock = 45, Image ="samsung-65.jpg", CategoryId =3 });
            _products.Add(new Product{ProductId = 23, Name = "Grundig 43 inç TV", Price = 8299, Stock = 13, Image ="grundig-43inc.jpg", CategoryId =3 });
            _products.Add(new Product{ProductId = 24, Name = "Vestel 43 inç TV", Price = 6999, Stock = 27, Image ="vestel-43f8500.jpg", CategoryId =3 });
            _products.Add(new Product{ProductId = 25, Name = "LG 50 inç TV", Price = 16055, Stock = 12, Image ="lg-50inc.jpg", CategoryId =3 });
            _products.Add(new Product{ProductId = 26, Name = "LG 55 inç TV", Price = 25946, Stock = 11, Image ="lg-55inc.jpg", CategoryId =3 });
            _products.Add(new Product{ProductId = 27, Name = "LG 65 inç TV", Price = 27019, Stock = 41, Image ="lg-65inc.jpg", CategoryId =3 });

            _products.Add(new Product{ProductId = 28, Name = "Avokado Yastık", Price = 89, Stock = 325, Image ="avokado-yastık.jpg", CategoryId =4 });
            _products.Add(new Product{ProductId = 29, Name = "Bambu Yatak", Price = 1049, Stock = 23, Image ="bambu-yatak.jpg", CategoryId =4 });
            _products.Add(new Product{ProductId = 30, Name = "Cadde Yıldız L Koltuk", Price = 5850, Stock = 19, Image ="cadde-yıldız-köse.jpg", CategoryId =4 });
            _products.Add(new Product{ProductId = 31, Name = "Ahşap Çalışma Masası", Price = 899, Stock = 32, Image ="calisma-masa.jpg", CategoryId =4 });
            _products.Add(new Product{ProductId = 32, Name = "Comfort Köşe Koltuk Takımı", Price = 6730, Stock = 17, Image ="komfort-köse-koltuk-takım.jpg", CategoryId =4 });
            _products.Add(new Product{ProductId = 33, Name = "Kiremit Renk L Koltuk", Price = 7190, Stock = 38, Image ="köse-koltuk.jpg", CategoryId =4 });
            _products.Add(new Product{ProductId = 34, Name = "Lüks Ortopedik Yatak", Price = 3129, Stock = 12, Image ="lüks-yatak.jpg", CategoryId =4 });
            _products.Add(new Product{ProductId = 35, Name = "Metal Mutfak Masası Takımı", Price = 2199, Stock = 85, Image ="mutfak-masa.jpg", CategoryId =4 });
            _products.Add(new Product{ProductId = 36, Name = "Ahşap Mutfak Masası Takımı", Price = 3250, Stock = 63, Image ="mutfak-masa2.jpg", CategoryId =4 });
            _products.Add(new Product{ProductId = 37, Name = "Silikon Yastık 4'lü", Price = 69, Stock = 468, Image ="silikon-yastık.jpg", CategoryId =4 });
            _products.Add(new Product{ProductId = 38, Name = "Şişme Yastık", Price = 39, Stock = 239, Image ="sisme-yastık.jpg", CategoryId =4 });



        }

        public static List<Product> Products
        {
            get
            {
                return _products;   
            }
        }

        public static void CreateProduct(Product entity)
        {
            _products.Add(entity);
        }

        public static void EditProduct(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if(entity != null)
            {
                entity.Name = updatedProduct.Name;
                entity.Price = updatedProduct.Price;
                entity.Image = updatedProduct.Image;
                entity.CategoryId = updatedProduct.CategoryId;
                entity.Stock = updatedProduct.Stock;
            }
        }

        public static void DeleteProduct(Product deletedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == deletedProduct.ProductId);

            if(entity != null)
            {
                _products.Remove(entity);
            }
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }



    }
}