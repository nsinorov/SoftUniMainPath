using SoftUni.Data;
using SoftUni.Models;
using System.Globalization;
using System.Text;
using System.Xml.Linq;

namespace SoftUni;

public class StartUp
{
    public static void Main()
    {
        var context = new SoftUniContext();
        string output = string.Empty;

        //03.
        //output = GetEmployeesFullInformation(context);

        //04.
        //output = GetEmployeesWithSalaryOver50000(context);

        //05.
        //output = GetEmployeesFromResearchAndDevelopment(context);

        //06.
        //output = AddNewAddressToEmployee(context);

        //07.
        //output = GetEmployeesInPeriod(context);

        //08.
        //output = GetAddressesByTown(context);

        //09.
        //output = GetEmployee147(context);

        //10.
        //output = GetDepartmentsWithMoreThan5Employees(context);

        //11.
        //output = GetLatestProjects(context);

        //12.
        //output = IncreaseSalaries(context);

        //13.
        //output = GetEmployeesByFirstNameStartingWithSa(context);

        //14.
        //output = DeleteProjectById(context);

        //15.
        //output = RemoveTown(context);

        Console.WriteLine(output);
    }

    //03.Employees Full Information
    public static string GetEmployeesFullInformation(SoftUniContext context)
    {
        var employees = context.Employees
            .Select(e => new { e.EmployeeId, e.FirstName, e.LastName, e.MiddleName, e.JobTitle, e.Salary })
            .OrderBy(e => e.EmployeeId)
            .ToList();

        StringBuilder sb = new StringBuilder();

        foreach (var employee in employees)
        {
            sb.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:F2}");
        }

        return sb.ToString().TrimEnd();
    }

    //04.Employees with Salary Over 50,000
    public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
    {
        var employees = context.Employees
            .Select(e => new { e.FirstName, e.Salary })
            .Where(e => e.Salary > 50000)
            .OrderBy(e => e.FirstName)
            .ToList();

        StringBuilder sb = new StringBuilder();

        foreach (var employee in employees)
        {
            sb.AppendLine($"{employee.FirstName} - {employee.Salary:F2}");
        }

        return sb.ToString().TrimEnd();
    }

    //05.Employees from Research and Development
    public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
    {
        var employees = context.Employees
            .Where(e => e.Department.Name == "Research and Development")
            .Select(e => new { e.FirstName, e.LastName, e.Department, e.Salary })
            .OrderBy(e => e.Salary)
            .ThenByDescending(e => e.FirstName)
            .ToList();

        StringBuilder sb = new StringBuilder();

        foreach (var employee in employees)
        {
            sb.AppendLine($"{employee.FirstName} {employee.LastName} from {employee.Department.Name} - ${employee.Salary:F2}");
        }

        return sb.ToString().TrimEnd();
    }

    //06.Adding a New Address and Updating Employee
    public static string AddNewAddressToEmployee(SoftUniContext context)
    {
        //Setting the address
        Address address = new Address();
        address.AddressText = "Vitoshka 15";
        address.TownId = 4;

        context.Addresses.Add(address);
        context.SaveChanges();

        //Employee
        var searchedEmployee = context.Employees
            .Where(e => e.LastName == "Nakov")
            .FirstOrDefault();

        searchedEmployee.Address = address;
        context.SaveChanges();

        //Selection
        var employees = context.Employees
            .Select(e => new { e.AddressId, e.Address })
            .OrderByDescending(e => e.AddressId)
            .Take(10);

        //Output
        StringBuilder sb = new StringBuilder();

        foreach (var employee in employees)
        {
            sb.AppendLine($"{employee.Address.AddressText}");
        }

        return sb.ToString().TrimEnd();
    }

    //07.Employees and Projects
    public static string GetEmployeesInPeriod(SoftUniContext context)
    {
        var EmployeeInfo = context.Employees
            .Take(10)
            .Select(e => new
            {
                e.FirstName,
                e.LastName,
                ManagerFirstName = e.Manager.FirstName,
                ManagerLastName = e.Manager.LastName,
                Projects = e.EmployeesProjects.Where(ep => ep.Project.StartDate.Year >= 2001 & ep.Project.StartDate.Year <= 2003)
                    .Select(ep => new
                    {
                        ProjectName = ep.Project.Name,
                        StartDate = ep.Project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
                        EndDate = ep.Project.EndDate != null
                            ? ep.Project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)
                            : "not finished"
                    })
            })
            .ToList();

        StringBuilder sb = new StringBuilder();

        foreach (var e in EmployeeInfo)
        {
            sb.AppendLine($"{e.FirstName} {e.LastName} - Manager: {e.ManagerFirstName} {e.ManagerLastName}");

            if (e.Projects.Any())
            {
                sb.AppendLine(String.Join(Environment.NewLine, e.Projects
                    .Select(p => $"--{p.ProjectName} - {p.StartDate} - {p.EndDate}")));
            }
        }

        return sb.ToString().TrimEnd();
    }

    //08.Addresses by Town
    public static string GetAddressesByTown(SoftUniContext context)
    {
        string[] addressesInfo = context.Addresses
            .OrderByDescending(a => a.Employees.Count)
            .ThenBy(a => a.Town.Name)
            .ThenBy(a => a.AddressText)
            .Take(10)
            .Select(a => $"{a.AddressText}, {a.Town.Name} - {a.Employees.Count} employees")
            .ToArray();

        return string.Join(Environment.NewLine, addressesInfo);
    }

    //09.Employee 147
    public static string GetEmployee147(SoftUniContext context)
    {
        var employee147Info = context.Employees
            .Where(e => e.EmployeeId == 147)
            .Select(x => new
            {
                x.FirstName,
                x.LastName,
                x.JobTitle,
                Projects = x.EmployeesProjects.Select(p => new { p.Project.Name }).OrderBy(p => p.Name).ToArray()
            })
            .FirstOrDefault();

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{employee147Info.FirstName} {employee147Info.LastName} - {employee147Info.JobTitle}");
        sb.Append(string.Join(Environment.NewLine, employee147Info.Projects.Select(p => p.Name)));

        return sb.ToString().TrimEnd();
    }

    //10.Departments with More Than 5 Employees
    public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
    {
        var departmentsInfo = context.Departments
            .Where(d => d.Employees.Count > 5)
            .OrderBy(d => d.Employees.Count)
            .ThenBy(d => d.Name)
            .Select(d => new
            {
                DepartmentName = d.Name,
                ManagerName = d.Manager.FirstName + " " + d.Manager.LastName,
                Employees = d.Employees
                    .OrderBy(e => e.FirstName)
                    .ThenBy(e => e.LastName)
                    .Select(e => new
                    {
                        EmployeeData = $"{e.FirstName} {e.LastName} - {e.JobTitle}"
                    })
                    .ToArray()
            })
            .ToArray();

        StringBuilder sb = new StringBuilder();
        foreach (var d in departmentsInfo)
        {
            sb.AppendLine($"{d.DepartmentName} - {d.ManagerName}");
            sb.Append(string.Join(Environment.NewLine, d.Employees.Select(e => e.EmployeeData)));
        }

        return sb.ToString().TrimEnd();
    }

    //11.Find Latest 10 Projects
    public static string GetLatestProjects(SoftUniContext context)
    {
        var projectsInfo = context.Projects
            .OrderByDescending(p => p.StartDate)
            .Take(10)
            .OrderBy(p => p.Name)
            .Select(p => new
            {
                p.Name,
                p.Description,
                StartDate = p.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
            })
            .ToArray();

        StringBuilder sb = new StringBuilder();
        foreach (var p in projectsInfo)
        {
            sb.AppendLine(p.Name);
            sb.AppendLine(p.Description);
            sb.AppendLine(p.StartDate);
        }

        return sb.ToString().TrimEnd();
    }

    //12.Increase Salaries
    public static string IncreaseSalaries(SoftUniContext context)
    {
        decimal salaryModifier = 1.12m;
        string[] departmentNames = new string[] { "Engineering", "Tool Design", "Marketing", "Information Services" };

        var employeesForSalaryIncrease = context.Employees
            .Where(e => departmentNames.Contains(e.Department.Name))
            .ToArray();

        foreach (var e in employeesForSalaryIncrease)
        {
            e.Salary *= salaryModifier;
        }

        context.SaveChanges();

        string[] emplyeesInfoText = context.Employees
            .Where(e => departmentNames.Contains(e.Department.Name))
            .OrderBy(e => e.FirstName)
            .ThenBy(e => e.LastName)
            .Select(e => $"{e.FirstName} {e.LastName} (${e.Salary:f2})")
            .ToArray();

        return string.Join(Environment.NewLine, emplyeesInfoText);
    }

    //13.Find Employees by First Name Starting With Sa
    public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
    {
        string[] employeesInfoText = context.Employees
            .Where(e => e.FirstName.Substring(0, 2).ToLower() == "sa")
            .OrderBy(e => e.FirstName)
            .ThenBy(e => e.LastName)
            .Select(e => $"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:f2})")
            .ToArray();

        return string.Join(Environment.NewLine, employeesInfoText);
    }

    //14.Delete Project by Id
    public static string DeleteProjectById(SoftUniContext context)
    {
        var employeesProjectsToDelete = context.EmployeesProjects.Where(ep => ep.ProjectId == 2);
        context.EmployeesProjects.RemoveRange(employeesProjectsToDelete);

        var projectToDelete = context.Projects.Where(p => p.ProjectId == 2);
        context.Projects.RemoveRange(projectToDelete);

        context.SaveChanges();

        string[] projectsNames = context.Projects
            .Take(10)
            .Select(p => p.Name)
            .ToArray();

        return string.Join(Environment.NewLine, projectsNames);
    }

    //15.Remove Town
    public static string RemoveTown(SoftUniContext context)
    {
        Town townToDelete = context.Towns
                .Where(t => t.Name == "Seattle")
                .FirstOrDefault();

        Address[] addressesToDelete = context.Addresses
            .Where(a => a.TownId == townToDelete.TownId)
            .ToArray();

        Employee[] employeesToRemoveAddressFrom = context.Employees
            .Where(e => addressesToDelete
            .Contains(e.Address))
            .ToArray();

        foreach (Employee e in employeesToRemoveAddressFrom)
        {
            e.AddressId = null;
        }

        context.Addresses.RemoveRange(addressesToDelete);
        context.Towns.Remove(townToDelete);
        context.SaveChanges();

        return $"{addressesToDelete.Count()} addresses in Seattle were deleted";
    }
}