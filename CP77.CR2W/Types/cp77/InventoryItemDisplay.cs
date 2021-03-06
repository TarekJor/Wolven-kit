using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryItemDisplay : BaseButtonView
	{
		[Ordinal(0)]  [RED("AttachementsDisplay")] public CArray<wCHandle<InventoryItemAttachmentDisplay>> AttachementsDisplay { get; set; }
		[Ordinal(1)]  [RED("BackgroundFrame")] public inkImageWidgetReference BackgroundFrame { get; set; }
		[Ordinal(2)]  [RED("BackgroundHighlight")] public inkImageWidgetReference BackgroundHighlight { get; set; }
		[Ordinal(3)]  [RED("BackgroundShape")] public inkImageWidgetReference BackgroundShape { get; set; }
		[Ordinal(4)]  [RED("DefaultCategoryIconName")] public CString DefaultCategoryIconName { get; set; }
		[Ordinal(5)]  [RED("IconFallback")] public inkImageWidgetReference IconFallback { get; set; }
		[Ordinal(6)]  [RED("IconImage")] public inkImageWidgetReference IconImage { get; set; }
		[Ordinal(7)]  [RED("IconShadowImage")] public inkImageWidgetReference IconShadowImage { get; set; }
		[Ordinal(8)]  [RED("ItemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(9)]  [RED("ModName")] public CName ModName { get; set; }
		[Ordinal(10)]  [RED("ModsRoot")] public inkCompoundWidgetReference ModsRoot { get; set; }
		[Ordinal(11)]  [RED("QuantityText")] public inkTextWidgetReference QuantityText { get; set; }
		[Ordinal(12)]  [RED("RarityRoot")] public inkWidgetReference RarityRoot { get; set; }
		[Ordinal(13)]  [RED("RarityWrapper")] public inkWidgetReference RarityWrapper { get; set; }
		[Ordinal(14)]  [RED("bigSize")] public Vector2 BigSize { get; set; }
		[Ordinal(15)]  [RED("equippedIcon")] public inkWidgetReference EquippedIcon { get; set; }
		[Ordinal(16)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(17)]  [RED("smallSize")] public Vector2 SmallSize { get; set; }
		[Ordinal(18)]  [RED("toggleHighlight")] public inkWidgetReference ToggleHighlight { get; set; }

		public InventoryItemDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
