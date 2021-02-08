using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questMiscAICommandNode : questConfigurableAICommandNode
	{
		[Ordinal(0)]  [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
		[Ordinal(1)]  [RED("function")] public CName Function { get; set; }
		[Ordinal(2)]  [RED("params")] public CHandle<questAICommandParams> Params { get; set; }

		public questMiscAICommandNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
