using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class OnscreenMessageGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("animProxyHide")] public CHandle<inkanimProxy> AnimProxyHide { get; set; }
		[Ordinal(1)]  [RED("animProxyShow")] public CHandle<inkanimProxy> AnimProxyShow { get; set; }
		[Ordinal(2)]  [RED("animProxyTimeout")] public CHandle<inkanimProxy> AnimProxyTimeout { get; set; }
		[Ordinal(3)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(4)]  [RED("blackboardDef")] public CHandle<UI_NotificationsDef> BlackboardDef { get; set; }
		[Ordinal(5)]  [RED("blinkingAnim")] public CHandle<inkanimDefinition> BlinkingAnim { get; set; }
		[Ordinal(6)]  [RED("hideAnim")] public CHandle<inkanimDefinition> HideAnim { get; set; }
		[Ordinal(7)]  [RED("mainTextWidget")] public inkTextWidgetReference MainTextWidget { get; set; }
		[Ordinal(8)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(9)]  [RED("screenMessage")] public gameSimpleScreenMessage ScreenMessage { get; set; }
		[Ordinal(10)]  [RED("screenMessageUpdateCallbackId")] public CUInt32 ScreenMessageUpdateCallbackId { get; set; }
		[Ordinal(11)]  [RED("showAnim")] public CHandle<inkanimDefinition> ShowAnim { get; set; }

		public OnscreenMessageGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
