using Npgsql;
using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.DataSource;

public class UsersDBService : DataProvider, IDBServiceBase<User>
{
    public UsersDBService(string connectionString) : base(connectionString)
    {
    }


    private static string insertQuery = "INSERT INTO TCB.users(telegram_client_id,password) VALUES ()";

    private static string connection = "";
    NpgsqlConnection conn = new NpgsqlConnection(connection);
    private NpgsqlCommand _command = new NpgsqlCommand(insertQuery, new NpgsqlConnection(connection));

    public async Task<User> Insert(User user)
    {
        string userInsertQueryTable =
            "INSERT INTO TCB.users (telegram_client_id,phone_number ,password) ";
        string userQuery =
            $" values ({user.TelegramClientId},{user.PhoneNumber},'{user.Password}');";
        string queryUser = userInsertQueryTable + userQuery;
        var resutReader =  await base.ExecuteWithResult(queryUser, null);
        return await SqlReaderToUsersModel(resutReader);
    }


    public async Task<List<User>> Insert(List<User> users)
    {
        if (users.Count != 0)
        {
            string usersInsertQueryTable =
                "INSERT INTO TCB.users (telegram_client_id,phone_number,password) ";
            string usersQuery = "";
            for (int i = 0; i < users.Count; i++)
            {
                usersQuery +=
                    $" values ({users[i].TelegramClientId},{users[i].PhoneNumber},'{users[i].Password}'";
                if (users.Count == i + 1)
                    usersQuery += ");";
                else
                    usersQuery += ",";
            }

            string queryUsers = usersInsertQueryTable + usersQuery;
            var resultReader =  await base.ExecuteWithResult(queryUsers, null);
            users = new List<User>();
            while (resultReader.Read())
            {
                users.Add(await SqlReaderToUsersModel(resultReader));
            }
        }

        return users;
    }

    public async Task Delete(User user)
    {
        string UserDeleteQuery = $"DELETE FROM TCB.users WHERE telegram_client_id = " + user.TelegramClientId;
        await base.ExecuteNonResult(UserDeleteQuery, null);
    }

    public async Task Delete(List<User> users)
    {
        if (users.Count > 0)
        {
            for (int i = 0; i < users.Count; i++)
            {
                string UsersDeleteQuery =
                    $"DELETE FROM TCB.users WHERE telegram_client_id = " + users[i].TelegramClientId;
                await base.ExecuteNonResult(UsersDeleteQuery, null);
            }
        }
    }

    public Task<User> Updete(User user)
    {
        throw new NotImplementedException();
    }

    public Task<List<User>> Updete(List<User> models)
    {
        throw new NotImplementedException();
    }

    public async Task<User> Read(User users)
    {
        string selectQuery =
            "SELECT " +
            "telegram_client_id," +
            "phone_number, " +
            "password, " +
            "is_premium FROM TCB.users where telegram_client_id = users.telegram_client_id;";
        var resultQuery = await base.ExecuteWithResult(selectQuery, null);
        return await SqlReaderToUsersModel(resultQuery);
    }

    public async Task<List<User>> Read()
    {
        string selectQuery =
            "SELECT " +
            "telegram_client_id," +
            "phone_number, " +
            "password, " +
            "is_premium FROM TCB.users where telegram_client_id = users.telegram_client_id;";
        var resultQuery = await base.ExecuteWithResult(selectQuery, null);
        List<User> users = new List<User>();
        while (resultQuery.Read())
            users.Add(await SqlReaderToUsersModel(resultQuery));
        return users;
    }

    private async Task<User> SqlReaderToUsersModel(NpgsqlDataReader reader) => new User()
    {
        TelegramClientId = reader.GetInt64(0),
        PhoneNumber = reader.GetString(1),
        Password = reader.GetString(2),
    };
}