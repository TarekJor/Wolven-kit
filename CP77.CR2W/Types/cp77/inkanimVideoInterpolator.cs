using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkanimVideoInterpolator : inkanimInterpolator
	{
		[Ordinal(0)]  [RED("allowSkipBackward")] public CBool AllowSkipBackward { get; set; }
		[Ordinal(1)]  [RED("audioEvent")] public CName AudioEvent { get; set; }
		[Ordinal(2)]  [RED("endValue")] public CFloat EndValue { get; set; }
		[Ordinal(3)]  [RED("retriggerAudioOnLoop")] public CBool RetriggerAudioOnLoop { get; set; }
		[Ordinal(4)]  [RED("startValue")] public CFloat StartValue { get; set; }
		[Ordinal(5)]  [RED("synchronizeToAudio")] public CBool SynchronizeToAudio { get; set; }

		public inkanimVideoInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
