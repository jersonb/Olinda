namespace Olinda.Domain
{
    public class Entries : List<Entry>
    {
        public Entries()
        {
        }

        private Entries(Entry[] entries)
            => AddEnties(entries);

        private Entries(Entry entry)
            => Add(entry);

        public static implicit operator Entries(Entry entry)
            => new Entries(entry);

        public static implicit operator Entries(Entry[] entries)
            => new Entries(entries);

        public void AddEntry(Entry entry)
        {
            if (entry.IsValid())
                base.Add(entry);
        }

        public void AddEnties(Entry[] entries)
            => base.AddRange(entries.Where(e => e.IsValid()));

    }
}