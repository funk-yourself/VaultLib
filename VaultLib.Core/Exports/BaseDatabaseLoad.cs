namespace VaultLib.Core.Exports
{
    public abstract class BaseDatabaseLoad : BaseExport
    {
        public override ulong GetExportID()
        {
            return 0xF1DFAC8D; // constant, probably doesn't matter but I don't know the text it comes from
        }

        public override string GetTypeId()
        {
            return "Attrib::DatabaseLoadData";
        }
    }
}