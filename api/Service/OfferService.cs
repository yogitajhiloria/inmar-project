public class OfferService : IOfferService {

    public OfferService() {
        this.Inventory = new List<Product>();
        this.AddDefaultProducts();
    }
    private IList<Product>  Inventory {get; set;}
    private void AddDefaultProducts() {
        
        this.Inventory.Add(new Product("P1",1000,"P1 desc"));
        this.Inventory.Add(new Product("P2",200,"P2 desc"));
        this.Inventory.Add(new Product("P3",400,"P3 desc"));
        this.Inventory.Add(new Product("P4",700,"P4 desc"));
        this.Inventory.Add(new Product("P5",600,"P5 desc"));
        this.Inventory.Add(new Product("P6",800,"P6 desc"));
    }

    public IEnumerable<Product> GetAllProducts() {
        return this.Inventory;
    }

    public IEnumerable<Offer> GetTodaysOffers() {
        var offers = new List<Offer>();
        Random rnd = new Random();
        offers.Add(new Offer("ComboPackage1",this.Inventory.OrderBy(x=>rnd.Next(0, 10)).Take(3)));
        offers.Add(new Offer("ComboPackage2",this.Inventory.OrderBy(x=>rnd.Next(0, 10)).Take(3)));
        offers.Add(new Offer("ComboPackage3",this.Inventory.OrderBy(x=>rnd.Next(0, 10)).Take(3)));
        offers.Add(new Offer("ComboPackage4",this.Inventory.OrderBy(x=>rnd.Next(0, 10)).Take(3)));
        // System.Collections.Generic.IEnumerable<Product>
        return offers;
    }

    public bool AddProduct(Product product) {
        this.Inventory.Add(product);
    }
}