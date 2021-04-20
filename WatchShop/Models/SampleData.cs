using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WatchShop.Models
{
    public class SampleData : DropCreateDatabaseAlways<WatchShopContext>
    {
        protected override void Seed(WatchShopContext context)
        {
            //Data for category
            var category = new List<Category>
            {
                new Category{ Id = 100, Name = "Chronograph"},
                new Category{ Id = 101, Name = "Automatic" },
                new Category{ Id = 102, Name = "SmartWatch"},
            };
            category.ForEach(a => context.Categories.Add(a));
            //Data for Suppliper
            var supplier = new List<Supplier>
            {
                new Supplier {Id = "AP", Name = "Apple", Logo = "apple.jpg", Email = "pike@yahoo.com", Phone = "0987345876" },
                new Supplier {Id = "CS", Name = "Casio", Logo = "casio.jpg", Email = "john@yahoo.com", Phone = "0918456987" },
                new Supplier {Id = "RL", Name = "Rolex", Logo = "rolex.jpg", Email = "key@yahoo.com", Phone = "0913745789" },
                new Supplier {Id = "HB", Name = "Hublot", Logo = "hublot.jpg", Email = "mon@yahoo.com", Phone = "0913125689" }
            };
            supplier.ForEach(a => context.Suppliers.Add(a));
            //Data for Product
            var product = new List<Product>
            {
                new Product {Id = 1001, Name="Rolex Aires Gold", UnitBrief="10 boxes x 20 bags", UnitPrice=1560000000, Image="1001.jpg",ProductDate=DateTime.Parse("2020-09-01") ,Available=true,Description="Đường kính mặt :43 mm, Chống nước :100 ATM, Chất liệu mặt :Sapphire, Size dây :22 mm, Chất liệu dây :Dây da, Xuất xứ :Singapore, Chế độ bảo hành :Bảo hành quốc tế 05 năm",CategoryId = 101, SupplierId="RL",Quantity=10,Discount=0.09,Special=true,Latest=false,Views=1},
                new Product {Id = 1002, Name="Apple Watch Series 6 GPS", UnitBrief="10 boxes x 20 bags", UnitPrice=17999000, Image="1002.jpg",ProductDate=DateTime.Parse("2020-09-01") ,Available=true,Description="Đường kính mặt :44 mm, Chống nước :0 ATM, Chất liệu mặt :Sapphire, Size dây :23.5 mm, Chất liệu dây :Silicone, Xuất xứ :China, Chế độ bảo hành :Bảo hành quốc tế 01 năm",CategoryId = 102, SupplierId="AP",Quantity=50,Discount=0.09,Special=false,Latest=false,Views=1},
                new Product {Id = 1003, Name="Apple Watch SE GPS + Cellular", UnitBrief="10 boxes x 20 bags", UnitPrice=9190000, Image="1003.jpg",ProductDate=DateTime.Parse("2020-09-01") ,Available=true,Description="Đường kính mặt :44 mm, Chống nước :0 ATM, Chất liệu mặt :Ion-X strengthened glass, Size dây :23.5 mm, Chất liệu dây :Silicone, Xuất xứ :China, Chế độ bảo hành :Bảo hành quốc tế 01 năm",CategoryId = 102, SupplierId="AP",Quantity=26,Discount=0.08,Special=false,Latest=false,Views=1},
                new Product {Id = 1004, Name="Rolex Day Date 40mm Yellow Gold Black", UnitBrief="10 boxes x 20 bags", UnitPrice=723000000, Image="1004.jpg",ProductDate=DateTime.Parse("2020-09-01") ,Available=true,Description="Đường kính mặt :43 mm, Chống nước :100 ATM, Chất liệu mặt :Sapphire, Size dây :22 mm, Chất liệu dây :vàng nguyên khối 18k, Xuất xứ :Singapore, Chế độ bảo hành :Bảo hành quốc tế 05 năm",CategoryId = 101, SupplierId="RL",Quantity=10,Discount=0.05,Special=true,Latest=false,Views=1},
                new Product {Id = 1005, Name="Casio AE-1200WHD-1AVDF", UnitBrief="10 boxes x 20 bags", UnitPrice=1059000, Image="1005.jpg",ProductDate=DateTime.Parse("2020-09-01") ,Available=true,Description="Đường kính mặt :43 mm, Chống nước :10 ATM, Chất liệu mặt :Mineral Crystal, Size dây :22 mm, Chất liệu dây :Inox, Xuất xứ :Japan, Chế độ bảo hành :Bảo hành quốc tế 01 năm",CategoryId = 100, SupplierId="CS",Quantity=100,Discount=0.15,Special=false,Latest=false,Views=1},
                new Product {Id = 1006, Name="Casio G-SHOCK DW-5600BB-1DR", UnitBrief="10 boxes x 20 bags", UnitPrice=2799000, Image="1006.jpg",ProductDate=DateTime.Parse("2020-09-01") ,Available=true,Description="Đường kính mặt :43 mm, Chống nước :10 ATM, Chất liệu mặt :Mineral Crystal, Size dây :22 mm, Chất liệu dây :Silicone, Xuất xứ :Japan, Chế độ bảo hành :Bảo hành quốc tế 01 năm",CategoryId = 100, SupplierId="CS",Quantity=60,Discount=0.15,Special=false,Latest=false,Views=1},
                new Product {Id = 1007, Name="Hublot Classic Fusion 542.OX.7081.LR", UnitBrief="10 boxes x 20 bags", UnitPrice=395059000, Image="1007.jpg",ProductDate=DateTime.Parse("2020-09-01") ,Available=true,Description="Đường kính mặt :43 mm, Chống nước :10 ATM, Chất liệu mặt :Mineral Crystal, Size dây :22 mm, Chất liệu dây :Da cá sấu, Xuất xứ :Switzerland, Chế độ bảo hành :Bảo hành quốc tế 05 năm",CategoryId = 101, SupplierId="HB",Quantity=100,Discount=0.15,Special=false,Latest=false,Views=1},
                new Product {Id = 1008, Name="Hublot Classic Fusion Titanium 45mm", UnitBrief="10 boxes x 20 bags", UnitPrice=198799000, Image="1008.jpg",ProductDate=DateTime.Parse("2020-09-01") ,Available=true,Description="Đường kính mặt :43 mm, Chống nước :10 ATM, Chất liệu mặt :Mineral Crystal, Size dây :22 mm, Chất liệu dây :Silicone, Xuất xứ :Switzerland, Chế độ bảo hành :Bảo hành quốc tế 05 năm",CategoryId = 101, SupplierId="HB",Quantity=60,Discount=0.15,Special=false,Latest=false,Views=1},
                new Product {Id = 1009, Name="Hublot Classic Fusion Titanium racing grey", UnitBrief="10 boxes x 20 bags", UnitPrice=156000000, Image="1009.jpg",ProductDate=DateTime.Parse("2020-09-01") ,Available=true,Description="Đường kính mặt :42 mm, Chống nước :5 ATM, Chất liệu mặt :Mineral Crystal, Size dây :22 mm, Chất liệu dây :Da cá sấu, Xuất xứ :Switzerland, Chế độ bảo hành :Bảo hành quốc tế 03 năm",CategoryId = 101, SupplierId="HB",Quantity=100,Discount=0.15,Special=false,Latest=false,Views=1},
                new Product {Id = 1010, Name="Hublot Classic Fusion Titanium Green", UnitBrief="10 boxes x 20 bags", UnitPrice=171000000, Image="1010.jpg",ProductDate=DateTime.Parse("2020-09-01") ,Available=true,Description="Đường kính mặt :43 mm, Chống nước :10 ATM, Chất liệu mặt :Shapphire, Size dây :22 mm, Chất liệu dây :Silicone, Xuất xứ :Switzerland, Chế độ bảo hành :Bảo hành quốc tế 03 năm",CategoryId = 101, SupplierId="HB",Quantity=60,Discount=0.15,Special=false,Latest=false,Views=1},
                new Product {Id = 1011, Name="Hublot Classic Fusion Ultra Thin Skeleton", UnitBrief="10 boxes x 20 bags", UnitPrice=352000000, Image="1011.jpg",ProductDate=DateTime.Parse("2020-09-01") ,Available=true,Description="Đường kính mặt :43 mm, Chống nước :5 ATM, Chất liệu mặt :Shapphire, Size dây :22 mm, Chất liệu dây :Silicone, Xuất xứ :Switzerland, Chế độ bảo hành :Bảo hành quốc tế 03 năm",CategoryId = 101, SupplierId="HB",Quantity=100,Discount=0.15,Special=false,Latest=false,Views=1},
                new Product {Id = 1012, Name="Casio A168WEGB-1BDF", UnitBrief="10 boxes x 20 bags", UnitPrice=1858000, Image="1012.jpg",ProductDate=DateTime.Parse("2020-09-01") ,Available=true,Description="Đường kính mặt :43 mm, Chống nước :3 ATM, Chất liệu mặt :Mineral Crystal, Size dây :22 mm, Chất liệu dây :Inox, Xuất xứ :Japan, Chế độ bảo hành :Bảo hành quốc tế 01 năm",CategoryId = 100, SupplierId="CS",Quantity=60,Discount=0.15,Special=false,Latest=false,Views=1},
                new Product {Id = 1013, Name="Casio G-SHOCK GA-700-1ADR", UnitBrief="10 boxes x 20 bags", UnitPrice=2720000, Image="1013.jpg",ProductDate=DateTime.Parse("2020-09-01") ,Available=true,Description="Đường kính mặt :43 mm, Chống nước :3 ATM, Chất liệu mặt :Mineral Crystal, Size dây :22 mm, Chất liệu dây :Silicone, Xuất xứ :Switzerland, Chế độ bảo hành :Bảo hành quốc tế 03 năm",CategoryId = 100, SupplierId="CS",Quantity=100,Discount=0.15,Special=false,Latest=false,Views=1},
                new Product {Id = 1014, Name="Apple Watch Series 6 40mm", UnitBrief="10 boxes x 20 bags", UnitPrice=9690000, Image="1014.jpg",ProductDate=DateTime.Parse("2020-09-01") ,Available=true,Description="Đường kính mặt :40 mm, Chống nước :1 ATM, Chất liệu mặt :Chất liệu mặt :Ion-X strengthened glass, Size dây :22 mm, Chất liệu dây :Silicone, Xuất xứ :Japan, Chế độ bảo hành :Bảo hành quốc tế 01 năm",CategoryId = 102, SupplierId="AP",Quantity=6,Discount=0.10,Special=false,Latest=false,Views=1},
                new Product {Id = 1015, Name="Apple Watch Series 6 44mm", UnitBrief="10 boxes x 20 bags", UnitPrice=10699000, Image="1015.jpg",ProductDate=DateTime.Parse("2020-09-01") ,Available=true,Description="Đường kính mặt :43 mm, Chống nước :1 ATM, Chất liệu mặt :Ion-X strengthened glass, Size dây :22 mm, Chất liệu dây :Silicone, Xuất xứ :Japan, Chế độ bảo hành :Bảo hành quốc tế 01 năm",CategoryId = 102, SupplierId="AP",Quantity=10,Discount=0.12,Special=false,Latest=false,Views=1},
                new Product {Id = 1016, Name="Rolex Datejust 31", UnitBrief="10 boxes x 20 bags", UnitPrice=1858000000, Image="1016.jpg",ProductDate=DateTime.Parse("2020-09-01") ,Available=true,Description="Đường kính mặt :43 mm, Chống nước :5 ATM, Chất liệu mặt :Sapphire, Size dây :22 mm, Chất liệu dây :vàng nguyên khối 18k, Xuất xứ :Switzerland, Chế độ bảo hành :Bảo hành quốc tế 03 năm",CategoryId = 101, SupplierId="RL",Quantity=3,Discount=0.15,Special=true,Latest=false,Views=1}

            };
            product.ForEach(a => context.Products.Add(a));
            //Data for Customer
            var customer = new List<Customer>
            {
                new Customer {Id ="ALFKI", Password="iloveyou", Fullname="Maria Anders", Email="maria@yahoo.com", Photo="", Activated=false},
                new Customer {Id ="ANATR", Password="iloveyou", Fullname="Ana Trujillo", Email="ana@yahoo.com", Photo="", Activated=false},
                new Customer {Id ="ANTON", Password="iloveyou", Fullname="Antonio Moreno", Email="antonio@yahoo.com", Photo="", Activated=false},
                new Customer {Id ="ANOTU", Password="iloveyou", Fullname="Ano Tujulloe", Email="ano@yahoo.com", Photo="", Activated=false},
                new Customer {Id ="BUETE", Password="iloveyou", Fullname="Buetur Teufedu", Email="buet@yahoo.com", Photo="", Activated=false},
                new Customer {Id ="SHINO", Password="iloveyou", Fullname="Ano Tujulloe", Email="ano@yahoo.com", Photo="", Activated=false},
                new Customer {Id ="CATERU", Password="iloveyou", Fullname="Cate Rufedu", Email="cate@yahoo.com", Photo="", Activated=false},
                new Customer {Id ="METANU", Password="iloveyou", Fullname="Meta Nulloe", Email="meta@yahoo.com", Photo="", Activated=false},
                new Customer {Id ="SATURE", Password="iloveyou", Fullname="Satu Reufedo", Email="satu@yahoo.com", Photo="", Activated=false}
            };
            customer.ForEach(a => context.Customers.Add(a));
            //Data for Order
            var order = new List<Order>
            {
                new Order { Id = 1, CustomerId = "ALFKI", OrderDate = DateTime.Parse("2020-10-01"), RequireDate = DateTime.Parse("2020-10-25"), Receiver = "Roger Federer", Address = "Luisenstr. 48", Description = "", Amount = 0 },
                new Order { Id = 2, CustomerId = "ANATR", OrderDate = DateTime.Parse("2020-11-25"), RequireDate = DateTime.Parse("2020-12-30"), Receiver = "John Biden", Address = "Araveder Street 78/4", Description = "", Amount = 0 },
                new Order { Id = 3, CustomerId = "METANU", OrderDate = DateTime.Parse("2020-05-01"), RequireDate = DateTime.Parse("2020-6-25"), Receiver = "Lex Don", Address = "Whasin Street 41/12/4", Description = "", Amount = 0 },
                new Order { Id = 4, CustomerId = "SATURE", OrderDate = DateTime.Parse("2020-11-12"), RequireDate = DateTime.Parse("2020-12-30"), Receiver = "Key Beme", Address = "Fneev Street 48/45/2", Description = "", Amount = 0 },

            };
            order.ForEach(a => context.Orders.Add(a));
            //Data for detail order
            var orderdetail = new List<OrderDetail>
            {
                new OrderDetail {Id=10,OrderId=1,ProductId=1001,UnitPrice=1560000000,Quantity=2,Discount=0.09},
                new OrderDetail {Id=11,OrderId=2,ProductId=1003,UnitPrice=9190000,Quantity=1,Discount=0.08},
                new OrderDetail {Id=12,OrderId=3,ProductId=1004,UnitPrice=723000000,Quantity=2,Discount=0.05},
                new OrderDetail {Id=13,OrderId=4,ProductId=1005,UnitPrice=1059000,Quantity=1,Discount=0.15},

            };
            orderdetail.ForEach(a => context.OrderDetails.Add(a));

            context.SaveChanges();
            base.Seed(context);

        }
    }
}