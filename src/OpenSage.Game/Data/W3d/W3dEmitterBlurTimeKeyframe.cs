﻿using System.IO;

namespace OpenSage.Data.W3d
{
    public sealed class W3dEmitterBlurTimeKeyframe
    {
        public float Time { get; private set; }

        public float BlurTime { get; private set; }

        internal static W3dEmitterBlurTimeKeyframe Parse(BinaryReader reader)
        {
            return new W3dEmitterBlurTimeKeyframe
            {
                Time = reader.ReadSingle(),
                BlurTime = reader.ReadSingle()
            };
        }
    }
}
