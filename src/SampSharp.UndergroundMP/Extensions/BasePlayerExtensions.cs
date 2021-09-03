using SampSharp.GameMode.World;

namespace SampSharp.UndergroundMP.Extensions
{
    public static class BasePlayerExtensions
    {
        public static float GetAircraftHeightLimit(this BasePlayer player)
        {
            return UGMP.Internal.GetPlayerAircraftHeightLimit(player.Id);
        }

        public static float GetJetpackHeightLimit(this BasePlayer player)
        {
            return UGMP.Internal.GetPlayerJetpackHeightLimit(player.Id);
        }

        public static void SetHUDComponentsColour(this BasePlayer player)
        {
            UGMP.Internal.SetPlayerHUDComponentsColour(player.Id);
        }

        public static void ChangePedColor(this BasePlayer player, int color1, int color2, int color3, int color4)
        {
            UGMP.Internal.ChangePlayerPedColor(player.Id, color1, color2, color3, color4);
        }

        public static void GetPedColor(this BasePlayer player, out int color1, out int color2, out int color3, out int color4)
        {
            UGMP.Internal.GetPlayerPedColor(player.Id, out color1, out color2, out color3, out color4);
        }

        public static bool IsRubbishVisible(this BasePlayer player)
        {
            return UGMP.Internal.IsRubbishVisibleForPlayer(player.Id);
        }

        public static void SetFireProof(this BasePlayer player, bool enable)
        {
            UGMP.Internal.SetPlayerFireProof(player.Id, enable);
        }

        public static void SetKnockedOffBikeState(this BasePlayer player, int knockState)
        {
            UGMP.Internal.SetPlayerKnockedOffBikeState(player.Id, knockState);
        }

        public static void SetJetpackHeightLimit(this BasePlayer player, float heightLimit)
        {
            UGMP.Internal.SetJetpackHeightLimitForPlayer(player.Id, heightLimit);
        }

        public static void SetAircraftHeightLimit(this BasePlayer player, float heightLimit)
        {
            UGMP.Internal.SetAircraftHeightLimitForPlayer(player.Id, heightLimit);
        }

        public static void ToggleSun(this BasePlayer player, bool enable)
        {
            UGMP.Internal.TogglePlayerSun(player.Id, enable);
        }

        public static void ToggleCCTV(this BasePlayer player, bool enable)
        {
            UGMP.Internal.TogglePlayerCCTV(player.Id, enable);
        }

        public static void ToggleDarknessFilter(this BasePlayer player, bool enable, int darknessAlpha)
        {
            UGMP.Internal.TogglePlayerDarknessFilter(player.Id, enable, darknessAlpha);
        }

        public static void ToggleFluffyClouds(this BasePlayer player, bool enable)
        {
            UGMP.Internal.TogglePlayerFluffyClouds(player.Id, enable);
        }

        public static void ToggleFogOverlay(this BasePlayer player, bool enable)
        {
            UGMP.Internal.TogglePlayerFogOverlay(player.Id, enable);
        }

        public static void ToggleGrass(this BasePlayer player, bool enable)
        {
            UGMP.Internal.TogglePlayerGrass(player.Id, enable);
        }

        public static void ToggleHUDComponents(this BasePlayer player, int hudComponent)
        {
            UGMP.Internal.TogglePlayerHUDComponents(player.Id, hudComponent);
        }

        public static void ToggleInfiniteSprint(this BasePlayer player, bool enable)
        {
            UGMP.Internal.TogglePlayerInfiniteSprint(player.Id, enable);
        }

        public static void ToggleInfraRed(this BasePlayer player, bool enable)
        {
            UGMP.Internal.TogglePlayerInfraRed(player.Id, enable);
        }

        public static void ToggleLowClouds(this BasePlayer player, bool enable)
        {
            UGMP.Internal.TogglePlayerLowClouds(player.Id, enable);
        }

        public static void ToggleMoon(this BasePlayer player, bool enable)
        {
            UGMP.Internal.TogglePlayerMoon(player.Id, enable);
        }

        public static void ToggleNightVision(this BasePlayer player, bool enable)
        {
            UGMP.Internal.TogglePlayerNightVision(player.Id, enable);
        }

        public static void ToggleRainbow(this BasePlayer player, bool enable)
        {
            UGMP.Internal.TogglePlayerRainbow(player.Id, enable);
        }

        public static void ToggleRubbish(this BasePlayer player, bool enable)
        {
            UGMP.Internal.TogglePlayerRubbish(player.Id, enable);
        }

        public static void ToggleStars(this BasePlayer player, bool enable)
        {
            UGMP.Internal.TogglePlayerStars(player.Id, enable);
        }

        public static void ToggleVideoCameraOverlay(this BasePlayer player, bool enable)
        {
            UGMP.Internal.TogglePlayerVideoCameraOverlay(player.Id, enable);
        }
    }
}
