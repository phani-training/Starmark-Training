using System;
using System.IO;

/*
 * Class is a UDT Reference type that is created to represent real world Entities. 
 * With the class, U get a host of features of OOP that could be applied on ur classes. 
 * Classes can be nested if U want to restrict the class usage only within the Parent class. 
 * Classes is a composition of fields(Data), properties(Accessors), methods(Functions) and events(Actions on the object). 
 * Fields are the charectistics of the object, Functions are actions performed by the object, events are actions performed on the object. Properties are setters and getters for the private fields so that they can be used like regular variables. 
 * When U design a class or its subclasses, U follow the principles of OOP called as SOLID Principles. 
 * S : Single Responsibility Principle ->One class should do only one kind of operation.
 * O : Open Closed Principle
 * L : Luskov's substitution Principle
 * I : Interface Segregation Principle.
 * D : Dependency Principle. 
 */
namespace SampleConApp
{

    class Account
    {
        public int AccountId { get; set; }
        public string Name { get; set; }
        public double Balance { get; private set; } = 5000;

        public void Credit(int amount) => Balance += amount;

        public void Debit(int amount)
        {
            if (amount > Balance)
                throw new Exception("Insufficient Funds");
            Balance -= amount;
        }
    }

    class AccountManager
    {
        private Account[] _accounts = null;
        private int _size = 0;
        public AccountManager(int size)
        {
            _size = size;
            _accounts = new Account[_size];
        }

        public void AddNewAccount(Account acc)
        {
            for (int i = 0; i < _size; i++)
            {
                if(_accounts[i] == null)
                {
                    _accounts[i] = new Account { AccountId = acc.AccountId, Name = acc.Name };
                    _accounts[i].Credit((int)acc.Balance);
                    return;
                }
            }
        }

        public void UpdateAccountDetails(Account acc)
        {
            for (int i = 0; i < _size; i++)
            {
                if(_accounts[i] != null && _accounts[i].AccountId == acc.AccountId)
                {
                    _accounts[i].Name = acc.Name;
                    return;
                }
            }
            throw new Exception("Account not found to update");
        }

        public void DeleteAccount(int id)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_accounts[i] != null && _accounts[i].AccountId == id)
                {
                    //.NET does not allow to delete an object. 
                    _accounts[i] = null; //
                    return;
                }
            }
            throw new Exception("No Account found to delete");

        }

        /// <summary>
        /// Gets the account from the repo based on ID
        /// </summary>
        /// <param name="id">ID of the Account</param>
        /// <returns>A Valid Account object</returns>
        /// <exception cref="System.Exception"/>
        public Account FindAccount(int id)
        {
            foreach(Account acc in _accounts)
            {
                if (acc != null && acc.AccountId == id)
                    return acc;
            }
            throw new Exception("No Account found");
        }

    }
    class Employee
    {
        int id;
        string name, address;
        double salary;

        public int EmpID
        {
            get { return id; }
            set { id = value; }
        }

        public string EmpName
        {
            get => name;
            set => name = value;
        }

        public string EmpAddress
        {
            get => address;
            set => address = value;
        }

        public double EmpSalary
        {
            get => salary;
            set => salary = value;
        }
       

    }

    class UIManager
    {
        public static AccountManager mgr = null;

        internal static void DisplayMenu(string file)
        {
            int size = Utilities.GetNumber("Enter the Size");
            mgr = new AccountManager(size);
            bool processing = true;
            string menu = File.ReadAllText(file);
            do
            {
                int choice = Utilities.GetNumber(menu);
                processing = processMenu(choice);
            } while (processing);
            Console.WriteLine("Thanks for using our application");
        }

        private static bool processMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    addingAccountHelper();
                    break;
                case 2:
                    updatingAccountHelper();
                    break;
                case 3:
                    findingAccountHelper();
                    break;
                case 4:
                    throw new Exception("Do it URSELF!!");
                default:
                    return false;
            }
            return true;//break vs. goto vs. return vs. throw.
        }

        private static void findingAccountHelper()
        {
            int id = Utilities.GetNumber("Enter the ID of the Account to Find");
            try
            {
                Account acc = mgr.FindAccount(id);
                Console.WriteLine("The Details of the Account are as follows:");
                string content = $"The Name: {acc.Name}\nThe Balance : {acc.Balance}\nThe Account No: {acc.AccountId}\n";
                Console.WriteLine(content);
                Utilities.Prompt("Press Enter to clear the Screen");
                Console.Clear();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static void updatingAccountHelper()
        {
            int id = Utilities.GetNumber("Enter the ID of the Account to Update");
            string name = Utilities.Prompt("Enter the  New Name of the Customer");
            Account acc = new Account { AccountId = id, Name = name };
            mgr.UpdateAccountDetails(acc);
            Utilities.Prompt("Press Enter to clear the Screen");
            Console.Clear();
        }

        private static void addingAccountHelper()
        {
            int id = Utilities.GetNumber("Enter the ID of the Account");
            string name = Utilities.Prompt("Enter the Name of the Customer");
            Account acc = new Account { AccountId = id, Name = name };
            mgr.AddNewAccount(acc);
            Utilities.Prompt("Press Enter to clear the Screen");
            Console.Clear();
        }
    }
    class Ex07ClassesDemo
    {
        static void employeeCreation()
        {
            Employee empObj = new Employee { EmpAddress = "Bangalore", EmpID = 111, EmpName = "Test Name", EmpSalary = 56000 };
            Console.WriteLine("The name is " + empObj.EmpName);
        }

        


        static void Main(string[] args)
        {
            UIManager.DisplayMenu(args[0]);
            //employeeCreation();
            //accountCreation();
            //accManagerCreation();
        }

        private static void accManagerCreation()
        {
            int count = Utilities.GetNumber("Enter the Account Count U want to create");
            AccountManager mgr = new AccountManager(count);
            try
            {
                mgr.FindAccount(123);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void accountCreation()
        {
            Account acc = new Account { AccountId = 111, Name = "Phaniraj" };
            Console.WriteLine("The Balance: " + acc.Balance);
            acc.Credit(1000);
            Console.WriteLine("The Balance: " + acc.Balance);
            try
            {
                acc.Debit(45000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
