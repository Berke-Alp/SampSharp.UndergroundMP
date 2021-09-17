using System;
using System.Collections.Generic;
using System.Text;

namespace SampSharp.UndergroundMP.Definitions
{
    /// <summary>
    /// Contains all vehicle models.
    /// </summary>
    public enum VehicleModelType
    {
        /// <summary>
        /// Stinger
        /// </summary>
        vc_stinger = 1194,
        /// <summary>
        /// VCPD Cheetah
        /// </summary>
        vc_vicechee = 1195,
        /// <summary>
        /// Spand Express
        /// </summary>
        vc_spand = 1196,
        /// <summary>
        /// Love Fist
        /// </summary>
        vc_lovefist = 1197,
        /// <summary>
        /// Sindacco
        /// </summary>
        lc_sindaccocar = 1199,
        /// <summary>
        /// Bickle 76
        /// </summary>
        lcs_bickle76 = 1200,
        /// <summary>
        /// Kuruma
        /// </summary>
        lc_kuruma = 1201,
        /// <summary>
        /// Idaho
        /// </summary>
        lc_idaho = 1202,
        /// <summary>
        /// Toyz
        /// </summary>
        lc_toyz = 1203,
        /// <summary>
        /// Borgnine
        /// </summary>
        lc_borgnine = 1204,
        /// <summary>
        /// Manchez
        /// </summary>
        lc_manchez = 1205,
        /// <summary>
        /// Noodleboy
        /// </summary>
        lc_noodleboy = 1206,
        /// <summary>
        /// Police
        /// </summary>
        lc_copcarlc = 1326,
        /// <summary>
        /// Police
        /// </summary>
        vc_copcarvc = 1573,
        /// <summary>
        /// Landstalker
        /// </summary>
        lc_monstros = 1699,
        /// <summary>
        /// Enforcer
        /// </summary>
        lv_enforcer = 25353,
        /// <summary>
        /// Enforcer
        /// </summary>
        sa_enforcer = 25354,
        /// <summary>
        /// Enforcer
        /// </summary>
        sf_enforcer = 25355,
        /// <summary>
        /// Police Maverick
        /// </summary>
        ls_polmav = 25356,
        /// <summary>
        /// Police Maverick
        /// </summary>
        lv_polmav = 25357,
        /// <summary>
        /// Police Maverick
        /// </summary>
        sf_polmav = 25358,
        /// <summary>
        /// CCPD Boxville
        /// </summary>
        cc_ccpdvan = 25359,
        /// <summary>
        /// Hellraiser
        /// </summary>
        ug_hellrais = 25360,
        /// <summary>
        /// Police Maverick
        /// </summary>
        mw_polmav = 25362,
        /// <summary>
        /// Police Maverick
        /// </summary>
        at_polmav = 25363,
        /// <summary>
        /// Subway
        /// </summary>
        lc_trainr = 25365,
        /// <summary>
        /// Shamal
        /// </summary>
        vc_shamal = 25369,
        /// <summary>
        /// Manana
        /// </summary>
        lc_corpse = 25370,
        /// <summary>
        /// Idaho
        /// </summary>
        sab_idaho = 25371,
        /// <summary>
        /// Taxi
        /// </summary>
        cc_taxi = 25373,
        /// <summary>
        /// APC
        /// </summary>
        cc_apc = 25375,
        /// <summary>
        /// Legacy
        /// </summary>
        lc_legacy = 25378,
        /// <summary>
        /// Perennial
        /// </summary>
        lcs_peren = 25380,
        /// <summary>
        /// Tailgater
        /// </summary>
        mh_tailgater = 25381,
        /// <summary>
        /// Steed
        /// </summary>
        cc_steed = 25382,
        /// <summary>
        /// Manana
        /// </summary>
        lcs_manana = 25383,
        /// <summary>
        /// Kuruma
        /// </summary>
        lcs_kuruma = 25384,
        /// <summary>
        /// Mafia Sentinel
        /// </summary>
        lcs_mafiab = 25385,
        /// <summary>
        /// Ballot Van
        /// </summary>
        lcs_ballot = 25389,
        /// <summary>
        /// Flatbed
        /// </summary>
        lcs_flatbed = 25390,
        /// <summary>
        /// Police Truck
        /// </summary>
        ug_policetruck = 25391,
        /// <summary>
        /// Guardian
        /// </summary>
        mw_guardian = 25392,
        /// <summary>
        /// FBI Cruiser
        /// </summary>
        fbipremierb = 25393,
        /// <summary>
        /// Police Motorcycle
        /// </summary>
        bw_copbike = 25394,
        /// <summary>
        /// Police
        /// </summary>
        mw_copcarmw2 = 25395,
        /// <summary>
        /// Elwood
        /// </summary>
        mw_elwood = 25396,
        /// <summary>
        /// Tranquility
        /// </summary>
        mp_tranquility = 25400,
        /// <summary>
        /// Hearse
        /// </summary>
        lcs_hearse = 25401,
        /// <summary>
        /// Voodoo
        /// </summary>
        mp_vbloodr = 25402,
        /// <summary>
        /// Henry
        /// </summary>
        ug_henry = 25405,
        /// <summary>
        /// Polaris Racer
        /// </summary>
        mp_polaris = 25406,
        /// <summary>
        /// Dukes Racer
        /// </summary>
        mp_dukesr = 25409,
        /// <summary>
        /// Majestic Racer
        /// </summary>
        mp_majesticr = 25410,
        /// <summary>
        /// Tahoma Racer
        /// </summary>
        mp_tahomar = 25411,
        /// <summary>
        /// Bloodring Cabbie
        /// </summary>
        mp_bcabbie = 25414,
        /// <summary>
        /// Sonic
        /// </summary>
        mp_f1a = 25415,
        /// <summary>
        /// Sonic
        /// </summary>
        mp_f1b = 25416,
        /// <summary>
        /// Sonic
        /// </summary>
        mp_f1c = 25417,
        /// <summary>
        /// Fire Truck
        /// </summary>
        lcs_firetruk = 25420,
        /// <summary>
        /// Fire Truck
        /// </summary>
        vcs_firetruk = 25421,
        /// <summary>
        /// Coach
        /// </summary>
        vc_coach = 25424,
        /// <summary>
        /// Tuff
        /// </summary>
        cc_tuff = 25425,
        /// <summary>
        /// Fire Escape
        /// </summary>
        mpvc_firehelif = 25428,
        /// <summary>
        /// Fire Ambulance
        /// </summary>
        mpvc_fireamb = 25431,
        /// <summary>
        /// Stinger
        /// </summary>
        cm_stinger = 25435,
        /// <summary>
        /// FBI Stanier
        /// </summary>
        cc_fbicar = 25437,
        /// <summary>
        /// RC Bandit
        /// </summary>
        lcs_rcbandit = 25438,
        /// <summary>
        /// Lifeguard
        /// </summary>
        mp_lifeguard = 25444,
        /// <summary>
        /// Cabbie
        /// </summary>
        vcs_cabbie = 25445,
        /// <summary>
        /// Romero
        /// </summary>
        vc_romero = 25461,
        /// <summary>
        /// Police Wintergreen
        /// </summary>
        mw_copbike = 25462,
        /// <summary>
        /// Articulated Trailer 6
        /// </summary>
        artict6 = 25463,
        /// <summary>
        /// Caravan
        /// </summary>
        ug_caravana = 25464,
        /// <summary>
        /// Insurrection
        /// </summary>
        ug_insurrection = 25466,
        /// <summary>
        /// Fire Ambulance
        /// </summary>
        mplc_fireamb = 25484,
        /// <summary>
        /// Fire Escape
        /// </summary>
        lc_fireesc = 25485,
        /// <summary>
        /// Hazmat Firetruck
        /// </summary>
        mplc_firehzmt = 25486,
        /// <summary>
        /// Fire Towtruck
        /// </summary>
        mplc_firetowt = 25489,
        /// <summary>
        /// Brush Unit
        /// </summary>
        mplc_firetruk = 25490,
        /// <summary>
        /// Fire Landstalker
        /// </summary>
        mplc_fireunit = 25491,
        /// <summary>
        /// Turismo
        /// </summary>
        vcc_turismo = 25492,
        /// <summary>
        /// Yankee
        /// </summary>
        bw_yankeea = 25497,
        /// <summary>
        /// Yankee
        /// </summary>
        bw_yankeeb = 25498,
        /// <summary>
        /// Faggio
        /// </summary>
        bw_faggio = 25499,
        /// <summary>
        /// BMX
        /// </summary>
        bw_aquabike = 25500,
        /// <summary>
        /// BMX
        /// </summary>
        bw_bike = 25501,
        /// <summary>
        /// BMX
        /// </summary>
        bw_bmx = 25502,
        /// <summary>
        /// BMX
        /// </summary>
        bw_bmxc = 25503,
        /// <summary>
        /// BMX
        /// </summary>
        bw_bmxr = 25504,
        /// <summary>
        /// Bike
        /// </summary>
        bw_bmxs = 25505,
        /// <summary>
        /// BMX
        /// </summary>
        bw_custombike = 25506,
        /// <summary>
        /// Mountain Bike
        /// </summary>
        bw_mtbike = 25507,
        /// <summary>
        /// BMX
        /// </summary>
        bw_oladbike = 25508,
        /// <summary>
        /// Mountain Bike
        /// </summary>
        bw_racer = 25509,
        /// <summary>
        /// BMX
        /// </summary>
        bw_retro = 25510,
        /// <summary>
        /// Boxville
        /// </summary>
        bw_boxville = 25516,
        /// <summary>
        /// Quadbike
        /// </summary>
        vcs_quad = 25517,
        /// <summary>
        /// Mule
        /// </summary>
        cm_mule = 25518,
        /// <summary>
        /// Kart
        /// </summary>
        bw_kart = 25520,
        /// <summary>
        /// Bus
        /// </summary>
        cc_bus = 25521,
        /// <summary>
        /// Bullion
        /// </summary>
        lcs_bullion = 25522,
        /// <summary>
        /// Speeder
        /// </summary>
        lcs_speeder = 25537,
        /// <summary>
        /// Barracks
        /// </summary>
        mw_barracks = 25538,
        /// <summary>
        /// Bullet GT
        /// </summary>
        mw_bulletgt = 25539,
        /// <summary>
        /// Stork
        /// </summary>
        mw_stork = 25540,
        /// <summary>
        /// Canyon
        /// </summary>
        mw_canyon = 25541,
        /// <summary>
        /// FBI Canyon
        /// </summary>
        mw_fbicanyo = 25542,
        /// <summary>
        /// Police Canyon
        /// </summary>
        mw_copcarru = 25543,
        /// <summary>
        /// Cottonmouth
        /// </summary>
        mw_cotmouth = 25544,
        /// <summary>
        /// El Destino
        /// </summary>
        mw_destino = 25546,
        /// <summary>
        /// Faction TT
        /// </summary>
        mw_faction = 25547,
        /// <summary>
        /// Juliette
        /// </summary>
        mw_juliette = 25548,
        /// <summary>
        /// Lazer
        /// </summary>
        mw_lazer = 25549,
        /// <summary>
        /// Lobo Donk
        /// </summary>
        mw_lobodonk = 25550,
        /// <summary>
        /// Premier
        /// </summary>
        mw_premier = 25551,
        /// <summary>
        /// Schafter
        /// </summary>
        mw_schafter = 25552,
        /// <summary>
        /// Super Diamond
        /// </summary>
        mw_diamond = 25553,
        /// <summary>
        /// Ontario
        /// </summary>
        mw_cntario = 25554,
        /// <summary>
        /// Ontario
        /// </summary>
        mw_ontario = 25555,
        /// <summary>
        /// Zion
        /// </summary>
        mw_zion = 25557,
        /// <summary>
        /// Taxi
        /// </summary>
        mw_taxi = 25572,
        /// <summary>
        /// Prison Bus
        /// </summary>
        mw_prisonbus = 25575,
        /// <summary>
        /// Faggio
        /// </summary>
        lcs_faggio = 25576,
        /// <summary>
        /// Pizzaboy
        /// </summary>
        lcs_pizzaboy = 25577,
        /// <summary>
        /// Premier
        /// </summary>
        premierb = 25584,
        /// <summary>
        /// Tampa
        /// </summary>
        cc_tampa = 25585,
        /// <summary>
        /// Civique
        /// </summary>
        mw_civique = 25586,
        /// <summary>
        /// Comet SR
        /// </summary>
        mw_comet = 25602,
        /// <summary>
        /// Coquette
        /// </summary>
        mw_coquette = 25603,
        /// <summary>
        /// Fiammetta
        /// </summary>
        mw_fiammetta = 25604,
        /// <summary>
        /// Exsess
        /// </summary>
        mw_exsess = 25605,
        /// <summary>
        /// Skimpy
        /// </summary>
        mw_skimpy = 25606,
        /// <summary>
        /// Steed
        /// </summary>
        mw_steed = 25607,
        /// <summary>
        /// Articulated Trailer 4
        /// </summary>
        artict4 = 25608,
        /// <summary>
        /// Hauler
        /// </summary>
        cc_hauler = 25609,
        /// <summary>
        /// Bug
        /// </summary>
        mw_bug = 25610,
        /// <summary>
        /// Patriot
        /// </summary>
        mw_patriot = 25612,
        /// <summary>
        /// Articulated Trailer 5
        /// </summary>
        artict5 = 25613,
        /// <summary>
        /// Python
        /// </summary>
        cc_python = 25614,
        /// <summary>
        /// Angel
        /// </summary>
        vcs_angel = 25641,
        /// <summary>
        /// Forklift
        /// </summary>
        vcs_forklift = 25642,
        /// <summary>
        /// Patriot
        /// </summary>
        vcs_patriot = 25643,
        /// <summary>
        /// Transit
        /// </summary>
        mw_transit = 25644,
        /// <summary>
        /// Texas
        /// </summary>
        mw_texas = 25646,
        /// <summary>
        /// Stanier
        /// </summary>
        mw_stanier = 25648,
        /// <summary>
        /// Veloce
        /// </summary>
        mw_veloce = 25649,
        /// <summary>
        /// Lebonham
        /// </summary>
        mw_lebhm = 25650,
        /// <summary>
        /// Dubsta
        /// </summary>
        mw_dubsta = 25665,
        /// <summary>
        /// Lokus
        /// </summary>
        mw_lokus = 25666,
        /// <summary>
        /// Imperator
        /// </summary>
        mw_imperator = 25668,
        /// <summary>
        /// Spacevan
        /// </summary>
        mw_steedvan = 25683,
        /// <summary>
        /// Mesa
        /// </summary>
        mw_mesa = 25685,
        /// <summary>
        /// Landstalker
        /// </summary>
        cc_landstal = 25686,
        /// <summary>
        /// Reagan
        /// </summary>
        cc_reagan = 25687,
        /// <summary>
        /// Police Crusier
        /// </summary>
        ug_copcara = 25689,
        /// <summary>
        /// Freeway
        /// </summary>
        lcs_freeway = 25690,
        /// <summary>
        /// Buffalo
        /// </summary>
        cc_buffalo = 25691,
        /// <summary>
        /// Interstate
        /// </summary>
        mw_interstate = 25692,
        /// <summary>
        /// Baron
        /// </summary>
        ug_baron = 25693,
        /// <summary>
        /// Gang Rancher
        /// </summary>
        vc_gangran = 2883,
        /// <summary>
        /// Wintergreen
        /// </summary>
        vc_wintergreen = 2884,
        /// <summary>
        /// VCPD WinterGreen
        /// </summary>
        vc_copwinter = 3136,
        /// <summary>
        /// Ventoso
        /// </summary>
        vc_moped50 = 3137,
        /// <summary>
        /// Avenger
        /// </summary>
        lcs_avenger = 3138,
        /// <summary>
        /// Streetfighter
        /// </summary>
        vc_streetfighter = 3139,
        /// <summary>
        /// Polaris V8
        /// </summary>
        vc_polaris = 3140,
        /// <summary>
        /// Clover Racer
        /// </summary>
        clovral = 3141,
        /// <summary>
        /// Angel
        /// </summary>
        lcs_angel = 3222,
        /// <summary>
        /// Landstalker
        /// </summary>
        lcs_landstal = 3223,
        /// <summary>
        /// PCJ-600
        /// </summary>
        lcs_pcj600 = 3224,
        /// <summary>
        /// LCPD WinterGreen
        /// </summary>
        lc_copbike = 3247,
        /// <summary>
        /// AT-200
        /// </summary>
        lc_at200a = 3248,
        /// <summary>
        /// Regina
        /// </summary>
        bw_regina = 3251,
        /// <summary>
        /// Vaquero
        /// </summary>
        bw_vaquero = 3416,
        /// <summary>
        /// Landstalker
        /// </summary>
        landstal = 400,
        /// <summary>
        /// Bravura
        /// </summary>
        bravura = 401,
        /// <summary>
        /// Buffalo
        /// </summary>
        buffalo = 402,
        /// <summary>
        /// Linerunner
        /// </summary>
        linerun = 403,
        /// <summary>
        /// Perennial
        /// </summary>
        peren = 404,
        /// <summary>
        /// Sentinel
        /// </summary>
        sentinel = 405,
        /// <summary>
        /// Dumper
        /// </summary>
        dumper = 406,
        /// <summary>
        /// Fire Truck
        /// </summary>
        firetruk = 407,
        /// <summary>
        /// Trashmaster
        /// </summary>
        trash = 408,
        /// <summary>
        /// Stretch
        /// </summary>
        stretch = 409,
        /// <summary>
        /// Manana
        /// </summary>
        manana = 410,
        /// <summary>
        /// Infernus
        /// </summary>
        infernus = 411,
        /// <summary>
        /// Voodoo
        /// </summary>
        voodoo = 412,
        /// <summary>
        /// Pony
        /// </summary>
        pony = 413,
        /// <summary>
        /// Mule
        /// </summary>
        mule = 414,
        /// <summary>
        /// Cheetah
        /// </summary>
        cheetah = 415,
        /// <summary>
        /// Ambulance
        /// </summary>
        ambulan = 416,
        /// <summary>
        /// Leviathan
        /// </summary>
        leviathn = 417,
        /// <summary>
        /// Moonbeam
        /// </summary>
        moonbeam = 418,
        /// <summary>
        /// Esperanto
        /// </summary>
        esperant = 419,
        /// <summary>
        /// Taxi
        /// </summary>
        taxi = 420,
        /// <summary>
        /// Washington
        /// </summary>
        washing = 421,
        /// <summary>
        /// Bobcat
        /// </summary>
        bobcat = 422,
        /// <summary>
        /// Mr. Whoopee
        /// </summary>
        mrwhoop = 423,
        /// <summary>
        /// BF Injection
        /// </summary>
        bfinject = 424,
        /// <summary>
        /// Hunter
        /// </summary>
        hunter = 425,
        /// <summary>
        /// Premier
        /// </summary>
        premier = 426,
        /// <summary>
        /// Enforcer
        /// </summary>
        enforcer = 427,
        /// <summary>
        /// Securicar
        /// </summary>
        securica = 428,
        /// <summary>
        /// Banshee
        /// </summary>
        banshee = 429,
        /// <summary>
        /// Predator
        /// </summary>
        predator = 430,
        /// <summary>
        /// Bus
        /// </summary>
        bus = 431,
        /// <summary>
        /// Rhino
        /// </summary>
        rhino = 432,
        /// <summary>
        /// Barracks
        /// </summary>
        barracks = 433,
        /// <summary>
        /// Hotknife
        /// </summary>
        hotknife = 434,
        /// <summary>
        /// Articulated Trailer 1
        /// </summary>
        artict1 = 435,
        /// <summary>
        /// Previon
        /// </summary>
        previon = 436,
        /// <summary>
        /// Coach
        /// </summary>
        coach = 437,
        /// <summary>
        /// Cabbie
        /// </summary>
        cabbie = 438,
        /// <summary>
        /// Stallion
        /// </summary>
        stallion = 439,
        /// <summary>
        /// Rumpo
        /// </summary>
        rumpo = 440,
        /// <summary>
        /// RC Bandit
        /// </summary>
        rcbandit = 441,
        /// <summary>
        /// Romero
        /// </summary>
        romero = 442,
        /// <summary>
        /// Packer
        /// </summary>
        packer = 443,
        /// <summary>
        /// Monster
        /// </summary>
        monster = 444,
        /// <summary>
        /// Admiral
        /// </summary>
        admiral = 445,
        /// <summary>
        /// Squalo
        /// </summary>
        squalo = 446,
        /// <summary>
        /// Seasparrow
        /// </summary>
        seaspar = 447,
        /// <summary>
        /// Pizzaboy
        /// </summary>
        pizzaboy = 448,
        /// <summary>
        /// Tram
        /// </summary>
        tram = 449,
        /// <summary>
        /// Articulated Trailer 2
        /// </summary>
        artict2 = 450,
        /// <summary>
        /// Turismo
        /// </summary>
        turismo = 451,
        /// <summary>
        /// Speeder
        /// </summary>
        speeder = 452,
        /// <summary>
        /// Reefer
        /// </summary>
        reefer = 453,
        /// <summary>
        /// Tropic
        /// </summary>
        tropic = 454,
        /// <summary>
        /// Flatbed
        /// </summary>
        flatbed = 455,
        /// <summary>
        /// Yankee
        /// </summary>
        yankee = 456,
        /// <summary>
        /// Caddy
        /// </summary>
        caddy = 457,
        /// <summary>
        /// Solair
        /// </summary>
        solair = 458,
        /// <summary>
        /// Berkley's RC Van
        /// </summary>
        topfun = 459,
        /// <summary>
        /// Skimmer
        /// </summary>
        skimmer = 460,
        /// <summary>
        /// PCJ-600
        /// </summary>
        pcj600 = 461,
        /// <summary>
        /// Faggio
        /// </summary>
        faggio = 462,
        /// <summary>
        /// Freeway
        /// </summary>
        freeway = 463,
        /// <summary>
        /// RC Baron
        /// </summary>
        rcbaron = 464,
        /// <summary>
        /// RC Raider
        /// </summary>
        rcraider = 465,
        /// <summary>
        /// Glendale
        /// </summary>
        glendale = 466,
        /// <summary>
        /// Oceanic
        /// </summary>
        oceanic = 467,
        /// <summary>
        /// Sanchez
        /// </summary>
        sanchez = 468,
        /// <summary>
        /// Sparrow
        /// </summary>
        sparrow = 469,
        /// <summary>
        /// Patriot
        /// </summary>
        patriot = 470,
        /// <summary>
        /// Quadbike
        /// </summary>
        quad = 471,
        /// <summary>
        /// Coastguard
        /// </summary>
        coastg = 472,
        /// <summary>
        /// Dinghy
        /// </summary>
        dinghy = 473,
        /// <summary>
        /// Hermes
        /// </summary>
        hermes = 474,
        /// <summary>
        /// Sabre
        /// </summary>
        sabre = 475,
        /// <summary>
        /// Rustler
        /// </summary>
        rustler = 476,
        /// <summary>
        /// Hunter
        /// </summary>
        vc_hunter = 4769,
        /// <summary>
        /// ZR-350
        /// </summary>
        zr350 = 477,
        /// <summary>
        /// Maverick
        /// </summary>
        vc_maverick = 4770,
        /// <summary>
        /// Skimmer
        /// </summary>
        vc_skimmer = 4772,
        /// <summary>
        /// FBI Rancher
        /// </summary>
        vc_fbiranch = 4774,
        /// <summary>
        /// Stepfather
        /// </summary>
        bw_stepfather = 4775,
        /// <summary>
        /// Escape
        /// </summary>
        lc_escape = 4776,
        /// <summary>
        /// Coach
        /// </summary>
        lc_coach = 4777,
        /// <summary>
        /// Enforcer
        /// </summary>
        ul_enforcer = 4779,
        /// <summary>
        /// Walton
        /// </summary>
        walton = 478,
        /// <summary>
        /// Police
        /// </summary>
        ul_copcarul = 4780,
        /// <summary>
        /// Police Maverick
        /// </summary>
        lcs_polmav = 4781,
        /// <summary>
        /// Bloodring Banger
        /// </summary>
        vc_bloodrb = 4782,
        /// <summary>
        /// Roamer
        /// </summary>
        cc_copbike = 4783,
        /// <summary>
        /// Roamer
        /// </summary>
        lv_copbike = 4784,
        /// <summary>
        /// Roamer
        /// </summary>
        sa_copbike = 4785,
        /// <summary>
        /// Roamer
        /// </summary>
        sf_copbike = 4786,
        /// <summary>
        /// Roamer
        /// </summary>
        sol_roamer = 4787,
        /// <summary>
        /// Ranger
        /// </summary>
        de_copcarru = 4788,
        /// <summary>
        /// Bulldozer
        /// </summary>
        vcs_bulldozer = 4789,
        /// <summary>
        /// Regina
        /// </summary>
        regina = 479,
        /// <summary>
        /// Deimos SP
        /// </summary>
        lcs_deimos = 4790,
        /// <summary>
        /// FBI Cruiser
        /// </summary>
        lcs_fbicar = 4791,
        /// <summary>
        /// News Chopper
        /// </summary>
        at_atnmav = 4792,
        /// <summary>
        /// News Chopper
        /// </summary>
        bw_bwnmav = 4793,
        /// <summary>
        /// News Chopper
        /// </summary>
        cc_ccnmav = 4794,
        /// <summary>
        /// News Chopper
        /// </summary>
        cm_cmnmav = 4795,
        /// <summary>
        /// News Escape
        /// </summary>
        lc_lcnesc = 4796,
        /// <summary>
        /// News Chopper
        /// </summary>
        mll_mllnmav = 4797,
        /// <summary>
        /// Tommy
        /// </summary>
        lcs_tommy = 4799,
        /// <summary>
        /// Comet
        /// </summary>
        comet = 480,
        /// <summary>
        /// Domestic
        /// </summary>
        bw_domestic = 4800,
        /// <summary>
        /// Walton
        /// </summary>
        ul_walton = 4802,
        /// <summary>
        /// Premier Racer
        /// </summary>
        ug_stanier_r = 4803,
        /// <summary>
        /// Sentinel Racer
        /// </summary>
        ug_sentinel_r = 4804,
        /// <summary>
        /// BMX
        /// </summary>
        bmx = 481,
        /// <summary>
        /// Burrito
        /// </summary>
        burrito = 482,
        /// <summary>
        /// Camper
        /// </summary>
        camper = 483,
        /// <summary>
        /// Marquis
        /// </summary>
        marquis = 484,
        /// <summary>
        /// Baggage
        /// </summary>
        baggage = 485,
        /// <summary>
        /// Dozer
        /// </summary>
        dozer = 486,
        /// <summary>
        /// Maverick
        /// </summary>
        maverick = 487,
        /// <summary>
        /// News Chopper
        /// </summary>
        vcnmav = 488,
        /// <summary>
        /// Rancher
        /// </summary>
        rancher = 489,
        /// <summary>
        /// FBI Rancher
        /// </summary>
        fbiranch = 490,
        /// <summary>
        /// Virgo
        /// </summary>
        virgo = 491,
        /// <summary>
        /// Greenwood
        /// </summary>
        greenwoo = 492,
        /// <summary>
        /// Jetmax
        /// </summary>
        jetmax = 493,
        /// <summary>
        /// Hotring Racer
        /// </summary>
        hotring = 494,
        /// <summary>
        /// Sandking
        /// </summary>
        sandking = 495,
        /// <summary>
        /// Blista Compact
        /// </summary>
        blistac = 496,
        /// <summary>
        /// Police Maverick
        /// </summary>
        polmav = 497,
        /// <summary>
        /// Boxville
        /// </summary>
        boxville = 498,
        /// <summary>
        /// Benson
        /// </summary>
        benson = 499,
        /// <summary>
        /// Mesa
        /// </summary>
        mesa = 500,
        /// <summary>
        /// RC Goblin
        /// </summary>
        rcgoblin = 501,
        /// <summary>
        /// Hotring Racer
        /// </summary>
        hotrina = 502,
        /// <summary>
        /// Hotring Racer
        /// </summary>
        hotrinb = 503,
        /// <summary>
        /// Bloodring Banger
        /// </summary>
        bloodra = 504,
        /// <summary>
        /// Rancher
        /// </summary>
        rnchlure = 505,
        /// <summary>
        /// Super GT
        /// </summary>
        supergt = 506,
        /// <summary>
        /// Elegant
        /// </summary>
        elegant = 507,
        /// <summary>
        /// Journey
        /// </summary>
        journey = 508,
        /// <summary>
        /// Bike
        /// </summary>
        bike = 509,
        /// <summary>
        /// Socialite
        /// </summary>
        ug_socialite = 5090,
        /// <summary>
        /// Socialite
        /// </summary>
        vc_socialite = 5091,
        /// <summary>
        /// Socialite
        /// </summary>
        lc_socialite = 5092,
        /// <summary>
        /// Dashhound
        /// </summary>
        dash = 5094,
        /// <summary>
        /// Bloodhound Maverick
        /// </summary>
        cm_armymav = 5099,
        /// <summary>
        /// Mountain Bike
        /// </summary>
        mtbike = 510,
        /// <summary>
        /// Police Maverick
        /// </summary>
        vc_polmav = 5100,
        /// <summary>
        /// Police Escape
        /// </summary>
        lc_polesc = 5101,
        /// <summary>
        /// Beagle
        /// </summary>
        beagle = 511,
        /// <summary>
        /// Cropduster
        /// </summary>
        cropdust = 512,
        /// <summary>
        /// Stuntplane
        /// </summary>
        stunt = 513,
        /// <summary>
        /// Tanker
        /// </summary>
        petro = 514,
        /// <summary>
        /// Roadtrain
        /// </summary>
        rdtrain = 515,
        /// <summary>
        /// Nebula
        /// </summary>
        nebula = 516,
        /// <summary>
        /// Majestic
        /// </summary>
        majestic = 517,
        /// <summary>
        /// Buccaneer
        /// </summary>
        buccanee = 518,
        /// <summary>
        /// Shamal
        /// </summary>
        shamal = 519,
        /// <summary>
        /// Hydra
        /// </summary>
        hydra = 520,
        /// <summary>
        /// FCR-900
        /// </summary>
        fcr900 = 521,
        /// <summary>
        /// NRG-500
        /// </summary>
        nrg500 = 522,
        /// <summary>
        /// HPV1000
        /// </summary>
        copbike = 523,
        /// <summary>
        /// Cement Truck
        /// </summary>
        cement = 524,
        /// <summary>
        /// Towtruck
        /// </summary>
        towtruck = 525,
        /// <summary>
        /// Fortune
        /// </summary>
        fortune = 526,
        /// <summary>
        /// Cadrona
        /// </summary>
        cadrona = 527,
        /// <summary>
        /// FBI Truck
        /// </summary>
        fbitruck = 528,
        /// <summary>
        /// Willard
        /// </summary>
        willard = 529,
        /// <summary>
        /// Forklift
        /// </summary>
        forklift = 530,
        /// <summary>
        /// Tractor
        /// </summary>
        tractor = 531,
        /// <summary>
        /// Combine Harvester
        /// </summary>
        combine = 532,
        /// <summary>
        /// Feltzer
        /// </summary>
        feltzer = 533,
        /// <summary>
        /// Remington
        /// </summary>
        remingtn = 534,
        /// <summary>
        /// Slamvan
        /// </summary>
        slamvan = 535,
        /// <summary>
        /// Blade
        /// </summary>
        blade = 536,
        /// <summary>
        /// Freight
        /// </summary>
        freight = 537,
        /// <summary>
        /// Brown Streak
        /// </summary>
        streak = 538,
        /// <summary>
        /// Vortex
        /// </summary>
        vortex = 539,
        /// <summary>
        /// Vincent
        /// </summary>
        vincent = 540,
        /// <summary>
        /// Bullet
        /// </summary>
        bullet = 541,
        /// <summary>
        /// Clover
        /// </summary>
        clover = 542,
        /// <summary>
        /// Sadler
        /// </summary>
        sadler = 543,
        /// <summary>
        /// Fire Truck
        /// </summary>
        firela = 544,
        /// <summary>
        /// Hustler
        /// </summary>
        hustler = 545,
        /// <summary>
        /// Intruder
        /// </summary>
        intruder = 546,
        /// <summary>
        /// Primo
        /// </summary>
        primo = 547,
        /// <summary>
        /// Cargobob
        /// </summary>
        cargobob = 548,
        /// <summary>
        /// Tampa
        /// </summary>
        tampa = 549,
        /// <summary>
        /// Sunrise
        /// </summary>
        sunrise = 550,
        /// <summary>
        /// Merit
        /// </summary>
        merit = 551,
        /// <summary>
        /// Utility Van
        /// </summary>
        utility = 552,
        /// <summary>
        /// Nevada
        /// </summary>
        nevada = 553,
        /// <summary>
        /// Yosemite
        /// </summary>
        yosemite = 554,
        /// <summary>
        /// Windsor
        /// </summary>
        windsor = 555,
        /// <summary>
        /// Monster
        /// </summary>
        monstera = 556,
        /// <summary>
        /// Monster
        /// </summary>
        monsterb = 557,
        /// <summary>
        /// Uranus
        /// </summary>
        uranus = 558,
        /// <summary>
        /// Jester
        /// </summary>
        jester = 559,
        /// <summary>
        /// Sultan
        /// </summary>
        sultan = 560,
        /// <summary>
        /// Stratum
        /// </summary>
        stratum = 561,
        /// <summary>
        /// Elegy
        /// </summary>
        elegy = 562,
        /// <summary>
        /// Raindance
        /// </summary>
        raindanc = 563,
        /// <summary>
        /// RC Tiger
        /// </summary>
        rctiger = 564,
        /// <summary>
        /// Flash
        /// </summary>
        flash = 565,
        /// <summary>
        /// Tahoma
        /// </summary>
        tahoma = 566,
        /// <summary>
        /// Savanna
        /// </summary>
        savanna = 567,
        /// <summary>
        /// Bandito
        /// </summary>
        bandito = 568,
        /// <summary>
        /// Freight
        /// </summary>
        freiflat = 569,
        /// <summary>
        /// Ambulance
        /// </summary>
        vc_ambulan = 5690,
        /// <summary>
        /// Dukes
        /// </summary>
        dukes = 5693,
        /// <summary>
        /// News Chopper
        /// </summary>
        vc_vcnmav = 5694,
        /// <summary>
        /// Newsvan
        /// </summary>
        vc_vcnvan = 5695,
        /// <summary>
        /// Police Maverick
        /// </summary>
        cm_polmav = 5696,
        /// <summary>
        /// Brown Streak
        /// </summary>
        streakc = 570,
        /// <summary>
        /// Police
        /// </summary>
        cc_copcarcc = 5701,
        /// <summary>
        /// Police
        /// </summary>
        cm_copcarcm = 5702,
        /// <summary>
        /// Kart
        /// </summary>
        kart = 571,
        /// <summary>
        /// Mower
        /// </summary>
        mower = 572,
        /// <summary>
        /// Dune
        /// </summary>
        duneride = 573,
        /// <summary>
        /// Sweeper
        /// </summary>
        sweeper = 574,
        /// <summary>
        /// Broadway
        /// </summary>
        broadway = 575,
        /// <summary>
        /// Tornado
        /// </summary>
        tornado = 576,
        /// <summary>
        /// AT-400
        /// </summary>
        at400 = 577,
        /// <summary>
        /// DFT-30
        /// </summary>
        dft30 = 578,
        /// <summary>
        /// Huntley
        /// </summary>
        huntley = 579,
        /// <summary>
        /// Stafford
        /// </summary>
        stafford = 580,
        /// <summary>
        /// BF-400
        /// </summary>
        bf400 = 581,
        /// <summary>
        /// Newsvan
        /// </summary>
        newsvan = 582,
        /// <summary>
        /// Tug
        /// </summary>
        tug = 583,
        /// <summary>
        /// Petrol Truck
        /// </summary>
        petrotr = 584,
        /// <summary>
        /// Emperor
        /// </summary>
        emperor = 585,
        /// <summary>
        /// Wayfarer
        /// </summary>
        wayfarer = 586,
        /// <summary>
        /// Euros
        /// </summary>
        euros = 587,
        /// <summary>
        /// Hotdog
        /// </summary>
        hotdog = 588,
        /// <summary>
        /// Club
        /// </summary>
        club = 589,
        /// <summary>
        /// Freibox
        /// </summary>
        freibox = 590,
        /// <summary>
        /// Articulated Trailer 3
        /// </summary>
        artict3 = 591,
        /// <summary>
        /// Andromada
        /// </summary>
        androm = 592,
        /// <summary>
        /// Dodo
        /// </summary>
        dodo = 593,
        /// <summary>
        /// RC Cam
        /// </summary>
        rccam = 594,
        /// <summary>
        /// Launch
        /// </summary>
        launch = 595,
        /// <summary>
        /// Police
        /// </summary>
        copcarla = 596,
        /// <summary>
        /// Police
        /// </summary>
        copcarsf = 597,
        /// <summary>
        /// Police
        /// </summary>
        copcarvg = 598,
        /// <summary>
        /// Ranger
        /// </summary>
        copcarru = 599,
        /// <summary>
        /// Picador
        /// </summary>
        picador = 600,
        /// <summary>
        /// S.W.A.T.
        /// </summary>
        swatvan = 601,
        /// <summary>
        /// Alpha
        /// </summary>
        alpha = 602,
        /// <summary>
        /// Enforcer
        /// </summary>
        vc_enforcer = 6027,
        /// <summary>
        /// Enforcer
        /// </summary>
        lc_enforcer = 6028,
        /// <summary>
        /// Enforcer
        /// </summary>
        cc_enforcer = 6029,
        /// <summary>
        /// Phoenix
        /// </summary>
        phoenix = 603,
        /// <summary>
        /// Enforcer
        /// </summary>
        cm_enforcer = 6030,
        /// <summary>
        /// Glendale
        /// </summary>
        glenshit = 604,
        /// <summary>
        /// Sadler
        /// </summary>
        sadlshit = 605,
        /// <summary>
        /// Baggage Box A
        /// </summary>
        bagboxa = 606,
        /// <summary>
        /// Baggage Box B
        /// </summary>
        bagboxb = 607,
        /// <summary>
        /// Tugstair
        /// </summary>
        tugstair = 608,
        /// <summary>
        /// Boxville
        /// </summary>
        boxburg = 609,
        /// <summary>
        /// Farm Trailer
        /// </summary>
        farmtr1 = 610,
        /// <summary>
        /// Utility Trailer
        /// </summary>
        utiltr1 = 611,
        /// <summary>
        /// Gang Burrito
        /// </summary>
        vc_gangbur = 612,
        /// <summary>
        /// Belly Up
        /// </summary>
        lc_bellyup = 613,
        /// <summary>
        /// Hoods Rumpo XL
        /// </summary>
        lc_hoods = 614,
        /// <summary>
        /// Sultan RS
        /// </summary>
        mw_sultanrs = 6258,
        /// <summary>
        /// Huntley S
        /// </summary>
        ug_huntleys = 6262,
        /// <summary>
        /// Police Interceptor
        /// </summary>
        vc_polinter = 6263,
        /// <summary>
        /// Regina
        /// </summary>
        cc_regina = 6266,
        /// <summary>
        /// Bobcat XL
        /// </summary>
        ug_bobcatxl = 6268,
        /// <summary>
        /// Warthog
        /// </summary>
        mw_warthog = 6269,
        /// <summary>
        /// Falcon
        /// </summary>
        mw_falcon = 6270,
        /// <summary>
        /// Mjolnir
        /// </summary>
        mw_mjolnir = 6271,
        /// <summary>
        /// Airtrain
        /// </summary>
        vcs_airtrain = 6272,
        /// <summary>
        /// Hako
        /// </summary>
        mw_hako = 6273,
        /// <summary>
        /// Defender
        /// </summary>
        mw_defend = 6274,
        /// <summary>
        /// Lil Monster
        /// </summary>
        lc_monster = 6526,
        /// <summary>
        /// Banshee
        /// </summary>
        vc_banshee = 6528,
        /// <summary>
        /// Panlantic
        /// </summary>
        lc_panlant = 6529,
        /// <summary>
        /// Hellenbach GT
        /// </summary>
        lcs_hellenbach = 6530,
        /// <summary>
        /// Cholo Sabre
        /// </summary>
        vc_cholo = 6532,
        /// <summary>
        /// Vulture
        /// </summary>
        ug_vulture = 6538,
        /// <summary>
        /// Subway
        /// </summary>
        lc_trainf = 6550,
        /// <summary>
        /// Violator
        /// </summary>
        vc_scarab = 6551,
        /// <summary>
        /// Bobcat
        /// </summary>
        lc_bobcat = 6552,
        /// <summary>
        /// Ambulance
        /// </summary>
        lc_ambulan = 6553,
        /// <summary>
        /// Banshee
        /// </summary>
        lc_banshee = 6554,
        /// <summary>
        /// Barracks OL
        /// </summary>
        lc_barracks = 6555,
        /// <summary>
        /// Bus
        /// </summary>
        lc_bus = 6556,
        /// <summary>
        /// Cabbie
        /// </summary>
        lc_cabbie = 6557,
        /// <summary>
        /// Cheetah
        /// </summary>
        lc_cheetah = 6558,
        /// <summary>
        /// Esperanto
        /// </summary>
        lc_esperant = 6559,
        /// <summary>
        /// Flatbed
        /// </summary>
        lc_flatbed = 6560,
        /// <summary>
        /// Infernus
        /// </summary>
        lc_infernus = 6561,
        /// <summary>
        /// Linerunner
        /// </summary>
        lc_linerun = 6563,
        /// <summary>
        /// Moonbeam
        /// </summary>
        lc_moonbeam = 6566,
        /// <summary>
        /// Mr. Whoopee
        /// </summary>
        lc_mrwhoop = 6567,
        /// <summary>
        /// Mule
        /// </summary>
        lc_mule = 6568,
        /// <summary>
        /// Patriot
        /// </summary>
        lc_patriot = 6569,
        /// <summary>
        /// Pony
        /// </summary>
        lc_pony = 6571,
        /// <summary>
        /// Rhino
        /// </summary>
        lc_rhino = 6572,
        /// <summary>
        /// Securicar
        /// </summary>
        lc_securica = 6573,
        /// <summary>
        /// Stallion
        /// </summary>
        lc_stallion = 6574,
        /// <summary>
        /// Stretch
        /// </summary>
        lc_stretch = 6575,
        /// <summary>
        /// Trashmaster
        /// </summary>
        lc_trash = 6576,
        /// <summary>
        /// Yankee
        /// </summary>
        lc_yankee = 6577,
        /// <summary>
        /// Admiral
        /// </summary>
        vc_admiral = 6578,
        /// <summary>
        /// Baggage
        /// </summary>
        vc_baggage = 6581,
        /// <summary>
        /// Benson
        /// </summary>
        vc_benson = 6584,
        /// <summary>
        /// BF Injection
        /// </summary>
        vc_bfinject = 6585,
        /// <summary>
        /// Bloodring Banger
        /// </summary>
        vc_bloodra = 6587,
        /// <summary>
        /// Bobcat
        /// </summary>
        vc_bobcat = 6588,
        /// <summary>
        /// Boxville
        /// </summary>
        vc_boxville = 6589,
        /// <summary>
        /// Burrito
        /// </summary>
        vc_burrito = 6590,
        /// <summary>
        /// Bus
        /// </summary>
        vc_bus = 6591,
        /// <summary>
        /// Cabbie
        /// </summary>
        vc_cabbie = 6592,
        /// <summary>
        /// Caddy
        /// </summary>
        vc_caddy = 6593,
        /// <summary>
        /// Cheetah
        /// </summary>
        vc_cheetah = 6594,
        /// <summary>
        /// Comet
        /// </summary>
        vc_comet = 6595,
        /// <summary>
        /// Esperanto
        /// </summary>
        vc_esperant = 6599,
        /// <summary>
        /// Faggio
        /// </summary>
        vc_faggio = 6600,
        /// <summary>
        /// Fire Truck
        /// </summary>
        vc_firetruk = 6603,
        /// <summary>
        /// Flatbed
        /// </summary>
        vc_flatbed = 6604,
        /// <summary>
        /// Freeway
        /// </summary>
        vc_freeway = 6605,
        /// <summary>
        /// Greenwood Racer
        /// </summary>
        ug_greenwoo_r = 6607,
        /// <summary>
        /// Glendale
        /// </summary>
        vc_glendale = 6608,
        /// <summary>
        /// Greenwood
        /// </summary>
        vc_greenwoo = 6609,
        /// <summary>
        /// Hermes
        /// </summary>
        vc_hermes = 6610,
        /// <summary>
        /// Hotring Racer
        /// </summary>
        vc_hotrina = 6611,
        /// <summary>
        /// Hotring Racer
        /// </summary>
        vc_hotrinb = 6612,
        /// <summary>
        /// Hotring Racer
        /// </summary>
        vc_hotring = 6613,
        /// <summary>
        /// Infernus
        /// </summary>
        vc_infernus = 6615,
        /// <summary>
        /// Landstalker
        /// </summary>
        vc_landstal = 6617,
        /// <summary>
        /// Linerunner
        /// </summary>
        vc_linerun = 6618,
        /// <summary>
        /// Yardie Lobo
        /// </summary>
        lc_yardie = 662,
        /// <summary>
        /// Manana
        /// </summary>
        vc_manana = 6620,
        /// <summary>
        /// Mesa
        /// </summary>
        vc_mesa = 6621,
        /// <summary>
        /// Mr. Whoopee
        /// </summary>
        vc_mrwhoop = 6623,
        /// <summary>
        /// Mule
        /// </summary>
        vc_mule = 6624,
        /// <summary>
        /// Oceanic
        /// </summary>
        vc_oceanic = 6626,
        /// <summary>
        /// Packer
        /// </summary>
        vc_packer = 6627,
        /// <summary>
        /// Patriot
        /// </summary>
        vc_patriot = 6628,
        /// <summary>
        /// PCJ-600
        /// </summary>
        vc_pcj600 = 6629,
        /// <summary>
        /// Cartel Cruiser
        /// </summary>
        lc_columb = 663,
        /// <summary>
        /// Perennial
        /// </summary>
        vc_peren = 6630,
        /// <summary>
        /// Phoenix
        /// </summary>
        vc_phoenix = 6631,
        /// <summary>
        /// Pizzaboy
        /// </summary>
        vc_pizzaboy = 6632,
        /// <summary>
        /// Pony
        /// </summary>
        vc_pony = 6634,
        /// <summary>
        /// Rancher
        /// </summary>
        vc_rancher = 6635,
        /// <summary>
        /// Regina
        /// </summary>
        vc_regina = 6636,
        /// <summary>
        /// Rumpo
        /// </summary>
        vc_rumpo = 6637,
        /// <summary>
        /// Sabre
        /// </summary>
        vc_sabre = 6638,
        /// <summary>
        /// Sanchez
        /// </summary>
        vc_sanchez = 6640,
        /// <summary>
        /// Sandking
        /// </summary>
        vc_sandking = 6641,
        /// <summary>
        /// Sentinel
        /// </summary>
        vc_sentinel = 6643,
        /// <summary>
        /// Stallion
        /// </summary>
        vc_stallion = 6646,
        /// <summary>
        /// Stretch
        /// </summary>
        vc_stretch = 6648,
        /// <summary>
        /// Taxi
        /// </summary>
        vc_taxi = 6649,
        /// <summary>
        /// Mafia Sentinel
        /// </summary>
        lc_mafia = 665,
        /// <summary>
        /// Top Fun
        /// </summary>
        vc_topfun = 6650,
        /// <summary>
        /// Trashmaster
        /// </summary>
        vc_trash = 6651,
        /// <summary>
        /// Virgo
        /// </summary>
        vc_virgo = 6652,
        /// <summary>
        /// Voodoo
        /// </summary>
        vc_voodoo = 6653,
        /// <summary>
        /// Walton
        /// </summary>
        vc_walton = 6654,
        /// <summary>
        /// Washington
        /// </summary>
        vc_washing = 6655,
        /// <summary>
        /// Yankee
        /// </summary>
        vc_yankee = 6656,
        /// <summary>
        /// Splitz-6 ATV
        /// </summary>
        vc_atv600 = 6657,
        /// <summary>
        /// V8 Ghost
        /// </summary>
        lcs_v8ghost = 6658,
        /// <summary>
        /// Taxi
        /// </summary>
        lc_taxi = 6659,
        /// <summary>
        /// Mr Wong
        /// </summary>
        lc_mrwong = 666,
        /// <summary>
        /// Thunder Rodd
        /// </summary>
        lc_thunder = 6660,
        /// <summary>
        /// Phobos VT
        /// </summary>
        lc_phobos = 6661,
        /// <summary>
        /// Fire Truck
        /// </summary>
        lc_firetruk = 6662,
        /// <summary>
        /// Little Willie
        /// </summary>
        vcs_litwil = 6663,
        /// <summary>
        /// Countcash
        /// </summary>
        vc_countach = 6664,
        /// <summary>
        /// Armadillo
        /// </summary>
        vc_armadillo = 6665,
        /// <summary>
        /// Air Ambulance
        /// </summary>
        vc_aamb = 6666,
        /// <summary>
        /// Predator
        /// </summary>
        lc_predator = 6667,
        /// <summary>
        /// Reefer
        /// </summary>
        lc_reefer = 6668,
        /// <summary>
        /// Rumpo
        /// </summary>
        lc_rumpo = 6669,
        /// <summary>
        /// FBI Washington
        /// </summary>
        vc_fbicar = 667,
        /// <summary>
        /// Sentinel
        /// </summary>
        lc_sentinel = 6670,
        /// <summary>
        /// Speeder
        /// </summary>
        lc_speeder = 6671,
        /// <summary>
        /// Stinger
        /// </summary>
        lc_stinger = 6672,
        /// <summary>
        /// BF Injection
        /// </summary>
        lc_bfinject = 6673,
        /// <summary>
        /// Dodo
        /// </summary>
        lc_dodo = 6674,
        /// <summary>
        /// FBI Kuruma
        /// </summary>
        lc_fbicar = 6675,
        /// <summary>
        /// BMX
        /// </summary>
        vcs_bmxboy = 6677,
        /// <summary>
        /// BMX
        /// </summary>
        vcs_bmxgirl = 6678,
        /// <summary>
        /// Viper
        /// </summary>
        ug_viper = 6679,
        /// <summary>
        /// Diablo Stallion
        /// </summary>
        lc_diablos = 668,
        /// <summary>
        /// Ambulance
        /// </summary>
        at_ambulan = 6684,
        /// <summary>
        /// Police
        /// </summary>
        mw_copcarmw1 = 6685,
        /// <summary>
        /// Posher
        /// </summary>
        sol_posher = 6686,
        /// <summary>
        /// Marshall
        /// </summary>
        sol_clovmon = 6687,
        /// <summary>
        /// Ambulance
        /// </summary>
        mw_ambulan = 6688,
        /// <summary>
        /// Fire Truck
        /// </summary>
        at_firetruk = 6689,
        /// <summary>
        /// Fire Truck
        /// </summary>
        mw_firetruk = 6690,
        /// <summary>
        /// Schoolbus
        /// </summary>
        bw_bus = 6691,
        /// <summary>
        /// Dozer
        /// </summary>
        bw_dozer = 6692,
        /// <summary>
        /// Forklift
        /// </summary>
        bw_forklift = 6693,
        /// <summary>
        /// Luton
        /// </summary>
        cc_luton = 6694,
        /// <summary>
        /// Triads Mule
        /// </summary>
        lc_triads = 6695,
        /// <summary>
        /// Airtrain
        /// </summary>
        lcs_airtrain = 6696,
        /// <summary>
        /// Police
        /// </summary>
        lcs_copcarlc = 6697,
        /// <summary>
        /// Faggio
        /// </summary>
        lcs_faggio2 = 6698,
        /// <summary>
        /// Drift Tampa
        /// </summary>
        ug_tampa = 6699,
        /// <summary>
        /// Xenon
        /// </summary>
        mw_xenon = 6700,
        /// <summary>
        /// Rebla
        /// </summary>
        mw_rebla = 6701,
        /// <summary>
        /// Daemon
        /// </summary>
        at_daemon = 6702,
        /// <summary>
        /// Police
        /// </summary>
        at_copcarat = 6703,
        /// <summary>
        /// Speedo
        /// </summary>
        cc_speedo = 6718,
        /// <summary>
        /// Ambulance
        /// </summary>
        cc_ambulan = 6719,
        /// <summary>
        /// UFO
        /// </summary>
        sol_ufo = 6720,
        /// <summary>
        /// Police
        /// </summary>
        bw_copcarbw = 6754,
        /// <summary>
        /// Ambulance
        /// </summary>
        bw_ambulan = 6757,
        /// <summary>
        /// Fire Truck
        /// </summary>
        bw_firetruk = 6758,
        /// <summary>
        /// Stanier
        /// </summary>
        vc_stanier = 6759,
        /// <summary>
        /// Stanier
        /// </summary>
        bw_stanier = 6760,
        /// <summary>
        /// Taxi
        /// </summary>
        bw_taxi = 6761,
        /// <summary>
        /// Delegate
        /// </summary>
        bw_delegate = 6762,
        /// <summary>
        /// Airmaster
        /// </summary>
        bw_airmax = 6763,
        /// <summary>
        /// Cabbie
        /// </summary>
        bw_cabbie = 6764,
        /// <summary>
        /// Coastguard
        /// </summary>
        vc_coastg = 6765,
        /// <summary>
        /// Jetmax
        /// </summary>
        vc_jetmax = 6767,
        /// <summary>
        /// Marquis
        /// </summary>
        vc_marquis = 6768,
        /// <summary>
        /// Predator
        /// </summary>
        vc_predator = 6769,
        /// <summary>
        /// Rio
        /// </summary>
        vc_rio = 6771,
        /// <summary>
        /// Speeder
        /// </summary>
        vc_speeder = 6772,
        /// <summary>
        /// Squalo
        /// </summary>
        vc_squalo = 6773,
        /// <summary>
        /// Tropic
        /// </summary>
        vc_tropic = 6774,
        /// <summary>
        /// AT-400
        /// </summary>
        vc_at400_1 = 6778,
        /// <summary>
        /// AT-400
        /// </summary>
        vc_at400_2 = 6779,
        /// <summary>
        /// AT-400
        /// </summary>
        vc_at400_3 = 6780,
        /// <summary>
        /// AT-200
        /// </summary>
        vc_at200a = 6781,
        /// <summary>
        /// K.U.T.T
        /// </summary>
        sol_kutt = 6782,
        /// <summary>
        /// Heavy Rescue
        /// </summary>
        sol_jamieshr = 6783,
        /// <summary>
        /// Elevator
        /// </summary>
        sol_elevator = 6784,
        /// <summary>
        /// Biplane
        /// </summary>
        vc_biplane = 6785,
        /// <summary>
        /// Bovver '64
        /// </summary>
        vc_bovver = 6786,
        /// <summary>
        /// Yola
        /// </summary>
        vc_yola = 6787,
        /// <summary>
        /// Ambassador
        /// </summary>
        vcs_speeder = 6788,
        /// <summary>
        /// Mower
        /// </summary>
        bw_mower = 6789,
        /// <summary>
        /// Towtruck
        /// </summary>
        sol_towtruck = 6790,
        /// <summary>
        /// Campaign Van
        /// </summary>
        lcs_campvan = 6793,
        /// <summary>
        /// NRG-500F
        /// </summary>
        sol_nrg500f = 6794,
        /// <summary>
        /// NRG-500RR
        /// </summary>
        sol_nrg500rr = 6795,
        /// <summary>
        /// Reagan
        /// </summary>
        bw_reagan = 6796,
        /// <summary>
        /// Clover 69
        /// </summary>
        sol_clover69 = 6797,
        /// <summary>
        /// Signum
        /// </summary>
        sol_signum = 6798,
        /// <summary>
        /// Premier
        /// </summary>
        lc_premier = 6799,
        /// <summary>
        /// Cuban Hermes
        /// </summary>
        vc_cubanh = 699,
        /// <summary>
        /// Angel
        /// </summary>
        vc_angel = 793,
        /// <summary>
        /// Deluxo
        /// </summary>
        vc_deluxo = 794,
        /// <summary>
        /// Sabre Turbo
        /// </summary>
        vc_sabretur = 795,
        /// <summary>
        /// Yakuza Stinger
        /// </summary>
        lc_yakuza = 796,
        /// <summary>
        /// Sentinel XS
        /// </summary>
        vc_sentxs = 797,
        /// <summary>
        /// Baller
        /// </summary>
        sol_baller = 7974,
        /// <summary>
        /// Zebra
        /// </summary>
        vc_zebra = 798,
        /// <summary>
        /// Blista
        /// </summary>
        lc_blista = 799,
        /// <summary>
        /// Forelli Exsess
        /// </summary>
        lcs_forellicar = 965,
        /// <summary>
        /// Kaufman Cab
        /// </summary>
        vc_kaufman = 999,
    }
}
