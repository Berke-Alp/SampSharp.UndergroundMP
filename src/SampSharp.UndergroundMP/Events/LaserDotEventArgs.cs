using SampSharp.GameMode;

namespace SampSharp.UndergroundMP.Events
{
    /// <summary>
    /// Laser dot event arguments
    /// </summary>
    public class LaserDotEventArgs
    {
        /// <summary>
        /// The ID of the weapon which is used by playerid.
        /// </summary>
        public int WeaponID { get; set; }
        /// <summary>
        /// The new coordinates of the laser dot.
        /// </summary>
        public Vector3 Coordinates { get; set; }
        /// <summary>
        /// Returning <see langword="false"/> will prevent this callback from being fired in (later) filterscripts and/or the gamemode and the laser dot update will be discarted. Returning <see langword="true"/> does not.
        /// </summary>
        public bool Discard { get; set; }
    }
}
