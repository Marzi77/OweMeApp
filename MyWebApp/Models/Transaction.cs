using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApp.Models;


public class Transaction
{
    [Key]
    public int Id{get;set;}

    [Required]
    public string Description{get;set;}=null!;

    [Column(TypeName= "decimal(6,2)")]
    public decimal Amount {get;set;}

    public DateTime Date{get;set;}=DateTime.Now;

    public int FriendId{get;set;}//dastabasede tutulur.
    
    [ForeignKey("FriendId")]
    public Friend? Friend{get;set;}//databasede tutulmaz ama transaction.friend.name yapabilirsin.
}