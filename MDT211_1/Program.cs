using System;
using MDT211_1.Model;

enum Menu
{
    Register = 1,
    GetStatistics,
    Login
}
enum MenuLogin
{
    Register = 1,
    ShowPresentStudent,
    ShowStudent,
    ShowTeacher,
    Logout
}
enum TypeRegister
{
    PresentStudent = 1,
    Student,
    Teacher
}
class PresentStudentList
{
    private List<PresentStudent> presentStudentLs;

    public PresentStudentList()
    {
        this.presentStudentLs = new List<PresentStudent>();
    }

    public void AddPresentStudent(PresentStudent PStudent)
    {
        this.presentStudentLs.Add(PStudent);
    }

    public void GetAllPresentStudent()
    {
        Console.WriteLine("List PresentStudent");
        Console.WriteLine("---------------------");
        foreach (PresentStudent PStudent in this.presentStudentLs)
        {
                Console.WriteLine("Title: {0}\nFirstName: {1} \nLastName: {2} \n"
                , PStudent.GetTitle(), PStudent.GetFirstName(), PStudent.GetLastName());
        }

    }
    public bool CheckDuplicate(PresentStudent presentStudent)
    {
        foreach (PresentStudent PStudent in this.presentStudentLs)
        {
            if (presentStudent.GetFullName() == PStudent.GetFullName())
            {
                return false;
            }
        }
        return true;
    }
    public bool CheckEmail(PresentStudent presentStudent)
    {
        if (presentStudent.GetAdminFlag() == "Yes")
        {
            foreach (PresentStudent PStudent in this.presentStudentLs)
            {
                if (presentStudent.GetEmail() == PStudent.GetEmail())
                {
                    return false;
                }
            }
        }

        return true;
    }
    public bool CheckLogin(string email, string pass)
    {
        foreach (PresentStudent PStudent in this.presentStudentLs)
        {
            if (PStudent.UserLogin(email, pass))
            {
                return true;
            }
        }
        return false;
    }
    public void GetCount()
    {
        int count = 0;
        foreach (PresentStudent PStudent in this.presentStudentLs)
        {
            count++;
        }
        Console.WriteLine("Number Of PresentStudent Registered: {0}", count);
    }
}
class StudentList
{
    private List<Student> studentLs;

    public StudentList()
    {
        this.studentLs = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        this.studentLs.Add(student);
    }

    public void GetAllStudent()
    {
        Console.WriteLine("List Student");
        Console.WriteLine("---------------------");
        foreach (Student student in this.studentLs)
        {
            Console.WriteLine("Title: {0}\nFirstName: {1} \nLastName: {2} \n"
            , student.GetTitle(), student.GetFirstName(), student.GetLastName());
        }
    }
    public bool CheckDuplicate(Student student)
    {
        foreach (Student stud in this.studentLs)
        {
            if (student.GetFullName() == stud.GetFullName())
            {
                return false;
            }
        }
        return true;
    }
    public void GetCount()
    {
        int count = 0;
        foreach (Student student in this.studentLs)
        {
            count++;
        }
        Console.WriteLine("Number Of Student Registered: {0}", count);
    }
    public void GetCountLevel4()
    {
        int countLv4 = 0;
        foreach (Student student in this.studentLs)
        {
            if (student.GetLevelOfEducation() == "มัธยมศึกษาปีที่ 4")
            {
                countLv4++;
            }
        }
        Console.WriteLine("Number Of Student Registered High School 4: {0}", countLv4);
    }
    public void GetCountLevel5()
    {
        int countLv4 = 0;
        foreach (Student student in this.studentLs)
        {
            if (student.GetLevelOfEducation() == "มัธยมศึกษาปีที่ 5")
            {
                countLv4++;
            }
        }
        Console.WriteLine("Number Of Student Registered High School 5: {0}", countLv4);
    }
    public void GetCountLevel6()
    {
        int countLv4 = 0;
        foreach (Student student in this.studentLs)
        {
            if (student.GetLevelOfEducation() == "มัธยมศึกษาปีที่ 6")
            {
                countLv4++;
            }
        }
        Console.WriteLine("Number Of Student Registered High School 6: {0}", countLv4);
    }
}
class TeacherList
{
    private List<Teacher> teacherLs;

    public TeacherList()
    {
        this.teacherLs = new List<Teacher>();
    }

    public void AddTeacher(Teacher teach)
    {
        this.teacherLs.Add(teach);
    }

    public void GetAllTeacher()
    {
        Console.WriteLine("List Teacher");
        Console.WriteLine("---------------------");
        foreach (Teacher teach in this.teacherLs)
        {
            Console.WriteLine("Title: {0}\nFirstName: {1} \nLastName: {2} \n"
            , teach.GetTitle(), teach.GetFirstName(), teach.GetLastName());
        }
    }
    public bool CheckDuplicate(Teacher teacher)
    {
        foreach (Teacher teach in this.teacherLs)
        {
            if (teacher.GetFullName() == teach.GetFullName())
            {
                return false;
            }
        }
        return true;
    }
    public bool CheckEmail(Teacher teacher)
    {
        if (teacher.GetAdminFlag() == "Yes")
        {
            foreach (Teacher teach in this.teacherLs)
            {
                if (teacher.GetEmail() == teach.GetEmail())
                {
                    return false;
                }
            }
        }

        return true;
    }
    public void GetCount()
    {
        int count = 0;
        foreach (Teacher teach in this.teacherLs)
        {
            count++;
        }
        Console.WriteLine("Number Of Teacher Registered: {0}", count);
    }
    public bool CheckLogin(string email, string pass)
    {
        foreach (Teacher teach in this.teacherLs)
        {
            if (teach.UserLogin(email, pass))
            {
                return true;
            }
        }
        return false;
    }
}

namespace MDT211
{

    class Program
    {
        static PresentStudentList presentStudentList;
        static StudentList studentList;
        static TeacherList teacherList;

        static void ProgramIsLoad()
        {
            Program.presentStudentList = new PresentStudentList();
            Program.studentList = new StudentList();
            Program.teacherList = new TeacherList();
        }
        static void Main(string[] args)
        {
            ProgramIsLoad();
            HomeMenu();
        }

        static void HomeMenu()
        {
            Console.Clear();
            PrintHeader();
            PrintListMenu();
            InputMenuFromKeyboard();
        }

        static void PrintHeader()
        {
            Console.WriteLine("Welcome to Idia Camp 2022.");
            Console.WriteLine("----------------------------------------------------");
        }

        static void PrintListMenu()
        {
            Console.WriteLine("1. Register for Idia Camp.");
            Console.WriteLine("2. Statistics Join Idia Camp.");
            Console.WriteLine("3. Login.");
        }
        static void PrintListMenuAfterLogin()
        {
            Console.WriteLine("1. Register for Idia Camp.");
            Console.WriteLine("2. Show All Present Student.");
            Console.WriteLine("3. Show All Student.");
            Console.WriteLine("4. Show All Teacher.");
            Console.WriteLine("5. Logout.");
        }

        static void InputMenuFromKeyboard()
        {
            Console.Write("Please Select Menu: ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));
            PresentMenu(menu);
        }

        static void PresentMenu(Menu menu)
        {
            if (menu == Menu.Register)
            {
                ShowInputRegister();
            }
            else if (menu == Menu.Login)
            {
                InputLogin();
                Console.Clear();
                PrintListMenuAfterLogin();
                Console.Write("Please Select Menu: ");
                MenuLogin menuLogin = (MenuLogin)(int.Parse(Console.ReadLine()));
                ShowMenuAfterLogin(menuLogin);
            }
            else if (menu == Menu.GetStatistics)
            {
                ShowStatistics();
            }
            else
            {
                ShowMessageIsInCorrect();
            }
        }
        static void InputLogin()
        {
            Console.Write("Input Email: ");
            var email = Console.ReadLine();
            if (email?.ToLower() == "exit")
            {
                HomeMenu();
            }
            Console.Write("Input Password: ");
            var password = Console.ReadLine();
            bool statusLogin = presentStudentList.CheckLogin(email, password);
            if (!statusLogin)
            {
                statusLogin = teacherList.CheckLogin(email, password);
            }
            if (!statusLogin)
            {
                Console.WriteLine("Incorrect email or password. Please try again.");
                InputLogin();
            }

        }
        static void ShowMenuAfterLogin(MenuLogin menuLogin) 
        {
            if (menuLogin == MenuLogin.Register)
            {
                ShowInputRegister();
            }
            else if (menuLogin == MenuLogin.ShowPresentStudent)
            {
                presentStudentList.GetAllPresentStudent();
                Console.WriteLine("Press Any Key to Continue...");
                Console.ReadLine();
                HomeMenu();
            }
            else if (menuLogin == MenuLogin.ShowStudent)
            {
                studentList.GetAllStudent();
                Console.WriteLine("Press Any Key to Continue...");
                Console.ReadLine();
                HomeMenu();
            }
            else if (menuLogin == MenuLogin.ShowTeacher)
            {
                teacherList.GetType();
                Console.WriteLine("Press Any Key to Continue...");
                Console.ReadLine();
                HomeMenu();
            }
            else if (menuLogin == MenuLogin.Logout)
            {
                HomeMenu();
            }
            else
            {
                ShowMessageIsInCorrect();
            }
        }
        static void ShowStatistics()
        {
            teacherList.GetCount();
            studentList.GetCount();
            presentStudentList.GetCount();
            studentList.GetCountLevel4();
            studentList.GetCountLevel5();
            studentList.GetCountLevel6();
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadLine();
            HomeMenu();
        }
        static void ShowInputRegister()
        {
            Console.Clear();
            PrintHeaderRegister();
        }

        static void PrintHeaderRegister()
        {
            Console.Clear();
            Console.WriteLine("Register for Idia Camp.");
            Console.WriteLine("---------------------");
            TypeRegister typeRegister = SelectTypeRegister();
            InputTypeRegister(typeRegister);

        }
        static TypeRegister SelectTypeRegister()
        {
            Console.Clear();
            Console.Write("Input Type Register: \n");
            Console.WriteLine("1. PresentStudent.");
            Console.WriteLine("2. Student.");
            Console.WriteLine("3. Teacher.");
            return (TypeRegister)(int.Parse(Console.ReadLine()));
        }

        static void InputTypeRegister(TypeRegister type)
        {
            
            if (TypeRegister.PresentStudent == type)
            {
                PresentStudent presentStudent = CreatePresentStudent();
                if (presentStudent != null)
                {
                    if (!Program.presentStudentList.CheckDuplicate(presentStudent))
                    {
                        Console.WriteLine("User is already registered. Please try again.");
                        InputTypeRegister(type);
                    }
                    if (!Program.presentStudentList.CheckEmail(presentStudent))
                    {
                        Console.WriteLine("Invalid email. Please try again.");
                        InputTypeRegister(type);
                    }
                    Program.presentStudentList.AddPresentStudent(presentStudent);
                    HomeMenu();
                }
                else
                {
                    InputTypeRegister(type);
                }

            }
            else if (TypeRegister.Student == type)
            {
                Student student = CreateStudent();
                if (student != null)
                {
                    if (!Program.studentList.CheckDuplicate(student))
                    {
                        Console.WriteLine("User is already registered. Please try again.");
                        InputTypeRegister(type);
                    }

                    Program.studentList.AddStudent(student);
                    HomeMenu();
                }
                else
                {
                    InputTypeRegister(type);
                }
            }
            else if (TypeRegister.Teacher == type)
            {
                Teacher teacher = CreateTeacher();
                if (teacher != null)
                {
                    if (!Program.teacherList.CheckDuplicate(teacher))
                    {
                        Console.WriteLine("User is already registered. Please try again.");
                        InputTypeRegister(type);
                    }
                    if (!Program.teacherList.CheckEmail(teacher))
                    {
                        Console.WriteLine("Invalid email. Please try again.");
                        InputTypeRegister(type);
                    }
                    Program.teacherList.AddTeacher(teacher);
                    HomeMenu();
                }
                else
                {
                    InputTypeRegister(type);
                }
            }
            else
            {
                ShowMessageIsInCorrect();
            }
           
        }

        static PresentStudent? CreatePresentStudent()
        {
            Console.Write("Title Name Select 1.นาย 2.นาง 3.นางสาว : ");
            var title = Console.ReadLine();

            while (true)
            {
                if (title == "1")
                {
                    title = "นาย";
                    break;

                }
                else if (title == "2")
                {
                    title = "นาง";
                    break;
                }
                else if (title == "3")
                {
                    title = "นางสาว";
                    break;
                }
                else
                {
                    Console.WriteLine("Title Name Incorrect Please try again.");
                    title = Console.ReadLine();
                }
            }

            Console.Write("First Name: ");
            var firstname = Console.ReadLine();
            Console.Write("Last Name: ");
            var lastname = Console.ReadLine();
            Console.Write("StudentId: ");
            var studentId = Console.ReadLine();
            Console.Write("Age: ");
            var age = Console.ReadLine();
            Console.Write("Allergy: ");
            var allergy = Console.ReadLine();
            Console.Write("Religion Select 1.พุทธ 2.คริสต์ 3.อิสลาม 4.อื่นๆ: ");
            var religion = Console.ReadLine();
            while (true)
            {
                if (religion == "1")
                {
                    religion = "พุทธ";
                    break;

                }
                else if (religion == "2")
                {
                    religion = "คริสต์";
                    break;
                }
                else if (religion == "3")
                {
                    religion = "อิสลาม";
                    break;
                }
                else if (religion == "4")
                {
                    religion = "อื่นๆ";
                    break;
                }
                else
                {
                    Console.WriteLine("Religion Incorrect Please try again.");
                    religion = Console.ReadLine();
                }
            }
            Console.Write("Admin ? (Y/N): ");
            var adminFlag = Console.ReadLine();
            var email = "";
            var password = "";
            if (adminFlag == "Y")
            {
                Console.Write("Email :");
                email = Console.ReadLine();
                if (email == "exit")
                {
                    Console.WriteLine("Invalid email. Please try again.");
                    return null;
                }
                Console.Write("Password :");
                password = Console.ReadLine();
            }
            var result = new PresentStudent(title, firstname, lastname, age, religion, allergy, studentId, adminFlag, email, password);
            return result;
        }
        static Student? CreateStudent()
        {
            Console.Write("Title Name Select 1.นาย 2.นาง 3.นางสาว : ");
            var title = Console.ReadLine();

            while (true)
            {
                if (title == "1")
                {
                    title = "นาย";
                    break;

                }
                else if (title == "2")
                {
                    title = "นาง";
                    break;
                }
                else if (title == "3")
                {
                    title = "นางสาว";
                    break;
                }
                else
                {
                    Console.WriteLine("Title Name Incorrect Please try again.");
                    title = Console.ReadLine();
                }
            }

            Console.Write("First Name: ");
            var firstname = Console.ReadLine();
            Console.Write("Last Name: ");
            var lastname = Console.ReadLine();
            Console.Write("Age: ");
            var age = Console.ReadLine();
            Console.Write("Level Of Education 1.มัธยมศึกษาปีที่ 4 , 2.มัธยมศึกษาปีที่ 5, 3.มัธยมศึกษาปีที่ 6: ");
            var levelOfEducation = Console.ReadLine();

            while (true)
            {
                if (levelOfEducation == "1")
                {
                    levelOfEducation = "มัธยมศึกษาปีที่ 4";
                    break;

                }
                else if (levelOfEducation == "2")
                {
                    levelOfEducation = "มัธยมศึกษาปีที่ 5";
                    break;
                }
                else if (levelOfEducation == "3")
                {
                    levelOfEducation = "มัธยมศึกษาปีที่ 6";
                    break;
                }
                else
                {
                    Console.WriteLine("Level Of Education Incorrect Please try again.");
                    levelOfEducation = Console.ReadLine();
                }
            }
            Console.Write("Allergy Name: ");
            var allergy = Console.ReadLine();
            Console.Write("Religion Select 1.พุทธ 2.คริสต์ 3.อิสลาม 4.อื่นๆ: ");
            var religion = Console.ReadLine();
            while (true)
            {
                if (religion == "1")
                {
                    religion = "พุทธ";
                    break;

                }
                else if (religion == "2")
                {
                    religion = "คริสต์";
                    break;
                }
                else if (religion == "3")
                {
                    religion = "อิสลาม";
                    break;
                }
                else if (religion == "4")
                {
                    religion = "อื่นๆ";
                    break;
                }
                else
                {
                    Console.WriteLine("Religion Incorrect Please try again.");
                    religion = Console.ReadLine();
                }
            }

            Console.Write("School Name: ");
            var School = Console.ReadLine();


            var result = new Student(title, firstname, lastname, age, religion, allergy, levelOfEducation, School);
            return result;
        }

        static Teacher? CreateTeacher()
        {
            Console.Write("Title Name Select 1.นาย 2.นาง 3.นางสาว : ");
            var title = Console.ReadLine();

            while (true)
            {
                if (title == "1")
                {
                    title = "นาย";
                    break;

                }
                else if (title == "2")
                {
                    title = "นาง";
                    break;
                }
                else if (title == "3")
                {
                    title = "นางสาว";
                    break;
                }
                else
                {
                    Console.WriteLine("Title Name Incorrect Please try again.");
                    title = Console.ReadLine();
                }
            }

            Console.Write("First Name: ");
            var firstname = Console.ReadLine();
            Console.Write("Last Name: ");
            var lastname = Console.ReadLine();
            Console.Write("Age: ");
            var age = Console.ReadLine();

            Console.Write("Position Select 1.คณบดี 2.หัวหน้าภาควิชา 3.อาจารย์ประจำ : ");
            var position = Console.ReadLine();

            while (true)
            {
                if (position == "1")
                {
                    position = "คณบดี";
                    break;

                }
                else if (position == "2")
                {
                    position = "หัวหน้าภาควิชา";
                    break;
                }
                else if (position == "3")
                {
                    position = "อาจารย์ประจำ";
                    break;
                }
                else
                {
                    Console.WriteLine("Position Incorrect Please try again.");
                    position = Console.ReadLine();
                }
            }

            Console.Write("Allergy: ");
            var allergy = Console.ReadLine();
            Console.Write("Religion Select 1.พุทธ 2.คริสต์ 3.อิสลาม 4.อื่นๆ: ");
            var religion = Console.ReadLine();
            while (true)
            {
                if (religion == "1")
                {
                    religion = "พุทธ";
                    break;

                }
                else if (religion == "2")
                {
                    religion = "คริสต์";
                    break;
                }
                else if (religion == "3")
                {
                    religion = "อิสลาม";
                    break;
                }
                else if (religion == "4")
                {
                    religion = "อื่นๆ";
                    break;
                }
                else
                {
                    Console.WriteLine("Religion Incorrect Please try again.");
                    religion = Console.ReadLine();
                }
            }

            Console.Write("Bring a car ? (Y/N): ");
            var haveCar = Console.ReadLine();
            var licenseno = "";
            if (haveCar == "Y")
            {
                Console.Write("License No. :");
                licenseno = Console.ReadLine();
            }

            Console.Write("Admin ? (Y/N): ");
            var adminFlag = Console.ReadLine();
            var email = "";
            var password = "";
            if (adminFlag == "Y")
            {
                Console.Write("Email :");
                email = Console.ReadLine();
                if (email == "exit")
                {
                    Console.WriteLine("Invalid email. Please try again.");
                    return null;
                }
                Console.Write("Password :");
                password = Console.ReadLine();
            }
            var result = new Teacher(title, firstname, lastname, age, religion, allergy, position, haveCar, licenseno, adminFlag, email, password);
            return result;
        }
        static void ShowMessageIsInCorrect()
        {
            Console.WriteLine("Menu Incorrect Please try again.");
            InputMenuFromKeyboard();
        }
    }

}