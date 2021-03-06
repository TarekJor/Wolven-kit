using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipWeaponInfoModule : ItemTooltipModuleController
	{
		[Ordinal(0)]  [RED("ammoText")] public inkTextWidgetReference AmmoText { get; set; }
		[Ordinal(1)]  [RED("ammoWrapper")] public inkWidgetReference AmmoWrapper { get; set; }
		[Ordinal(2)]  [RED("arrow")] public inkImageWidgetReference Arrow { get; set; }
		[Ordinal(3)]  [RED("attacksPerSecondText")] public inkTextWidgetReference AttacksPerSecondText { get; set; }
		[Ordinal(4)]  [RED("dpsText")] public inkTextWidgetReference DpsText { get; set; }
		[Ordinal(5)]  [RED("nonLethal")] public inkTextWidgetReference NonLethal { get; set; }
		[Ordinal(6)]  [RED("perHitText")] public inkTextWidgetReference PerHitText { get; set; }
		[Ordinal(7)]  [RED("scopeIndicator")] public inkWidgetReference ScopeIndicator { get; set; }
		[Ordinal(8)]  [RED("silencerIndicator")] public inkWidgetReference SilencerIndicator { get; set; }
		[Ordinal(9)]  [RED("wrapper")] public inkWidgetReference Wrapper { get; set; }

		public ItemTooltipWeaponInfoModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
