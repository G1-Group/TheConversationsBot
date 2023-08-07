using TheConversationsBot.Domain.Enums;
using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.DataSource;

public partial class SQLService
{
    private string insertQuery = "INSERT INTO TCB";

    public async Task InsertUser(User user)
    {
        string userInsertQueryTable = ".users (telegram_client_id,phone_number,password) ";
        string userQuery = $" values ({user.TelegramClientId},'{user.PhoneNumber}','{user.Password}' );";
        string queryUser = insertQuery + userInsertQueryTable + userQuery;
        base.ExecuteNonResult(queryUser, null).Wait();
        Console.WriteLine("asfd");
    }

    public async Task InsertUsers(List<User> users)
    {
        if (users.Count != 0)
        {
            string userInsertQueryTable = ".users(telegram_client_id,phone_number,password) ";
            string userQuery = "";
            for (int i = 0; i < users.Count; i++)
            {
                userQuery += $" values ({users[i].TelegramClientId},'{users[i].PhoneNumber}','{users[i].Password}'";
                if (users.Count == i + 1)
                    userQuery += ");";
                else
                    userQuery += ",";
            }

            string queryUsers = insertQuery + userInsertQueryTable + userQuery;
            await base.ExecuteNonResult(queryUsers, null);
        }
    }

    public async Task InsertClient(Client client)
    {
        string clientInsertQueryTable = ".clients (user_id,telegram_client_id,nickname,status,is_premium) ";
        string clientQuery =
            $" values ({client.UserId},{client.TelegramChatId},'{client.Nickname}',{client.Status},{client.IsPremium});";
        string queryclient = insertQuery + clientInsertQueryTable + clientQuery;
        await base.ExecuteNonResult(queryclient, null);
    }

    public async Task InsertClients(List<Client> clients)
    {
        if (clients.Count != 0)
        {
            string clientInsertQueryTable = ".clients (user_id,telegram_client_id,nickname,status,is_premium) ";
            string clientQuery = "";
            for (int i = 0; i < clients.Count; i++)
            {
                clientQuery +=
                    $" values ({clients[i].UserId},{clients[i].TelegramChatId},'{clients[i].Nickname}',{clients[i].Status},{clients[i].IsPremium}";
                if (clients.Count == i + 1)
                    clientQuery += ");";
                else
                    clientQuery += ",";
            }

            string queryclients = insertQuery + clientInsertQueryTable + clientQuery;
            await base.ExecuteNonResult(queryclients, null);
        }
    }

    public async Task InsertMessage(Message message)
    {
        string messageInsertQueryTable = ".messages (from_id,message,chat_id,type,board_id) ";
        string messageQuery =
            $" values ({message.FromId},'{message.Messages}',{message.ChatId},{message.Type},{message.BoardId});";
        string queryMessage = insertQuery + messageInsertQueryTable + messageQuery;
        await base.ExecuteNonResult(queryMessage, null);
    }

    public async Task InsertMessages(List<Message> messages)
    {
        if (messages.Count != 0)
        {
            string messageInsertQueryTable = ".messages (from_id,message,chat_id,type,board_id) ";
            string messageQuery = "";
            for (int i = 0; i < messages.Count; i++)
            {
                messageQuery +=
                    $" values ({messages[i].FromId},'{messages[i].Messages}',{messages[i].ChatId},{messages[i].Type},{messages[i].BoardId}";
                if (messages.Count == i + 1)
                    messageQuery += ");";
                else
                    messageQuery += ",";
            }

            string querymessages = insertQuery + messageInsertQueryTable + messageQuery;
            await base.ExecuteNonResult(querymessages, null);
        }
    }

    public async Task InsertAnonymChat(AnonymChat anonymChat)
    {
        string anonymChatInsertQueryTable = ".anonym_chats (create_date,from_id,to_id,state) ";
        string anonymChatQuery =
            $" values ({anonymChat.CreatedDate},{anonymChat.FromId},{anonymChat.ToId},{anonymChat.State});";
        string queryAnonymChat = insertQuery + anonymChatInsertQueryTable + anonymChatQuery;
        await base.ExecuteNonResult(queryAnonymChat, null);
    }

    public async Task InsertAnonymChats(List<AnonymChat> anonymChats)
    {
        if (anonymChats.Count != 0)
        {
            string anonymChatInsertQueryTable = ".anonym_chats (create_date,from_id,to_id,state) ";
            string anonymChatQuery = "";
            for (int i = 0; i < anonymChats.Count; i++)
            {
                anonymChatQuery +=
                    $" values ({anonymChats[i].CreatedDate},{anonymChats[i].FromId},{anonymChats[i].ToId},{anonymChats[i].State}";
                if (anonymChats.Count == i + 1)
                    anonymChatQuery += ");";
                else
                    anonymChatQuery += ",";
            }

            string queryAnonymChats = insertQuery + anonymChatInsertQueryTable + anonymChatQuery;
            await base.ExecuteNonResult(queryAnonymChats, null);
        }
    }

    private async Task InsertBoard(Board board)
    {
        string boardInsertQueryTable = ".boards (nickname,owner_id) ";
        string boardQuery =
            $" values ('{board.Nickname}',{board.OwnerId});";
        string queryBoard = insertQuery + boardInsertQueryTable + boardQuery;
        await base.ExecuteNonResult(queryBoard, null);
    }

    private async Task InsertBoards(List<Board> boards)
    {
        if (boards.Count != 0)
        {
            string boardInsertQueryTable = ".boards (nickname,owner_id) ";
            string boardQuery = "";
            for (int i = 0; i < boards.Count; i++)
            {
                boardQuery +=
                    $" values ({boards[i].Nickname},{boards[i].OwnerId}";
                if (boards.Count == i + 1)
                    boardQuery += ");";
                else
                    boardQuery += ",";
            }

            string queryBoard = insertQuery + boardInsertQueryTable + boardQuery;
            await base.ExecuteNonResult(queryBoard, null);
        }
    }
}