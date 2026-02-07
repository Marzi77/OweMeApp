using MyWebApp.DTOs;

namespace MyWebApp.Interfaces;


public interface IFriendService
{  
    Task<List<FriendDto>>  GetAllFriendAsync();

    Task<int> CreateFriendAsync(CreateFriendDto request);
}