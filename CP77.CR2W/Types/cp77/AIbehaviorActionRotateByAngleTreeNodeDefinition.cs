using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionRotateByAngleTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("angle")] public CHandle<AIArgumentMapping> Angle { get; set; }
		[Ordinal(1)]  [RED("angleTolerance")] public CHandle<AIArgumentMapping> AngleTolerance { get; set; }

		public AIbehaviorActionRotateByAngleTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
