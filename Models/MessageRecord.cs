namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
        //As a message reading user, I want to view a list of rooms that represent conversations - Joe Tschida
        public MessageRecord(int roomID, string authorName, string text)
        {
            RoomID = roomID;
            Text = text;
            AuthorName = authorName;
        }

        public int RoomID
        {
            get;
            private set;
        }

        public string Text
        {
            get;
            private set;
        }

        //As a message reading user, I want to view a list of rooms that represent conversations - Joe Tschida
        public string AuthorName
        {
            get;
            private set;
        }
    }
}
