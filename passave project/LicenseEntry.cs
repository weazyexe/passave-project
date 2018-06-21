namespace Passave
{
    public class LicenseEntry : BaseEntry
    {
        public LicenseEntry()
        {

        }

        public LicenseEntry(string name, string key, string notes) : base(name, notes)
        {
            Key = key;
        }

        public string Key
        {
            get; set;
        }
    }
}
