namespace OpenBankProject.Net.Models.Transaction
{
    public class OtherTransactionAccount : TransactionAccountInformation
    {
        public Holder Holder { get; set; }
        public TransactionAccountMetadata Metadata { get; set; }
    }
}
