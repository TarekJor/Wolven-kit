using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BackpackEquipSlotChooserData : inkGameNotificationData
	{
		[Ordinal(0)]  [RED("inventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(1)]  [RED("item")] public InventoryItemData Item { get; set; }

		public BackpackEquipSlotChooserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
