using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NameplateVisibleEvent : redEvent
	{
		[Ordinal(0)]  [RED("entityID")] public entEntityID EntityID { get; set; }
		[Ordinal(1)]  [RED("isNameplateVisible")] public CBool IsNameplateVisible { get; set; }

		public NameplateVisibleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
