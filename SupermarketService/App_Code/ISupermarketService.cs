using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

[ServiceContract]
public interface ISupermarketService
{
    [OperationContract]
    List<Product> GetProducts();

    [OperationContract]
    Product GetProduct(int id);

    [OperationContract]
    void AddProduct(Product product);

    [OperationContract]
    void UpdateProduct(Product product);

    [OperationContract]
    void DeleteProduct(int id);
}

[DataContract]
public class Product
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public decimal Price { get; set; }

    [DataMember]
    public int Quantity { get; set; }
}