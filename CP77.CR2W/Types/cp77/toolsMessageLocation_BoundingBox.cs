using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class toolsMessageLocation_BoundingBox : toolsIMessageLocation
	{
		[Ordinal(0)]  [RED("box")] public Box Box { get; set; }
		[Ordinal(1)]  [RED("resourcePath")] public MessageResourcePath ResourcePath { get; set; }

		public toolsMessageLocation_BoundingBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
