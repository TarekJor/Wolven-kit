using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IntercomBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(0)]  [RED("DisplayString")] public gamebbScriptID_String DisplayString { get; set; }
		[Ordinal(1)]  [RED("EnableActions")] public gamebbScriptID_Bool EnableActions { get; set; }
		[Ordinal(2)]  [RED("Status")] public gamebbScriptID_Variant Status { get; set; }

		public IntercomBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
