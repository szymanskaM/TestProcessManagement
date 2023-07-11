using Common.Model.Users;
using Microsoft.AspNetCore.Mvc;

namespace Services.Contract
{
    public interface IUserService
    {
        Task<IActionResult> AddUser(CreateUserDto dto);
        Task<IActionResult> CheckUser(CheckLog log);
        Task<IActionResult> UpdateUser(UpdateUserDto dto);
        Task<IActionResult> UpdateUserPassword(UpdateUserDto dto);
    }
}
