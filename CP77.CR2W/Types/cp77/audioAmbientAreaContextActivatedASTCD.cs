using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAmbientAreaContextActivatedASTCD : audioAudioStateTransitionConditionData
	{
		[Ordinal(0)]  [RED("areaMixingContext")] public CName AreaMixingContext { get; set; }

		public audioAmbientAreaContextActivatedASTCD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
