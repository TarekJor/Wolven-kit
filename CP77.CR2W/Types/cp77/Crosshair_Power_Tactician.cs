using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Power_Tactician : gameuiCrosshairBaseGameController
	{
		[Ordinal(0)]  [RED("botPart")] public inkWidgetReference BotPart { get; set; }
		[Ordinal(1)]  [RED("leftPart")] public inkWidgetReference LeftPart { get; set; }
		[Ordinal(2)]  [RED("rightPart")] public inkWidgetReference RightPart { get; set; }
		[Ordinal(3)]  [RED("topPart")] public inkWidgetReference TopPart { get; set; }

		public Crosshair_Power_Tactician(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
