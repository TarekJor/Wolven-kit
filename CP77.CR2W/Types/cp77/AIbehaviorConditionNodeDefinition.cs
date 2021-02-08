using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorConditionNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(0)]  [RED("condition")] public CHandle<AIbehaviorConditionDefinition> Condition { get; set; }
		[Ordinal(1)]  [RED("resultIfFailed")] public CEnum<AIbehaviorCompletionStatus> ResultIfFailed { get; set; }

		public AIbehaviorConditionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
