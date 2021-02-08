using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScriptedReactionSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("callInAction")] public CBool CallInAction { get; set; }
		[Ordinal(1)]  [RED("fleeingNPCs")] public CInt32 FleeingNPCs { get; set; }
		[Ordinal(2)]  [RED("policeCaller")] public wCHandle<entEntity> PoliceCaller { get; set; }
		[Ordinal(3)]  [RED("registeredTimeout")] public CFloat RegisteredTimeout { get; set; }
		[Ordinal(4)]  [RED("runners")] public CArray<wCHandle<entEntity>> Runners { get; set; }

		public ScriptedReactionSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
