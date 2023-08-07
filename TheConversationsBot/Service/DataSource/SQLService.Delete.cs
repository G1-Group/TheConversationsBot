using TheConversationsBot.Domain.Enums;
using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.Interface;

public partial class SQLService
{
    private string _deleteQuery = $"DELETE FROM TCB.";
    public async Task DeleteUserAsync(User user)
    {
        string userDeleteQuery = _deleteQuery + $"users WHERE id = " + user.Id.ToString();
        var t  = await base.ExecuteNonResult(userDeleteQuery, null);
        // Console.WriteLine(t);
    }

    public async Task DeleteClientAsync(Client client)
    {
        string ClientDeleteQuery = _deleteQuery + $"clients WHERE client_id = " + client.ClientId;
        int result = await base.ExecuteNonResult(ClientDeleteQuery, null);
        //Console.WriteLine(ClientDeleteQuery);
    }

    public async Task DeleteMessageAsync(Message message)
    {
        string MessageDeleteQuery = _deleteQuery + $"message WHERE id = " + message.Id.ToString();
        int result = await base.ExecuteNonResult(MessageDeleteQuery, null);
        //Console.WriteLine(MessageDeleteQuery);
    }

    public async Task DeleteAnonymChatAsync(AnonymChat anonymChat)
    {
        string anonymChatDeleteQuery = _deleteQuery + $"anonym_chats WHERE id = " + anonymChat.Id.ToString();
        int result = await base.ExecuteNonResult(anonymChatDeleteQuery, null);
        // Console.WriteLine(anonymChatDeleteQuery);
    }

    public async Task DeleteBoardAsync(Board board)
    {
        string BoardDeleteQuery = _deleteQuery + $"boards WHERE id = " + board.BoardId.ToString();
        int i = await  base.ExecuteNonResult(BoardDeleteQuery, null);
        // Console.WriteLine(BoardDeleteQuery);
        // Console.WriteLine(i);
    }
}