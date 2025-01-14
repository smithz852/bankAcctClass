
public class BankAccount
{
		private decimal _balance;
		
		// TODO: Change this as desired
		public BankAccount(){
			_balance = 0;
		}
		
		// TODO: Add to balance, add verifications, and return if deposit was successful
		public bool Deposit(decimal amountToDeposit){
			if (amountToDeposit <= 0)
      {
        Console.WriteLine("You cannot deposit a negative amount.");
				return false;
			}
      else
      {
        var depositTotal = _balance + amountToDeposit;
        Console.WriteLine(depositTotal);
				return true;
			}
		}
		
		// TODO: Remove from balance, add verifications, and return if withdrawal was successful
		// public bool Withdraw(decimal amountToWithdraw){
			
		// }
		
		// // TODO: See balance
		// public decimal ViewBalance(){
			
		// }
		
		// // TODO: Write method to determine if bank account is overdrawn
		// public bool IsOverdrawn(){
			
		// }
		
		// // TODO: Return the name of the account owner
		// public string GetAccountOwner(){
			
		// }
		
		// // TODO: Add any extra properties & methods you wish to use
}

class Program 
{
  static void Main(string[] args) 
  {
    var account = new BankAccount();
    account.Deposit(100);
  }
}
