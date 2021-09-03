using SampSharp.GameMode.World;

namespace SampSharp.UndergroundMP.Extensions
{
	/// <summary>
	/// Extension methods for <seealso cref="BasePlayer"/> class
	/// </summary>
    public static class BasePlayerExtensions
    {
		/// <summary>
		/// Changes the ped colors of a certain skin. See this page for a list of valid ped color IDs.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="color1">The primary ped color ID to use.</param>
		/// <param name="color2">The secondary ped color ID to use.</param>
		/// <param name="color3">The tertiary ped color ID to use.</param>
		/// <param name="color4">The quaternary ped color ID to use.</param>
		public static void ChangePlayerPedColor(BasePlayer player, int color1, int color2, int color3, int color4)
		{
			UGMP.Internal.ChangePlayerPedColor(player.Id, color1, color2, color3, color4);
		}

		/// <summary>
		/// Gets the aircraft height limit for a single player.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <returns>The aircraft height limit set for this player.</returns>
		public static float GetPlayerAircraftHeightLimit(BasePlayer player)
		{
			return UGMP.Internal.GetPlayerAircraftHeightLimit(player.Id);
		}

		/// <summary>
		/// Gets the jetpack height limit for a single player.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <returns>The jetpack height limit set for this player.</returns>
		public static float GetPlayerJetpackHeightLimit(BasePlayer player)
		{
			return UGMP.Internal.GetPlayerJetpackHeightLimit(player.Id);
		}

		/// <summary>
		/// Retrieves the model ID for a server-side model by it's model name.
		/// </summary>
		/// <param name="player">The player which to get the model ID for.</param>
		/// <param name="modelname">The model name to get the model ID for.</param>
		/// <returns>The model ID for the specified model name and player. INVALID_MODEL if it cannot be retrieved.</returns>
		public static int GetPlayerNetModelID(BasePlayer player, string modelname)
		{
			return UGMP.Internal.GetPlayerNetModelID(player.Id, modelname);
		}

		/// <summary>
		/// Returns the current ped colours applied to a player. See this page for a list of valid ped color IDs.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="color1">The primary ped color ID used by this player ped. This parameter is updated by this native and is passed by reference.</param>
		/// <param name="color2">The secondary ped color ID used by this player ped. This parameter is updated by this native and is passed by reference.</param>
		/// <param name="color3">The tertiary ped color ID used by this player ped. This parameter is updated by this native and is passed by reference.</param>
		/// <param name="color4">The quaternary ped color ID used by this player ped. This parameter is updated by this native and is passed by reference.</param>
		public static void GetPlayerPedColor(BasePlayer player, out int color1, out int color2, out int color3, out int color4)
		{
			UGMP.Internal.GetPlayerPedColor(player.Id, out color1, out color2, out color3, out color4);
		}

		/// <summary>
		/// Checks whether or not an animated clump model ID is valid for a player.
		/// </summary>
		/// <param name="player">The player ID for which to verify a model ID's validity.</param>
		/// <param name="modelid">The model ID to verify.</param>
		/// <returns>1 if the model is valid, 0 if it isn't.</returns>
		public static bool IsAClmpNetModelValidForPlayer(BasePlayer player, int modelid)
		{
			return UGMP.Internal.IsAClmpNetModelValidForPlayer(player.Id, modelid);
		}

		/// <summary>
		/// Checks whether or not an atomic model ID is valid for a player.
		/// </summary>
		/// <param name="player">The player ID for which to verify a model ID's validity.</param>
		/// <param name="modelid">The model ID to verify.</param>
		/// <returns>1 if the model is valid, 0 if it isn't.</returns>
		public static bool IsAtmModelValidForPlayer(BasePlayer player, int modelid)
		{
			return UGMP.Internal.IsAtmModelValidForPlayer(player.Id, modelid) == 1;
		}

		/// <summary>
		/// Checks whether or not a ped model ID is valid for a player.
		/// </summary>
		/// <param name="player">The player ID for which to verify a model ID's validity.</param>
		/// <param name="modelid">The model ID to verify.</param>
		/// <returns>1 if the model is valid, 0 if it isn't.</returns>
		public static bool IsPedModelValidForPlayer(BasePlayer player, int modelid)
		{
			return UGMP.Internal.IsPedModelValidForPlayer(player.Id, modelid);
		}

		/// <summary>
		/// Checks if rubbish is visible for a certain player.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <returns>0: Rubbish will not be visible to this player.1: Rubbish will be visible to this player.</returns>
		public static bool IsRubbishVisibleForPlayer(BasePlayer player)
		{
			return UGMP.Internal.IsRubbishVisibleForPlayer(player.Id);
		}

		/// <summary>
		/// Checks if the GTA:SA sun position formula is enabled for a single player.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <returns>0: The GTA:III formula is used for this player.1: The GTA:SA formula is used for this player.</returns>
		public static bool IsSASunPositionFormulaEnabled(BasePlayer player)
		{
			return UGMP.Internal.IsSASunPositionFormulaEnabled(player.Id);
		}

		/// <summary>
		/// Checks whether or not a timed model ID is valid for a player.
		/// </summary>
		/// <param name="player">The player ID for which to verify a model ID's validity.</param>
		/// <param name="modelid">The model ID to verify.</param>
		/// <returns>1 if the model is valid, 0 if it isn't.</returns>
		public static bool IsTimeModelValidForPlayer(BasePlayer player, int modelid)
		{
			return UGMP.Internal.IsTimeModelValidForPlayer(player.Id, modelid);
		}

		/// <summary>
		/// Checks whether or not a vehicle model ID is valid for a player.
		/// </summary>
		/// <param name="player">The player ID for which to verify a model ID's validity.</param>
		/// <param name="modelid">The model ID to verify.</param>
		/// <returns>1 if the model is valid, 0 if it isn't.</returns>
		public static bool IsVehicleModelValidForPlayer(BasePlayer player, int modelid)
		{
			return UGMP.Internal.IsVehicleModelValidForPlayer(player.Id, modelid);
		}

		/// <summary>
		/// Sets the aircraft height limit for a single player. This makes it possible to fly much higher than you normally can in GTA: SA.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="heightLimit">The aircraft height limit which will be set for the player.</param>
		public static void SetAircraftHeightLimitForPlayer(BasePlayer player, float heightLimit)
		{
			UGMP.Internal.SetAircraftHeightLimitForPlayer(player.Id, heightLimit);
		}

		/// <summary>
		/// Sets the jetpack height limit for a single player. This makes it possible to fly much higher than you normally can in GTA: SA.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="heightLimit">The jetpack height limit which will be set for the player.</param>
		public static void SetJetpackHeightLimitForPlayer(BasePlayer player, float heightLimit)
		{
			UGMP.Internal.SetJetpackHeightLimitForPlayer(player.Id, heightLimit);
		}

		/// <summary>
		/// This native can be used to make a player fireproof. By default, all players receive fire damage.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable.</param>
		public static void SetPlayerFireProof(BasePlayer player, bool enable)
		{
			UGMP.Internal.SetPlayerFireProof(player.Id, enable);
		}

		/// <summary>
		/// Overrides the color of one or more HUD components for a specific player.
		/// </summary>
		/// <param name="player">The player.</param>
		public static void SetPlayerHUDComponentsColour(BasePlayer player)
		{
			UGMP.Internal.SetPlayerHUDComponentsColour(player.Id);
		}

		/// <summary>
		/// This native can be used to make sure a player does not fall off a bike, which may be very useful during cutscenes.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="knockState">The 'behavior type' which should be set for this player. This parameter can be one of the following values:BIKE_KNOCK_OFF_DEFAULT - The player can be knocked off a bike by crashing, or whatever. The difference between BIKE_KNOCK_OFF_ALWAYS and BIKE_KNOCK_OFF_DEFAULT is that with the default value used mission peds aren't knocked off their bike as often, but with BIKE_KNOCK_OFF_ALWAYS mission peds can be knocked off their bike just as easily as normal peds.BIKE_KNOCK_OFF_NEVER - Never allow a player to be knocked off a bike, even when crashing into a wall at full speed.BIKE_KNOCK_OFF_ALWAYS - See the description for BIKE_KNOCK_OFF_DEFAULT</param>
		public static void SetPlayerKnockedOffBikeState(BasePlayer player, int knockState)
		{
			UGMP.Internal.SetPlayerKnockedOffBikeState(player.Id, knockState);
		}

		/// <summary>
		/// Sets the current in-game season for a single player. The in-game weather in Bullworth will change to that of the selected season with the in-game clock enabled.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="season">Use one of the following types:SEASON_DONT_OVERRIDE - Disables the season override. The game will switch back to its UGMP.Internal season when used.SEASON_SUMMERSEASON_AUTUMNSEASON_WINTERSEASON_SPRING</param>
		public static void SetPlayerSeason(BasePlayer player, int season)
		{
			UGMP.Internal.SetPlayerSeason(player.Id, season);
		}

		/// <summary>
		/// Enables or disables the stock GTA:SA way of calculating the position of the sun in the sky for one connected player. This does not affect the distance from the player at which the sun is placed. If you disable the GTA:SA sun position formula, the game will switch to the GTA:III formula, which is used by all other 3D era games, including Bully. Useful if you want to make a cutscene at Salvatore's Gentlemans Club in the morning but with the sun behind the building.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable. Enabled for all players by default.</param>
		public static void ToggleSASunPositionFormula_Pl(BasePlayer player, bool enable)
		{
			UGMP.Internal.ToggleSASunPositionFormula_Pl(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the CCTV effect inmediately. This effect is never used in the original game.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable.</param>
		public static void TogglePlayerCCTV(BasePlayer player, bool enable)
		{
			UGMP.Internal.TogglePlayerCCTV(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the darkness filter effect inmediately. This effect is never used in the original game.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable.</param>
		/// <param name="darknessAlpha">Darkness effect transparency. This native expects a value between 0 and 255.</param>
		public static void TogglePlayerDarknessFilter(BasePlayer player, bool enable, int darknessAlpha)
		{
			UGMP.Internal.TogglePlayerDarknessFilter(player.Id, enable, darknessAlpha);
		}

		/// <summary>
		/// Enables or disables the big fluffy clouds which appear on GTA: III, GTA: VC, GTA: LCS, Bully, and GTA: VCS sunny weather types for a single player.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable. Enabled for all players by default.</param>
		public static void TogglePlayerFluffyClouds(BasePlayer player, bool enable)
		{
			UGMP.Internal.TogglePlayerFluffyClouds(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the fog effect inmediately. This effect is never used in the original game.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable.</param>
		public static void TogglePlayerFogOverlay(BasePlayer player, bool enable)
		{
			UGMP.Internal.TogglePlayerFogOverlay(player.Id, enable);
		}

		/// <summary>
		/// Makes procedural grass visible to a single player. The grass will move with the in-game wind, and is visible to all players by default.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to make procedural grass visible, and 0 to make grass invisible.</param>
		public static void TogglePlayerGrass(BasePlayer player, bool enable)
		{
			UGMP.Internal.TogglePlayerGrass(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables one or multiple HUD components for a specific player.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="hudComponent">A bitfield of all HUD components. This can be one of the following values:HUD_COMPONENT_AMMOHUD_COMPONENT_WEAPONICONHUD_COMPONENT_HEALTHHUD_COMPONENT_OXYGENHUD_COMPONENT_ARMOURHUD_COMPONENT_RADARHUD_COMPONENT_CROSSHAIRHUD_COMPONENT_MONEYHUD_COMPONENT_LASERDOT</param>
		public static void TogglePlayerHUDComponents(BasePlayer player, int hudComponent)
		{
			UGMP.Internal.TogglePlayerHUDComponents(player.Id, hudComponent);
		}

		/// <summary>
		/// Enables or disables infinite stamina for a single player. Infinite sprint is disabled for all players by default.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable.</param>
		public static void TogglePlayerInfiniteSprint(BasePlayer player, bool enable)
		{
			UGMP.Internal.TogglePlayerInfiniteSprint(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the infrared effect inmediately.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable.</param>
		public static void TogglePlayerInfraRed(BasePlayer player, bool enable)
		{
			UGMP.Internal.TogglePlayerInfraRed(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the long, thin clouds which appear on sunny weather types for a single player.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable. Enabled for all players by default.</param>
		public static void TogglePlayerLowClouds(BasePlayer player, bool enable)
		{
			UGMP.Internal.TogglePlayerLowClouds(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the in-game moon for a single player.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable. Enabled for all players by default.</param>
		public static void TogglePlayerMoon(BasePlayer player, bool enable)
		{
			UGMP.Internal.TogglePlayerMoon(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the night vision effect inmediately.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable.</param>
		public static void TogglePlayerNightVision(BasePlayer player, bool enable)
		{
			UGMP.Internal.TogglePlayerNightVision(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the in-game rainbows after a rainstorm for a single player.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable. Enabled for all players by default.</param>
		public static void TogglePlayerRainbow(BasePlayer player, bool enable)
		{
			UGMP.Internal.TogglePlayerRainbow(player.Id, enable);
		}

		/// <summary>
		/// Makes rubbish (e.g. the flying 'zombie elvis found' newspapers and leaves) (in)visible for a single player. Rubbish is visible by all players by default.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to make rubbish visible, and 0 to make rubbish invisible.</param>
		public static void TogglePlayerRubbish(BasePlayer player, bool enable)
		{
			UGMP.Internal.TogglePlayerRubbish(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the in-game stars for a single player at nighttime.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable. Enabled for all players by default.</param>
		public static void TogglePlayerStars(BasePlayer player, bool enable)
		{
			UGMP.Internal.TogglePlayerStars(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the sun for a single player.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable.</param>
		public static void TogglePlayerSun(BasePlayer player, bool enable)
		{
			UGMP.Internal.TogglePlayerSun(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the video camera effect inmediately. This effect is present in GTA: SA, but never used. It is used in GTA: VC as the camera overlay you see when entering/exiting the golf club or airport.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable.</param>
		public static void TogglePlayerVideoCameraOverlay(BasePlayer player, bool enable)
		{
			UGMP.Internal.TogglePlayerVideoCameraOverlay(player.Id, enable);
		}
	}
}
