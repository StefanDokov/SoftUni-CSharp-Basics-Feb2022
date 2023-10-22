using System.Text;

namespace MailClient
{
    public class MailBox
    {
        public MailBox(int capacity)
        {
            Capacity = capacity;	
			Inbox = new List<Mail> ();
			Archive = new List<Mail> ();
        }

        private int capacity;

		public int Capacity
		{
			get { return capacity; }
			set { capacity = value; }
		}

		private List<Mail> inbox;

		public List<Mail> Inbox
        {
			get { return inbox; }
			set { inbox = value; }
		}

		private List<Mail> archive;

		public List<Mail> Archive
        {
			get { return archive; }
			set { archive = value; }
		}

		public void IncomingMail(Mail mail)
		{
			if (Inbox.Count < Capacity) 
			{ 
				Inbox.Add(mail);
			}
		}

		public bool DeleteMail(string sender)
		{
			return Inbox.Remove(Inbox.Where(m => m.Sender == sender).FirstOrDefault());
		}

		public int ArchiveInboxMessages()
		{
			int b = Inbox.Count();
			Archive.AddRange(Inbox);
			Inbox.Clear();
			return b;
		}

		public string GetLongestMessage()
		{
			return Inbox.OrderByDescending(m => m.Body.Length).FirstOrDefault().ToString();
		}

		public string InboxView()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("Inbox:");

			foreach (Mail mail in Inbox)
			{
				sb.AppendLine(mail.ToString());
			}

			return sb.ToString().TrimEnd();
		}

	}
}
