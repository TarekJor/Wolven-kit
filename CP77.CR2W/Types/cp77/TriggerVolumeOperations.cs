using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TriggerVolumeOperations : DeviceOperations
	{
		[Ordinal(0)]  [RED("triggerVolumeOperations")] public CArray<STriggerVolumeOperationData> _TriggerVolumeOperations { get; set; }

		public TriggerVolumeOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
