public class Product {

    public Product(string productName,decimal price,string description) {
        this.ProductName = productName;
        this.Price = price;
        this.Description = description;
    }
    public string ProductName { get; set;}
    public decimal Price { get; set;}
    public string Description { get; set;   }
}