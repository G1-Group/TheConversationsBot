using Npgsql;
using TheConversationsBot.Domain.Enums;
using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.DataSource;

public class AnonymChatDBService : DataProvider, IDBServiceBase<AnonymChat>
{
    public AnonymChatDBService(string connectionString) : base(connectionString)
    {
    }

    public async Task<AnonymChat> Insert(AnonymChat anonymChat)
    {
        string anonymChatInsertQueryTable = "INSERT INTO TCB.anonym_chats (create_date,from_id,to_id,state) ";
        string anonymChatQuery =
            $" values ({anonymChat.CreatedDate},{anonymChat.FromId},{anonymChat.ToId},{anonymChat.State});";
        string queryAnonymChat = anonymChatInsertQueryTable + anonymChatQuery;
        await base.ExecuteNonResult(queryAnonymChat, null);
        return null;
    }

    public async Task<List<AnonymChat>> Insert(List<AnonymChat> anonymChats)
    {
        if (anonymChats.Count != 0)
        {
            string anonymChatInsertQueryTable = "INSERT INTO TCB.anonym_chats (create_date,from_id,to_id,state) ";
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

            string queryAnonymChats = anonymChatInsertQueryTable + anonymChatQuery;
            await base.ExecuteNonResult(queryAnonymChats, null);
        }

        return null;
    }

    public async Task Delete(AnonymChat anonymChat)
    {
        string anonymChatDeleteQuery = $"DELETE FROM TCB.anonym_chats WHERE id = " + anonymChat.Id.ToString();
        await base.ExecuteNonResult(anonymChatDeleteQuery, null);
    }

    public async Task Delete(List<AnonymChat> anonymChats)
    {
        if (anonymChats.Count > 0)
        {
            for (int i = 0; i < anonymChats.Count; i++)
            {
                string anonymChatDeleteQuery =
                    $"DELETE FROM TCB.anonym_chats WHERE id = " + anonymChats[i].Id.ToString();
                await base.ExecuteNonResult(anonymChatDeleteQuery, null);
            }
        }
    }

    public async Task<AnonymChat> Updete(AnonymChat anonymChat)
    {
        throw new NotImplementedException();
    }

    public async Task<List<AnonymChat>> Updete(List<AnonymChat> anonymChats)
    {
        throw new NotImplementedException();
    }

    public async Task<AnonymChat> Read(AnonymChat anonymChat)
    {
        string selectQuery = $"SELECT create_date, " +
                             $"from_id, " +
                             $"to_id, " +
                             $"state, " +
                             $"id FROM TCB.anonym_chats where id = {anonymChat.Id};";
        var resultRequest = await base.ExecuteWithResult(selectQuery, null);
        return await ReaderToAnonymChatModel(resultRequest);
    }

    public async Task<List<AnonymChat>> Read()
    {
        string selectQuery =
            "SELECT " +
            "create_date, " +
            "from_id, to_id, " +
            "state, " +
            "id FROM TCB.anonym_chats;";

        var resultQuery = await base.ExecuteWithResult(selectQuery, null);
        List<AnonymChat> anonymChats = new List<AnonymChat>();
        while (resultQuery.Read())
            anonymChats.Add(await ReaderToAnonymChatModel(resultQuery));
        return anonymChats;
    }

    private async Task<AnonymChat> ReaderToAnonymChatModel(NpgsqlDataReader reader) => new AnonymChat {
        CreatedDate = reader.GetDateTime(0),
        FromId = reader.GetInt64(1),
        ToId = reader.GetInt64(2),
        State = (ChatState)reader.GetInt64(3),
        Id = reader.GetInt64(4)
    };
}