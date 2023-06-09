﻿namespace HexaEngine.DirectXTex.Tests
{
    public unsafe class WICUtilities
    {
        [Test]
        public void GetWICCodec()
        {
            var ptr = DirectXTex.GetWICCodec(WICCodecs.WicCodecPng);
            if (ptr == null)
            {
                Assert.Fail("Ptr is null");
            }
        }

        [Test]
        public void GetSetWICTestory()
        {
            bool isWIC2;
            var factory = DirectXTex.GetWICFactory(&isWIC2);
            DirectXTex.SetWICFactory(factory);
        }
    }
}