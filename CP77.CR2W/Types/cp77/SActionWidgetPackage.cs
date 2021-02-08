using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SActionWidgetPackage : SWidgetPackage
	{
		[Ordinal(0)]  [RED("action")] public CHandle<gamedeviceAction> Action { get; set; }
		[Ordinal(1)]  [RED("dependendActions")] public CArray<CHandle<gamedeviceAction>> DependendActions { get; set; }
		[Ordinal(2)]  [RED("wasInitalized")] public CBool WasInitalized { get; set; }

		public SActionWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
