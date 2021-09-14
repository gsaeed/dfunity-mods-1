using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.MagicAndEffects;

namespace Assets.Scripts.Game.MacadaynuMods.HotkeyBar
{
    public class Hotkey
    {
        //public int Id { get; set; }

        public DaggerfallUnityItem PrimaryItem { get; set; }

        public HotkeyType Type { get; set; }

        public EffectBundleSettings Spell { get; set; }

        public int? TemplateId { get; set; }
    }
}