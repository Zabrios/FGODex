using System;
using System.Threading;
using FGODex.Application.Contract.Client;
using FGODex.Application.Contract.Service;
using FGODex.Application.Implementation;
using MihaZupan.TelegramBotClients;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace FGODex.Application.Implementation.Service
{
    public class BotService : IBotService
    {
        protected readonly BlockingTelegramBotClient Bot;

        public BotService(IBotClient bot)
        {
            Bot = bot.Client;
            Bot.OnMessage += BotOnMessageReceived;
        }

        public void LaunchChaldea()
        {
            var me = Bot.GetMeAsync().Result;
            Bot.StartReceiving(Array.Empty<UpdateType>());
            Thread.Sleep(int.MaxValue);
            //test();

        }

        private async void BotOnMessageReceived(object sender, MessageEventArgs messageEventArgs)
        {
            var message = messageEventArgs.Message;

            if (message == null || message.Type != MessageType.Text) return;

            await Bot.SendTextMessageAsync(
                message.Chat.Id,
                "Work in Progress, await summon."
                //replyMarkup: inlineKeyboard
                );
        }

        public async void test()
        {
            await Bot.SendTextMessageAsync(
                chatId: 42711,
                text: "puto mariconazo"
                    );
        }
        
    }
}
