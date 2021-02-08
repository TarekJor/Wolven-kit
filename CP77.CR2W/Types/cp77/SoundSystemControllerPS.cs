using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SoundSystemControllerPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("cachedEvent")] public CHandle<ChangeMusicAction> CachedEvent { get; set; }
		[Ordinal(1)]  [RED("currentEvent")] public CHandle<ChangeMusicAction> CurrentEvent { get; set; }
		[Ordinal(2)]  [RED("defaultAction")] public CInt32 DefaultAction { get; set; }
		[Ordinal(3)]  [RED("soundSystemSettings")] public CArray<SoundSystemSettings> SoundSystemSettings { get; set; }

		public SoundSystemControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
