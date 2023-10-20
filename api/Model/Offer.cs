public class Offer {

    public Offer(string offerName,IEnumerable<Product> products) {
        this.OfferName = offerName;
        this.Products = products;
    }
    public string OfferName { get; set;}
    public IEnumerable<Product> Products { get; set;}
    
}