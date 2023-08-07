
using TheConversationsBot.Domain.Models;
using TheConversationsBot.Service.Interface;
using TheConversationsBot.TelegramBot;

namespace TheConversationsBot.Service
{

    public class SessionManager : ISessionManager<Session>
    {
        private readonly UserDataService _userDataService;
        private List<Session> sessions => new List<Session>();

        public SessionManager(UserDataService userDataService)
        {
            _userDataService = userDataService;
        }

        public async Task<Session> GetSessionByChatId(long chatId)
        {
            var user = await _userDataService.GetUserByChatId(chatId);
            if (user is null)
                throw new Exception("Bunday foydalanuvchi mavjud emas");
            
            var lastSession = sessions.FindLast(x => x.User.UserId == user.UserId);
            if (lastSession is null)
            {
                var session = new Session()
                {
                    User = user,
                    Action = null,
                    Controller = null,
                    Id = 0
                };
                sessions.Add(session);
                return session;
            }

            return lastSession;
        }
    }

    /*public class UserDataService
    {
        public async Task<User> GetUserByChatId(long chatId)
        {
            throw new NotImplementedException();
        }
    }*/
    
}


