using System;

namespace YammerBot.Core.Yammer.Interface
{
    public interface IYammerMessageServiceManager
    {
        string GetLatestMessagesTextFromServer();
        string GetLatestMessagesTextFromServerAfterMessageID(Int64 messageID);
        string PostNewMessage(string message);
        string PostMessageReply(string message, Int64 threadId);
    }
}