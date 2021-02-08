using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SDoorStateOperationData : CVariable
	{
		[Ordinal(0)]  [RED("operation")] public SBaseDeviceOperationData Operation { get; set; }
		[Ordinal(1)]  [RED("state")] public CEnum<EDoorStatus> State { get; set; }

		public SDoorStateOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
