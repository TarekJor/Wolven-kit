using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questVehicleCollision_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)]  [RED("magnitude")] public CEnum<questImpulseMagnitude> Magnitude { get; set; }

		public questVehicleCollision_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
