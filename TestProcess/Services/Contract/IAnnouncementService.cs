using Common.Model.Announcements;
using Common.Model.Users;
using Microsoft.AspNetCore.Mvc;

namespace Services.Contract
{
    public interface IAnnouncementService
    {
        Task<IActionResult> AddAnnouncements(CreateAnnouncementDto dto);
        Task<IActionResult> UpdateAnnouncements(UpdateAnnouncementDto dto);
        Task<IActionResult> DeleteAnnouncements(long id);//, long userId);
        Task<IActionResult> SelectAnnouncements();
        Task<IActionResult> SelectAnnouncementsByUserId(long userId);
    }
}
