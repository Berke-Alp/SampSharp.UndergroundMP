using SampSharp.GameMode.World;

namespace SampSharp.UndergroundMP.Events
{
    /// <summary>
    /// Change radio event arguments
    /// </summary>
    public class ChangeRadioEventArgs
    {
        /// <summary>
        /// The vehicle the player which changed the radio station is in.
        /// </summary>
        public BaseVehicle Vehicle { get; set; }
        /// <summary>
        /// The old radio station.
        /// </summary>
        public int oldStation { get; set; }
        /// <summary>
        /// The new radio station.
        /// </summary>
        public int newStation { get; set; }
    }
}
