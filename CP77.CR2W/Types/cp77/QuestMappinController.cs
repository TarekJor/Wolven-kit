using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestMappinController : gameuiQuestMappinController
	{
		[Ordinal(0)]  [RED("aboveWidget")] public wCHandle<inkWidget> AboveWidget { get; set; }
		[Ordinal(1)]  [RED("animOptions")] public inkanimPlaybackOptions AnimOptions { get; set; }
		[Ordinal(2)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(3)]  [RED("arrowCanvas")] public inkWidgetReference ArrowCanvas { get; set; }
		[Ordinal(4)]  [RED("arrowPart")] public inkWidgetReference ArrowPart { get; set; }
		[Ordinal(5)]  [RED("belowWidget")] public wCHandle<inkWidget> BelowWidget { get; set; }
		[Ordinal(6)]  [RED("isCompletedPhase")] public CBool IsCompletedPhase { get; set; }
		[Ordinal(7)]  [RED("isMainQuest")] public CBool IsMainQuest { get; set; }
		[Ordinal(8)]  [RED("mappin")] public wCHandle<gamemappinsIMappin> Mappin { get; set; }
		[Ordinal(9)]  [RED("portalIcon")] public inkWidgetReference PortalIcon { get; set; }
		[Ordinal(10)]  [RED("questMappin")] public wCHandle<gamemappinsQuestMappin> QuestMappin { get; set; }
		[Ordinal(11)]  [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(12)]  [RED("runtimeMappin")] public wCHandle<gamemappinsRuntimeMappin> RuntimeMappin { get; set; }
		[Ordinal(13)]  [RED("scanningDiamond")] public inkWidgetReference ScanningDiamond { get; set; }
		[Ordinal(14)]  [RED("selector")] public inkWidgetReference Selector { get; set; }
		[Ordinal(15)]  [RED("shouldHideWhenClamped")] public CBool ShouldHideWhenClamped { get; set; }
		[Ordinal(16)]  [RED("vehicleAlreadySummonedTime")] public EngineTime VehicleAlreadySummonedTime { get; set; }
		[Ordinal(17)]  [RED("vehicleMappinComponent")] public CHandle<VehicleMappinComponent> VehicleMappinComponent { get; set; }
		[Ordinal(18)]  [RED("vehiclePulseTimeSecs")] public CFloat VehiclePulseTimeSecs { get; set; }

		public QuestMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
