using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HitStatusEffectPresentPrereq : GenericHitPrereq
	{
		[Ordinal(0)]  [RED("checkType")] public CString CheckType { get; set; }
		[Ordinal(1)]  [RED("statusEffectParam")] public CString StatusEffectParam { get; set; }
		[Ordinal(2)]  [RED("tag")] public CName Tag { get; set; }

		public HitStatusEffectPresentPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
