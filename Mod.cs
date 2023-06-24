using PulsarModLoader;

namespace Win_by_default
{
    public class Mod : PulsarMod
    {
        public override string Version => "0.0.0";

        public override string Author => "18107";

        public override string ShortDescription => "You win the race immediately if all other ships have been destroyed.";

        public override string Name => "Win by default";

        public override string ModID => "winbydefault";

        public override string HarmonyIdentifier()
        {
            return "id107.winbydefault";
        }
    }
}
