using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TabButtonController : inkToggleController
	{
		[Ordinal(0)]  [RED("data")] public CInt32 Data { get; set; }
		[Ordinal(1)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(2)]  [RED("iconSet")] public CString IconSet { get; set; }
		[Ordinal(3)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(4)]  [RED("labelSet")] public CString LabelSet { get; set; }

		public TabButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
