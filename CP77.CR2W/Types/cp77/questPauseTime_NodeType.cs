using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPauseTime_NodeType : questITimeManagerNodeType
	{
		[Ordinal(0)]  [RED("pause")] public CBool Pause { get; set; }
		[Ordinal(1)]  [RED("source")] public CName Source { get; set; }

		public questPauseTime_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
