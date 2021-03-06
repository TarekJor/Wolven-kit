using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsCacheKey : CVariable
	{
		[Ordinal(0)]  [RED("entryIndex")] public CUInt32 EntryIndex { get; set; }
		[Ordinal(1)]  [RED("key")] public physicsGeometryKey Key { get; set; }

		public physicsCacheKey(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
