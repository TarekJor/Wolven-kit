using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_Effect : animAnimEvent
	{
		[Ordinal(0)]  [RED("effectName")] public CName EffectName { get; set; }

		public animAnimEvent_Effect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
