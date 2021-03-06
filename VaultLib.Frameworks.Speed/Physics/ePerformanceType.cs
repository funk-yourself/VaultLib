﻿using VaultLib.Core.Types;

namespace VaultLib.Frameworks.Speed.Physics
{
    [VLTTypeInfo("Physics::ePerformanceType")]
    public enum ePerformanceType
    {
        PERFORMANCE_SIMPLE_TIME_0_TO_100_MPH = 0x0,
        PERFORMANCE_SIMPLE_TIME_0_TO_60_MPH = 0x1,
        PERFORMANCE_SIMPLE_TIME_70_TO_150_MPH = 0x2,
        PERFORMANCE_SIMPLE_TIME_100_TO_0_MPH = 0x3,
        PERFORMANCE_SIMPLE_TIME_60_TO_0_MPH = 0x4,
        PERFORMANCE_SIMPLE_DISTANCE_60_TO_0_MPH = 0x5,
        PERFORMANCE_SIMPLE_DISTANCE_100_TO_0_MPH = 0x6,
        PERFORMANCE_SIMPLE_TIME_QUARTER_MILE = 0x7,
        PERFORMANCE_SIMPLE_SPEED_QUARTER_MILE_MPH = 0x8,
        PERFORMANCE_SIMPLE_TIME_60_FEET = 0x9,
        PERFORMANCE_SIMPLE_TOPSPEED = 0xA,
        PERFORMANCE_SIMPLE_MAX_GS_30_MPH = 0xB,
        PERFORMANCE_SIMPLE_MAX_GS_60_MPH = 0xC,
        PERFORMANCE_SIMPLE_MAX_GS_100_MPH = 0xD,
        PERFORMANCE_SIMPLE_TIME_CORNER_200M_40M_300M = 0xE,
        PERFORMANCE_SIMPLE_DOWNFORCE = 0xF,
        PERFORMANCE_SIMPLE_DRAG = 0x10,
        PERFORMANCE_SIMPLE_FRONT_TOE_30_MPH = 0x11,
        PERFORMANCE_SIMPLE_FRONT_TOE_60_MPH = 0x12,
        PERFORMANCE_SIMPLE_FRONT_TOE_100_MPH = 0x13,
        PERFORMANCE_SIMPLE_CASTER = 0x14,
        PERFORMANCE_SIMPLE_FRONT_WEIGHT_BIAS = 0x15,
        PERFORMANCE_SIMPLE_EBRAKE = 0x16,
        PERFORMANCE_SIMPLE_STEERING_ALIGNMENT_TORQUE = 0x17,
        PERFORMANCE_SIMPLE_AERO_CG = 0x18,
        PERFORMANCE_SIMPLE_ROLL_CENTER = 0x19,
        PERFORMANCE_SIMPLE_SPRING_STIFFNESS = 0x1A,
        PERFORMANCE_SIMPLE_SWAYBAR_STIFFNESS = 0x1B,
        PERFORMANCE_SIMPLE_SHOCK_DIGRESSION = 0x1C,
        PERFORMANCE_SIMPLE_SHOCK_VALVING = 0x1D,
        PERFORMANCE_SIMPLE_HORSEPOWER = 0x1E,
        PERFORMANCE_SIMPLE_HORSEPOWERRPM = 0x1F,
        PERFORMANCE_SIMPLE_PEAKTORQUE = 0x20,
        PERFORMANCE_SIMPLE_PEAKTORQUERPM = 0x21,
        PERFORMANCE_SIMPLE_WEIGHT = 0x22,
        PERFORMANCE_SIMPLE_WEIGHT_TO_POWER_RATIO = 0x23,
        PERFORMANCE_COMPLEX_GRIP = 0x24,
        PERFORMANCE_COMPLEX_DRIFT = 0x25,
        PERFORMANCE_COMPLEX_DRAG = 0x26,
        PERFORMANCE_COMPLEX_WHEELIE = 0x27,
        PERFORMANCE_COMPLEX_SPEED_CHALLENGE = 0x28,
        PERFORMANCE_COMPLEX_POWER = 0x29,
        PERFORMANCE_COMPLEX_TRACTION = 0x2A,
        PERFORMANCE_COMPLEX_AERO = 0x2B,
        PERFORMANCE_COMPLEX_HANDLING = 0x2C,
        PERFORMANCE_COMPLEX_CONTROL = 0x2D,
        PERFORMANCE_COMPLEX_STABILITY = 0x2E,
        PERFORMANCE_SIMPLE_START = 0x0,
        PERFORMANCE_SIMPLE_LAST = 0x23,
        NUMBER_PERFORMANCE_SIMPLE = 0x24,
        PERFORMANCE_COMPLEX_START = 0x24,
        PERFORMANCE_COMPLEX_LAST = 0x2E,
        NUMBER_PERFORMANCE_COMPLEX = 0xB,
        PERFORMANCE_START = 0x0,
        PERFORMANCE_LAST = 0x2E,
        NUMBER_PERFORMANCE = 0x2F,
    }
}