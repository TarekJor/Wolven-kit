using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPuppetAIManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(0)]  [RED("entries")] public CArray<questPuppetAIManagerNodeDefinitionEntry> Entries { get; set; }

		public questPuppetAIManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
