using Newtonsoft.Json;
using System;

namespace HelpDesk.Common.Models
{
    public class TrubleTicket
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int CreateUser { get; set; }
        public string Text { get; set; }
        public string? Resolve { get; set; }
        public bool IsSolved { get; set; }
        public DateTime Created { get; set; }
        public DateTime? ResolveTime { get; set; }
        public int? ResolveUser { get; set; }
        public DateTime Deadline { get; set; }


        public TrubleTicket() { }

        [JsonConstructor]
        private TrubleTicket(int id, string status, int createUser, string text, string? resolve, bool isSolved, DateTime created, DateTime? resolveTime, int? resolveUser, DateTime deadline)
        {
            Id = id;
            Status = status;
            CreateUser = createUser;
            Text = text;
            Resolve = resolve;
            IsSolved = isSolved;
            Created = created;
            ResolveTime = resolveTime;
            ResolveUser = resolveUser;
            Deadline = deadline;
        }
    }
}
