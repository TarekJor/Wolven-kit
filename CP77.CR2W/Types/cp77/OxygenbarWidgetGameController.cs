using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class OxygenbarWidgetGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("RootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(1)]  [RED("animHideOxygenProxy")] public CHandle<inkanimProxy> AnimHideOxygenProxy { get; set; }
		[Ordinal(2)]  [RED("animHideTemp")] public CHandle<inkanimDefinition> AnimHideTemp { get; set; }
		[Ordinal(3)]  [RED("animLongFade")] public CHandle<inkanimDefinition> AnimLongFade { get; set; }
		[Ordinal(4)]  [RED("animShortFade")] public CHandle<inkanimDefinition> AnimShortFade { get; set; }
		[Ordinal(5)]  [RED("bbPSceneTierEventId")] public CUInt32 BbPSceneTierEventId { get; set; }
		[Ordinal(6)]  [RED("currentOxygen")] public CFloat CurrentOxygen { get; set; }
		[Ordinal(7)]  [RED("currentSwimmingState")] public CEnum<gamePSMSwimming> CurrentSwimmingState { get; set; }
		[Ordinal(8)]  [RED("oxygenController")] public wCHandle<NameplateBarLogicController> OxygenController { get; set; }
		[Ordinal(9)]  [RED("oxygenControllerRef")] public inkWidgetReference OxygenControllerRef { get; set; }
		[Ordinal(10)]  [RED("oxygenListener")] public CHandle<OxygenListener> OxygenListener { get; set; }
		[Ordinal(11)]  [RED("oxygenPercTextPath")] public inkTextWidgetReference OxygenPercTextPath { get; set; }
		[Ordinal(12)]  [RED("oxygenStatusTextPath")] public inkTextWidgetReference OxygenStatusTextPath { get; set; }
		[Ordinal(13)]  [RED("sceneTier")] public CEnum<GameplayTier> SceneTier { get; set; }
		[Ordinal(14)]  [RED("swimmingStateBlackboardId")] public CUInt32 SwimmingStateBlackboardId { get; set; }

		public OxygenbarWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
