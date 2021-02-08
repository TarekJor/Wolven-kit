using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ToggleActivate : ActionBool
	{
		[Ordinal(0)]  [RED("FalseRecordName")] public CString FalseRecordName { get; set; }
		[Ordinal(1)]  [RED("TrueRecordName")] public CString TrueRecordName { get; set; }

		public ToggleActivate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
