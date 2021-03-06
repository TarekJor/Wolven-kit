using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BuildBluelinePart : gameinteractionsvisBluelinePart
	{
		[Ordinal(0)]  [RED("comparisonOperator")] public CEnum<ECompareOp> ComparisonOperator { get; set; }
		[Ordinal(1)]  [RED("lhsValue")] public CInt32 LhsValue { get; set; }
		[Ordinal(2)]  [RED("record")] public CHandle<gamedataPlayerBuild_Record> Record { get; set; }
		[Ordinal(3)]  [RED("rhsValue")] public CInt32 RhsValue { get; set; }

		public BuildBluelinePart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
