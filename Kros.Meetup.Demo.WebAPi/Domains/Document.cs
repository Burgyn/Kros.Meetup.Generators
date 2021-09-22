namespace Kros.Meetup.Demo.WebAPi.Domains
{
    public class Document
    {
        public Contact Owner { get; set; }

        public Contact Collaborator { get; set; }

        public string Name { get; set; }

        public Settings Settings { get; set; }
    }
}
