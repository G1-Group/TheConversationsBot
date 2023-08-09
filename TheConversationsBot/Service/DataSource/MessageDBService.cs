using Npgsql;
using TheConversationsBot.Domain.Models;
using TheConversationsBot.Domain.Enums;

namespace TheConversationsBot.Service.DataSource;

public class MessageDBService : DataProvider, IDBServiceBase<Message>
{
    public MessageDBService(string connectionString) : base(connectionString)
    {
    }

    public async Task<Message> Insert(Message message)
    {
        string messageInsertQueryTable = "INSERT INTO TCB.messages (from_id,message,chat_id,type,board_id) ";
        string messageQuery =
            $" values ({message.FromId},'{message.Messages}',{message.ChatId},{message.Type},{message.BoardId});";
        string queryMessage = messageInsertQueryTable + messageQuery;
        var messageReader = await base.ExecuteWithResult(queryMessage, null);
        return await SqlReaderToMessageModel(messageReader);
    }

    public async Task<List<Message>> Insert(List<Message> messages)
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
            var messageReader = await base.ExecuteWithResult(querymessages, null);
            messages = new List<Message>();
            while (messageReader.Read())
            {
                messages.Add(await SqlReaderToMessageModel(messageReader));
            }
        }

        return messages;
    }


    public async Task Delete(Message message)
    {
        string MessageDeleteQuery = $"DELETE FROM TCB.messages WHERE id = " + message.Id.ToString(); 
        await base.ExecuteNonResult(MessageDeleteQuery, null);
    }

    public async Task Delete(List<Message> models)
    {
        throw new NotImplementedException();
    }

    private string updateQuery = $"DELETE FROM TCB.";

    public async Task<Message> Updete(Message message)
    {
        var readerMessage = await this.ExecuteWithResult(updateQuery, new NpgsqlParameter[]
        {
            new NpgsqlParameter("@p1", message.FromId),
            new NpgsqlParameter("@p2", message.Messages),
            new NpgsqlParameter("@p3", message.ChatId),
            new NpgsqlParameter("@p4", message.BoardId),
        });
        return await SqlReaderToMessageModel(readerMessage);
    }

    public async Task<List<Message>> Updete(List<Message> messages)
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