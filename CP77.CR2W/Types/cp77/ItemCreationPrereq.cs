using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemCreationPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)]  [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }
		[Ordinal(1)]  [RED("fireAndForget")] public CBool FireAndForget { get; set; }
		[Ordinal(2)]  [RED("statType")] public CEnum<gamedataStatType> StatType { get; set; }
		[Ordinal(3)]  [RED("valueToCheck")] public CFloat ValueToCheck { get; set; }

		public ItemCreationPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
