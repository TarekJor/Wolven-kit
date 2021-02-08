using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityGate : InteractiveMasterDevice
	{
		[Ordinal(0)]  [RED("scanningArea")] public CHandle<gameStaticTriggerAreaComponent> ScanningArea { get; set; }
		[Ordinal(1)]  [RED("sideA")] public CHandle<gameStaticTriggerAreaComponent> SideA { get; set; }
		[Ordinal(2)]  [RED("sideB")] public CHandle<gameStaticTriggerAreaComponent> SideB { get; set; }
		[Ordinal(3)]  [RED("trespassersDataList")] public CArray<TrespasserEntry> TrespassersDataList { get; set; }

		public SecurityGate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
