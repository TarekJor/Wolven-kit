using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GateSignal : gameTaggedSignalUserData
	{
		[Ordinal(0)]  [RED("data")] public CHandle<AISignalSenderTask> Data { get; set; }
		[Ordinal(1)]  [RED("lifeTime")] public CFloat LifeTime { get; set; }
		[Ordinal(2)]  [RED("priority")] public CFloat Priority { get; set; }

		public GateSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
