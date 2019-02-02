using System;

namespace EventsBerry.Model
{
    public class CheckIn
    {
        public string ParticipatorId { get; set; }
        public string ParticipatorDisplayName { get; set; }
        public DateTime CheckInTime { get; set; }
    }
}
