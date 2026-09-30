namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
        // Changes for Sprint 2 -- User Story 2a -- Sophie E
        // Changes for Sprint 1 -- User Story 1B -- Dillan Mzila
        public MessageRecord(int roomID, string authorName, string text)
        {
            RoomID = roomID;
            Text = text;
            AuthorName = authorName;
        }

        // Changes for Sprint 2 -- User Story 2c -- Sophie E
        // Changes for Sprint 1 -- User Story 1B -- Dillan Mzila
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

        // Changes for Sprint 1 -- User Story 1B -- Dillan Mzila
        public string AuthorName
        {
            get;
            private set;
        }
    }
}
