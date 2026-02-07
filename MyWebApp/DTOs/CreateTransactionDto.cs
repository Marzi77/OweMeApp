using System.ComponentModel.DataAnnotations;

namespace MyWebApp.DTOs;


public class CreateTransactionDto
{
    [Required]
    public string Description{get;set;}=string.Empty;

    [Required]
    [Range(0.01,100000,ErrorMessage ="Tutar 0 ile 100.000 arasinda olmalidir")]
    public decimal Amount{get;set;}

    [Required]
    public int FriendId{get;set;}
}