using System;
using System.Threading;
using FGODex.Application.Contract.Client;
using FGODex.Application.Contract.Service;
using FGODex.Application.Implementation;
using MihaZupan.TelegramBotClients;

namespace FGODex.Application.Implementation.Service
{
    public class BotService : IBotService
    {
        protected readonly BlockingTelegramBotClient Bot;

        public BotService(IBotClient bot)
        {
            Bot = bot.Client;
        }

        public void LaunchChaldea()
        {
            throw new NotImplementedException();
        }
    }
}
