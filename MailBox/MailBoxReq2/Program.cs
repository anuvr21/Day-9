using System;
using System.Collections.Generic;


namespace MailBoxReq2
{
    public class Mail
    {
        private long _id;

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _to;

        public string To
        {
            get { return _to; }
            set { _to = value; }
        }
        private string _from;

        public string From
        {
            get { return _from; }
            set { _from = value; }
        }
        private string _subject;

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        private string _content;

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        private DateTime _receivedDate;

        public DateTime ReceivedDate
        {
            get { return _receivedDate; }
            set { DateTime _receivedDate = value; }
        }
        private double _size;

        public double Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public Mail()
        {

        }
        public Mail(long _id, string _to, string _from, string _subject, string _content, DateTime _receivedDate, double _size)
        {
            this.Id = _id;
            To = _to;
            From = _from;
            Subject = _subject;
            Content = _content;
            ReceivedDate = _receivedDate;
            Size = _size;
        }
        public static Mail CreateMail(string detail)
        {
            string[] details = detail.Split(',');
            long id = long.Parse(details[0]);
            string from = details[1];
            string to = details[2];
            string subject = details[3];
            string content = details[4];
            DateTime receivedDate = DateTime.Parse(details[5]);
            double size = double.Parse(details[6]);

            return new Mail(id, from, to, subject, content, receivedDate, size);
        }
        public override string ToString()
        {
            return string.Format("{0} {1,15} {2,15} {3,15} {4,15} {5,15:dd-MM-yyyy} {6,15:F1}", Id, From, To, Subject, Content, ReceivedDate, Size);
        }
    }
    public class MailFolder
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private List<Mail> _mailList;
        public List<Mail> MailList
        {
            get { return _mailList; }
            set { _mailList = value; }
        }
        public MailFolder(string _name, List<Mail> _mailList)
        {
            this._name = _name;
            this._mailList = _mailList;
        }

        public MailFolder(string _name) : this(_name, new List<Mail>())
        {
        }

        public void AddMailToFolder(Mail mail)
        {
            _mailList.Add(mail);
            Console.WriteLine("Mail successfully added");
        }
        public bool RemoveMailFromFolder(long id)
        {
            foreach (Mail mail in _mailList)
            {
                if (mail.Id == id)
                {
                    _mailList.Remove(mail);
                    Console.WriteLine("Mail successfully deleted");
                    return true;
                }
            }
            Console.WriteLine("Mail not found");
        }
    }
}
