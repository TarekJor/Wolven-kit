using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DropdownElementController : BaseButtonView
	{
		[Ordinal(0)]  [RED("active")] public CBool Active { get; set; }
		[Ordinal(1)]  [RED("arrow")] public inkImageWidgetReference Arrow { get; set; }
		[Ordinal(2)]  [RED("contentContainer")] public inkWidgetReference ContentContainer { get; set; }
		[Ordinal(3)]  [RED("data")] public CHandle<DropdownItemData> Data { get; set; }
		[Ordinal(4)]  [RED("frame")] public inkWidgetReference Frame { get; set; }
		[Ordinal(5)]  [RED("text")] public inkTextWidgetReference Text { get; set; }

		public DropdownElementController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
