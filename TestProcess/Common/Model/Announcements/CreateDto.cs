
namespace Common.Model.Announcements
{
    public class CreateAnnouncementDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public long UserId { get; set; }
    }
}
