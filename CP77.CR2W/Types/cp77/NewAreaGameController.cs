using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NewAreaGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(1)]  [RED("data")] public CHandle<NewAreaDiscoveredUserData> Data { get; set; }
		[Ordinal(2)]  [RED("label")] public inkTextWidgetReference Label { get; set; }

		public NewAreaGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
