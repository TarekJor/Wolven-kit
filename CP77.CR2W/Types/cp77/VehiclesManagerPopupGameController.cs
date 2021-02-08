using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehiclesManagerPopupGameController : BaseModalListPopupGameController
	{
		[Ordinal(0)]  [RED("dataSource")] public CHandle<inkScriptableDataSourceWrapper> DataSource { get; set; }
		[Ordinal(1)]  [RED("dataView")] public CHandle<VehiclesManagerDataView> DataView { get; set; }
		[Ordinal(2)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(3)]  [RED("quickSlotsManager")] public wCHandle<QuickSlotsManager> QuickSlotsManager { get; set; }
		[Ordinal(4)]  [RED("scrollArea")] public inkScrollAreaWidgetReference ScrollArea { get; set; }
		[Ordinal(5)]  [RED("scrollController")] public wCHandle<inkScrollController> ScrollController { get; set; }
		[Ordinal(6)]  [RED("scrollControllerWidget")] public inkWidgetReference ScrollControllerWidget { get; set; }

		public VehiclesManagerPopupGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
