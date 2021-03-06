﻿using VaultLib.Core.Types;

namespace VaultLib.Frameworks.Speed.NIS
{
    [VLTTypeInfo("NIS::ePIPTrigger")]
    public enum ePIPTrigger
    {
        NONE = 0x0,
        PLAYER_HIT_BOSS = 0x1,
        PLAYER_HIT_RIVAL = 0x2,
        PLAYER_CRASHES = 0x3,
        PLAYER_NEAR_FINISH = 0x4,
        PLAYER_PASS_BOSS_LEFT = 0x5,
        PLAYER_PASS_BOSS_RIGHT = 0x6,
        PLAYER_ENTER_COOLDOWN = 0x7,
        PLAYER_DRAFT_PAST_BOSS = 0x8,
        PLAYER_HIT_RACEBREAKER = 0x9,
        PLAYER_STAND_STILL = 0xA,
        BOSS_HIT_PLAYER = 0xB,
        BOSS_CRASHES = 0xC,
        BOSS_CROSS_FINISH = 0xD,
        BOSS_NEAR_FINISH = 0xE,
        BOSS_PASS_PLAYER_LEFT = 0xF,
        BOSS_PASS_PLAYER_RIGHT = 0x10,
        RIVAL_CRASHES = 0x11,
        RIVAL_CROSS_FINISH = 0x12,
        WINGMAN_HIT_RIVAL = 0x13,
        WINGMAN_CRASHES = 0x14,
        WINGMAN_PASS_RIVAL = 0x15,
        WINGMAN_NOS = 0x16,
        WINGMAN_ENTER_FIRSTPLACE = 0x17,
        WINGMAN_ENTER_LASTPLACE = 0x18,
        WINGMAN_JUMPS = 0x19,
        BLOCKER_ACTIVATE = 0x1A,
        BLOCKER_ATTACK_BEHIND = 0x1B,
        BLOCKER_ATTACK_FRONT = 0x1C,
        BLOCKER_HIT_BOSS = 0x1D,
        SCOUT_ACTIVATE = 0x1E,
        SCOUT_ENTER_SHORTCUT = 0x1F,
        DRAFTER_ACTIVATE = 0x20,
        COP_JOIN_PURSUIT = 0x21,
        CANYON_PLAYER_FALLBEHIND = 0x22,
        CANYON_PLAYER_FALLBEHIND_REPEAT = 0x23,
        CANYON_PLAYER_PULLAHEAD = 0x24,
        CANYON_BOSS_BROKE_GUARDRAIL = 0x25,
        CANYON_PLAYER_LOW_SCORE = 0x26,
        CANYON_PLAYER_LOW_SCORE_REPEAT = 0x27,
        CANYON_PLAYER_HIGH_SCORE = 0x28,
        CANYON_PLAYER_HIGH_SCORE_REPEAT = 0x29,
        CANYON_PLAYER_FAST_SCORE = 0x2A,
        CANYON_BOSS_OFF_CLIFF = 0x2B,
        TUTORIAL_IGNORED_COMMANDS = 0x2C,
        TUTORIAL_REPEAT_HIT = 0x2D,
        TUTORIAL_FAREWELL = 0x2E,
        TUTORIAL_START = 0x2F,
        NUM_PIP_TRIGGERS = 0x30,
    }
}