using System.Collections.Generic;

namespace Tibia_Utilities.Models.Houses
{
  public class AuctionHouse
  {
    public int current_bid { get; set; }
    public bool finished { get; set; }
    public string time_left { get; set; }
  }

  public class GuildhallList
  {
    public Auction auction { get; set; }
    public bool auctioned { get; set; }
    public int house_id { get; set; }
    public string name { get; set; }
    public int rent { get; set; }
    public bool rented { get; set; }
    public int size { get; set; }
  }

  public class HouseList
  {
    public Auction auction { get; set; }
    public bool auctioned { get; set; }
    public int house_id { get; set; }
    public string name { get; set; }
    public int rent { get; set; }
    public bool rented { get; set; }
    public int size { get; set; }
  }

  public class Houses
  {
    public List<GuildhallList> guildhall_list { get; set; }
    public List<HouseList> house_list { get; set; }
    public string town { get; set; }
    public string world { get; set; }
  }

  public class HousesByTownModel
  {
    public Houses houses { get; set; }
  }
}
