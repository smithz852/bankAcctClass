
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
        Console.WriteLine("Can't deposit $0 or less");
				return false;
			}
      else
      {
        var depositTotal = _balance + amountToDeposit;
        Console.WriteLine($"successfully deposited: ${depositTotal}");
				var currentBalance = _balance;
       Console.WriteLine($"Current balance: ${currentBalance}");
				return true;
			}

      
		}
		
		// TODO: Remove from balance, add verifications, and return if withdrawal was successful
		public bool Withdraw(decimal amountToWithdraw){
			if (_balance >= amountToWithdraw && amountToWithdraw > 0)
			{
				_balance -= amountToWithdraw;
				Console.WriteLine($"successfully withdrew: ${amountToWithdraw}");
				return true;
			} 
			else
			{
				Console.WriteLine("Insufficient funds");
				return false;
			}
		}
		
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
		account.Withdraw(25);
  }
}
