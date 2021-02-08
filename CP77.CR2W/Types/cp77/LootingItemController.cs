using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LootingItemController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("isCurrentlySelected")] public CBool IsCurrentlySelected { get; set; }
		[Ordinal(1)]  [RED("itemIcon")] public inkImageWidgetReference ItemIcon { get; set; }
		[Ordinal(2)]  [RED("itemName")] public inkTextWidgetReference ItemName { get; set; }
		[Ordinal(3)]  [RED("itemNameText")] public CHandle<inkTextWidget> ItemNameText { get; set; }
		[Ordinal(4)]  [RED("itemQualityBar")] public inkWidgetReference ItemQualityBar { get; set; }
		[Ordinal(5)]  [RED("itemQuantity")] public inkTextWidgetReference ItemQuantity { get; set; }
		[Ordinal(6)]  [RED("itemSelection")] public inkWidgetReference ItemSelection { get; set; }
		[Ordinal(7)]  [RED("itemType")] public inkTextWidgetReference ItemType { get; set; }
		[Ordinal(8)]  [RED("itemWeight")] public inkTextWidgetReference ItemWeight { get; set; }

		public LootingItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
