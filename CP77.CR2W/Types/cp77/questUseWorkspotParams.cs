using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questUseWorkspotParams : CVariable
	{
		[Ordinal(0)]  [RED("forceEntryAnimName")] public CName ForceEntryAnimName { get; set; }
		[Ordinal(1)]  [RED("workspotNode")] public NodeRef WorkspotNode { get; set; }

		public questUseWorkspotParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
