using System;
using System.Collections.Generic;
using FGODex.Application.Contract.Client;
using System.Text;
using MihaZupan.TelegramBotClients;
using Microsoft.Extensions.Configuration;
using System.Net.Http;

namespace FGODex.Application.Implementation.Client
{
    public class BotClient : IBotClient
    {
        public BlockingTelegramBotClient Client { get; }

        public BotClient(IConfiguration config)
        {
            try
            {
                Client = new BlockingTelegramBotClient(config["TelegramBotToken"], (HttpClient)null);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
