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
            // should HTTPCLient change to anything not null?
                Client = new BlockingTelegramBotClient(config["TelegramBotToken"], (HttpClient)null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
