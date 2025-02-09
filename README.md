# Basic MVC Customer Orders

## Proje Açıklaması
Bu proje, ASP.NET Core MVC kullanılarak geliştirilen basit bir müşteri ve sipariş yönetim sistemidir.
Proje, bir müşteriye ait siparişleri görüntülemeyi sağlar.

## Kullanılan Teknolojiler
- ASP.NET Core MVC
- C#
- Bootstrap 5.3.3

## Projeyi Çalıştırma
1. **Projeyi klonlayın**
   ```sh
   git clone <repository-url>
   cd Basic_MVC
   ```
2. **Visual Studio veya .NET CLI ile çalıştırın**
   ```sh
   dotnet run
   ```
3. **Tarayıcıdan aşağıdaki URL’yi açın:**
   ```sh
   https://localhost:<port>/CustomerOrders
   ```

## Proje Yapısı

### **1. Model Sınıfları**
Projede üç temel model bulunmaktadır:

- **Customer (Müşteri Modeli)**:
  ```csharp
  public class Customer
  {
      public int Id { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string Email { get; set; }
  }
  ```

- **Order (Sipariş Modeli)**:
  ```csharp
  public class Order
  {
      public int Id { get; set; }
      public string ProductName { get; set; }
      public decimal Price { get; set; }
      public int Quentity { get; set; }
  }
  ```

- **CustomerOrderViewModel (Müşteri ve Siparişleri İçeren Model)**:
  ```csharp
  public class CustomerOrderViewModel
  {
      public Customer Customer { get; set; }
      public List<Order> Orders { get; set; } = new List<Order>();
  }
  ```

### **2. Controller**
Müşteri ve sipariş bilgilerini **CustomerOrdersController** üzerinden yönetiyoruz:
  
  ```csharp
  public class CustomerOrdersController : Controller
  {
      public IActionResult Index()
      {
          Customer customer = new Customer
          {
              FirstName = "Name",
              LastName = "Last Name",
              Email = "xx@gmail.com",
              Id = 1
          };

          List<Order> orders = new List<Order>
          {
              new Order { ProductName = "Product1", Quentity = x, Price = x, Id = 1},
              new Order { ProductName = "Product2", Quentity = x, Price = x, Id = 2},
              new Order { ProductName = "Product3", Quentity = x, Price = x, Id = 3}
          };

          CustomerOrderViewModel viewModel = new CustomerOrderViewModel
          {
               Customer = customer,
               Orders = orders
          };

          return View(viewModel);
      }
  }
  ```

### **3. View (Görünüm - Razor)**
Müşteri bilgilerini ve sipariş listesini görüntülemek için **Index.cshtml** kullanıyoruz:
  
  ```html
  @using Basic_MVC.Models
  @model CustomerOrderViewModel

  <html>
      <head>
      <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
      </head>
      <body>
      
      <ul class="list-group">
          <li class="list-group-item active">@Model.Customer.FirstName @Model.Customer.LastName</li>
          <li class="list-group-item">Email: @Model.Customer.Email</li>
          <li class="list-group-item">Id: @Model.Customer.Id</li>
      </ul>
      
      <div class="card-header fw-bold">SİPARİŞLER</div>
      
      @foreach (var item in Model.Orders)
      {
          <div class="card" style="width: 18rem;">
              <div class="card-header">@item.ProductName</div>
              <ul class="list-group list-group-flush">
                  <li class="list-group-item">Fiyat: @item.Price</li>
                  <li class="list-group-item">Adet: @item.Quentity</li>
                  <li class="list-group-item">Id: @item.Id</li>
              </ul>
          </div>
      }
      </body>
  </html>
  ```

## **Ekran Görüntüsü**
![Örnek Görüntü](https://github.com/OsmanOzyasar/Basic_MVC/blob/master/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-02-09%20175427.png)

## **Lisans**
Bu proje MIT Lisansı ile lisanslanmıştır. Dilediğiniz gibi kullanabilirsiniz. 📜

---
Bu **README.md**, projenizi daha iyi anlatmanızı sağlar ve yeni geliştiricilerin projeye kolayca adapte olmasına yardımcı olur! 🚀

