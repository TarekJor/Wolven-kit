using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SMovementPattern : CVariable
	{
		[Ordinal(0)]  [RED("direction")] public CEnum<EMovementDirection> Direction { get; set; }
		[Ordinal(1)]  [RED("distance")] public CFloat Distance { get; set; }
		[Ordinal(2)]  [RED("speed")] public CFloat Speed { get; set; }

		public SMovementPattern(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
