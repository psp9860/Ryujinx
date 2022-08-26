﻿using Ryujinx.Graphics.GAL;
using System;

namespace Ryujinx.Graphics.Vulkan
{
    internal abstract class WindowBase: IWindow
    {
        public bool ScreenCaptureRequested { get; set; }

        public abstract void Dispose();
        public abstract void Present(ITexture texture, ImageCrop crop, Action<object> swapBuffersCallback);
        public abstract void SetSize(int width, int height);
        public abstract void ChangeVSyncMode(bool vsyncEnabled);

        public abstract void ApplyEffect(AntiAliasing effect);

        public abstract void ApplyScaler(UpscaleType scalerType);

        public abstract void SetUpscalerLevel(float scale);
    }
}