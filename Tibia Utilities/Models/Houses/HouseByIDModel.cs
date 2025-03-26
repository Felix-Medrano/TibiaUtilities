namespace Tibia_Utilities.Models.Houses
{
  public class Auction
  {
    public string auction_end { get; set; }
    public bool auction_ongoing { get; set; }
    public int current_bid { get; set; }
    public string current_bidder { get; set; }
  }

  public class House
  {
    public int beds { get; set; }
    public int houseid { get; set; }
    public string img { get; set; }
    public string name { get; set; }
    public int rent { get; set; }
    public int size { get; set; }
    public Status status { get; set; }
    public string town { get; set; }
    public string type { get; set; }
    public string world { get; set; }
    public int Top { get; set; } = 0;
  }

  public class Rental
  {
    public string moving_date { get; set; }
    public string owner { get; set; }
    public string owner_sex { get; set; }
    public string paid_until { get; set; }
    public bool transfer_accept { get; set; }
    public int transfer_price { get; set; }
    public string transfer_receiver { get; set; }
  }

  public class HouseByIDModel
  {
    public House house { get; set; }
  }

  public class Status
  {
    public Auction auction { get; set; }
    public bool is_auctioned { get; set; }
    public bool is_moving { get; set; }
    public bool is_rented { get; set; }
    public bool is_transfering { get; set; }
    public string original { get; set; }
    public Rental rental { get; set; }
    public int error { get; set; }
    public int http_code { get; set; }
    public string message { get; set; }
  }


}
