using System;

namespace BridgeLabzTraining.dsa_csharp_practice.social_media_friend_connections
{
    class User
    {
        private int userId;
        private string name;
        private int age;

        public int[] FriendIds;
        public int FriendCount;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public User(int userId, string name, int age)
        {
            this.userId = userId;
            this.name = name;
            this.age = age;

            FriendIds = new int[50];
            FriendCount = 0;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {UserId}, Name: {Name}, Age: {Age}");
        }
    }
}
