﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Quest_OpenXR
{
    public static class OpenXR
    {
        [StructLayout(LayoutKind.Sequential)]
        public class XrQuat
        {
            public float x;
            public float y;
            public float z;
            public float w;
        }

        [DllImport("QuestFaceTrackingOpenXR.dll")]
        internal static extern int InitOpenXRRuntime();

        [DllImport("QuestFaceTrackingOpenXR.dll")]
        internal static extern int UpdateOpenXRFaceTracker();

        [DllImport("QuestFaceTrackingOpenXR.dll")]
        internal static extern float GetCheekPuff(int cheekIndex);

        [DllImport("QuestFaceTrackingOpenXR.dll")]
        internal static extern void GetEyeOrientation(int eyeIndex, XrQuat outOrientation);

        [DllImport("QuestFaceTrackingOpenXR.dll")]
        internal static extern void GetFaceWeights([MarshalAs(UnmanagedType.LPArray, SizeConst = 63)] float[] faceExpressionFB);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        internal static extern bool SetDllDirectory(string lpPathName);
    }
    public enum FBExpression
    {
        Brow_Lowerer_L = 0,
        Brow_Lowerer_R = 1,
        Cheek_Puff_L = 2,
        Cheek_Puff_R = 3,
        Cheek_Raiser_L = 4,
        Cheek_Raiser_R = 5,
        Cheek_Suck_L = 6,
        Cheek_Suck_R = 7,
        Chin_Raiser_B = 8,
        Chin_Raiser_T = 9,
        Dimpler_L = 10,
        Dimpler_R = 11,
        Eyes_Closed_L = 12,
        Eyes_Closed_R = 13,
        Eyes_Look_Down_L = 14,
        Eyes_Look_Down_R = 15,
        Eyes_Look_Left_L = 16,
        Eyes_Look_Left_R = 17,
        Eyes_Look_Right_L = 18,
        Eyes_Look_Right_R = 19,
        Eyes_Look_Up_L = 20,
        Eyes_Look_Up_R = 21,
        Inner_Brow_Raiser_L = 22,
        Inner_Brow_Raiser_R = 23,
        Jaw_Drop = 24,
        Jaw_Sideways_Left = 25,
        Jaw_Sideways_Right = 26,
        Jaw_Thrust = 27,
        Lid_Tightener_L = 28,
        Lid_Tightener_R = 29,
        Lip_Corner_Depressor_L = 30,
        Lip_Corner_Depressor_R = 31,
        Lip_Corner_Puller_L = 32,
        Lip_Corner_Puller_R = 33,
        Lip_Funneler_LB = 34,
        Lip_Funneler_LT = 35,
        Lip_Funneler_RB = 36,
        Lip_Funneler_RT = 37,
        Lip_Pressor_L = 38,
        Lip_Pressor_R = 39,
        Lip_Pucker_L = 40,
        Lip_Pucker_R = 41,
        Lip_Stretcher_L = 42,
        Lip_Stretcher_R = 43,
        Lip_Suck_LB = 44,
        Lip_Suck_LT = 45,
        Lip_Suck_RB = 46,
        Lip_Suck_RT = 47,
        Lip_Tightener_L = 48,
        Lip_Tightener_R = 49,
        Lips_Toward = 50,
        Lower_Lip_Depressor_L = 51,
        Lower_Lip_Depressor_R = 52,
        Mouth_Left = 53,
        Mouth_Right = 54,
        Nose_Wrinkler_L = 55,
        Nose_Wrinkler_R = 56,
        Outer_Brow_Raiser_L = 57,
        Outer_Brow_Raiser_R = 58,
        Upper_Lid_Raiser_L = 59,
        Upper_Lid_Raiser_R = 60,
        Upper_Lip_Raiser_L = 61,
        Upper_Lip_Raiser_R = 62,
        Max = 63
    }
}
