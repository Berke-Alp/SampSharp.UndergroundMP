using SampSharp.GameMode.World;

namespace SampSharp.UndergroundMP.Events
{
    /// <summary>
    /// Vehicle spray event arguments
    /// </summary>
    public class VehicleSprayEventArgs
    {
        /// <summary>
        /// The vehicle which was resprayed.
        /// </summary>
        public BaseVehicle Vehicle { get; set; }
        /// <summary>
        /// The new primary vehicle color used by this vehicle.
        /// </summary>
        public int Color1 { get; set; }
        /// <summary>
        /// The new secondary vehicle color used by this vehicle.
        /// </summary>
        public int Color2 { get; set; }
        /// <summary>
        /// The new tetriary vehicle color used by this vehicle.
        /// </summary>
        public int Color3 { get; set; }
        /// <summary>
        /// The new quaternary vehicle color used by this vehicle.
        /// </summary>
        public int Color4 { get; set; }
    }
}
