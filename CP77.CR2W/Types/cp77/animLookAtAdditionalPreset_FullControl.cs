using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animLookAtAdditionalPreset_FullControl : animLookAtAdditionalPreset
	{
		[Ordinal(0)]  [RED("attachHandToOtherOne")] public CBool AttachHandToOtherOne { get; set; }
		[Ordinal(1)]  [RED("limits")] public animLookAtLimits Limits { get; set; }
		[Ordinal(2)]  [RED("mode")] public CInt32 Mode { get; set; }
		[Ordinal(3)]  [RED("suppress")] public CFloat Suppress { get; set; }
		[Ordinal(4)]  [RED("useRightHand")] public CBool UseRightHand { get; set; }

		public animLookAtAdditionalPreset_FullControl(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
