namespace Week8;

public class CargoContainer<T> where T: DeliveryItem
{
    private List<T> allDeliveryItems = new List<T>();

    public void AddItem(T item)
    {
        allDeliveryItems.Add(item);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (T item in allDeliveryItems)
        {
            totalCost += item.CalculateCost();
        }

        return totalCost;
    }
}
