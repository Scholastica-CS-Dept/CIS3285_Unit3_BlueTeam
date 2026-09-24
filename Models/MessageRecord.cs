namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
        // Changes for Sprint 2 -- User Story 2a -- Sophie E
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

        // Changes for Sprint 2 -- User Story 2a -- Sophie E
        public string Text
        {
            get;
            private set;
        }

        public string AuthorName
        {
            get;
            private set;
        }
    }
}
