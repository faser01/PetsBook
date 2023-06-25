using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsBook
{
    public class Notifications
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public string Type { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsDone { get; set; }

        public Notifications(int id, int petId, string type, DateTime dateTime, bool isDone)
        {
            Id = id;
            PetId = petId;
            Type = type;
            DateTime = dateTime;
            IsDone = isDone;
        }

        public static void AddNotification(List<Notifications> notifications, Notifications notification)
        {
            notifications.Add(notification);
        }

        public static void RemoveNotification(List<Notifications> notifications, Notifications notification)
        {
            notifications.Remove(notification);
        }

        public static void UpdateNotification(List<Notifications> notifications, Notifications notification, string type, DateTime dateTime, bool isDone)
        {
            notification.Type = type;
            notification.DateTime = dateTime;
            notification.IsDone = isDone;
        }
    }
}
