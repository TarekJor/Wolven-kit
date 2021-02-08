using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class hudRecordingController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("anim_intro")] public CHandle<inkanimProxy> Anim_intro { get; set; }
		[Ordinal(1)]  [RED("anim_loop")] public CHandle<inkanimProxy> Anim_loop { get; set; }
		[Ordinal(2)]  [RED("anim_outro")] public CHandle<inkanimProxy> Anim_outro { get; set; }
		[Ordinal(3)]  [RED("factListener")] public CUInt32 FactListener { get; set; }
		[Ordinal(4)]  [RED("option_intro")] public inkanimPlaybackOptions Option_intro { get; set; }
		[Ordinal(5)]  [RED("option_loop")] public inkanimPlaybackOptions Option_loop { get; set; }
		[Ordinal(6)]  [RED("option_outro")] public inkanimPlaybackOptions Option_outro { get; set; }
		[Ordinal(7)]  [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }

		public hudRecordingController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
