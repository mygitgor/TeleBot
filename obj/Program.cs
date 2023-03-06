
string token = File.ReadAllText("token.config");

TelegramBot bot = new TelegramBot(token);

void Updates(TelegramMessageModel msg)
{
    bot.SendMessage(msg.chatId, $"{msg.text}: send");
}

bot.action = Updates;

bot.Start();

Console.WriteLine("++++");
