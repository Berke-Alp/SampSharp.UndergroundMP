using SampSharp.GameMode.World;
using SampSharp.UndergroundMP.Events;
using System;

namespace SampSharp.UndergroundMP
{
    public partial class UGMP
    {
        /// <summary>
        /// This callback fires whenever a vehicle gets resprayed at a Pay N' Spray garage.
        /// </summary>
        /// <param name="player">The player which resprayed the vehicle. This is guaranteed to be the driver of vehicleid.</param>
        /// <param name="e">Event arguments</param>
        protected virtual void OnVehicleResprayAtGarage(BasePlayer player, VehicleSprayEventArgs e)
        {
            VehicleResprayAtGarage?.Invoke(player, e);
        }

        /// <summary>
        /// This callback fires whenever a player is using a laser rifle and the dot position changed.
        /// </summary>
        /// <param name="player">The player which is using a laser rifle.</param>
        /// <param name="e">Event arguments</param>
        /// <returns></returns>
        protected virtual bool OnLaserDotUpdate(BasePlayer player, LaserDotEventArgs e)
        {
            LaserDotUpdate?.Invoke(player, e);
            return !e.Discard;
        }

        /// <summary>
        /// Callback which fires whenever a server-side model is fully set up and a valid model ID is stored for the player.
        /// </summary>
        /// <param name="player">The player for which the model was set up.</param>
        /// <param name="e">Event arguments</param>
        protected virtual void OnAddModelCompleted(BasePlayer player, AddModelEventArgs e)
        {
            AddModelCompleted?.Invoke(player, e);
        }

        /// <summary>
        /// Callback which fires when downloading has started for a player.
        /// </summary>
        /// <param name="player">The player which just started downloading files.</param>
        /// <param name="e">Event arguments</param>
        protected virtual void OnPlayerStartedDownloading(BasePlayer player, EventArgs e)
        {
            PlayerStartedDownloading?.Invoke(player, e);
        }

        /// <summary>
        /// Callback which fires when downloading has finished for a player.
        /// </summary>
        /// <param name="player">The player which just finished downloading files.</param>
        /// <param name="e">Event arguments</param>
        protected virtual void OnPlayerFinishedDownloading(BasePlayer player, EventArgs e)
        {
            PlayerFinishedDownloading?.Invoke(player, e);
        }

        /// <summary>
        /// This callback fires whenever a player changes the radio station inside a vehicle.
        /// </summary>
        /// <param name="player">The player which changed the radio station.</param>
        /// <param name="e">Event arguments</param>
        protected virtual void OnPlayerChangeRadio(BasePlayer player, ChangeRadioEventArgs e)
        {
            PlayerChangeRadio?.Invoke(player, e);
        }

        /// <summary>
        /// This event fires whenever a vehicle gets resprayed at a Pay N' Spray garage.
        /// </summary>
        public event EventHandler<VehicleSprayEventArgs> VehicleResprayAtGarage;
        /// <summary>
        /// This event fires whenever a player is using a laser rifle and the dot position changed.
        /// </summary>
        public event EventHandler<LaserDotEventArgs> LaserDotUpdate;
        /// <summary>
        /// Event which fires when downloading has started for a player.
        /// </summary>
        public event EventHandler PlayerStartedDownloading;
        /// <summary>
        /// Event which fires when downloading has finished for a player.
        /// </summary>
        public event EventHandler PlayerFinishedDownloading;
        /// <summary>
        /// This event fires whenever a player changes the radio station inside a vehicle.
        /// </summary>
        public event EventHandler<ChangeRadioEventArgs> PlayerChangeRadio;
        /// <summary>
        /// Event which fires whenever a server-side model is fully set up and a valid model ID is stored for the player.
        /// </summary>
        public event EventHandler<AddModelEventArgs> AddModelCompleted;
    }
}
