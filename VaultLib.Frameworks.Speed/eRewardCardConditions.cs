﻿// This file is part of VaultLib by heyitsleo.
// 
// Created: 10/09/2019 @ 9:44 AM.

using VaultLib.Core.Types;

namespace VaultLib.Frameworks.Speed
{
    [VLTTypeInfo(nameof(eRewardCardConditions))]
    public enum eRewardCardConditions
    {
        REWARD_CARD_UNSPECIFIED = -1,
        WIN_X_CAREER_RACES = 0x0,
        LOSE_X_CAREER_RACES = 0x1,
        EARN_X_DOLLARS = 0x2,
        ALL_SAFE_HOUSES = 0x3,
        WIN_X_CANYON_DUELS = 0x4,
        WIN_X_DEFENSIVE_RACES = 0x5,
        DISABLE_X_COP_CARS = 0x6,
        WIN_X_FREE_ROAM_CREW_RACES = 0x7,
        HIT_X_KPH_IN_SPEEDTRAP = 0x8,
        SELL_X_CARS = 0x9,
        UNLOCK_X_TRACKS_IN_QR = 0xA,
        AVOID_X_ROADBLOCKS = 0xB,
        GET_HEAT_LEVEL_X = 0xC,
        ESCAPE_X_COP_CHASES = 0xD,
        GET_BUSTED_BY_COP_X_TIMES = 0xE,
        AVOID_X_SPIKE_TRAPS = 0xF,
        RAM_X_COP_CARS = 0x10,
        TRIGGER_X_RACE_BREAKERS = 0x11,
        ESCAPE_COPS_IN_X_MINS = 0x12,
        COP_CHASE_AT_LEAST_X_LONG = 0x13,
        GET_X_POINTS_IN_SINGLE_DRIFT_RACE = 0x14,
        ACQUIRE_X_CARS = 0x15,
        GENERATE_X_BOUNTY_IN_SINGLE_RACE = 0x16,
        IMMOBILIZE_RHINO = 0x17,
        BEAT_X_CHALLENGES = 0x18,
        BEAT_ALL_BRONZE_CHALLENGES = 0x19,
        BEAT_ALL_SILVER_CHALLENGES = 0x1A,
        BEAT_ALL_GOLD_CHALLENGES = 0x1B,
        WIN_X_FREE_ROAM_POINT_TO_POINT = 0x1C,
        BEAT_ALL_CHALLENGES = 0x1D,
        UNLOCK_X_CARS = 0x1E,
        FILL_SAFEHOUSE = 0x1F,
        FILL_SAFEHOUSE_WITH_MUSCLE = 0x20,
        FILL_SAFEHOUSE_WITH_TUNER = 0x21,
        FILL_SAFEHOUSE_WITH_EXOTIC = 0x22,
        PLAY_X_QUICKRACES = 0x23,
        TURN_DOWN_X_CREW_CHALLENGES = 0x24,
        GET_X_REP = 0x25,
        PLAY_X_MULTI_PLAYER_QUICKRACE = 0x26,
        MODIFY_CAR_WITH_AUTOSCUPLT = 0x27,
        PLAY_X_SPRINT_RACES = 0x28,
        PLAY_X_CIRCUIT_RACES = 0x29,
        PLAY_X_CANYON_DUELS = 0x2A,
        COMMIT_X_INFRACTIONS_IN_SINGLE_RACE = 0x2B,
        HIRE_X_CREW_MEMBERS = 0x2C,
        USE_SPEED_BREAKER = 0x2D,
        ACCUMULATE_X_FINES = 0x2E,
        WIN_X_DRIFT_RACES = 0x2F,
        ACCUMULATE_X_COST_TO_STATE = 0x30,
        CONQUER_AREA_X_COMPLETELY = 0x31,
        BEAT_THE_CAREER_MODE = 0x32,
        BEAT_100_PERCENT_OF_CAREER = 0x33,
        SHOW_BOATING = 0x34,
        HEADSTART = 0x35,
        PERFECT_CANYON_DUEL = 0x36,
        ONLINE_PLAYED_8_PLAYER_GAME = 0x37,
        ONLINE_WON_8_PLAYER = 0x38,
        ONLINE_SENT_PHOTO = 0x39,
        ONLINE_CROSSED_FINISHLINE_REVERSE = 0x3A,
        ONLINE_DOWNLOADED_GHOST = 0x3B,
        NUM_OFFLINE_REWARD_COND = 0x3C,
        ONLINE_REP_LEVEL_X = 0x3D,
        ONLINE_WINNING_STREAK_RANKED_SOLO = 0x3E,
        ONLINE_PLAYED_X_GAMES = 0x3F,
        ONLINE_WON_X_CAF_AS_HELPER = 0x40,
        ONLINE_BEAT_X_CHALLENGE = 0x41,
        ONLINE_WON_X_CAF_IN_YOUR_CAREER = 0x42,
        ONLINE_WON_X_CIRCUIT_RACES = 0x43,
        ONLINE_WON_X_SPEEDTRAP_RACES = 0x44,
        ONLINE_WON_X_CAYNON_RACES = 0x45,
        ONLINE_WON_X_SPRINT_RACES = 0x46,
        ONLINE_WON_X_PURSIT_KOCKOUT_RACES = 0x47,
        ONLINE_WON_X_PURSUIT_TAGS = 0x48,
        ONLINE_WON_MODERATOR_CHALLENGE = 0x49,
        NUM_REWARD_CARD_CONDITIONS = 0x4A,
        NUM_ONLINE_REWARD_COND = 0xE,
    }
}