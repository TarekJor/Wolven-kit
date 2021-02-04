using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayHoldEvent : redEvent
	{
		[Ordinal(0)]  [RED("actionName")] public CHandle<inkActionName> ActionName { get; set; }
		[Ordinal(1)]  [RED("itemData")] public InventoryItemData ItemData { get; set; }

		public ItemDisplayHoldEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}