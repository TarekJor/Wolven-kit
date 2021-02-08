using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GenericMessageNotificationCloseData : inkGameNotificationData
	{
		[Ordinal(0)]  [RED("identifier")] public CInt32 Identifier { get; set; }
		[Ordinal(1)]  [RED("result")] public CEnum<GenericMessageNotificationResult> Result { get; set; }

		public GenericMessageNotificationCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
