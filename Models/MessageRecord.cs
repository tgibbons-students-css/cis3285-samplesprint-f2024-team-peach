namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
        // Changes Sprint 1 -- As a message reading user, I want to view a list of rooms that represent conversations - Joe Tschida
        // Changes Sprint 1 -- As a message poster, I want to send markdown text that will be correctly formatted - Joe Tschida
        public MessageRecord(int roomID, string authorName, string text)
        {
            RoomID = roomID;
            Text = text;
            AuthorName = authorName;
        }
        // Changes Sprint 1 -- As a system administrator, I want to serve hundreds of users concurrently. - Joe Tschida
        public int RoomID
        {
            get;
            private set;
        }
        // Changes Sprint 1 -- As a message poster, I want to send markdown text that will be correctly formatted - Joe Tschida
        public string Text
        {
            get;
            private set;
        }

        // Changes Sprint 1 -- As a message reading user, I want to view a list of rooms that represent conversations - Joe Tschida
        public string AuthorName
        {
            get;
            private set;
        }
    }
}
