using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ModifyDamageWithDistance : ModifyDamageEffector
	{
		[Ordinal(0)]  [RED("increaseWithDistance")] public CBool IncreaseWithDistance { get; set; }
		[Ordinal(1)]  [RED("percentMult")] public CFloat PercentMult { get; set; }
		[Ordinal(2)]  [RED("unitThreshold")] public CFloat UnitThreshold { get; set; }

		public ModifyDamageWithDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
