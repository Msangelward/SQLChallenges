using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Examples.BonusChallenge_Slack
{
    public class UserMessageThread
    {
        public int UserId { get; set; }
        public List<User> Users { get; set; }
        public int MessageThreadId { get; set; }
        public List<MessageThread> MessageThreads { get; set; }
    }
}
