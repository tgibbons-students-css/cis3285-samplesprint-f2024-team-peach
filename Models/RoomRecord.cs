namespace CIS3285_Unit3Sample_2024.Models
{
    public class RoomRecord
    {
        // Changes Sprint 1 -- I want to create rooms for categorizing conversations -- Joe Tschida
        public RoomRecord(string name, int roomId)
        {
            Name = name;
            RoomId1 = roomId;
            // Changes Sprint 1 -- User Limit to be added -- Joe Tschida
        }

        int RoomId;
        public int RoomId1 { get => RoomId; set => RoomId = value; }
        
        // Changes Sprint 1 -- As a system administrator, I want to serve hundreds of users concurrently. - Joe Tschida
        public string Name
        {
            get;
            private set;
        }
    }
}
