using System.Text.Json;

namespace TheConversationsBot.Service.Interface;

public class FaylService
{
    private T Deserialize<T>(string data) => JsonSerializer.Deserialize<T>(data);
    private string Serialize(object data) => JsonSerializer.Serialize(data);
}