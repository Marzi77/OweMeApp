using System.ComponentModel.DataAnnotations;

namespace MyWebApp.DTOs;


public class CreateFriendDto
{
    [Required(ErrorMessage="Lutfen bir isim giriniz")]
    [StringLength(50,ErrorMessage="isim 50 karakterden fazla olamaz")]
    public string Name{get;set;}=string.Empty;


}