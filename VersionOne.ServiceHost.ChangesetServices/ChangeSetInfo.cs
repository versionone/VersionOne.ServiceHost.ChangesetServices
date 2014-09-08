using System;
using System.Collections.Generic;

namespace VersionOne.ServiceHost.SubversionServices
{
	public class ChangeSetInfo
	{
		public readonly string Author;
		public readonly string Message;
		public readonly IList<string> ChangedFiles;
		public readonly DateTime ChangeDate;
		public readonly int Revision;
		public readonly IList<string> References;
	    public readonly LinkInfo Link;
		
        public ChangeSetInfo(string author, string message, IList<string> changedFiles, int revision, string repositoryId,
                             DateTime changeDate, IList<string> references, LinkInfo link, string repositoryFriendlyName) 
            : this(author, message, changedFiles, revision, changeDate, references)
        {
            Link = link;
        }

		public ChangeSetInfo(string author, string message, IList<string> changedfiles, int revision, DateTime changedate, IList<string> references)
		{
			Author = author;
			Message = message;
			ChangedFiles = changedfiles;
			Revision = revision;
			ChangeDate = changedate;
			References = references;
		}
	}
}
