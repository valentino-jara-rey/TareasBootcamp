using PrimerTarea;

public class Producto 
{
  public Producto(int pId, string pName, decimal pPrice, string pCategory, bool pActive){
        Id = pId;
        Name = pName;
        Price = pPrice;
        Category = pCategory;
        Active = pActive;
    }  
  public int Id { get; private set; }
  public string Name { get; private set; }
  public decimal Price { get; private set; }
  public string Category { get; private set; }
  public bool Active { get; private set; }


}
