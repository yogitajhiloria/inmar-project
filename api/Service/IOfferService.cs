public interface IOfferService {

    IEnumerable<Product> GetAllProducts();

    bool AddProduct(Product product);
    IEnumerable<Offer> GetTodaysOffers();
}