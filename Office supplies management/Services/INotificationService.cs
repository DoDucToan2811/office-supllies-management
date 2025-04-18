using Office_supplies_management.DTOs.Notification;

namespace Office_supplies_management.Services
{
    public interface INotificationService
    {
        Task<List<NotificationDto>> GetNotificationsByUserID(int userId);
        Task<NotificationDto> CreateNotification(CreateNotificationDto createNotificationDto);
        Task<bool> MarkAsRead(int notificationId);
        Task<List<NotificationDto>> GetUnreadNotificationsByUserAsync(int userId);
        Task<bool> MarkAllAsReadAsync(int userId);
        Task<int> GetUnreadNotificationCountByUserAsync(int userId);
    }
}
