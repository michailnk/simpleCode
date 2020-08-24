using MihaZupan;
using System;
using Telegram.Bot;

namespace FirstBotTelegram {
    class Program {

        private static ITelegramBotClient client;

        static void Main(string[] args) {
            client = new TelegramBotClient("1295910855:AAHkwoRmWfyy2uTQmx3gA46hbve1EruhhLo") { Timeout = TimeSpan.FromSeconds(10) }; ;
            // unblock for russian 
            // spys.one proxy type socks5
            var proxy = new HttpToSocks5Proxy("174.77.111.197", 4145);
            //client = new TelegramBotClient("1295910855:AAHkwoRmWfyy2uTQmx3gA46hbve1EruhhLo", proxy) { Timeout = TimeSpan.FromSeconds(10) };
            var me = client.GetMeAsync().Result;
            Console.WriteLine(me.FirstName +" " + me.Id);

            client.OnMessage += Client_OnMessage;
            client.StartReceiving();

            Console.ReadKey();
        }

        private static async void Client_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e) {
            var text = e?.Message?.Text;
            if (text == null)
                return;
            Console.WriteLine($"recived text: {text} message: {e.Message.Chat.Id}");
            await client.SendTextMessageAsync(
                chatId: e.Message.Chat.Id,
                text: $"You said {text}")
                .ConfigureAwait(false);
        }
    }
}
