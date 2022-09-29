using Assignment_29_09;
Account acc = new Account();
BankTransaction bt = new BankTransaction();
var ab = new AccountBag();

int amt = bt.Deposit(acc);

Console.WriteLine($"amount after deposit = {amt}");


int amt1 = bt.WithDraw(acc);

Console.WriteLine($"amount after deposit = {amt1}");



