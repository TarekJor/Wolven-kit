using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BossHealthBarGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("boss")] public wCHandle<NPCPuppet> Boss { get; set; }
		[Ordinal(1)]  [RED("bossName")] public inkTextWidgetReference BossName { get; set; }
		[Ordinal(2)]  [RED("bossPuppets")] public CArray<wCHandle<NPCPuppet>> BossPuppets { get; set; }
		[Ordinal(3)]  [RED("foldAnimation")] public CHandle<inkanimProxy> FoldAnimation { get; set; }
		[Ordinal(4)]  [RED("healthController")] public wCHandle<NameplateBarLogicController> HealthController { get; set; }
		[Ordinal(5)]  [RED("healthControllerRef")] public inkWidgetReference HealthControllerRef { get; set; }
		[Ordinal(6)]  [RED("healthPersentage")] public inkTextWidgetReference HealthPersentage { get; set; }
		[Ordinal(7)]  [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(8)]  [RED("statListener")] public CHandle<BossHealthStatListener> StatListener { get; set; }

		public BossHealthBarGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
