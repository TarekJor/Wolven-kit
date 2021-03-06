using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorAlphaByDistance : IParticleModificator
	{
		[Ordinal(0)]  [RED("farBlendDistance")] public Vector2 FarBlendDistance { get; set; }
		[Ordinal(1)]  [RED("nearBlendDistance")] public Vector2 NearBlendDistance { get; set; }

		public CParticleModificatorAlphaByDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
