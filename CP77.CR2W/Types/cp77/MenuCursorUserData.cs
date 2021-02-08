using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MenuCursorUserData : inkUserData
	{
		[Ordinal(0)]  [RED("actions")] public CArray<CName> Actions { get; set; }
		[Ordinal(1)]  [RED("animationOverride")] public CName AnimationOverride { get; set; }

		public MenuCursorUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
