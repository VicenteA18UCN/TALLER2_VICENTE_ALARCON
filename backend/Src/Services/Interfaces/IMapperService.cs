using backend.Src.DTO.Users;
using backend.Src.DTO;
using backend.Src.Models;

namespace backend.Src.Services.Interfaces
{
    public interface IMapperService
    {
        public List<UserDto> MapUsers(List<User> users);

        public User CreateClientDtoToUser(CreateUserDto createUserDto);
    }
}