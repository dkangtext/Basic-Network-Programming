using System;

namespace CollaborativeWhiteboard.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public bool IsConnected { get; set; }

        public User(string userId, string userName)
        {
            UserId = userId;
            UserName = userName;
            IsConnected = true;
        }

        public void Disconnect()
        {
            IsConnected = false;
        }

        public void Connect()
        {
            IsConnected = true;
        }
    }
}