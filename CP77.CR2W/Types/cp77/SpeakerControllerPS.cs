using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SpeakerControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("currentValue")] public CName CurrentValue { get; set; }
		[Ordinal(1)]  [RED("previousValue")] public CName PreviousValue { get; set; }
		[Ordinal(2)]  [RED("speakerSetup")] public SpeakerSetup SpeakerSetup { get; set; }

		public SpeakerControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
