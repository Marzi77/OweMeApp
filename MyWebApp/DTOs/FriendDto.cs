namespace MyWebApp.DTOs;


public class FriendDto
{
    public int Id{get;set;}

    public string Name{get;set;}=string.Empty;

    public decimal Balance{get;set;}

    public List<TransactionDto>Transactions{get;set;}=new List<TransactionDto>();





}