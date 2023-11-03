using backend.Src.DTO.Users;
using backend.Src.Repositories.Interfaces;
using backend.Src.Services.Interfaces;

namespace backend.Src.Services
{
    public class UsersService : IUsersService
    {

        private readonly IUsersRepository _usersRepository;
        private readonly IMapperService _mapperService;

        public UsersService(IUsersRepository usersRepository, IMapperService mapperService)
        {
            _usersRepository = usersRepository;
            _mapperService = mapperService;
        }

        public async Task<List<UserDto>> GetAll()
        {
            var users = await _usersRepository.GetAll();

            var mappedUsers = _mapperService.MapUsers(users);

            return mappedUsers;
        }
    }
}