using TheConversationsBot.Domain.Models;
    
using TheConversationsBot.Service.Interface;
using TheConversationsBot.TelegramBot;
using Npgsql;

namespace TheConversationsBot.Service;
public class UserDataService : DataProvider
{

    private static string tableName = "users";

    private string selectQuery = $"SELECT * FROM {tableName}";
    private string selectByIdQuery = $"SELECT * FROM {tableName} WHERE id = @p0";
    private string selectByChatIdQuery = $"SELECT * FROM {tableName} WHERE telegram_client_id= @p0";

    private string insertQuery =
        $"INSERT INTO {tableName} (telegram_client_id,phone_number,password) VALUES ( @p1, @p2, @p3);";

    public UserDataService(string connectionString) : base(connectionString)
    {
    }

    public async Task<List<Domain.Models.User>> GetAll()
    {
        var reader = await this.ExecuteWithResult(this.selectQuery, null);
        List<Domain.Models.User> result = new List<Domain.Models.User>();
        while (reader.Read())
            result.Add(this.ReaderDataToModel(reader));

        return result;
    }


    public async Task<Domain.Models.User?> GetById(long id)
    {
        var reader = await this.ExecuteWithResult(this.selectByIdQuery, new NpgsqlParameter[]
        {
            new NpgsqlParameter("@p0", id)
        });
        List<Domain.Models.User> result = new List<Domain.Models.User>();
        while (reader.Read())
            result.Add(this.ReaderDataToModel(reader));

        return result.ElementAtOrDefault(0);
    }

    public async Task<int> Insert(Domain.Models.User user)
    {
        return await this.ExecuteNonResult(this.insertQuery, new NpgsqlParameter[]
        {
            new NpgsqlParameter("@p1", user.TelegramClientId),
            new NpgsqlParameter("@p2", user.PhoneNumber),
            new NpgsqlParameter("@p3", user.Password),
        });
    }

    public async Task<User?> GetUserByChatId(long chatId)
    {
        var reader = await this.ExecuteWithResult(this.selectByChatIdQuery, new NpgsqlParameter[]
        {
            new NpgsqlParameter("@p0", chatId)
        });
        List<Domain.Models.User> result = new List<Domain.Models.User>();
        while (reader.Read())
            result.Add(this.ReaderDataToModel(reader));

        return result.ElementAtOrDefault(0);
    }

    private Domain.Models.User ReaderDataToModel(NpgsqlDataReader reader)
    {
        return new Domain.Models.User()
        {
            UserId = reader.GetInt32(0),
            TelegramClientId = reader.GetInt32(1),
            PhoneNumber = reader.GetString(2),
            Password = reader.GetString(3)

        };
    }
}