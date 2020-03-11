namespace DataStructuresInCSharp.Implementations._CommonSteps
{
    public class Message
    {
        public Message(string messageID, string messageText)
        {
            MessageID = messageID;
            MessageText = messageText;
        }

        public string MessageID { get; set; }
        public string MessageText { get; set; }
    }
}
