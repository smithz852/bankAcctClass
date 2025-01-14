using Spectre.Console;

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
        _balance += amountToDeposit;
        Console.WriteLine($"successfully deposited: ${amountToDeposit}");
				ViewBalance();
				return true;
			}

      
		}
		
		// TODO: Remove from balance, add verifications, and return if withdrawal was successful
		public bool Withdraw(decimal amountToWithdraw){
     
     var isOverdrawn = IsOverdrawn(amountToWithdraw);

			if (isOverdrawn == false && amountToWithdraw > 0)
			{
				_balance -= amountToWithdraw;
				Console.WriteLine($"successfully withdrew: ${amountToWithdraw}");
				ViewBalance();
				return true;
			} 
			else
			{
				return false;
			}
		}
		
		// // TODO: See balance
		public decimal ViewBalance(){
			Console.WriteLine($"Current balance: ${_balance}");
			return _balance;
		}
		
		// // TODO: Write method to determine if bank account is overdrawn
		public bool IsOverdrawn(decimal requestedAmount){
			if (_balance < requestedAmount)
			{
				Console.WriteLine($"Requesting to withdraw: ${requestedAmount}");
				var amountShort = requestedAmount - _balance;
				Console.WriteLine($"Insufficient funds: ${amountShort} short");
				return true;
			}
			else
			{
				return false;
			}
		}
		
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

 var amountToDeposit = AnsiConsole.Prompt(
	new TextPrompt<int>("[mediumspringgreen]How much would you like to deposit?[/]"));

    account.Deposit(amountToDeposit);
		account.Withdraw(15);
  }
}
