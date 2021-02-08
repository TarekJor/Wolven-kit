using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GetOnWindowCombatDecorator : AIVehicleTaskAbstract
	{
		[Ordinal(0)]  [RED("mountInfo")] public gamemountingMountingInfo MountInfo { get; set; }
		[Ordinal(1)]  [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(2)]  [RED("vehicle")] public wCHandle<gameObject> Vehicle { get; set; }
		[Ordinal(3)]  [RED("windowOpenEvent")] public CHandle<VehicleExternalWindowRequestEvent> WindowOpenEvent { get; set; }

		public GetOnWindowCombatDecorator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
