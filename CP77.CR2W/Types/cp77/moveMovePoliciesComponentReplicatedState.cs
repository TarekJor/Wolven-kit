using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class moveMovePoliciesComponentReplicatedState : netIComponentState
	{
		[Ordinal(0)]  [RED("movePolicies")] public moveReplicatedMovePoliciesState MovePolicies { get; set; }

		public moveMovePoliciesComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
