using TheConversationsBot.Service;
using TheConversationsBot.Service.DataSource;
using TheConversationsBot.TelegramBot.Managers;

namespace TheConversationsBot.TelegramBot.Controllers;

public class AuthController:ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(ManagerController managerController,AuthService authService) : base(managerController)
    {
        _authService = authService;
    }

    protected override async Task Index(Context context)
    {
        
    }

    protected override async Task HandleAction(Context context)
    {
        switch (context.Session.Action)
        {
            case nameof(SignUpStepStart):
            {
                await SignUpStepStart(context);
                break;
            }
            case nameof(SignUpStepFirst):
            {
                await SignUpStepFirst(context);
                break;
            }
            case nameof(SignUpStepLast):
            {
                await SignUpStepLast(context);
                break;
            }
            case nameof(SignUpStepThird):
            {
                await SignUpStepThird(context);
                break;
            }
            
            
            
            case nameof(LoginStepStart):
            {
                await LoginStepStart(context);
                break;
            }
            case nameof(LoginStepFirst):
            {
                await LoginStepLast(context);
                break;
            }
            case nameof(LoginStepLast):
            {
                await LoginStepLast(context);
                break;
            }
            
            
            
            default:
            {
                await Index(context);
                break;
            }
        }
    }

    protected override async Task HandleUpdate(Context context)
    {
        
    }


    public async Task SignUpStepStart(Context context)
    {
        
        context.Session.Action = nameof(SignUpStepFirst);
    }

    public async Task SignUpStepFirst(Context context)
    {
        
        context.Session.Action = nameof(SignUpStepLast);
    }

    public async Task SignUpStepLast(Context context)
    {


        context.Session.Action = nameof(SignUpStepThird);
    }

    public async Task SignUpStepThird(Context context)
    {

        context.Session.Action = nameof(Index);
    }


    public async Task LoginStepStart(Context context)
    {

        context.Session.Action = nameof(LoginStepFirst);
    }

    public async Task LoginStepFirst(Context context)
    {
        
        context.Session.Action = nameof(LoginStepLast);
    }

    public async Task LoginStepLast(Context context)
    {
        context.Session.Controller = nameof(ClientDataService);
        context.Session.Action = null;
    }
    
    
}