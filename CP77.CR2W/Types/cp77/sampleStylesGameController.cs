using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class sampleStylesGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("button1Controller")] public wCHandle<inkButtonController> Button1Controller { get; set; }
		[Ordinal(1)]  [RED("button2Controller")] public wCHandle<inkButtonController> Button2Controller { get; set; }
		[Ordinal(2)]  [RED("stateText")] public wCHandle<inkTextWidget> StateText { get; set; }

		public sampleStylesGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
