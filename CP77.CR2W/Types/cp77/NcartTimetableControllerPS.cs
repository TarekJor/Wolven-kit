using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NcartTimetableControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("currentTimeToDepart")] public CInt32 CurrentTimeToDepart { get; set; }
		[Ordinal(1)]  [RED("ncartTimetableSetup")] public NcartTimetableSetup NcartTimetableSetup { get; set; }

		public NcartTimetableControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
