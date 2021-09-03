using SampSharp.GameMode;
using SampSharp.GameMode.World;
using SampSharp.UndergroundMP;

[assembly: SampSharpExtension(typeof(UGMP))]
namespace SampSharp.UndergroundMP
{
	/// <summary>
	/// Underground Multiplayer wrapper class
	/// </summary>
    public partial class UGMP : Extension, IUGMP
    {
		/// <summary>
		/// The GameMode which uses this wrapper
		/// </summary>
        public BaseMode GameMode { get; private set; }

		/// <summary>
		/// This method loads the services (and natives) to the GameMode
		/// </summary>
		/// <param name="gameMode"></param>
        public override void LoadServices(BaseMode gameMode)
        {
            GameMode = gameMode;
            gameMode.Services.AddService<IUGMP>(this);

            base.LoadServices(gameMode);
        }

		#region Ped Natives
		/// <summary>
		/// Returns the total number of ped models.
		/// </summary>
		/// <returns>The number of ped models.</returns>
		public static int GetNumPedModels()
		{
			return Internal.GetNumPedModels();
		}

		/// <summary>
		/// Returns a random valid ped model ID using the internal ped info array.
		/// </summary>
		/// <returns>A random ped model ID from the internal ped info array.</returns>
		public static int GetRandomPedModel()
		{
			return Internal.GetRandomPedModel();
		}

		/// <summary>
		/// Returns the ped model ID at a specific index in the internal ped info array.
		/// </summary>
		/// <param name="index">An index in the internal ped info array.</param>
		/// <returns>The ped model ID found.</returns>
		public static int GetValidPedModelAt(int index)
		{
			return Internal.GetValidPedModelAt(index);
		}

		/// <summary>
		/// Checks whether or not the ped model ID is valid.
		/// </summary>
		/// <param name="modelid">The model ID.</param>
		/// <returns>1 if this ped model ID is valid, 0 otherwise.</returns>
		public static bool IsValidPedModel(int modelid)
		{
			return Internal.IsValidPedModel(modelid);
		}
		#endregion

		#region Radio Natives
		/// <summary>
		/// Enables or disables auto-tune.
		/// </summary>
		/// <param name="enable">1 to enable auto-tune, 0 to disable it.</param>
		public static void EnableRadioAutoTune(bool enable)
		{
			Internal.EnableRadioAutoTune(enable);
		}

		/// <summary>
		/// Gets the name of a radio station by its radio station ID.
		/// </summary>
		/// <param name="station">The radio station ID to get the name from. The values can be found inside ugmp_vehicles.inc.</param>
		/// <param name="str">An string into which to store the name, passed by reference.</param>
		/// <param name="len">Optional. The length of the name array.</param>
		public static void GetRadioStationName(int station, out string str, int len)
		{
			Internal.GetRadioStationName(station, out str, len);
		}

		/// <summary>
		/// Checks whether or not auto-tune is enabled.
		/// </summary>
		/// <returns>1 if auto-tune is enabled, 0. if it is disabled.</returns>
		public static bool IsRadioAutoTuneEnabled()
		{
			return Internal.IsRadioAutoTuneEnabled();
		}
		#endregion

		#region Weapon Natives
		/// <summary>
		/// Returns the total number of weapon models.
		/// </summary>
		/// <returns>The number of weapon models.</returns>
		public static int GetNumWeaponModels()
		{
			return Internal.GetNumWeaponModels();
		}

		/// <summary>
		/// Returns a random valid weapon model ID using the internal weapon info array.
		/// </summary>
		/// <returns>A random weapon model ID from the internal weapon info array.</returns>
		public static int GetRandomWeaponModel()
		{
			return Internal.GetRandomWeaponModel();
		}

		/// <summary>
		/// Returns a random valid weapon type using the internal weapon info array.
		/// </summary>
		/// <returns>A random weapon type from the internal weapon info array.</returns>
		public static int GetRandomWeaponType()
		{
			return Internal.GetRandomWeaponType();
		}

		/// <summary>
		/// Returns the weapon type at a specific index in the internal weapon info array.
		/// </summary>
		/// <param name="index">An index in the internal weapon info array.</param>
		/// <returns>The weapon type found.</returns>
		public static int GetValidWeaponTypeAt(int index)
		{
			return Internal.GetValidWeaponTypeAt(index);
		}

		/// <summary>
		/// Gets the highest parent weapon type of a weapon type.
		/// </summary>
		/// <param name="weapontype">The weapon type to obtain the highest parent type for.</param>
		/// <returns>The highest weapon parent type.</returns>
		public static int GetWeaponHighestParentType(int weapontype)
		{
			return Internal.GetWeaponHighestParentType(weapontype);
		}

		/// <summary>
		/// Checks whether or not the weapon type is valid (and can safely be granted to other players).
		/// </summary>
		/// <param name="weapontype">The weapon type to check against.</param>
		/// <returns>1 if this weapon type is valid, 0 otherwise.</returns>
		public static bool IsValidWeaponType(int weapontype)
		{
			return Internal.IsValidWeaponType(weapontype);
		}

		/// <summary>
		/// Checks whether or not the weapon model is valid.
		/// </summary>
		/// <param name="weaponmodel">The weapon model ID to check against.</param>
		/// <returns>1 if this weapon model ID is valid, 0 otherwise.</returns>
		public static bool IsValidWeaponModel(int weaponmodel)
		{
			return Internal.IsValidWeaponModel(weaponmodel);
		}

		/// <summary>
		/// Returns the weapon model ID at a specific index in the internal weapon info array.
		/// </summary>
		/// <param name="index">An index in the internal weapon info array.</param>
		/// <returns>The weapon model ID found.</returns>
		public static int GetValidWeaponModelAt(int index)
		{
			return Internal.GetValidWeaponModelAt(index);
		}
		#endregion

		#region Vehicle Natives
		/// <summary>
		/// Assigns an RGB vehicle color to a vehicle.
		/// </summary>
		/// <param name="vehicleid">The vehicle ID to assign RGB vehicle colors to.</param>
		/// <param name="color">The color "variant" to assign the RGB color to. This can be one of the following values:VEHICLE_COLOR_PRIMARYVEHICLE_COLOR_SECONDARYVEHICLE_COLOR_TERTIARYVEHICLE_COLOR_QUATERNARY</param>
		/// <param name="red">Self-explainatory.</param>
		/// <param name="green">Self-explainatory.</param>
		/// <param name="blue">Self-explainatory.</param>
		public static void ChangeVehicleColorRGB(int vehicleid, int color, int red, int green, int blue)
		{
			Internal.ChangeVehicleColorRGB(vehicleid, color, red, green, blue);
		}

		/// <summary>
		/// Changes the pearlescent color of a vehicle.
		/// </summary>
		/// <param name="vehicleid">The vehicle ID to assign pearlescent colors to.</param>
		/// <param name="color">The vehicle color ID.</param>
		public static void ChangeVehiclePearlColor(int vehicleid, int color)
		{
			Internal.ChangeVehiclePearlColor(vehicleid, color);
		}

		/// <summary>
		/// Changes the pearlescent color of a vehicle to an RGB color.
		/// </summary>
		/// <param name="vehicleid">The vehicle ID to assign pearlescent colors to.</param>
		/// <param name="red">Self-explainatory.</param>
		/// <param name="green">Self-explainatory.</param>
		/// <param name="blue">Self-explainatory.</param>
		public static void ChangeVehiclePearlColorRGB(int vehicleid, int red, int green, int blue)
		{
			Internal.ChangeVehiclePearlColorRGB(vehicleid, red, green, blue);
		}

		/// <summary>
		/// Returns the total number of vehicle models.
		/// </summary>
		/// <returns>The number of vehicle models.</returns>
		public static int GetNumVehicleModels()
		{
			return Internal.GetNumVehicleModels();
		}

		/// <summary>
		/// Returns a random valid vehicle model ID using the internal vehicle info array.
		/// </summary>
		/// <returns>A random vehicle model ID from the internal vehicle info array.</returns>
		public static int GetRandomVehicleModel()
		{
			return Internal.GetRandomVehicleModel();
		}

		/// <summary>
		/// Returns the vehicle model ID at a specific index in the internal vehicle info array.
		/// </summary>
		/// <param name="index">An index in the internal vehicle info array.</param>
		/// <returns>The vehicle model ID found.</returns>
		public static int GetValidVehicleModelAt(int index)
		{
			return Internal.GetValidVehicleModelAt(index);
		}

		/// <summary>
		/// Returns the vehicle model ID and some other info at a specific index in the internal vehicle info array.
		/// </summary>
		/// <param name="index">An index in the internal vehicle info array.</param>
		/// <param name="modelid">The vehicle model ID, passed by reference.</param>
		/// <param name="vehtype">The vehicle type, passed by reference.</param>
		/// <param name="modifyas">A type which describes how the vehicle can be modified as, passed by reference.</param>
		/// <param name="name">An string into which to store the name, passed by reference.</param>
		/// <param name="namelen">Optional. The length of the model name array.</param>
		public static void GetValidVehicleModelAtEx(int index, int modelid, int vehtype, int modifyas, string name, int namelen)
		{
			Internal.GetValidVehicleModelAtEx(index, modelid, vehtype, modifyas, name, namelen);
		}

		/// <summary>
		/// Extended variant of GetVehicleComponentType which returns the UG-MP component types for the front and rear bumpers (and the bullbars too).
		/// </summary>
		/// <param name="component">The vehicle component model ID to get the component type from. A list of them can be found here.</param>
		/// <returns>The component slot ID of the specified component or -1 if the component is invalid.</returns>
		public static int GetVehicleComponentTypeEx(int component)
		{
			return Internal.GetVehicleComponentTypeEx(component);
		}

		/// <summary>
		/// Gets the current radio station which is set for a specific vehicle.
		/// </summary>
		/// <param name="vehicleid">The vehicle ID.</param>
		/// <returns>A radio station ID. The values can be found inside ugmp_vehicles.inc.</returns>
		public static bool GetVehicleRadioStation(int vehicleid)
		{
			return Internal.GetVehicleRadioStation(vehicleid);
		}

		/// <summary>
		/// Checks whether or not the vehicle model ID is valid.
		/// </summary>
		/// <param name="modelid">The model ID.</param>
		/// <returns>1 if this vehicle model ID is valid, 0 otherwise.</returns>
		public static bool IsValidVehicleModel(int modelid)
		{
			return Internal.IsValidVehicleModel(modelid);
		}

		/// <summary>
		/// Changes the radio station for a specific vehicle.
		/// </summary>
		/// <param name="vehicleid">The vehicle ID which will have its radio station changed.</param>
		/// <param name="station">The new radio station ID. The values can be found inside ugmp_vehicles.inc.</param>
		public static void SetVehicleRadioStation(int vehicleid, int station)
		{
			Internal.SetVehicleRadioStation(vehicleid, station);
		}
		#endregion

		#region Weather Natives
		/// <summary>
		/// Removes an extra weather type for all players.
		/// </summary>
		/// <param name="extraweatherid">The extra weather ID which was obtained when calling CreateExtraWeather.</param>
		/// <returns>This function will return 1 if successful, or -1 if there is no extra weather ID with the specified type.</returns>
		public static int DestroyExtraWeather(int extraweatherid)
		{
			return Internal.DestroyExtraWeather(extraweatherid);
		}

		/// <summary>
		/// Sets the current in-game season for all connected players. The in-game weather in Bullworth will change to that of the selected season with the in-game clock enabled.
		/// </summary>
		/// <param name="season">Use one of the following types:SEASON_DONT_OVERRIDE - Disables the season override. The game will switch back to its internal season when used.SEASON_SUMMERSEASON_AUTUMNSEASON_WINTERSEASON_SPRING</param>
		public static void SetCurrentSeason(int season)
		{
			Internal.SetCurrentSeason(season);
		}

		/// <summary>
		/// Creates an additional weather type for all players.
		/// </summary>
		/// <param name="weatherHandlingType">This parameter tells the game to interpret the data you pass for this weather type as GTA: III weather data, for example. This means you can load timecyc.dat mods made for GTA: III, GTA: VC, Bully, and GTA: SA. See this page for a list of weather handling types.</param>
		/// <param name="weatherType">This parameter tells the game which 'type' of weather this is. See this page for a list of weather base types.</param>
		/// <param name="colourFilter">This parameter tells the game which postfx should be used. All 3d era games have their own postfx which uses the weather data you provide. If you want to use GTA: VCS postfx, you can set this parameter to COLOURFILTER_LEEDS and weatherHandlingType to WEATHER_HANDLING_GTAVCS. One important thing to note in this case is that GTA: VCS has two postfx effects (radiosity and blur) while GTA: LCS only uses blur. See this page for a list of colour filters.</param>
		/// <returns>The extra weather ID. If you wish to use this weather type, add 150 to the extra weather ID when calling SetWeather. If there are no free slots for a new weather type, this function will return -1.</returns>
		public static int CreateExtraWeather(int weatherHandlingType, int weatherType, int colourFilter)
		{
			return Internal.CreateExtraWeather(weatherHandlingType, weatherType, colourFilter);
		}

		/// <summary>
		/// Sets (or removes) flags for an extra weather type.
		/// </summary>
		/// <param name="extraweatherid">The extra weather ID which was obtained when calling CreateExtraWeather.</param>
		/// <param name="hour">The in-game hour for which this parameter will be used.</param>
		/// <param name="param">The extra weather flag bitfield. See this page for a list of weather type flags.</param>
		/// <param name="flags">Self-explainatory.</param>
		/// <returns>This function will return 1 if successful, or -1 if there is no extra weather ID with the specified type.</returns>
		public static int SetExtraWeatherParam_Flags(int extraweatherid, int hour, int param, int flags)
		{
			return Internal.SetExtraWeatherParam_Flags(extraweatherid, hour, param, flags);
		}

		/// <summary>
		/// Sets a float parameter for an extra weather type.
		/// </summary>
		/// <param name="extraweatherid">The extra weather ID which was obtained when calling CreateExtraWeather.</param>
		/// <param name="hour">The in-game hour for which this parameter will be used.</param>
		/// <param name="param">The extra weather float parameter to modify. See this page for a list of float weather params.</param>
		/// <param name="fParam">Self-explainatory.</param>
		/// <returns>This function will return 1 if successful, or -1 if there is no extra weather ID with the specified type.</returns>
		public static int SetExtraWeatherParam_Float(int extraweatherid, int hour, int param, float fParam)
		{
			return Internal.SetExtraWeatherParam_Float(extraweatherid, hour, param, fParam);
		}

		/// <summary>
		/// Sets an int parameter for an extra weather type.
		/// </summary>
		/// <param name="extraweatherid">The extra weather ID which was obtained when calling CreateExtraWeather.</param>
		/// <param name="hour">The in-game hour for which this parameter will be used.</param>
		/// <param name="param">The extra weather int parameter to modify. See this page for a list of integer weather params.</param>
		/// <param name="nParam">Self-explainatory.</param>
		/// <returns>This function will return 1 if successful, or -1 if there is no extra weather ID with the specified type.</returns>
		public static int SetExtraWeatherParam_Int(int extraweatherid, int hour, int param, int nParam)
		{
			return Internal.SetExtraWeatherParam_Int(extraweatherid, hour, param, nParam);
		}

		/// <summary>
		/// Sets an RGB parameter for an extra weather type.
		/// </summary>
		/// <param name="extraweatherid">The extra weather ID which was obtained when calling CreateExtraWeather.</param>
		/// <param name="hour">The in-game hour for which this parameter will be used.</param>
		/// <param name="param">The extra weather RGB parameter to modify. See this page for a list of RGB weather params.</param>
		/// <param name="r">Self-explainatory.</param>
		/// <param name="g">Self-explainatory.</param>
		/// <param name="b">Self-explainatory.</param>
		/// <returns>This function will return 1 if successful, or -1 if there is no extra weather ID with the specified type.</returns>
		public static int SetExtraWeatherParam_RGB(int extraweatherid, int hour, int param, int r, int g, int b)
		{
			return Internal.SetExtraWeatherParam_RGB(extraweatherid, hour, param, r, g, b);
		}

		/// <summary>
		/// Sets an RGBA parameter for an extra weather type.
		/// </summary>
		/// <param name="extraweatherid">The extra weather ID which was obtained when calling CreateExtraWeather.</param>
		/// <param name="hour">The in-game hour for which this parameter will be used.</param>
		/// <param name="param">The extra weather RGBA parameter to modify. See this page for a list of RGBA weather params.</param>
		/// <param name="r">Self-explainatory.</param>
		/// <param name="g">Self-explainatory.</param>
		/// <param name="b">Self-explainatory.</param>
		/// <param name="a">Self-explainatory.</param>
		/// <returns>This function will return 1 if successful, or -1 if there is no extra weather ID with the specified type.</returns>
		public static int SetExtraWeatherParam_RGBA(int extraweatherid, int hour, int param, float r, float g, float b, float a)
		{
			return Internal.SetExtraWeatherParam_RGBA(extraweatherid, hour, param, r, g, b, a);
		}

		/// <summary>
		/// Sets the windyness for an extra weather type.
		/// </summary>
		/// <param name="extraweatherid">The extra weather ID which was obtained when calling CreateExtraWeather.</param>
		/// <param name="windyness">The windyness for this weather type. The in-game wind will affect procedural vegetation, tree branch movement, wave height, how the Chinatown banners move, and a lot more. The value really knows no limit. 0.0 means no wind, while 2.0 is used for hurricane weather types. In singleplayer, this column is defined in weather.dat.</param>
		/// <returns>This function will return 1 if successful, or -1 if there is no extra weather ID with the specified type.</returns>
		public static int SetExtraWeatherParam_Windyness(int extraweatherid, float windyness)
		{
			return Internal.SetExtraWeatherParam_Windyness(extraweatherid, windyness);
		}
		#endregion

		#region Togglers
		/// <summary>
		/// Enables or disables the big fluffy clouds which appear on GTA: III, GTA: VC, GTA: LCS, Bully, and GTA: VCS sunny weather types for all connected players.
		/// </summary>
		/// <param name="enable">1 to enable, and 0 to disable. Enabled for all players by default.</param>
		public static void ToggleFluffyClouds(bool enable)
		{
			Internal.ToggleFluffyClouds(enable);
		}

		/// <summary>
		/// Enables or disables the long, thin clouds which appear on sunny weather types for all connected players.
		/// </summary>
		/// <param name="enable">1 to enable, and 0 to disable. Enabled for all players by default.</param>
		public static void ToggleLowClouds(bool enable)
		{
			Internal.ToggleLowClouds(enable);
		}

		/// <summary>
		/// Enables or disables the in-game moon for all connected players.
		/// </summary>
		/// <param name="enable">1 to enable, and 0 to disable. Enabled for all players by default.</param>
		public static void ToggleMoon(bool enable)
		{
			Internal.ToggleMoon(enable);
		}

		/// <summary>
		/// Enables or disables the in-game rainbows after a rainstorm for all connected players.
		/// </summary>
		/// <param name="enable">1 to enable, and 0 to disable. Enabled for all players by default.</param>
		public static void ToggleRainbow(bool enable)
		{
			Internal.ToggleRainbow(enable);
		}

		/// <summary>
		/// Enables or disables the stock GTA:SA way of calculating the position of the sun in the sky for all connected players. This does not affect the distance from the player at which the sun is placed. If you disable the GTA:SA sun position formula, the game will switch to the GTA:III formula, which is used by all other 3D era games, including Bully. Useful if you want to make a cutscene at Salvatore's Gentlemans Club in the morning but with the sun behind the building.
		/// </summary>
		/// <param name="enable">1 to enable, and 0 to disable. Enabled for all players by default.</param>
		public static void ToggleSASunPositionFormula(bool enable)
		{
			Internal.ToggleSASunPositionFormula(enable);
		}

		/// <summary>
		/// Enables or disables the in-game stars for all connected players at nighttime.
		/// </summary>
		/// <param name="enable">1 to enable, and 0 to disable. Enabled for all players by default.</param>
		public static void ToggleStars(bool enable)
		{
			Internal.ToggleStars(enable);
		}

		/// <summary>
		/// Assigns an RGB vehicle color to a vehicle.
		/// </summary>
		/// <param name="vehicleid">The vehicle ID to assign RGB vehicle colors to.</param>
		/// <param name="color">The color "variant" to enable/disable RGB colors on. This can be one of the following values:VEHICLE_COLOR_PRIMARYVEHICLE_COLOR_SECONDARYVEHICLE_COLOR_TERTIARYVEHICLE_COLOR_QUATERNARY</param>
		/// <param name="enable">1 to enable RGB colors, 0 to disable them.</param>
		public static void ToggleVehicleColorRGB(int vehicleid, int color, bool enable)
		{
			Internal.ToggleVehicleColorRGB(vehicleid, color, enable);
		}
		#endregion

		#region Player Natives
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
			Internal.ChangePlayerPedColor(player.Id, color1, color2, color3, color4);
		}

		/// <summary>
		/// Gets the aircraft height limit for a single player.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <returns>The aircraft height limit set for this player.</returns>
		public static float GetPlayerAircraftHeightLimit(BasePlayer player)
		{
			return Internal.GetPlayerAircraftHeightLimit(player.Id);
		}

		/// <summary>
		/// Gets the jetpack height limit for a single player.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <returns>The jetpack height limit set for this player.</returns>
		public static float GetPlayerJetpackHeightLimit(BasePlayer player)
		{
			return Internal.GetPlayerJetpackHeightLimit(player.Id);
		}

		/// <summary>
		/// Retrieves the model ID for a server-side model by it's model name.
		/// </summary>
		/// <param name="player">The player which to get the model ID for.</param>
		/// <param name="modelname">The model name to get the model ID for.</param>
		/// <returns>The model ID for the specified model name and player. INVALID_MODEL if it cannot be retrieved.</returns>
		public static int GetPlayerNetModelID(BasePlayer player, string modelname)
		{
			return Internal.GetPlayerNetModelID(player.Id, modelname);
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
			Internal.GetPlayerPedColor(player.Id, out color1, out color2, out color3, out color4);
		}
		
		/// <summary>
		/// Checks whether or not an animated clump model ID is valid for a player.
		/// </summary>
		/// <param name="player">The player ID for which to verify a model ID's validity.</param>
		/// <param name="modelid">The model ID to verify.</param>
		/// <returns>1 if the model is valid, 0 if it isn't.</returns>
		public static bool IsAClmpNetModelValidForPlayer(BasePlayer player, int modelid)
		{
			return Internal.IsAClmpNetModelValidForPlayer(player.Id, modelid);	
		}

		/// <summary>
		/// Checks whether or not an atomic model ID is valid for a player.
		/// </summary>
		/// <param name="player">The player ID for which to verify a model ID's validity.</param>
		/// <param name="modelid">The model ID to verify.</param>
		/// <returns>1 if the model is valid, 0 if it isn't.</returns>
		public static bool IsAtmModelValidForPlayer(BasePlayer player, int modelid)
		{
			return Internal.IsAtmModelValidForPlayer(player.Id, modelid) == 1;
		}
		
		/// <summary>
		/// Checks whether or not a ped model ID is valid for a player.
		/// </summary>
		/// <param name="player">The player ID for which to verify a model ID's validity.</param>
		/// <param name="modelid">The model ID to verify.</param>
		/// <returns>1 if the model is valid, 0 if it isn't.</returns>
		public static bool IsPedModelValidForPlayer(BasePlayer player, int modelid)
		{
			return Internal.IsPedModelValidForPlayer(player.Id, modelid);
		}
		
		/// <summary>
		/// Checks if rubbish is visible for a certain player.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <returns>0: Rubbish will not be visible to this player.1: Rubbish will be visible to this player.</returns>
		public static bool IsRubbishVisibleForPlayer(BasePlayer player)
		{
			return Internal.IsRubbishVisibleForPlayer(player.Id);
		}

		/// <summary>
		/// Checks if the GTA:SA sun position formula is enabled for a single player.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <returns>0: The GTA:III formula is used for this player.1: The GTA:SA formula is used for this player.</returns>
		public static bool IsSASunPositionFormulaEnabled(BasePlayer player)
		{
			return Internal.IsSASunPositionFormulaEnabled(player.Id);
		}

		/// <summary>
		/// Checks whether or not a timed model ID is valid for a player.
		/// </summary>
		/// <param name="player">The player ID for which to verify a model ID's validity.</param>
		/// <param name="modelid">The model ID to verify.</param>
		/// <returns>1 if the model is valid, 0 if it isn't.</returns>
		public static bool IsTimeModelValidForPlayer(BasePlayer player, int modelid)
		{
			return Internal.IsTimeModelValidForPlayer(player.Id, modelid);
		}

		/// <summary>
		/// Checks whether or not a vehicle model ID is valid for a player.
		/// </summary>
		/// <param name="player">The player ID for which to verify a model ID's validity.</param>
		/// <param name="modelid">The model ID to verify.</param>
		/// <returns>1 if the model is valid, 0 if it isn't.</returns>
		public static bool IsVehicleModelValidForPlayer(BasePlayer player, int modelid)
		{
			return Internal.IsVehicleModelValidForPlayer(player.Id, modelid);
		}

		/// <summary>
		/// Sets the aircraft height limit for a single player. This makes it possible to fly much higher than you normally can in GTA: SA.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="heightLimit">The aircraft height limit which will be set for the player.</param>
		public static void SetAircraftHeightLimitForPlayer(BasePlayer player, float heightLimit)
		{
			Internal.SetAircraftHeightLimitForPlayer(player.Id, heightLimit);
		}

		/// <summary>
		/// Sets the jetpack height limit for a single player. This makes it possible to fly much higher than you normally can in GTA: SA.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="heightLimit">The jetpack height limit which will be set for the player.</param>
		public static void SetJetpackHeightLimitForPlayer(BasePlayer player, float heightLimit)
		{
			Internal.SetJetpackHeightLimitForPlayer(player.Id, heightLimit);
		}

		/// <summary>
		/// This native can be used to make a player fireproof. By default, all players receive fire damage.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable.</param>
		public static void SetPlayerFireProof(BasePlayer player, bool enable)
		{
			Internal.SetPlayerFireProof(player.Id, enable);
		}

		/// <summary>
		/// Overrides the color of one or more HUD components for a specific player.
		/// </summary>
		/// <param name="player">The player.</param>
		public static void SetPlayerHUDComponentsColour(BasePlayer player)
		{
			Internal.SetPlayerHUDComponentsColour(player.Id);
		}

		/// <summary>
		/// This native can be used to make sure a player does not fall off a bike, which may be very useful during cutscenes.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="knockState">The 'behavior type' which should be set for this player. This parameter can be one of the following values:BIKE_KNOCK_OFF_DEFAULT - The player can be knocked off a bike by crashing, or whatever. The difference between BIKE_KNOCK_OFF_ALWAYS and BIKE_KNOCK_OFF_DEFAULT is that with the default value used mission peds aren't knocked off their bike as often, but with BIKE_KNOCK_OFF_ALWAYS mission peds can be knocked off their bike just as easily as normal peds.BIKE_KNOCK_OFF_NEVER - Never allow a player to be knocked off a bike, even when crashing into a wall at full speed.BIKE_KNOCK_OFF_ALWAYS - See the description for BIKE_KNOCK_OFF_DEFAULT</param>
		public static void SetPlayerKnockedOffBikeState(BasePlayer player, int knockState)
		{
			Internal.SetPlayerKnockedOffBikeState(player.Id, knockState);
		}

		/// <summary>
		/// Sets the current in-game season for a single player. The in-game weather in Bullworth will change to that of the selected season with the in-game clock enabled.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="season">Use one of the following types:SEASON_DONT_OVERRIDE - Disables the season override. The game will switch back to its internal season when used.SEASON_SUMMERSEASON_AUTUMNSEASON_WINTERSEASON_SPRING</param>
		public static void SetPlayerSeason(BasePlayer player, int season)
		{
			Internal.SetPlayerSeason(player.Id, season);
		}

		/// <summary>
		/// Enables or disables the stock GTA:SA way of calculating the position of the sun in the sky for one connected player. This does not affect the distance from the player at which the sun is placed. If you disable the GTA:SA sun position formula, the game will switch to the GTA:III formula, which is used by all other 3D era games, including Bully. Useful if you want to make a cutscene at Salvatore's Gentlemans Club in the morning but with the sun behind the building.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable. Enabled for all players by default.</param>
		public static void ToggleSASunPositionFormula_Pl(BasePlayer player, bool enable)
		{
			Internal.ToggleSASunPositionFormula_Pl(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the CCTV effect inmediately. This effect is never used in the original game.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable.</param>
		public static void TogglePlayerCCTV(BasePlayer player, bool enable)
		{
			Internal.TogglePlayerCCTV(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the darkness filter effect inmediately. This effect is never used in the original game.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable.</param>
		/// <param name="darknessAlpha">Darkness effect transparency. This native expects a value between 0 and 255.</param>
		public static void TogglePlayerDarknessFilter(BasePlayer player, bool enable, int darknessAlpha)
		{
			Internal.TogglePlayerDarknessFilter(player.Id, enable, darknessAlpha);
		}

		/// <summary>
		/// Enables or disables the big fluffy clouds which appear on GTA: III, GTA: VC, GTA: LCS, Bully, and GTA: VCS sunny weather types for a single player.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable. Enabled for all players by default.</param>
		public static void TogglePlayerFluffyClouds(BasePlayer player, bool enable)
		{
			Internal.TogglePlayerFluffyClouds(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the fog effect inmediately. This effect is never used in the original game.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable.</param>
		public static void TogglePlayerFogOverlay(BasePlayer player, bool enable)
		{
			Internal.TogglePlayerFogOverlay(player.Id, enable);
		}

		/// <summary>
		/// Makes procedural grass visible to a single player. The grass will move with the in-game wind, and is visible to all players by default.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to make procedural grass visible, and 0 to make grass invisible.</param>
		public static void TogglePlayerGrass(BasePlayer player, bool enable)
		{
			Internal.TogglePlayerGrass(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables one or multiple HUD components for a specific player.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="hudComponent">A bitfield of all HUD components. This can be one of the following values:HUD_COMPONENT_AMMOHUD_COMPONENT_WEAPONICONHUD_COMPONENT_HEALTHHUD_COMPONENT_OXYGENHUD_COMPONENT_ARMOURHUD_COMPONENT_RADARHUD_COMPONENT_CROSSHAIRHUD_COMPONENT_MONEYHUD_COMPONENT_LASERDOT</param>
		public static void TogglePlayerHUDComponents(BasePlayer player, int hudComponent)
		{
			Internal.TogglePlayerHUDComponents(player.Id, hudComponent);
		}

		/// <summary>
		/// Enables or disables infinite stamina for a single player. Infinite sprint is disabled for all players by default.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable.</param>
		public static void TogglePlayerInfiniteSprint(BasePlayer player, bool enable)
		{
			Internal.TogglePlayerInfiniteSprint(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the infrared effect inmediately.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable.</param>
		public static void TogglePlayerInfraRed(BasePlayer player, bool enable)
		{
			Internal.TogglePlayerInfraRed(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the long, thin clouds which appear on sunny weather types for a single player.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable. Enabled for all players by default.</param>
		public static void TogglePlayerLowClouds(BasePlayer player, bool enable)
		{
			Internal.TogglePlayerLowClouds(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the in-game moon for a single player.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable. Enabled for all players by default.</param>
		public static void TogglePlayerMoon(BasePlayer player, bool enable)
		{
			Internal.TogglePlayerMoon(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the night vision effect inmediately.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable.</param>
		public static void TogglePlayerNightVision(BasePlayer player, bool enable)
		{
			Internal.TogglePlayerNightVision(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the in-game rainbows after a rainstorm for a single player.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable. Enabled for all players by default.</param>
		public static void TogglePlayerRainbow(BasePlayer player, bool enable)
		{
			Internal.TogglePlayerRainbow(player.Id, enable);
		}

		/// <summary>
		/// Makes rubbish (e.g. the flying 'zombie elvis found' newspapers and leaves) (in)visible for a single player. Rubbish is visible by all players by default.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to make rubbish visible, and 0 to make rubbish invisible.</param>
		public static void TogglePlayerRubbish(BasePlayer player, bool enable)
		{
			Internal.TogglePlayerRubbish(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the in-game stars for a single player at nighttime.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable. Enabled for all players by default.</param>
		public static void TogglePlayerStars(BasePlayer player, bool enable)
		{
			Internal.TogglePlayerStars(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the sun for a single player.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable.</param>
		public static void TogglePlayerSun(BasePlayer player, bool enable)
		{
			Internal.TogglePlayerSun(player.Id, enable);
		}

		/// <summary>
		/// Enables or disables the video camera effect inmediately. This effect is present in GTA: SA, but never used. It is used in GTA: VC as the camera overlay you see when entering/exiting the golf club or airport.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <param name="enable">1 to enable, and 0 to disable.</param>
		public static void TogglePlayerVideoCameraOverlay(BasePlayer player, bool enable)
		{
			Internal.TogglePlayerVideoCameraOverlay(player.Id, enable);
		}
		#endregion

		#region Discord Rich Presence
		/// <summary>
		/// Initialises Discord Rich Presence.
		/// </summary>
		/// <param name="applicationID">The Discord application ID to use.</param>
		public static void InitialiseDiscordRichPresence(string applicationID)
		{
			Internal.InitialiseDiscordRichPresence(applicationID);
		}

		/// <summary>
		/// Updates Discord Rich Presence parameters.
		/// </summary>
		/// <param name="smallImageKey">The small image key to use.</param>
		/// <param name="smallImageText">The small image text to use.</param>
		/// <param name="largeImageKey">The large image key to use.</param>
		/// <param name="largeImageText">The large image text to use.</param>
		/// <param name="details">The 'details' parameter to use.</param>
		public static void UpdateDiscordRichPresence(string smallImageKey, string smallImageText, string largeImageKey, string largeImageText, string details)
		{
			Internal.UpdateDiscordRichPresence(smallImageKey, smallImageText, largeImageKey, largeImageText, details);
		}

		/// <summary>
		/// Shuts down Discord Rich Presence. Doing so will make the game use default UG-MP Discord Rich Presence parameters.
		/// </summary>
		public static void ShutdownDiscordRichPresence()
		{
			Internal.ShutdownDiscordRichPresence();
		}
		#endregion

		#region Other Natives
		/// <summary>
		/// Adds an animated clump model for all players. The parameters of this native correspond with raw IDE:anim entries.
		/// </summary>
		/// <param name="modelid">The model ID. Use ALLOCATE_DYNAMICALLY if you want it to be dynamically allocated.</param>
		/// <param name="modelname">The model name.</param>
		/// <param name="txdname">The name of the TXD to use.</param>
		/// <param name="animblock">The name of the animation block to use.</param>
		/// <param name="drawdistance">The draw distance this model uses. Anything above 300.0 will make the game treat this model as a big building, and it will no longer have collision.</param>
		/// <param name="modelflags">The model flags to use. This is a bitfield.</param>
		public static void AddAnimatedClumpModel(int modelid, string modelname, string txdname, string animblock, float drawdistance, int modelflags)
		{
			Internal.AddAnimatedClumpModel(modelid, modelname, txdname, animblock, drawdistance, modelflags);
		}

		/// <summary>
		/// Adds a normal model for all players. The parameters of this native correspond with raw IDE:objs entries.
		/// </summary>
		/// <param name="modelid">The model ID. Use ALLOCATE_DYNAMICALLY if you want it to be dynamically allocated.</param>
		/// <param name="modelname">The model name.</param>
		/// <param name="txdname">The name of the TXD to use.</param>
		/// <param name="drawdistance">The draw distance this model uses. Anything above 300.0 will make the game treat this model as a big building, and it will no longer have collision.</param>
		/// <param name="modelflags">The model flags to use. This is a bitfield.</param>
		public static void AddAtomicModel(int modelid, string modelname, string txdname, float drawdistance, int modelflags)
		{
			Internal.AddAtomicModel(modelid, modelname, txdname, drawdistance, modelflags);
		}

		/// <summary>
		/// Adds a cdimage (IMG file) which will be loaded by players once they join.
		/// </summary>
		/// <param name="filename">The path to the IMG file, relative to the assets folder.</param>
		public static void AddCdImage(string filename)
		{
			Internal.AddCdImage(filename);
		}

		/// <summary>
		/// Adds a data file which will be loaded by players once they join. This native allows you to specify a custom vehicle audio settings file, or a carcols.dat file, for example.
		/// </summary>
		/// <param name="filename">The path to the data file, relative to the assets folder.</param>
		/// <param name="file type">The type of file this is. See this page for a list of possible file types.</param>
		public static void AddDataFile(string filename, int filetype)
		{
			Internal.AddDataFile(filename, filetype);
		}

		/// <summary>
		/// Adds an item definition (IDE) file which will be loaded by players once they join.
		/// </summary>
		/// <param name="filename">The path to the IDE file, relative to the assets folder.</param>
		public static void AddIDE(string filename)
		{
			Internal.AddIDE(filename);
		}

		/// <summary>
		/// Adds an item placement (IPL) file which will be loaded by players once they join.
		/// </summary>
		/// <param name="filename">The path to the IPL file, relative to the assets folder.</param>
		/// <param name="fOffsetX">The offset X coordinate to apply to all entries in the file. Very useful if you want to load in maps and place them outside of San Andreas.</param>
		/// <param name="fOffsetY">The offset Y coordinate to apply to all entries in the file. Very useful if you want to load in maps and place them outside of San Andreas.</param>
		/// <param name="fOffsetZ">The offset Z coordinate to apply to all entries in the file. Very useful if you want to load in maps and place them outside of San Andreas.</param>
		public static void AddIPL(string filename, float fOffsetX, float fOffsetY, float fOffsetZ)
		{
			Internal.AddIPL(filename, fOffsetX, fOffsetY, fOffsetZ);
		}

		/// <summary>
		/// Adds a ped model for all players. The parameters of this native correspond with raw IDE:peds entries.
		/// </summary>
		/// <param name="modelid">The model ID.</param>
		/// <param name="modelname">The model name.</param>
		/// <param name="txdname">The name of the TXD to use.</param>
		/// <param name="pedstatname">The ped stat name to use.</param>
		/// <param name="pedtype">The ped type. Certain types have different behavior on singleplayer.</param>
		/// <param name="animgrpname">The anim group to use for this ped. This can be used to give the ped a custom walking style, for example.</param>
		/// <param name="animfilename">The anim file to use for this ped. This can be used to give the ped a custom walking style, for example.</param>
		/// <param name="carmask">The "cars can drive..." mask. See the notes for more info.</param>
		/// <param name="flags">The ped flags. See the notes for more info.</param>
		/// <param name="radio1">The primary preferred radio to use. See the notes for more info.</param>
		/// <param name="radio2">The secondary preferred radio to use. See the notes for more info.</param>
		public static void AddPedModel(int modelid, string modelname, string txdname, string pedstatname, int pedtype, string animgrpname, string animfilename, int carmask, int flags, int radio1, int radio2)
		{
			Internal.AddPedModel(modelid, modelname, txdname, pedstatname, pedtype, animgrpname, animfilename, carmask, flags, radio1, radio2);
		}

		/// <summary>
		/// Adds a timed model for all players. The parameters of this native correspond with raw IDE:tobj entries.
		/// </summary>
		/// <param name="modelid">The model ID. Use ALLOCATE_DYNAMICALLY if you want it to be dynamically allocated.</param>
		/// <param name="modelname">The model name.</param>
		/// <param name="txdname">The name of the TXD to use.</param>
		/// <param name="drawdistance">The draw distance this model uses. Anything above 300.0 will make the game treat this model as a big building, and it will no longer have collision.</param>
		/// <param name="modelflags">The model flags to use. This is a bitfield.</param>
		/// <param name="timeon">The time at which this model will become visible.</param>
		/// <param name="timeoff">The time at which this model will disappear.</param>
		public static void AddTimeModel(int modelid, string modelname, string txdname, float drawdistance, int modelflags, int timeon, int timeoff)
		{
			Internal.AddTimeModel(modelid, modelname, txdname, drawdistance, modelflags, timeon, timeoff);
		}

		/// <summary>
		/// Adds a vehicle model for all players. The parameters of this native correspond with raw IDE:cars entries.
		/// </summary>
		/// <param name="modelid">The model ID.</param>
		/// <param name="modelname">The model name.</param>
		/// <param name="txdname">The name of the TXD to use.</param>
		/// <param name="vehicletype">The vehicle type.</param>
		/// <param name="handlingname">The name of the handling line.</param>
		/// <param name="gamename">The GXT key which corresponds with the name of the vehicle.</param>
		/// <param name="animblockname">The animation block to use for this vehicle.</param>
		/// <param name="vehicleclass">The vehicle class to use for this vehicle. This is used a lot under-the-hood as a means to better categorize vehicles.</param>
		/// <param name="freq">The spawn frequency for this vehicle. This parameter only applies for NPC traffic, and thus isn't relevant on UG-MP. The value must be between 0 and 10.</param>
		/// <param name="flags">The vehicle model flags to use.</param>
		/// <param name="comprules">The rules which vehicle components (as-in extras must adhere to.</param>
		/// <param name="wheelmodelid">The wheel model to use for this vehicle. This value used here is NOT a model ID!</param>
		/// <param name="wheelscalefront">The scale of the front wheels. 1.0 is the standard wheel size; use values higher or lower than 1.0 to set the front wheel sizes.</param>
		/// <param name="wheelscalerear">The scale of the rear wheels. 1.0 is the standard wheel size; use values higher or lower than 1.0 to set the rear wheel sizes.</param>
		/// <param name="wheelupgradeclass">Optional. The wheel upgrade class used by this vehicle.</param>
		public static void AddVehicleModel(int modelid, string modelname, string txdname, int vehicletype, string handlingname, string gamename, string animblockname, int vehicleclass, int freq, int flags, int comprules, int wheelmodelid, float wheelscalefront, float wheelscalerear, int wheelupgradeclass)
		{
			Internal.AddVehicleModel(modelid, modelname, txdname, vehicletype, handlingname, gamename, animblockname, vehicleclass, freq, flags, comprules, wheelmodelid, wheelscalefront, wheelscalerear, wheelupgradeclass);
		}

		/// <summary>
		/// Applies the offset coordinates of an in-game map area to the input coords. This is useful if you want to ensure that your positions are always relative to the center of a map area (such as Vice City). If we ever decided to move maps around, updating your coords should no longer be necessary.
		/// </summary>
		/// <param name="type">The map offset type applied to the input coordinates. This can be one of the following values:MAPOFFSET_MIAMI - As of Snapshot 3.4, this will apply an offset of 7500.0, -7500.0, -5.0 to the input coordinates.MAPOFFSET_NEWYORK - As of Snapshot 3.4, this will apply an offset of 8250.0 8250.0 0.0 to the input coordinates.MAPOFFSET_NEWENGLAND - As of Snapshot 3.4, this will apply an offset of 8250.0 14250.0 0.0 to the input coordinates.</param>
		/// <param name="x_coor">The input X coordinate, passed as reference.</param>
		/// <param name="y_coor">The input Y coordinate, passed as reference.</param>
		/// <param name="z_coor">The input Z coordinate, passed as reference.</param>
		public static void ApplyMapOffsetToCoords(int type, float x_coor, float y_coor, float z_coor)
		{
			Internal.ApplyMapOffsetToCoords(type, x_coor, y_coor, z_coor);
		}

		/// <summary>
		/// Checks whether or not an animation name & animation library pair refers to a valid animation.
		/// </summary>
		/// <param name="animlib">The name of the animation library.</param>
		/// <param name="animname">The name of the animation.</param>
		public static void IsValidAnimationAndLibrary(string animlib, string animname)
		{
			Internal.IsValidAnimationAndLibrary(animlib, animname);
		}

		/// <summary>
		/// Returns a random number between a and b using a mersenne twister.
		/// </summary>
		/// <param name="a">The start of the range.</param>
		/// <param name="b">The end of the range.</param>
		/// <returns>A random value between a and b.</returns>
		public static int MT19937_Random(int a, int b)
		{
			return Internal.MT19937_Random(a, b);
		}

		/// <summary>
		/// Tells the client to use a different server which hosts the files. Players will download files from the hostname provided here instead of the default file server provided with UG-MP.
		/// </summary>
		/// <param name="hostname">The hostname of the server which hosts the DL assets.</param>
		public static void RedirectDownloadsTo(string hostname)
		{
			Internal.RedirectDownloadsTo(hostname);
		}
		#endregion
	}
}