using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_SendActionSignal : gameEffectExecutor_Scripted
	{
		[Ordinal(0)]  [RED("signalDuration")] public CFloat SignalDuration { get; set; }
		[Ordinal(1)]  [RED("signalName")] public CName SignalName { get; set; }

		public EffectExecutor_SendActionSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
