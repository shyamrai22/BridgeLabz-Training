using System;

namespace BridgeLabzTraining.dsa_csharp_practice.social_media_friend_connections
{
    class SinglyLinkedList
    {
        private Node head;

        // Add user
        public void AddUser(User user)
        {
            Node newNode = new Node(user);
            newNode.Next = head;
            head = newNode;
        }

        // Get user by ID
        private User GetUserById(int userId)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.Data.UserId == userId)
                    return temp.Data;
                temp = temp.Next;
            }
            return null;
        }

        // Add friend connection
        public void AddFriend(int userId1, int userId2)
        {
            User u1 = GetUserById(userId1);
            User u2 = GetUserById(userId2);

            if (u1 == null || u2 == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            u1.FriendIds[u1.FriendCount++] = userId2;
            u2.FriendIds[u2.FriendCount++] = userId1;

            Console.WriteLine("Connection added.");
        }

        // Remove friend connection
        public void RemoveFriend(int userId1, int userId2)
        {
            User u1 = GetUserById(userId1);
            User u2 = GetUserById(userId2);

            if (u1 == null || u2 == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            RemoveFromArray(u1, userId2);
            RemoveFromArray(u2, userId1);

            Console.WriteLine("Friend connection removed.");
        }

        private void RemoveFromArray(User user, int friendId)
        {
            for (int i = 0; i < user.FriendCount; i++)
            {
                if (user.FriendIds[i] == friendId)
                {
                    for (int j = i; j < user.FriendCount - 1; j++)
                        user.FriendIds[j] = user.FriendIds[j + 1];

                    user.FriendCount--;
                    return;
                }
            }
        }

        // Display friends
        public void DisplayFriends(int userId)
        {
            User user = GetUserById(userId);
            if (user == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            Console.WriteLine($"Friends of {user.Name}:");
            for (int i = 0; i < user.FriendCount; i++)
            {
                User friend = GetUserById(user.FriendIds[i]);
                if (friend != null)
                    Console.WriteLine($"- {friend.Name} (ID: {friend.UserId})");
            }
        }

        // Find mutual friends
        public void FindMutualFriends(int userId1, int userId2)
        {
            User u1 = GetUserById(userId1);
            User u2 = GetUserById(userId2);

            if (u1 == null || u2 == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            Console.WriteLine("Mutual Friends:");
            for (int i = 0; i < u1.FriendCount; i++)
            {
                for (int j = 0; j < u2.FriendCount; j++)
                {
                    if (u1.FriendIds[i] == u2.FriendIds[j])
                    {
                        User mutual = GetUserById(u1.FriendIds[i]);
                        if (mutual != null)
                            Console.WriteLine(mutual.Name);
                    }
                }
            }
        }

        // Search by ID
        public void SearchById(int userId)
        {
            User user = GetUserById(userId);
            if (user != null)
                user.Display();
            else
                Console.WriteLine("User not found.");
        }

        // Search by Name
        public void SearchByName(string name)
        {
            Node temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Data.Name.Equals(name))
                {
                    temp.Data.Display();
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("User not found.");
        }

        // Count friends
        public void CountFriends()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(
                    $"{temp.Data.Name} --> {temp.Data.FriendCount} friends."
                );
                temp = temp.Next;
            }
        }
    }
}
