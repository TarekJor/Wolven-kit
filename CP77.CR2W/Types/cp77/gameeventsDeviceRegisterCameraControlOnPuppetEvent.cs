using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameeventsDeviceRegisterCameraControlOnPuppetEvent : redEvent
	{
		[Ordinal(0)]  [RED("component")] public CHandle<gameDeviceCameraControlComponent> Component { get; set; }
		[Ordinal(1)]  [RED("register")] public CBool Register { get; set; }

		public gameeventsDeviceRegisterCameraControlOnPuppetEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
