using TheConversationsBot.TelegramBot.Managers;

namespace TheConversationsBot.TelegramBot.Controllers;

public abstract class ControllerBase
{
    private readonly ManagerController _managerController;

    public ControllerBase(ManagerController managerController)
    {
        _managerController = managerController;
    }
    protected abstract Task HandleAction(Context context);
    protected abstract Task HandleUpdate(Context context);
    
    public async Task Handle(Context context)
    {
      
    }
}