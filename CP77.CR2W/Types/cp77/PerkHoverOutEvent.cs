using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerkHoverOutEvent : redEvent
	{
		[Ordinal(0)]  [RED("perkData")] public CHandle<BasePerkDisplayData> PerkData { get; set; }
		[Ordinal(1)]  [RED("widget")] public wCHandle<inkWidget> Widget { get; set; }

		public PerkHoverOutEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
