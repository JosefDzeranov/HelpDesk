using HelpDesk.Common.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace HelpDesk.Common
{
    public class JsonStorage : IProvider
    {
        private string usersFileName = "users.json";
        private string trubleTicketsFileName = "trubleTicket.json";

        public bool IsCorrectLoginPassword(string login, string password)
        {
            var users = JsonProvider.Deserialize<User>(usersFileName);
            User user = null;

            if (users == null || users.Count == 0)
            {
                return false;
            }
            else
            {
                user = users.FirstOrDefault(x => x.Login == login);
            }

            if (user == null)
            {
                return false;
            }

            return user.Password != Methods.GetHashMD5(password);
        }

        public User GetUser(string login)
        {
            var users = JsonProvider.Deserialize<User>(usersFileName);
            User user = null;

            if (users == null || users.Count == 0)
            {
                return new User();
            }
            else
            {
                user = users.FirstOrDefault(x => x.Login == login);
            }

            if (user == null)
            {
                return new User();
            }

            return user;
        }

        public User GetUser(int id)
        {
            var users = JsonProvider.Deserialize<User>(usersFileName);
            User user = null;

            if (users == null || users.Count == 0)
            {
                return new User();
            }
            else
            {
                user = users.FirstOrDefault(x => x.Id == id);
            }

            if (user == null)
            {
                return new User();
            }

            return user;
        }

        public void AddUser(User user)
        {
            var users = JsonProvider.Deserialize<User>(usersFileName);

            if (users != null)
            {
                user.Id = users.Max(x => x.Id) + 1;

                users.Add(user);
            }
            else
            {
                users = new List<User> { user };
            }


            JsonProvider.Serialize(users, usersFileName);
        }

        public List<User> GetAllUsers()
        {
            return JsonProvider.Deserialize<User>(usersFileName);
        }

        public void AddTrubleTicket(TrubleTicket trubleTicket)
        {
            var trubleTickets = JsonProvider.Deserialize<TrubleTicket>(trubleTicketsFileName);

            if (trubleTickets == null)
            {
                trubleTickets = new List<TrubleTicket> { trubleTicket };
            }
            else
            {
                trubleTicket.Id = trubleTickets.Max(x => x.Id) + 1;

                trubleTickets.Add(trubleTicket);
            }

            JsonProvider.Serialize(trubleTickets, trubleTicketsFileName);
        }

        public List<TrubleTicket> GetAllTrubleTickets()
        {
            var trubleTickets = JsonProvider.Deserialize<TrubleTicket>(trubleTicketsFileName);

            if (trubleTickets == null)
            {
                return new List<TrubleTicket>();
            }
            else
            {
                return JsonProvider.Deserialize<TrubleTicket>(trubleTicketsFileName);
            }
        }

        public TrubleTicket GetTrubleTicket(int id)
        {
            var trubleTickets = JsonProvider.Deserialize<TrubleTicket>(trubleTicketsFileName);

            if (trubleTickets == null)
            {
                return new TrubleTicket();
            }
            else
            {
                var trubleTicket = trubleTickets.FirstOrDefault(t => t.Id == id);

                return trubleTicket;
            }
        }

        public void ResolveTrubleTicket(int id, string status, string resolve, int resolveUserId)
        {
            var trubleTickets = GetAllTrubleTickets();
            var trubleTicket = GetTrubleTicket(id);

            trubleTickets.RemoveAll(x => x.Id == id);

            trubleTicket.IsSolved = true;
            trubleTicket.Status = status;
            trubleTicket.Resolve = resolve;
            trubleTicket.ResolveTime = DateTime.Now;
            trubleTicket.ResolveUser = resolveUserId;

            trubleTickets.Add(trubleTicket);

            var sortedTrubleTickets = trubleTickets.OrderBy(x => x.Id).ToList();

            JsonProvider.Serialize(sortedTrubleTickets, trubleTicketsFileName);
        }

        public void ChangeStatusTrubleTicket(int id, string status, int resolveUserId)
        {
            var trubleTickets = GetAllTrubleTickets();
            var trubleTicket = GetTrubleTicket(id);

            trubleTickets.RemoveAll(x => x.Id == id);

            trubleTicket.Status = status;
            trubleTicket.ResolveUser = resolveUserId;

            trubleTickets.Add(trubleTicket);

            var sortedTrubleTickets = trubleTickets.OrderBy(x => x.Id).ToList();

            JsonProvider.Serialize(sortedTrubleTickets, trubleTicketsFileName);

        }

        public void ChangeUserToEmployee(User user, string function, string department)
        {
            var users = GetAllUsers();
            users.RemoveAll(x => x.Id == user.Id);

            var convertedUser = new User
            {
                Id = user.Id,
                Name = user.Name,
                Login = user.Login,
                Password = user.Password,
                Email = user.Email,
                IsEmployee = true,
                Function = function,
                Department = department
            };

            users.Add(convertedUser);

            var sortedUsers = users.OrderBy(x => x.Id).ToList();

            JsonProvider.Serialize(sortedUsers, usersFileName);
        }

        public void ChangeEmployeeToUser(User user)
        {
            var users = GetAllUsers();
            users.RemoveAll(x => x.Id == user.Id);

            user.IsEmployee = false;
            user.Function = null;
            user.Department = null;

            users.Add(user);

            var sortedUsers = users.OrderBy(x => x.Id).ToList();

            JsonProvider.Serialize(sortedUsers, usersFileName);
        }

        public void UpdateUser(User user)
        {
            var users = GetAllUsers();
            users.RemoveAll(x => x.Id == user.Id);
            users.Add(user);

            var sortedUsers = users.OrderBy(x => x.Id).ToList();

            JsonProvider.Serialize(sortedUsers, usersFileName);
        }
    }
}
