using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TooltipSpecialAbilityList : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("container")] public inkCompoundWidgetReference Container { get; set; }
		[Ordinal(1)]  [RED("data")] public CArray<gameInventoryItemAbility> Data { get; set; }
		[Ordinal(2)]  [RED("itemsList")] public CArray<wCHandle<inkWidget>> ItemsList { get; set; }
		[Ordinal(3)]  [RED("libraryItemName")] public CName LibraryItemName { get; set; }
		[Ordinal(4)]  [RED("qualityName")] public CName QualityName { get; set; }

		public TooltipSpecialAbilityList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
