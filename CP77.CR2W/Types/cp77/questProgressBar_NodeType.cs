using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questProgressBar_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)]  [RED("show")] public CBool Show { get; set; }
		[Ordinal(2)]  [RED("text")] public LocalizationString Text { get; set; }

		public questProgressBar_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
