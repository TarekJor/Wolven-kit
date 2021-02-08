using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTppRepAttachedObjectInfo : CVariable
	{
		[Ordinal(0)]  [RED("itemID")] public TweakDBID ItemID { get; set; }
		[Ordinal(1)]  [RED("slotID")] public TweakDBID SlotID { get; set; }

		public gameTppRepAttachedObjectInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
