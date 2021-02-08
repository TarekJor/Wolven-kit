using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MaterialTooltip : AGenericTooltipController
	{
		[Ordinal(0)]  [RED("BasePrice")] public inkTextWidgetReference BasePrice { get; set; }
		[Ordinal(1)]  [RED("Price")] public inkTextWidgetReference Price { get; set; }
		[Ordinal(2)]  [RED("Title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(3)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(4)]  [RED("descriptionLine")] public inkWidgetReference DescriptionLine { get; set; }
		[Ordinal(5)]  [RED("descriptionWrapper")] public inkWidgetReference DescriptionWrapper { get; set; }
		[Ordinal(6)]  [RED("titleWrapper")] public inkWidgetReference TitleWrapper { get; set; }

		public MaterialTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
