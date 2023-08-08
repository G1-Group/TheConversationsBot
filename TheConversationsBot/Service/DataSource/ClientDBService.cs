using Npgsql;
using TheConversationsBot.Domain.Enums;
using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.DataSource;

public class ClientDBService : DataProvider, IDBServiceBase<Client>
{
    public ClientDBService(string connectionString) : base(connectionString)
    {
    }

    public async Task Insert(Client client)
    {
        string clientInsertQueryTable =
            "INSERT INTO TCB.clients (user_id,telegram_client_id,nickname,status,is_premium) ";
        string clientQuery =
            $" values ({client.UserId},{client.TelegramChatId},'{client.Nickname}',{client.Status},{client.IsPremium});";
        string queryclient = clientInsertQueryTable + clientQuery;
        await base.ExecuteNonResult(queryclient, null);
    }

    public async Task Insert(List<Client> clients)
    {
        if (clients.Count != 0)
        {
            string clientInsertQueryTable =
                "INSERT INTO TCB.clients (user_id,telegram_client_id,nickname,status,is_premium) ";
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

            string queryclients = clientInsertQueryTable + clientQuery;
            await base.ExecuteNonResult(queryclients, null);
        }
    }

    public async Task Delete(Client client)
    {
        string ClientDeleteQuery = $"DELETE FROM TCB.clients WHERE client_id = " + client.ClientId;
        await base.ExecuteNonResult(ClientDeleteQuery, null);
    }

    public async Task Delete(List<Client> clients)
    {
        if (clients.Count > 0)
        {
            for (int i = 0; i < clients.Count; i++)
            {
                string ClientDeleteQuery = $"DELETE FROM TCB.clients WHERE client_id = " + clients[i].ClientId;
                await base.ExecuteNonResult(ClientDeleteQuery, null);
            }
        }
    }

    public async Task Updete(Client client)
    {
        throw new NotImplementedException();
    }

    public async Task Updete(List<Client> clients)
    {
        throw new NotImplementedException();
    }

    public async Task<Client> Read(Client client)
    {
        string selectQuery =
            "SELECT " +
            "client_id," +
            "user_id, " +
            "telegram_chat_id, " +
            "nickname, " +
            "status, " +
            $"is_premium FROM TCB.clients where client_id = {client.ClientId};";
        var resultQuery = await base.ExecuteWithResult(selectQuery, null);
        return await SqlReaderToClientModel(resultQuery);
    }

    public async Task<List<Client>> Read()
    {
        string selectQuery =
            "SELECT " +
            "client_id," +
            "user_id, " +
            "telegram_chat_id, " +
            "nickname, " +
            "status, " +
            "is_premium FROM TCB.clients;";

        var resultQuery = await base.ExecuteWithResult(selectQuery, null);
        List<Client> clients = new List<Client>();
        while (resultQuery.Read())
            clients.Add(await SqlReaderToClientModel(resultQuery));
        return clients;
    }

    private async Task<Client> SqlReaderToClientModel(NpgsqlDataReader reader) => new Client() {
        ClientId = reader.GetInt64(0),
        UserId = reader.GetInt64(1),
        TelegramChatId = reader.GetInt64(2),
        Nickname = reader.GetString(3),
        Status = (ClientStatus)reader.GetInt64(4),
        IsPremium = reader.GetBoolean(5)
    };
}