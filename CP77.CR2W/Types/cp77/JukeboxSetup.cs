using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class JukeboxSetup : CVariable
	{
		[Ordinal(0)]  [RED("glitchSFX")] public CName GlitchSFX { get; set; }
		[Ordinal(1)]  [RED("paymentRecordID")] public TweakDBID PaymentRecordID { get; set; }
		[Ordinal(2)]  [RED("startingStation")] public CEnum<ERadioStationList> StartingStation { get; set; }

		public JukeboxSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
