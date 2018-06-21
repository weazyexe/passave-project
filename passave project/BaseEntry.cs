namespace Passave
{
    public abstract class BaseEntry
    {
        public BaseEntry()
        {

        }

        public BaseEntry(string name, string notes)
        {
            Name = name;
            Notes = notes;
        }

        public string Name
        {
            get; set;
        }

        public string Notes
        {
            get; set;
        }
    }
}
