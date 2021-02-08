using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipIconModule : ItemTooltipModuleController
	{
		[Ordinal(0)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(1)]  [RED("iconicLines")] public inkImageWidgetReference IconicLines { get; set; }
		[Ordinal(2)]  [RED("iconsNameResolver")] public CHandle<gameuiIconsNameResolver> IconsNameResolver { get; set; }

		public ItemTooltipIconModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
