using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIStatListener : gameScriptStatsListener
	{
		[Ordinal(0)]  [RED("behaviorCallbackName")] public CName BehaviorCallbackName { get; set; }
		[Ordinal(1)]  [RED("owner")] public wCHandle<ScriptedPuppet> Owner { get; set; }

		public AIStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
