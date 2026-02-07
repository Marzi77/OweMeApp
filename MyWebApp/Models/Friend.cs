using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models;
public class Friend
{
    [Key]
    public int Id{get;set;}
    [Required]
    public string Name{get;set;}=string.Empty;

    public decimal Balance{get;set;}

   public List<Transaction>Transactions {get;set;}=new List<Transaction>();
//databasede tutulmicak ama transactionlari kolaylikla isterdigimiz zaman erisebilicez.
}




