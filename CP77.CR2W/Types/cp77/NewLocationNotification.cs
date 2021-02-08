using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NewLocationNotification : JournalNotification
	{
		[Ordinal(0)]  [RED("districtFluffIcon")] public inkImageWidgetReference DistrictFluffIcon { get; set; }
		[Ordinal(1)]  [RED("districtIcon")] public inkImageWidgetReference DistrictIcon { get; set; }
		[Ordinal(2)]  [RED("districtName")] public inkTextWidgetReference DistrictName { get; set; }

		public NewLocationNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
