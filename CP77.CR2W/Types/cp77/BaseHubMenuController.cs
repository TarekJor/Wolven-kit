using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseHubMenuController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("menuData")] public CHandle<IScriptable> MenuData { get; set; }
		[Ordinal(1)]  [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }

		public BaseHubMenuController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
