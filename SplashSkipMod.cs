using MioGame;
using MioModdingApi;
using MioModLoader;
using PolyHook2.API;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace SplashSkip
{
    public class SplashSkipMod : Mod
    {
        public override unsafe void Initialize()
        {
            On.MioGame.On_Metagame.update_splashes.Prefix +=
                static (Metagame* self) => { self->splashes.done = true; };
        }
    }
}
