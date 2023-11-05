namespace FinanceMentor.Client.Components
{
    public class EarningModel
    {
        public DateTime Date { get; set; }
        public string Subject { get; set; } = string.Empty;
        public EarningCategory Category { get; set; }
        public Decimal Amount { get; set; }



    }
}
