using MihaZupan.TelegramBotClients;

namespace FGODex.Application.Contract.Client
{
    public interface IBotClient
    {
        BlockingTelegramBotClient Client { get; }
    }
}
