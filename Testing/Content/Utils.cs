using NUnit.Framework;
using Content;
using Networking;

namespace Testing.Content
{
	///<summary>
	/// This file will contain required sample datastructures to test files and modules
	/// </summary>
	public class Utils
    {
		private FakeCommunicator _fakeCommunicator;

		public Utils()
        {
			_fakeCommunicator = new FakeCommunicator();
        }

		public FakeCommunicator GetFakeCommunicator()
        {
			return _fakeCommunicator;
        }

		public SendMessageData GenerateChatSendMsgData(string msg = "Hello", int[] rcvIds = null, int replyId = -1, MessageType type = MessageType.Chat)
        {
			if (rcvIds == null)
			{
				rcvIds = new int[0];
			}
			var toConvert = new SendMessageData();
			toConvert.Message = msg;
			toConvert.Type = type;
			toConvert.ReplyThreadId = replyId;
			toConvert.ReceiverIds = rcvIds;
			return toConvert;
		}

		public MessageData GenerateChatMessageData(MessageEvent chatEvent = MessageEvent.NewMessage, string msg = "Hello", int[] rcvIds = null, int replyId = -1, MessageType type = MessageType.Chat)
        {
			if(rcvIds == null)
            {
				rcvIds = new int[0];
            }
			SendMessageData sampleData = GenerateChatSendMsgData(msg,rcvIds,replyId,type);
			ChatClient contentChatClient = new ChatClient(_fakeCommunicator);
			MessageData msgData = contentChatClient.SendToMessage(sampleData, chatEvent);
			return msgData;
		}

		public MessageData GenerateNewMessageData(string Message, int MessageId = 1, int[] rcvIds = null, int ReplyThreadId = -1, int SenderId = -1, bool Starred = false, MessageType Type = MessageType.Chat)
		{
			if (rcvIds == null)
			{
				rcvIds = new int[0];
			}
			var msg = new MessageData();
			msg.Event = MessageEvent.NewMessage;
			msg.Message = Message;
			msg.MessageId = MessageId;
			msg.ReceiverIds = rcvIds;
			msg.SenderId = SenderId;
			msg.ReplyThreadId = ReplyThreadId;
			msg.Starred = Starred;
			msg.Type = Type;
			return msg;
		}

        public ReceiveMessageData GenerateNewReceiveMessageData(string Message, int MessageId = 1, int[] rcvIds = null, int ReplyThreadId = -1, int SenderId = -1, bool Starred = false, MessageType Type = MessageType.Chat)
        {
            if (rcvIds == null)
            {
                rcvIds = new int[0];
            }
            var msg = new ReceiveMessageData();
            msg.Event = MessageEvent.NewMessage;
            msg.Message = Message;
            msg.MessageId = MessageId;
            msg.ReceiverIds = rcvIds;
            msg.SenderId = SenderId;
            msg.ReplyThreadId = ReplyThreadId;
            msg.Starred = Starred;
            msg.Type = Type;
            return msg;
        }

		public SendMessageData GetSendMessageData1()
		{
			var toconvert1 = new SendMessageData();
			toconvert1.Message = "Hello";
			toconvert1.Type = MessageType.Chat;
			toconvert1.ReplyThreadId = -1;
			toconvert1.ReceiverIds = new int[0];
			return toconvert1;
		}

		public MessageData GetMessageData1()
        {
			SendMessageData sampleData = GetSendMessageData1();
			ChatClient conch = new ChatClient(_fakeCommunicator);
			MessageData msgData = conch.SendToMessage(sampleData, MessageEvent.NewMessage);
			return msgData;
		}

		public SendMessageData GetSendMessageData2()
		{
			var toconvert2 = new SendMessageData();
			toconvert2.Message = null;
			toconvert2.Type = MessageType.Chat;
			toconvert2.ReplyThreadId = -1;
			toconvert2.ReceiverIds = new int[0];
			return toconvert2;
		}

		///<summary>
		/// We need output string from server to trigger INotificationHandler function so that we can deserialized it and update chatContext map
		/// </summary>
	}
}
