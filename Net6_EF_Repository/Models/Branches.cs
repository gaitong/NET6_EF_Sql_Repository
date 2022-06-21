namespace Net6_EF_Repository.Models
{
    public class Branches
    {
      public int Id {get; set;}
      public string? BranchId {get; set;}
      public string? AfsId {get; set;}
      public string BranchName {get; set;}
      public string? Gateway {get; set;}
      public string CreateBy {get; set;}
      public DateTime CreateDate {get; set;}
      public string? ModifiedBy {get; set;}
      public DateTime? ModifiedDate {get; set;}
      public bool? IsStatus {get; set;}
    }
}
