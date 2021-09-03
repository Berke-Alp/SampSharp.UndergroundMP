using SampSharp.Core.Callbacks;
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
		 /// <param name="playerid">The player ID which resprayed the vehicle. This is guaranteed to be the driver of vehicleid.</param>
		 /// <param name="vehicleid">The ID of the vehicle which was resprayed.</param>
		 /// <param name="color1">The new primary vehicle color ID used by this vehicle.</param>
		 /// <param name="color2">The new secondary vehicle color ID used by this vehicle.</param>
		 /// <param name="color3">The new tertiary vehicle color ID used by this vehicle.</param>
		 /// <param name="color4">The new quaternary vehicle color ID used by this vehicle.</param>
		[Callback]
        internal void OnVehicleResprayAtGarage(int playerid, int vehicleid, int color1, int color2, int color3, int color4)
        {
            var player = BasePlayer.FindOrCreate(playerid);
            var eventArgs = new VehicleSprayEventArgs()
            {
                Vehicle = BaseVehicle.Find(vehicleid),
                Color1 = color1,
                Color2 = color2,
                Color3 = color3,
                Color4 = color4
            };

            OnVehicleResprayAtGarage(player, eventArgs);
        }

		/// <summary>
		/// Callback which fires whenever a server-side model is fully set up and a valid model ID is stored for the player.
		/// </summary>
		/// <param name="playerid">The player ID for which the model was set up.</param>
		/// <param name="modelname">The name of the model which has been set up for a player.</param>
		/// <param name="modelid">The model ID assigned to the model for the player.</param>
		[Callback]
		internal void OnAddModelCompleted(int playerid, string modelname, int modelid)
		{
			var player = BasePlayer.FindOrCreate(playerid);
			var eventArgs = new AddModelEventArgs()
			{
				ModelID = modelid,
				ModelName = modelname
			};

			OnAddModelCompleted(player, eventArgs);
		}

		/// <summary>
		/// This callback fires whenever a player is using a laser rifle and the dot position changed.
		/// </summary>
		/// <param name="playerid">The player ID which is using a laser rifle.</param>
		/// <param name="weaponid">The ID of the weapon which is used by playerid.</param>
		/// <param name="x">The new X coordinate of the laser dot.</param>
		/// <param name="y">The new Y coordinate of the laser dot.</param>
		/// <param name="z">The new Z coordinate of the laser dot.</param>
		/// <returns>Returning 0 will prevent this callback from being fired in (later) filterscripts and/or the gamemode and the laser dot update will be discarted. Returning 1 does not.</returns>
		[Callback]
		internal bool OnLaserDotUpdate(int playerid, int weaponid, float x, float y, float z)
		{
			var player = BasePlayer.FindOrCreate(playerid);
			var eventArgs = new LaserDotEventArgs()
			{
				Coordinates = new GameMode.Vector3(x, y, z),
				WeaponID = weaponid,
				Discard = false
			};

			return OnLaserDotUpdate(player, eventArgs);
		}

		/// <summary>
		/// This callback fires whenever a player changes the radio station inside a vehicle.
		/// </summary>
		/// <param name="playerid">The player which changed the radio station.</param>
		/// <param name="vehicleid">The vehicle the player which changed the radio station is in.</param>
		/// <param name="oldstation">The old radio station.</param>
		/// <param name="newstation">The new radio station.</param>
		[Callback]
		internal void OnPlayerChangeRadio(int playerid, int vehicleid, int oldstation, int newstation)
		{
			var player = BasePlayer.FindOrCreate(playerid);
			var eventArgs = new ChangeRadioEventArgs()
			{
				newStation = newstation,
				oldStation = oldstation,
				Vehicle = BaseVehicle.Find(vehicleid)
			};

			OnPlayerChangeRadio(player, eventArgs);
		}

		/// <summary>
		/// Callback which fires when downloading has finished for a player.
		/// </summary>
		/// <param name="playerid">The player ID which just finished downloading files.</param>
		[Callback]
		internal void OnPlayerFinishedDownloading(int playerid)
		{
			var player = BasePlayer.FindOrCreate(playerid);

            OnPlayerFinishedDownloading(player, new EventArgs());
        }

        /// <summary>
        /// Callback which fires when downloading has started for a player.
        /// </summary>
        /// <param name="playerid">The player ID which just started downloading files.</param>
        [Callback]
		internal void OnPlayerStartedDownloading(int playerid)
		{
			var player = BasePlayer.FindOrCreate(playerid);

			OnPlayerStartedDownloading(player, new EventArgs());
		}
	}
}
