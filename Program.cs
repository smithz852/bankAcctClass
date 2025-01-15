using Spectre.Console;

public class BankAccount
{
		private decimal _balance;
		public string AccountOwner { get; set; }
		
		// TODO: Change this as desired
		public BankAccount(){
			_balance = 0;
			AccountOwner = "John Doe";
		}
		
		// TODO: Add to balance, add verifications, and return if deposit was successful
		public bool Deposit(decimal amountToDeposit){
			if (amountToDeposit <= 0)
      {
        Console.WriteLine("Can't deposit $0 or less");
				MoreTasks();
				return false;
			}
      else
      {
        _balance += amountToDeposit;
        Console.WriteLine($"successfully deposited: ${amountToDeposit}");
        MoreTasks();
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
				MoreTasks();
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
			MoreTasks();
			return _balance;
		}
		
		// // TODO: Write method to determine if bank account is overdrawn
		public bool IsOverdrawn(decimal requestedAmount){
			if (_balance < requestedAmount)
			{
				Console.WriteLine($"Requesting to withdraw: ${requestedAmount}");
				var amountShort = requestedAmount - _balance;
				Console.WriteLine($"Insufficient funds: ${amountShort} short");
				MoreTasks();
				return true;
			}
			else
			{
				return false;
			}
		}
		
		// // TODO: Return the name of the account owner
		public string GetAccountOwner(){
			AnsiConsole.Write(new Markup($"Welcome to your bank account, [mediumspringgreen]{AccountOwner}[/] \n"));
		  bankAccountPrompts();
			return AccountOwner;
		}

    public string bankAccountPrompts() {

      var prompt = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
        .Title("How can I help you today?")
        .PageSize(10)
        .AddChoices(new[] {
          "Deposit", "Withdraw", "View Balance", "Exit"
        }));

				if (prompt == "Deposit")
				{
					var amountToDeposit = AnsiConsole.Prompt(
					new TextPrompt<int>("[mediumspringgreen]How much would you like to deposit?[/]"));

					Deposit(amountToDeposit);
				}

        if (prompt == "Withdraw")
				{
					var amountToWithdraw = AnsiConsole.Prompt(
					new TextPrompt<int>("[mediumspringgreen]How much would you like to withdraw?[/]"));

					Withdraw(amountToWithdraw);
				}

				if (prompt == "View Balance")
				{
					ViewBalance();
				}

				if (prompt == "Exit")
				{
					AnsiConsole.Write(new Markup("[mediumspringgreen]Thanks for banking with us![/] \n"));
				}

				return prompt;
		}

		public bool MoreTasks() {
			var moreTasks = AnsiConsole.Prompt(
					new SelectionPrompt<string>()
					.Title("Would you like to do anything else?")
					.PageSize(10)
					.AddChoices(new[] {
						"Yes", "No"
					}));

				if (moreTasks == "Yes")
				{
					bankAccountPrompts();
					return true;
				}
				else
				{
					AnsiConsole.Write(new Markup("[mediumspringgreen]Thanks for banking with us![/] \n"));
					return false;
				}
		}

}


class Program 
{
  static void Main(string[] args) 
  {
    var account = new BankAccount();
  
	account.GetAccountOwner();
 
		// account.Withdraw(15);
  }
}
