using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIMoveRotateToCommandHandler : AICommandHandlerBase
	{
		[Ordinal(0)]  [RED("angleOffset")] public CHandle<AIArgumentMapping> AngleOffset { get; set; }
		[Ordinal(1)]  [RED("angleTolerance")] public CHandle<AIArgumentMapping> AngleTolerance { get; set; }
		[Ordinal(2)]  [RED("speed")] public CHandle<AIArgumentMapping> Speed { get; set; }
		[Ordinal(3)]  [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }

		public AIMoveRotateToCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
