using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class KnockdownEvents : StatusEffectEvents
	{
		[Ordinal(0)]  [RED("cachedPlayerVelocity")] public Vector4 CachedPlayerVelocity { get; set; }
		[Ordinal(1)]  [RED("frictionForceApplied")] public CBool FrictionForceApplied { get; set; }
		[Ordinal(2)]  [RED("playedImpactAnim")] public CBool PlayedImpactAnim { get; set; }
		[Ordinal(3)]  [RED("secondaryKnockdownDir")] public Vector4 SecondaryKnockdownDir { get; set; }
		[Ordinal(4)]  [RED("secondaryKnockdownTimer")] public CFloat SecondaryKnockdownTimer { get; set; }

		public KnockdownEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
