using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ToggleGlassTint : ActionBool
	{
		[Ordinal(0)]  [RED("FalseRecord")] public CString FalseRecord { get; set; }
		[Ordinal(1)]  [RED("TrueRecord")] public CString TrueRecord { get; set; }

		public ToggleGlassTint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
