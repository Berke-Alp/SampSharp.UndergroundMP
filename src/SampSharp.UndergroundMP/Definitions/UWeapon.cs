using System;
using System.Collections.Generic;
using System.Text;

namespace SampSharp.UndergroundMP.Definitions
{
    /// <summary>
    /// Contains all weapons.
    /// </summary>
    public enum UWeapon
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,
        /// <summary>
        /// Brass Knuckles
        /// </summary>
        BrassKnuckles = 1,
        /// <summary>
        /// Golf Club
        /// </summary>
        GolfClub = 2,
        /// <summary>
        /// Night Stick
        /// </summary>
        NightStick = 3,
        /// <summary>
        /// Knife
        /// </summary>
        Knife = 4,
        /// <summary>
        /// Baseball Bat
        /// </summary>
        Bat = 5,
        /// <summary>
        /// Shovel
        /// </summary>
        Shovel = 6,
        /// <summary>
        /// Pool Cue
        /// </summary>
        PoolCue = 7,
        /// <summary>
        /// Katana
        /// </summary>
        Katana = 8,
        /// <summary>
        /// Chainsaw
        /// </summary>
        Chainsaw = 9,
        /// <summary>
        /// Dildo
        /// </summary>
        Dildo1 = 10,
        /// <summary>
        /// Dildo
        /// </summary>
        Dildo2 = 11,
        /// <summary>
        /// Vibrator
        /// </summary>
        Vibrator1 = 12,
        /// <summary>
        /// Vibrator
        /// </summary>
        Vibrator2 = 13,
        /// <summary>
        /// Flowers
        /// </summary>
        Flowers = 14,
        /// <summary>
        /// Cane
        /// </summary>
        Cane = 15,
        /// <summary>
        /// Grenade
        /// </summary>
        Grenade = 16,
        /// <summary>
        /// Teargas
        /// </summary>
        Teargas = 17,
        /// <summary>
        /// Molotov Cocktail
        /// </summary>
        MolotovCocktail = 18,
        /// <summary>
        /// Missile
        /// </summary>
        Missile = 21,
        /// <summary>
        /// Colt 45
        /// </summary>
        Colt45 = 22,
        /// <summary>
        /// Silenced Pistol
        /// </summary>
        SilencedPistol = 23,
        /// <summary>
        /// Desert Eagle
        /// </summary>
        DesertEagle = 24,
        /// <summary>
        /// Heat Seeker
        /// </summary>
        HeatSeeker = 36,
        /// <summary>
        /// Camera
        /// </summary>
        Camera = 43,
        /// <summary>
        /// Night Vision Goggles
        /// </summary>
        NVGoogles = 44,
        /// <summary>
        /// Thermal Goggles
        /// </summary>
        ThermalGoggles = 45,
        /// <summary>
        /// Parachute
        /// </summary>
        Parachute = 46,
        /// <summary>
        /// Shotgun
        /// </summary>
        Shotgun = 25,
        /// <summary>
        /// Sawn-off Shotgun
        /// </summary>
        Sawnoff = 26,
        /// <summary>
        /// Combat Shotgun
        /// </summary>
        CombatShotgun = 27,
        /// <summary>
        /// Micro SMG
        /// </summary>
        MicroSMG = 28,
        /// <summary>
        /// MP5
        /// </summary>
        MP5 = 29,
        /// <summary>
        /// AK-47
        /// </summary>
        AK47 = 30,
        /// <summary>
        /// M4
        /// </summary>
        M4 = 31,
        /// <summary>
        /// TEC9
        /// </summary>
        TEC9 = 32,
        /// <summary>
        /// Cuntgun
        /// </summary>
        Cuntgun = 33,
        /// <summary>
        /// Sniper Rifle
        /// </summary>
        SniperRifle = 34,
        /// <summary>
        /// Rocket Launcher
        /// </summary>
        RocketLauncher = 35,
        /// <summary>
        /// Flamethrower
        /// </summary>
        Flamethrower = 37,
        /// <summary>
        /// Minigun
        /// </summary>
        Minigun = 38,
        /// <summary>
        /// Satchel Charge
        /// </summary>
        SatchelCharge = 39,
        /// <summary>
        /// Spray Can
        /// </summary>
        SprayCan = 41,
        /// <summary>
        /// Fire Extinguisher
        /// </summary>
        FireExtinguisher = 42,

        #region UGMP Weapons

        /// <summary>
        /// AK-47
        /// </summary>
        sab_ak47 = 100,
        /// <summary>
        /// Camera
        /// </summary>
        sa_cscamera = 101,
        /// <summary>
        /// Glock
        /// </summary>
        sab_glock = 102,
        /// <summary>
        /// Golf Club
        /// </summary>
        sa_csgolfclub = 103,
        /// <summary>
        /// Parachute
        /// </summary>
        sab_gun_para = 104,
        /// <summary>
        /// PSG-1
        /// </summary>
        sab_psg1 = 105,
        /// <summary>
        /// Shovel
        /// </summary>
        sa_csshovel = 106,
        /// <summary>
        /// Skateboard
        /// </summary>
        sab_skateboard = 107,
        /// <summary>
        /// Spray Can
        /// </summary>
        sab_spraycan = 108,
        /// <summary>
        /// Switchblade
        /// </summary>
        sa_csswitchblade = 109,
        /// <summary>
        /// Throwing Knife
        /// </summary>
        sa_csthrowingkf = 110,
        /// <summary>
        /// AK-47
        /// </summary>
        lc_ak47 = 111,
        /// <summary>
        /// Baseball Bat
        /// </summary>
        lc_bat = 112,
        /// <summary>
        /// Colt 45
        /// </summary>
        lc_colt45 = 113,
        /// <summary>
        /// Flamethrower
        /// </summary>
        lc_flame = 114,
        /// <summary>
        /// Grenade
        /// </summary>
        lc_grenade = 115,
        /// <summary>
        /// Rocket Launcher
        /// </summary>
        lc_heatseek = 116,
        /// <summary>
        /// M16
        /// </summary>
        lc_m16 = 117,
        /// <summary>
        /// Missile
        /// </summary>
        lc_missile = 118,
        /// <summary>
        /// Molotov Cocktail
        /// </summary>
        lc_molotov = 119,
        /// <summary>
        /// Shotgun
        /// </summary>
        lc_shotgun = 120,
        /// <summary>
        /// Sniper Rifle
        /// </summary>
        lc_sniper = 121,
        /// <summary>
        /// UZI
        /// </summary>
        lc_uzi = 122,
        /// <summary>
        /// Brass Knuckles
        /// </summary>
        vc_brassknuckle = 123,
        /// <summary>
        /// Stubby Shotgun
        /// </summary>
        vc_buddyshot = 124,
        /// <summary>
        /// Chainsaw
        /// </summary>
        vc_chnsaw = 125,
        /// <summary>
        /// Shotgun
        /// </summary>
        vc_chromegun = 126,
        /// <summary>
        /// Cleaver
        /// </summary>
        vc_cleaver = 127,
        /// <summary>
        /// Colt 45
        /// </summary>
        vc_colt45 = 128,
        /// <summary>
        /// Flamethrower
        /// </summary>
        vc_flame = 129,
        /// <summary>
        /// Golf Club
        /// </summary>
        vc_golfclub = 130,
        /// <summary>
        /// Grenade
        /// </summary>
        vc_grenade = 131,
        /// <summary>
        /// Hammer
        /// </summary>
        vc_hammer = 132,
        /// <summary>
        /// Ingram
        /// </summary>
        vc_ingram = 133,
        /// <summary>
        /// Katana
        /// </summary>
        vc_katana = 134,
        /// <summary>
        /// Knife
        /// </summary>
        vc_knifecur = 135,
        /// <summary>
        /// Laser Rifle
        /// </summary>
        vc_laser = 136,
        /// <summary>
        /// M4
        /// </summary>
        vc_m4 = 137,
        /// <summary>
        /// M60
        /// </summary>
        vc_m60 = 138,
        /// <summary>
        /// Machete
        /// </summary>
        vc_machete = 139,
        /// <summary>
        /// Minigun
        /// </summary>
        vc_minigun = 140,
        /// <summary>
        /// Missile
        /// </summary>
        vc_missile = 141,
        /// <summary>
        /// Molotov Cocktail
        /// </summary>
        vc_molotov = 142,
        /// <summary>
        /// MP5
        /// </summary>
        vc_mp5lng = 143,
        /// <summary>
        /// Night Stick
        /// </summary>
        vc_nitestick = 144,
        /// <summary>
        /// Python
        /// </summary>
        vc_python = 145,
        /// <summary>
        /// Rocket Launcher
        /// </summary>
        vc_rocketla = 146,
        /// <summary>
        /// Kruger
        /// </summary>
        vc_ruger = 147,
        /// <summary>
        /// Screwdriver
        /// </summary>
        vc_screwdriver = 148,
        /// <summary>
        /// S.P.A.S 12
        /// </summary>
        vc_shotgspa = 149,
        /// <summary>
        /// Sniper Rifle
        /// </summary>
        vc_sniper = 150,
        /// <summary>
        /// Teargas
        /// </summary>
        vc_teargas = 151,
        /// <summary>
        /// TEC9
        /// </summary>
        vc_tec9 = 152,
        /// <summary>
        /// UZ-I
        /// </summary>
        vc_uzi = 153,
        /// <summary>
        /// Ruger
        /// </summary>
        vcps2_ruger = 154,
        /// <summary>
        /// Silenced Pistol
        /// </summary>
        vcb_coltsil = 155,
        /// <summary>
        /// Silenced Ingram
        /// </summary>
        vcb_ingramsl = 157,
        /// <summary>
        /// Short MP5
        /// </summary>
        vcb_mp5short = 158,
        /// <summary>
        /// Nailgun
        /// </summary>
        vcb_nailgun = 159,
        /// <summary>
        /// Stapler
        /// </summary>
        vcb_stapleg = 160,
        /// <summary>
        /// Steyr AUG
        /// </summary>
        vcb_steyr = 161,
        /// <summary>
        /// AK-47
        /// </summary>
        lcs_ak47 = 163,
        /// <summary>
        /// Baseball Bat
        /// </summary>
        lcs_bat = 164,
        /// <summary>
        /// Brass Knuckles
        /// </summary>
        lcs_brassknuckle = 165,
        /// <summary>
        /// Stubby Shotgun
        /// </summary>
        lcs_buddyshot = 166,
        /// <summary>
        /// Camera
        /// </summary>
        lcs_camera = 167,
        /// <summary>
        /// Cane
        /// </summary>
        lcs_cane = 168,
        /// <summary>
        /// Chisel
        /// </summary>
        lcs_chisel = 169,
        /// <summary>
        /// Chainsaw
        /// </summary>
        lcs_chnsaw = 170,
        /// <summary>
        /// Shotgun
        /// </summary>
        lcs_chromegun = 171,
        /// <summary>
        /// Cleaver
        /// </summary>
        lcs_cleaver = 172,
        /// <summary>
        /// Flamethrower
        /// </summary>
        lcs_flame = 173,
        /// <summary>
        /// Glock 17
        /// </summary>
        lcs_glock17 = 174,
        /// <summary>
        /// Grenade
        /// </summary>
        lcs_grenade = 175,
        /// <summary>
        /// Hand Axe
        /// </summary>
        lcs_handaxe = 176,
        /// <summary>
        /// Hockey Stick
        /// </summary>
        lcs_hockey = 177,
        /// <summary>
        /// Mac
        /// </summary>
        lcs_ingram = 178,
        /// <summary>
        /// Katana
        /// </summary>
        lcs_katana = 179,
        /// <summary>
        /// Knife
        /// </summary>
        lcs_knifecur = 180,
        /// <summary>
        /// Laser Rifle
        /// </summary>
        lcs_laser = 181,
        /// <summary>
        /// M4
        /// </summary>
        lcs_m4 = 182,
        /// <summary>
        /// M21
        /// </summary>
        lcs_m21 = 183,
        /// <summary>
        /// M60
        /// </summary>
        lcs_M60 = 184,
        /// <summary>
        /// Machete
        /// </summary>
        lcs_machete = 185,
        /// <summary>
        /// Minigun
        /// </summary>
        lcs_minigun = 186,
        /// <summary>
        /// Missile
        /// </summary>
        lcs_missile = 187,
        /// <summary>
        /// Molotov Cocktail
        /// </summary>
        lcs_molotov = 188,
        /// <summary>
        /// MP5K
        /// </summary>
        lcs_mp5k = 189,
        /// <summary>
        /// Night Stick
        /// </summary>
        lcs_nitestick = 190,
        /// <summary>
        /// Python
        /// </summary>
        lcs_python = 191,
        /// <summary>
        /// Rocket Launcher
        /// </summary>
        lcs_rocketla = 192,
        /// <summary>
        /// S.P.A.S 12
        /// </summary>
        lcs_shotgspa = 193,
        /// <summary>
        /// Teargas
        /// </summary>
        lcs_teargas = 194,
        /// <summary>
        /// TEC9
        /// </summary>
        lcs_tec9 = 195,
        /// <summary>
        /// UZI
        /// </summary>
        lcs_uzi = 196,
        /// <summary>
        /// AK-47
        /// </summary>
        vcs_ak47 = 197,
        /// <summary>
        /// Baseball Bat
        /// </summary>
        vcs_bat = 198,
        /// <summary>
        /// Beretta
        /// </summary>
        vcs_beretta = 199,
        /// <summary>
        /// Binoculars
        /// </summary>
        vcs_binoculars = 200,
        /// <summary>
        /// Brass Knuckles
        /// </summary>
        vcs_brassknuckle = 201,
        /// <summary>
        /// Stubby Shotgun
        /// </summary>
        vcs_buddyshot = 202,
        /// <summary>
        /// Butterfly Knife
        /// </summary>
        vcs_butknife = 203,
        /// <summary>
        /// Camera
        /// </summary>
        vcs_camera = 204,
        /// <summary>
        /// Cane
        /// </summary>
        vcs_cane = 205,
        /// <summary>
        /// Chainsaw
        /// </summary>
        vcs_chainsaw = 206,
        /// <summary>
        /// Shotgun
        /// </summary>
        vcs_chromegun = 207,
        /// <summary>
        /// Equalizer
        /// </summary>
        vcs_equalizer = 208,
        /// <summary>
        /// Flamethrower
        /// </summary>
        vcs_flame = 209,
        /// <summary>
        /// Gaff Hook
        /// </summary>
        vcs_gaff = 210,
        /// <summary>
        /// Golf Club
        /// </summary>
        vcs_golfclub = 211,
        /// <summary>
        /// Grenade
        /// </summary>
        vcs_grenade = 212,
        /// <summary>
        /// Hand Axe
        /// </summary>
        vcs_handaxe = 213,
        /// <summary>
        /// Mac
        /// </summary>
        vcs_ingramsl = 214,
        /// <summary>
        /// Knife
        /// </summary>
        vcs_knifecur = 215,
        /// <summary>
        /// M16
        /// </summary>
        vcs_M16 = 217,
        /// <summary>
        /// M21
        /// </summary>
        vcs_m21 = 219,
        /// <summary>
        /// M72
        /// </summary>
        vcs_m72 = 220,
        /// <summary>
        /// M249
        /// </summary>
        vcs_m249 = 221,
        /// <summary>
        /// Machete
        /// </summary>
        vcs_machete = 222,
        /// <summary>
        /// Minigun
        /// </summary>
        vcs_minigun = 223,
        /// <summary>
        /// Molotov Cocktail
        /// </summary>
        vcs_molotov = 224,
        /// <summary>
        /// Skorpion
        /// </summary>
        vcs_skorpion = 225,
        /// <summary>
        /// SP 89
        /// </summary>
        vcs_sp89 = 226,
        /// <summary>
        /// S.P.A.S 12
        /// </summary>
        vcs_shotgspa = 227,
        /// <summary>
        /// SVD
        /// </summary>
        vcs_svd = 228,
        /// <summary>
        /// Teargas
        /// </summary>
        vcs_teargas = 229,
        /// <summary>
        /// UZI
        /// </summary>
        vcs_uzi = 230,
        /// <summary>
        /// 56 II
        /// </summary>
        ug_56II = 231,
        /// <summary>
        /// 93R
        /// </summary>
        ug_93r = 232,
        /// <summary>
        /// AA12
        /// </summary>
        ug_aa12 = 233,
        /// <summary>
        /// AKS-74U
        /// </summary>
        ug_aks74u = 234,
        /// <summary>
        /// Arabian Sword
        /// </summary>
        ug_arabiansw = 235,
        /// <summary>
        /// AUG A3
        /// </summary>
        ug_auga3 = 236,
        /// <summary>
        /// AWP
        /// </summary>
        ug_awp = 237,
        /// <summary>
        /// Bone Knife
        /// </summary>
        ug_bonekf = 238,
        /// <summary>
        /// Cartel Revolver
        /// </summary>
        ug_cartelrevolver = 239,
        /// <summary>
        /// Claxe
        /// </summary>
        ug_claxe = 240,
        /// <summary>
        /// Colt 1911
        /// </summary>
        ug_colt1911 = 241,
        /// <summary>
        /// ES 57
        /// </summary>
        ug_es57 = 242,
        /// <summary>
        /// FAMAS
        /// </summary>
        ug_famas = 243,
        /// <summary>
        /// Fast Hawk
        /// </summary>
        ug_fasthawk = 244,
        /// <summary>
        /// Fire Axe
        /// </summary>
        ug_fireaxe = 245,
        /// <summary>
        /// G3
        /// </summary>
        ug_g3 = 246,
        /// <summary>
        /// G3 6C
        /// </summary>
        ug_g36c = 247,
        /// <summary>
        /// GALIL
        /// </summary>
        ug_galil = 248,
        /// <summary>
        /// Hatchet
        /// </summary>
        ug_hatchet = 249,
        /// <summary>
        /// HK 416
        /// </summary>
        ug_hk416 = 250,
        /// <summary>
        /// Kitchen Knife
        /// </summary>
        ug_kitchenkf = 251,
        /// <summary>
        /// KRISS
        /// </summary>
        ug_kriss = 252,
        /// <summary>
        /// Kukri Blade
        /// </summary>
        ug_kukri = 253,
        /// <summary>
        /// Luger
        /// </summary>
        ug_luger = 254,
        /// <summary>
        /// Luxwalt
        /// </summary>
        ug_luxwalt = 255,
        /// <summary>
        /// M1 Grand
        /// </summary>
        ug_m1garand = 256,
        /// <summary>
        /// M82
        /// </summary>
        ug_m82 = 257,
        /// <summary>
        /// M200
        /// </summary>
        ug_m200 = 258,
        /// <summary>
        /// M1903
        /// </summary>
        ug_m1903 = 259,
        /// <summary>
        /// Machete
        /// </summary>
        ug_machete = 260,
        /// <summary>
        /// Mauser
        /// </summary>
        ug_mauser = 261,
        /// <summary>
        /// MP7
        /// </summary>
        ug_mp7 = 262,
        /// <summary>
        /// MP40
        /// </summary>
        ug_mp40 = 263,
        /// <summary>
        /// OA93
        /// </summary>
        ug_oa93 = 264,
        /// <summary>
        /// Oldie
        /// </summary>
        ug_oldie = 265,
        /// <summary>
        /// P90
        /// </summary>
        ug_p90 = 266,
        /// <summary>
        /// Paper Knife
        /// </summary>
        ug_paperkf = 268,
        /// <summary>
        /// Pickaxe
        /// </summary>
        ug_pickaxe = 269,
        /// <summary>
        /// Pipe Wrench
        /// </summary>
        ug_pipew = 270,
        /// <summary>
        /// Pump Shotgun
        /// </summary>
        ug_pumpshot = 271,
        /// <summary>
        /// Revolver
        /// </summary>
        ug_revolver = 272,
        /// <summary>
        /// Revolver Rifle
        /// </summary>
        ug_revolverrifle = 273,
        /// <summary>
        /// SCAR
        /// </summary>
        ug_scar = 274,
        /// <summary>
        /// Scissors
        /// </summary>
        ug_scissors = 275,
        /// <summary>
        /// Scout
        /// </summary>
        ug_scout = 276,
        /// <summary>
        /// Silenced UZI
        /// </summary>
        ug_silenceduzi = 277,
        /// <summary>
        /// Songbird
        /// </summary>
        ug_songbird = 278,
        /// <summary>
        /// S.P.A.S 15
        /// </summary>
        ug_spas15 = 279,
        /// <summary>
        /// SP Carbine
        /// </summary>
        ug_spcarbine = 280,
        /// <summary>
        /// Stickground
        /// </summary>
        ug_stickgrnd = 281,
        /// <summary>
        /// Tactical Fist
        /// </summary>
        ug_tacticalfsth = 282,
        /// <summary>
        /// TMP
        /// </summary>
        ug_tmp = 283,
        /// <summary>
        /// Tomahawk
        /// </summary>
        ug_tomahawk = 284,
        /// <summary>
        /// Tommygun
        /// </summary>
        ug_tommygun = 285,
        /// <summary>
        /// Trench Knife
        /// </summary>
        ug_trenchkf = 286,
        /// <summary>
        /// Triple Barrel Sawnoff Shotgun
        /// </summary>
        ug_tripleshot = 287,
        /// <summary>
        /// UMP 45
        /// </summary>
        ug_ump45 = 288,
        /// <summary>
        /// Wood Cutter
        /// </summary>
        ug_woodcut = 289,
        /// <summary>
        /// Wooden Shotgun
        /// </summary>
        ug_woodshot = 290,
        /// <summary>
        /// Wooden Spale
        /// </summary>
        ug_woodspal = 291,
        /// <summary>
        /// Wrench
        /// </summary>
        ug_wrench = 292,
        /// <summary>
        /// XM8
        /// </summary>
        ug_xm8 = 293,
        /// <summary>
        /// XM 1014
        /// </summary>
        ug_xm1014 = 294,
        /// <summary>
        /// 2 by 4
        /// </summary>
        bw_2by4 = 295,
        /// <summary>
        /// Baseball Bat
        /// </summary>
        bw_bbbat = 296,
        /// <summary>
        /// BB Gun
        /// </summary>
        bw_bbgun = 297,
        /// <summary>
        /// Bolt Cutters
        /// </summary>
        bw_boltcutters = 298,
        /// <summary>
        /// Broom
        /// </summary>
        bw_broom = 299,
        /// <summary>
        /// Cane
        /// </summary>
        bw_cane = 300,
        /// <summary>
        /// Cricket
        /// </summary>
        bw_cricket = 301,
        /// <summary>
        /// Devil's Fork
        /// </summary>
        bw_devilfork = 302,
        /// <summary>
        /// Camera
        /// </summary>
        bw_camera = 303,
        /// <summary>
        /// Drumstick
        /// </summary>
        bw_drumstick = 304,
        /// <summary>
        /// Flashlight
        /// </summary>
        bw_flashlight = 305,
        /// <summary>
        /// Mallet
        /// </summary>
        bw_mallet = 306,
        /// <summary>
        /// Maracas
        /// </summary>
        bw_maracas = 307,
        /// <summary>
        /// Newsroll
        /// </summary>
        bw_newsroll = 308,
        /// <summary>
        /// Pool Cue
        /// </summary>
        bw_poolcue = 309,
        /// <summary>
        /// Ratchet
        /// </summary>
        bw_ratchet = 310,
        /// <summary>
        /// Skateboard
        /// </summary>
        bw_skate = 311,
        /// <summary>
        /// Sledgehammer
        /// </summary>
        bw_sledgehammer = 312,
        /// <summary>
        /// Snow Shovel
        /// </summary>
        bw_snwshovel = 313,
        /// <summary>
        /// Spray Can
        /// </summary>
        bw_spraycan = 314,
        /// <summary>
        /// Whip
        /// </summary>
        bw_whip = 315,
        /// <summary>
        /// Wrench
        /// </summary>
        bw_wrench = 316,
        /// <summary>
        /// Water Pipe
        /// </summary>
        bw_wtrpipe = 317,
        /// <summary>
        /// Yardstick
        /// </summary>
        bw_yardstick = 318,
        /// <summary>
        /// Axe
        /// </summary>
        cc_axe = 319,
        /// <summary>
        /// Baseball Bat
        /// </summary>
        cc_bat = 320,
        /// <summary>
        /// Chainsaw
        /// </summary>
        cc_chnsaw = 321,
        /// <summary>
        /// Cleaver
        /// </summary>
        cc_cleaver = 322,
        /// <summary>
        /// Crowbar
        /// </summary>
        cc_crowbar = 323,
        /// <summary>
        /// Desert Eagle
        /// </summary>
        cc_deagle = 324,
        /// <summary>
        /// Glock
        /// </summary>
        cc_glock = 325,
        /// <summary>
        /// Hammer
        /// </summary>
        cc_hammer = 326,
        /// <summary>
        /// Ice Axe
        /// </summary>
        cc_iceaxe = 327,
        /// <summary>
        /// Ingram
        /// </summary>
        cc_ingram = 328,
        /// <summary>
        /// Knife
        /// </summary>
        cc_knifecur = 329,
        /// <summary>
        /// M4
        /// </summary>
        cc_m4 = 330,
        /// <summary>
        /// Machete
        /// </summary>
        cc_machete = 331,
        /// <summary>
        /// Nailed Bat
        /// </summary>
        cc_nailbat = 332,
        /// <summary>
        /// Nailgun
        /// </summary>
        cc_nailgun = 333,
        /// <summary>
        /// Night Stick
        /// </summary>
        cc_nitestick = 334,
        /// <summary>
        /// PSG-1
        /// </summary>
        cc_psg1 = 335,
        /// <summary>
        /// Revolver
        /// </summary>
        cc_revolver = 336,
        /// <summary>
        /// Shards
        /// </summary>
        cc_shard = 337,
        /// <summary>
        /// S.P.A.S 12
        /// </summary>
        cc_shotgspa = 338,
        /// <summary>
        /// Stubby Shotgun
        /// </summary>
        cc_shotgun = 339,
        /// <summary>
        /// Sickle
        /// </summary>
        cc_sickle = 340,
        /// <summary>
        /// Small Bat
        /// </summary>
        cc_smallbat = 341,
        /// <summary>
        /// Sniper Rifle
        /// </summary>
        cc_sniper = 342,
        /// <summary>
        /// Tranquilizer
        /// </summary>
        cc_tranq = 343,
        /// <summary>
        /// Wooden Bat
        /// </summary>
        cc_woodbat = 344,
        /// <summary>
        /// Crowbar
        /// </summary>
        cc_crowbar2 = 345,
        /// <summary>
        /// Scythe
        /// </summary>
        cc_scythe = 346,
        /// <summary>
        /// Amp Knife
        /// </summary>
        cm_amputationkf = 347,
        /// <summary>
        /// Bouquet
        /// </summary>
        cm_bouquet = 348,
        /// <summary>
        /// Broom
        /// </summary>
        cm_broom = 349,
        /// <summary>
        /// Crowbar
        /// </summary>
        cm_crowbar = 350,
        /// <summary>
        /// Desert Eagle
        /// </summary>
        cm_deagle = 351,
        /// <summary>
        /// Fire Axe
        /// </summary>
        cm_fireaxe = 352,
        /// <summary>
        /// Fire Tool
        /// </summary>
        cm_firetool = 353,
        /// <summary>
        /// Glock
        /// </summary>
        cm_glock = 354,
        /// <summary>
        /// Hay Fork
        /// </summary>
        cm_hayfork = 355,
        /// <summary>
        /// Ingram
        /// </summary>
        cm_ingram = 356,
        /// <summary>
        /// M4
        /// </summary>
        cm_m4 = 357,
        /// <summary>
        /// Night Stick
        /// </summary>
        cm_nitestick = 358,
        /// <summary>
        /// Pliers
        /// </summary>
        cm_pliers = 359,
        /// <summary>
        /// Rake
        /// </summary>
        cm_rake = 360,
        /// <summary>
        /// Razor
        /// </summary>
        cm_razor = 361,
        /// <summary>
        /// Revolver
        /// </summary>
        cm_revolver = 362,
        /// <summary>
        /// Shards
        /// </summary>
        cm_shard = 363,
        /// <summary>
        /// S.P.A.S 12
        /// </summary>
        cm_shotgspa = 364,
        /// <summary>
        /// Stubby Shotgun
        /// </summary>
        cm_shotgun = 365,
        /// <summary>
        /// Shovel
        /// </summary>
        cm_shovel = 366,
        /// <summary>
        /// Sickle
        /// </summary>
        cm_sickle = 367,
        /// <summary>
        /// Sledgehammer
        /// </summary>
        cm_sledgehammer = 368,
        /// <summary>
        /// Syringe
        /// </summary>
        cm_syringe = 369,
        /// <summary>
        /// Tranquilizer
        /// </summary>
        cm_tranq = 370,
        /// <summary>
        /// Wooden Bat
        /// </summary>
        cm_wbat = 371,
        /// <summary>
        /// Circular Saw
        /// </summary>
        cm_circularsaw = 372,
        /// <summary>
        /// Clipboard
        /// </summary>
        cm_clipboard = 373,
        /// <summary>
        /// Crossbow
        /// </summary>
        cm_crossbow = 374,
        /// <summary>
        /// Dildo
        /// </summary>
        cm_dildo = 375,
        /// <summary>
        /// Fire Extinguisher
        /// </summary>
        cm_fireex = 376,
        /// <summary>
        /// Flare Gun
        /// </summary>
        cm_flaregun = 377,
        /// <summary>
        /// Flashlight
        /// </summary>
        cm_flashlight = 378,
        /// <summary>
        /// Hacksaw
        /// </summary>
        cm_hacksaw = 379,
        /// <summary>
        /// Hammer
        /// </summary>
        cm_hammer = 380,
        /// <summary>
        /// Katana
        /// </summary>
        cm_katana = 381,
        /// <summary>
        /// Mace
        /// </summary>
        cm_mace = 382,
        /// <summary>
        /// Newspaper
        /// </summary>
        cm_newspaper = 383,
        /// <summary>
        /// Picket
        /// </summary>
        cm_picket = 384,
        /// <summary>
        /// Saw
        /// </summary>
        cm_saw = 385,
        /// <summary>
        /// Scissors
        /// </summary>
        cm_scissors = 386,
        /// <summary>
        /// Sniper Rifle
        /// </summary>
        cm_sniper = 387,
        /// <summary>
        /// Stun Baton
        /// </summary>
        cm_stunbaton = 388,
        /// <summary>
        /// Baseball Bat
        /// </summary>
        vc_bat = 393,
        /// <summary>
        /// Cane
        /// </summary>
        vc_cane = 394,
        /// <summary>
        /// 2T Glock
        /// </summary>
        ug_2tglock = 395,
        /// <summary>
        /// AK-SOPMOD
        /// </summary>
        ug_aksopmod = 396,
        /// <summary>
        /// AR7
        /// </summary>
        ug_ar7 = 397,
        /// <summary>
        /// Bat
        /// </summary>
        ug_bat = 398,
        /// <summary>
        /// Brass Knuckles
        /// </summary>
        ug_brassknuckle = 400,
        /// <summary>
        /// Calico
        /// </summary>
        ug_calico = 401,
        /// <summary>
        /// Camouflage Sniper
        /// </summary>
        ug_camosniper = 402,
        /// <summary>
        /// FMG9
        /// </summary>
        ug_fmg9 = 403,
        /// <summary>
        /// Karambit
        /// </summary>
        ug_karambit = 404,
        /// <summary>
        /// M202A1
        /// </summary>
        ug_m202a1 = 406,
        /// <summary>
        /// Matador
        /// </summary>
        ug_matador = 408,
        /// <summary>
        /// Paintball Gun
        /// </summary>
        ug_paintball = 409,
        /// <summary>
        /// Plunger
        /// </summary>
        ug_plunger = 410,
        /// <summary>
        /// RPG-26
        /// </summary>
        ug_rpg26 = 412,
        /// <summary>
        /// SEW-500
        /// </summary>
        ug_sew500 = 413,
        /// <summary>
        /// Silver Revolver
        /// </summary>
        ug_silverrevolver = 414,
        /// <summary>
        /// Snub Revolver
        /// </summary>
        ug_snub = 415,
        /// <summary>
        /// Spiked Brass Knuckles
        /// </summary>
        ug_spikedknuckle = 416,
        /// <summary>
        /// SRSA-1
        /// </summary>
        ug_srsa1 = 417,
        /// <summary>
        /// Sturmgewehr
        /// </summary>
        ug_sturmgewehr = 418,
        /// <summary>
        /// Sword
        /// </summary>
        ug_sword = 419,
        /// <summary>
        /// Tennisracket
        /// </summary>
        ug_tennisracket = 420,
        /// <summary>
        /// Volcanic Pistol
        /// </summary>
        ug_volcanic = 421,

        #endregion
    }
}
