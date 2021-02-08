using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SampleUIButtons : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("Button")] public inkWidgetReference Button { get; set; }
		[Ordinal(1)]  [RED("RadioGroup")] public inkWidgetReference RadioGroup { get; set; }
		[Ordinal(2)]  [RED("Text")] public inkTextWidgetReference Text { get; set; }
		[Ordinal(3)]  [RED("Toggle1")] public inkWidgetReference Toggle1 { get; set; }
		[Ordinal(4)]  [RED("Toggle2")] public inkWidgetReference Toggle2 { get; set; }
		[Ordinal(5)]  [RED("Toggle3")] public inkWidgetReference Toggle3 { get; set; }

		public SampleUIButtons(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
