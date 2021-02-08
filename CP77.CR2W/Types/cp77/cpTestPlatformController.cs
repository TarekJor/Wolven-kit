using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class cpTestPlatformController : gameObject
	{
		[Ordinal(0)]  [RED("platform")] public NodeRef Platform { get; set; }
		[Ordinal(1)]  [RED("pointA")] public NodeRef PointA { get; set; }
		[Ordinal(2)]  [RED("pointB")] public NodeRef PointB { get; set; }
		[Ordinal(3)]  [RED("speed")] public CFloat Speed { get; set; }

		public cpTestPlatformController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
