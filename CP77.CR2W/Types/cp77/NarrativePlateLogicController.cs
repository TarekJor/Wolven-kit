using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NarrativePlateLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("captionWidget")] public inkWidgetReference CaptionWidget { get; set; }
		[Ordinal(1)]  [RED("root")] public inkWidgetReference Root { get; set; }
		[Ordinal(2)]  [RED("textWidget")] public inkWidgetReference TextWidget { get; set; }

		public NarrativePlateLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
