using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleDoorOpen : ActionBool
	{
		[Ordinal(0)]  [RED("autoCloseTime")] public CFloat AutoCloseTime { get; set; }
		[Ordinal(1)]  [RED("shouldAutoClose")] public CBool ShouldAutoClose { get; set; }
		[Ordinal(2)]  [RED("slotID")] public CName SlotID { get; set; }

		public VehicleDoorOpen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
