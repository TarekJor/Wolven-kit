using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RecipientData : CVariable
	{
		[Ordinal(0)]  [RED("entryID")] public CInt32 EntryID { get; set; }
		[Ordinal(1)]  [RED("fuseID")] public CInt32 FuseID { get; set; }

		public RecipientData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
