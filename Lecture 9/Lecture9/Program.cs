// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
    namespace lecture9
{
    internal class Program
    
        {
            Company company = new Company();
            Console.WriteLine("Is Company  local ?  (YES/NO) ");
            string isLocalString = Console.ReadLine().ToUpper();
            if (isLocalString == "YES")
            {
                company.isLocal = true;
            }
            else if (isLocalString == "NO")
            {
                company.isLocal = false;
            }
            Employee employee = new Employee();
            Console.WriteLine("Enter the name of the employee");
            employee.name = Console.ReadLine();
            Console.WriteLine("Enter the age of the employee");
            employee.age = int.Parse(Console.ReadLine());
            employee.SetworkHours();
            employee.Setposition();
            employee.totalSalary = (employee.salaryNormaldays + employee.salaryWeekend + employee.totalOverTime);
            if (employee.totalWorkHours > 50);
            

            {
                employee.totalSalary = employee.totalSalary + (employee.totalSalary * 20 / 100);
            }

            employee.totalSalary = employee.totalSalary - (employee.totalSalary * company.isLocalcheck() / 100);

            Console.WriteLine("The total salary of the employee is {0}", employee.totalSalary);


            Console.WriteLine("Press any key to exit app...");
            Console.ReadLine();

        
    


