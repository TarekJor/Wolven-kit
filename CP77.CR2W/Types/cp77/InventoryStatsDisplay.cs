using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryStatsDisplay : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("StatItemName")] public CName StatItemName { get; set; }
		[Ordinal(1)]  [RED("StatItems")] public CArray<wCHandle<InventoryStatItemV2>> StatItems { get; set; }
		[Ordinal(2)]  [RED("StatsRoot")] public inkCompoundWidgetReference StatsRoot { get; set; }

		public InventoryStatsDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
