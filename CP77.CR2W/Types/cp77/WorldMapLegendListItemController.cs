using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WorldMapLegendListItemController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(1)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(2)]  [RED("variant")] public CEnum<gamedataMappinVariant> Variant { get; set; }

		public WorldMapLegendListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
