namespace Contab
{
    public class Operation
    {
        public Operation()
        {
        }

        public Operation(string username, string currentMoney, string addSubtract, string reason, string moneyAfterOperation, string operationDate, string currentDate)
        {
            Username = username;
            CurrentMoney = currentMoney;
            AddSubtract = addSubtract;
            Reason = reason;
            MoneyAfterOperation = moneyAfterOperation;
            OperationDate = operationDate;
            CurrentDate = currentDate;
        }

        public string Username { get; set; }

        public string CurrentMoney { get; set; }

        public string AddSubtract { get; set; }

        public string Reason { get; set; }

        public string MoneyAfterOperation { get; set; }

        public string OperationDate { get; set; }

        public string CurrentDate { get; set; }
    }
}
