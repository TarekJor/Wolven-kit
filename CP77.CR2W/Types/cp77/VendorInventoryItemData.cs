using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendorInventoryItemData : WrappedInventoryItemData
	{
		[Ordinal(0)]  [RED("IsBuybackStack")] public CBool IsBuybackStack { get; set; }
		[Ordinal(1)]  [RED("IsEnoughMoney")] public CBool IsEnoughMoney { get; set; }
		[Ordinal(2)]  [RED("IsVendorItem")] public CBool IsVendorItem { get; set; }

		public VendorInventoryItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
