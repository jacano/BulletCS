using System;
using System.Collections.Generic;
using System.Text;

namespace BulletSharp
{
    public static class Native
    {
#if IOS
        public const string dllName = "__Internal";
#else
        public const string dllName = "bulletwrap";
#endif
    }
}
