using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SThumbnailWidgetPackage : SWidgetPackage
	{
		[Ordinal(0)]  [RED("deviceStatus")] public CString DeviceStatus { get; set; }
		[Ordinal(1)]  [RED("thumbnailAction")] public CHandle<ThumbnailUI> ThumbnailAction { get; set; }

		public SThumbnailWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
