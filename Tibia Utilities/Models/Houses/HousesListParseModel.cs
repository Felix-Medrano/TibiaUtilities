namespace Tibia_Utilities.Models.Houses
{
  public class HousesListParseModel
  {
    public AuctionHouse auction { get; set; }
    public bool auctioned { get; set; }
    public int house_id { get; set; }
    public string name { get; set; }
    public int rent { get; set; }
    public bool rented { get; set; }
    public int size { get; set; }

    public void SetData(HousesList house)
    {
      auction = house.auction;
      auctioned = house.auctioned;
      house_id = house.house_id;
      name = house.name;
      rent = house.rent;
      rented = house.rented;
      size = house.size;
    }

    public void SetData(GuildhallList house)
    {
      auction = house.auction;
      auctioned = house.auctioned;
      house_id = house.house_id;
      name = house.name;
      rent = house.rent;
      rented = house.rented;
      size = house.size;
    }
  }
}
