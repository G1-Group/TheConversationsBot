using Npgsql;
using TheConversationsBot.Domain.Models;
using TheConversationsBot.Domain.Enums;

namespace TheConversationsBot.Service.DataSource;

public class MessageDBService : DataProvider, IDBServiceBase<Message>
{
    public MessageDBService(string connectionString) : base(connectionString)
    {
    }

    public async Task Insert(Message message)
    {
        string messageInsertQueryTable = "INSERT INTO TCB.messages (from_id,message,chat_id,type,board_id) ";
        string messageQuery =
            $" values ({message.FromId},'{message.Messages}',{message.ChatId},{message.Type},{message.BoardId});";
        string queryMessage = messageInsertQueryTable + messageQuery;
        await base.ExecuteNonResult(queryMessage, null);
    }

    public async Task Insert(List<Message> messages)
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

            string querymessages = messageInsertQueryTable + messageQuery;
            await base.ExecuteNonResult(querymessages, null);
        }
    }

    private string _deleteQuery = $"DELETE FROM TCB.";

    public async Task Delete(Message message)
    {
        string MessageDeleteQuery = _deleteQuery + $"message WHERE id = " + message.Id.ToString();
        int result = await base.ExecuteNonResult(MessageDeleteQuery, null);
    }

    public async Task Delete(List<Message> models)
    {
        throw new NotImplementedException();
    }

    private string updateQuery = $"DELETE FROM TCB.";

    public async Task Updete(Message message)
    {
        var result = await this.ExecuteNonResult(updateQuery, new NpgsqlParameter[]
        {
            new NpgsqlParameter("@p1", message.FromId),
            new NpgsqlParameter("@p2", message.Messages),
            new NpgsqlParameter("@p3", message.ChatId),
            new NpgsqlParameter("@p4", message.BoardId),
        });
    }

    public async Task Updete(List<Message> models)
    {
        throw new NotImplementedException();
    }


    public async Task<Message> Read(Message message)
    {
        string selectQuery =
            "SELECT " +
            "ID," +
            "FromID, " +
            "Messages, " +
            "ChatID, " +
            "BoardID, " +
            "is_premium FROM TCB.Messages;";
        var resultQuery = await base.ExecuteWithResult(selectQuery, null);
        return await SqlReaderToMessageModel(resultQuery);
    }


    public async Task<List<Message>> Read()
    {
        string selectQuery =
            "SELECT " +
            "ID," +
            "FromID, " +
            "Messages, " +
            "ChatID, " +
            "BoardID, " +
            "is_premium FROM TCB.Messages;";

        var resultQuery = await base.ExecuteWithResult(selectQuery, null);
        List<Message> messages = new List<Message>();
        while (resultQuery.Read())
            messages.Add(await SqlReaderToMessageModel(resultQuery));
        return messages;
    }

    private async Task<Message> SqlReaderToMessageModel(NpgsqlDataReader resultQuery)
    {
        throw new NotImplementedException();
    }
}