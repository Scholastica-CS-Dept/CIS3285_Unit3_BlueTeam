namespace CIS3285_Unit3Sample_2024.Models
{
    public class RoomRecord
    {
        public RoomRecord(string name, int roomId)
        // Changes for Sprint 1 -- User Story -- Sophie E
        {
            Name = name;
            RoomId1 = roomId;
        }

        int RoomId;
        public int RoomId1 { get => RoomId; set => RoomId = value; }

        public string Name
        // Changes for Sprint 2b -- User Story 2c -- Sophie E
        {
            get;
            private set;
        }
    }
}
