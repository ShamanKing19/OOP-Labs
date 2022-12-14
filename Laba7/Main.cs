namespace Laba7
{
    public static class Laba7
    {
        public static void Main()
        {
            EmployeeRole[] roles1 = new EmployeeRole[] { EmployeeRole.Support };
            EmployeeRole[] roles2 = new EmployeeRole[] { EmployeeRole.Manager };
            EmployeeRole[] roles3 = new EmployeeRole[] { EmployeeRole.Programmer };
            EmployeeRole[] roles4 = new EmployeeRole[] { EmployeeRole.Support, EmployeeRole.Manager };
            EmployeeRole[] roles5 = new EmployeeRole[] { EmployeeRole.Manager, EmployeeRole.Programmer};
           
            string[] languages1 = new string[] {"ru"};
            string[] languages2 = new string[] {"ru", "en"};
            string[] languages3 = new string[] {"hz", "ru", "petuhon"};
            string[] languages4 = new string[] {"en", "de", "javaScript"};
            string[] languages5 = new string[] {"fr", "ne"};

            Employee employee1 = new Employee("Олег", "Какойтович", null, "89118898989", roles1, languages1);
            Employee employee2 = new Employee("Алексей", "Арбузов", "nagibator2000@mail.ru", null, roles2, languages2);
            Employee employee3 = new Employee("Максим", "Подручкин", null, null, roles3, languages3);
            Employee employee4 = new Employee("Андрей", "Головкин", "zxc@ghoul.die", "892166696669", roles4, languages4);
            Employee employee5 = new Employee("Георгий", "Сухомлин", "billy.herrington@king.gym", null, roles5, languages5);
            Employee employee6 = new Employee("Аркадий", "Абобов", "asd@asd.asd", "+79123456789", roles1, languages1);
            Employee employee7 = new Employee("Ван", "Даркхолм", "qwe@qwe.qwe", "+79999999999", roles2, languages2);
            Employee employee8 = new Employee("Леон", "Бравлович", "zxc@zxc.zxc", "88000000000", roles3, languages3);
            Employee employee9 = new Employee("Джейсон", "Стэйтем", "www@www.www", null, roles3, languages1);
            Employee employee10 = new Employee("Тухтылбек", "Варгифов", "brug@bruh.bruh", null, roles3, languages1);

            List<Employee> staff = new List<Employee>() { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10 };
            
            // 1). Пользователи, у которых есть email и первый язык указан "ru", а второй "en"
            List<string> russianStaffWithFirstRuLang = getRussianEmployeesWithEmail(staff);
            foreach (string employee in russianStaffWithFirstRuLang)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine();

            // 2). Описание пользователя строкой
            List<string> staffInfoList = getEmployeesInfo(staff);
            foreach (string employee in staffInfoList)
            {
                Console.WriteLine(employee);
            }
        }


        private static List<string> getEmployeesInfo(List<Employee> staff)
        {
            List<string> filteredList = new List<string>();

            foreach (var employee in staff)
            {
                string name = $"{employee.FirstName}, {employee.SecondName}";
                string languages = string.Join(", ", employee.Languages);
                
                if (
                    employee.Phone is not null 
                    && employee.Email is not null
                    && employee.Languages.Length == 3
                ) {
                    if (employee.Roles.Contains(EmployeeRole.Support))
                    {
                        filteredList.Add($"ФИО: {name}, Email: {employee.Email}, Phone: {employee.Phone}, Поддержка говорит на трех языках: {languages}");
                    }
                    
                    if (employee.Roles.Contains(EmployeeRole.Manager)) {
                        filteredList.Add($"ФИО: {name}, Email: {employee.Email}, Phone: {employee.Phone}, Менеджер говорит на трех языках: {languages}");
                    }
                    
                    if (employee.Roles.Contains(EmployeeRole.Programmer)) {
                        filteredList.Add($"ФИО: {name}, Email: {employee.Email}, Phone: {employee.Phone}, Программист говорит на трех языках: {languages}");
                    }
                } else if (
                    employee.Phone is not null 
                    && employee.Email is not null
                    && employee.Languages.Length == 2
                ) {
                    if (employee.Roles.Contains(EmployeeRole.Support))
                    {
                        filteredList.Add($"ФИО: {name}, Email: {employee.Email}, Phone: {employee.Phone}, Поддержка говорит на двух языках: {languages}");
                    }
                    
                    if (employee.Roles.Contains(EmployeeRole.Manager)) {
                        filteredList.Add($"ФИО: {name}, Email: {employee.Email}, Phone: {employee.Phone}, Менеджер говорит на двух языках: {languages}");
                    }
                    
                    if (employee.Roles.Contains(EmployeeRole.Programmer)) {
                        filteredList.Add($"ФИО: {name}, Email: {employee.Email}, Phone: {employee.Phone}, Программист говорит на двух языках: {languages}");
                    }
                } else if (
                    employee.Email is not null
                    && employee.Phone is null
                    && employee.Languages.Length == 1
                ) {
                    if (employee.Roles.Contains(EmployeeRole.Support))
                    {
                        filteredList.Add($"ФИО: {name}, Email: {employee.Email}, Поддержка знает один язык: {languages}");
                    } 
                    
                    if (employee.Roles.Contains(EmployeeRole.Manager)) {
                        filteredList.Add($"ФИО: {name}, Email: {employee.Email}, Менеджер знает один язык: {languages}");
                    } 
                    
                    if (employee.Roles.Contains(EmployeeRole.Programmer)) {
                        filteredList.Add($"ФИО: {name}, Email: {employee.Email}, Программист знает один язык: {languages}");
                    }
                }
            }

            return filteredList;
        }

        private static List<string> getRussianEmployeesWithEmail(List<Employee> staff)
        {
            List<string> filteredList = new List<string>();
            foreach (Employee employee in staff)
            {
                if (
                    employee.Email is not null 
                    && employee.Languages.Length >= 2
                ) {
                    if (employee.Languages[0] == "ru" && employee.Languages[1] == "en")
                    {
                        string roles = string.Join(", ", employee.Roles);
                        filteredList.Add($"ФИО: {employee.FirstName} {employee.SecondName}, Email: {employee.Email}, Roles: {roles}");
                    }
                }
            }

            return filteredList;
        }
    }


    public enum EmployeeRole
    {
        Support,
        Manager,
        Programmer
    }
}
