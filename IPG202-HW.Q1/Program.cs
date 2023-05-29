using System;

namespace IPG202_HW.Q1
{
    class Program
    {
        /*here we declare our two dimensional Array to 
        store the students data within it*/
        static string[,] students = new string[200, 8];//we have created an array for all the classes in the school
        static int counter = 0;//a counter to move through each record along the array

        /*now we declare a method to fill our array with data
        * which it will be given from the user*/
        static void Registration(string first_name, string last_name, string annual_rate, string dateOfbirth, string Rdate/*registration date*/, string Cyear/*current year*/ )
        {
            int id = counter + 1;
            students[counter, 0] = id.ToString();
            students[counter, 1] = first_name; 
            students[counter, 2] = last_name; 
            students[counter, 3] = annual_rate; 

            /*the average of the annual rates will be calculated in 
             our program then stored in the array so we do the following*/

            float sum = 0, average;
            string[] total = annual_rate.Split('/');/*we split each annual rate here in case we have more than one
                                                     and store it inside an array in order to calculate the average later*/
            int previous_years = total.Length;/*in case the student studied in the school more than one year*/
             
            /*here we creat 'foreach loop' to calculate each average for each student in the array*/
            foreach(string av in total)
            {
                sum += float.Parse(av);
            }
            average = sum / previous_years;

            students[counter, 4] = Math.Round(average).ToString();/*we round to the nearest integer then we stre 
                                                                   the result as a string by converting the rounded result*/
            students[counter, 5] = dateOfbirth; 
            students[counter, 6] = Rdate; 
            students[counter, 7] = Cyear;
           
            counter++;/*we incrase the counter to move to the next record*/
            
        }

       

        static void Main(string[] args)
        {
            Registration("Bassel", "Alhassan", "78", "16/6/1999", "15/10/2020", "2");
            Registration("Zoher", "Alhow", "90/90/85/87", "2/2/2000", "1/6/2017", "5");
            Registration("Ehab", "Hussein", "80/78", "27/10/1999", "17/7/2017", "3");
            Registration("Hamza", "Askar", "78", "25/8/2002", "15/10/2020", "2");
            Registration("Majd", "Falhout", "75/73", "16/6/1999", "17/7/2017", "3");
            Registration("Ghaith", "Zaghlouleh", "85/79", "10/9/1998", "17/7/2017", "3");
            Registration("Taimaa", "AlHamzawi", "70", "14/1/2001", "26/10/2021", "2");
            Registration("Nouha", "Adham", "89/89", "16/2/2000", "17/7/2017", "3");
            Registration("Hassan", "Alkhalaf", "90/90/92", "21/10/1997", "29/6/2016", "4");
            Registration("Fayez", "Anas", "70", "27/3/2001", "15/3/2021", "2");
            Registration("Mouhamad", "Ghayad", "73/82/80/81", "1/1/1998", "1/6/2017", "5");
            Registration("Naaem", "Alhow", "89", "5/4/2002", "8/6/2020", "2");
            Registration("Ammer", "Sukkar", "72", "4/4/2001", "15/10/2020", "2");
            Registration("Sedra", "Daloll", "70", "13/7/2001", "15/10/2020", "2");
            Registration("Feras", "Watfe", "86/75", "16/6/1999", "15/10/2020", "3");
            Registration("Anas", "Haboush", "88/88/90/85", "15/8/1997", "30/10/2016", "5");
            Registration("Besher", "Alhassan", "90", "21/9/2002", "15/10/2020", "2");
            Registration("Ahmad", "Alhassan", "88/85", "14/8/2000", "1/4/2020", "3");
            Registration("Hassan", "Shaker", "69", "4/2/2001", "2/4/2020", "2");
            Registration("Fareed", "Zenbarakji", "76/76", "14/9/1999", "15/6/2017", "3");
            Registration("Wlied", "Salameh", "69", "9/9/1999", "16/10/2020", "2");
            Console.WriteLine("21 students have been registered so far");
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------------");

            //will make a multiple options to let the user choose from
            Console.WriteLine("Select an Option to perform a task:");
            Console.WriteLine(" a . Display the number of registerd students");
            Console.WriteLine(" b . Diplay student rate and his average by his ID");
            Console.WriteLine(" c . Display the names of the top 10 students in the second year");
            Console.WriteLine(" d . Register a new student");
            Console.WriteLine(" e . Display student specification by his full name or by the first 3 characters");
            Console.WriteLine(" f . Exit\n");
            
            /*while loop in case the user wants to keep the whole process*/
            bool x = true;
            while(x == true)
            {
                char Option = char.Parse(Console.ReadLine());
                /* now we will declare a switch statment to move through our options above*/
                switch (Option)
                {
                    case 'a':
                        {
                            Console.Write("Registerd students so far are: " + GivemeCounter());
                            Console.WriteLine("\n-----------------------------------------------------------------------------");
                            break;
                        }

                    case 'b':
                        {
                            Console.Write("Please pass the student ID: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("------------------------------------------------------------------------------");
                            Dis_s_Average(id);/*Display Student Average Procedure, we call it here but we have declare it beneath the Main*/
                            Console.WriteLine("\n------------------------------------------------------------------------------");
                            break;

                        }

                    case 'c':
                        {
                            Top_10_Students();/*we call our procedure that display the top 10 students in the 2nd year*/
                            break;
                        }

                    case 'd':
                        {
                            string first_name, last_name, annual_rate, dateOfbirth, Rdate, Cyear;

                            Console.Write("Register new student: ");
                            Console.Write("\n------------------------------------------------------------------------------\n");
                            Console.Write(" First Name: "); first_name = Console.ReadLine();
                            Console.Write("Last Name: "); last_name = Console.ReadLine();
                            Console.Write("Annual rate for each year(rate1/rate2):  "); annual_rate = Console.ReadLine();
                            Console.Write("Date Of Birth(D/M/Y):  "); dateOfbirth = Console.ReadLine();
                            Console.Write("Regestration Date At School(D/M/Y): "); Rdate = Console.ReadLine();
                            Console.Write("Student Current Year(number): "); Cyear = Console.ReadLine();
                            Registration(first_name, last_name, annual_rate, dateOfbirth, Rdate/*registration date*/, Cyear/*curenet year*/ );/*we call our method to store the new information within the array*/
                            break;
                        }

                    case 'e':
                        {
                            Console.WriteLine("Enter student full name\n press 1\n You don't remember the name?!\n press 2");
                            int num = Int32.Parse(Console.ReadLine());
                            switch (num)
                            {
                                case 1:
                                    {
                                        string FirstName, LastName;
                                        Console.WriteLine("Please pass the student first name : "); FirstName = Console.ReadLine().ToLower();
                                        Console.WriteLine("Please pass the student last name : "); LastName = Console.ReadLine().ToLower();
                                        Display(FirstName, LastName);/*we call this procedure which been declared beneath the main to perform this selection */
                                        break;
                                    }

                                case 2:
                                    {
                                        string stname;
                                        Console.WriteLine("Pass three laters that you can remember in order: ");
                                        stname = Console.ReadLine().ToLower();
                                        DisplayMatches(stname);/*we call this procedure which been declared beneath the main to perform this selection */
                                        break;
                                    }
                            }
                            break;
                        }

                    case 'f':
                        {
                            x = false;
                            break;
                        }



                }
                
            }
          

        }

        public static int GivemeCounter()/*a function to return the counter value when we call it in the Main */
        {
            return counter;
        }

        static void Dis_s_Average(int sid/*student id*/)/*a procedure to perform the second option we used a procedure here to perform multiple tasks that
                                                          that return multiple results */
        {
            for(int i=0; i < counter/*it must be less than the counter because the last index in the array is 19*/; i++)/*the reason bhind the for loop here is to get through each id in the array*/
                if(students[i/*represents the changing record through the array*/, 0/*represents the first field which is the ID*/] == sid.ToString())
                {
                    Console.WriteLine("Student's rate in his previous year" + "         " + "Student's Cumulative rate(Average)");
                    Console.WriteLine("\n------------------------------------------------------------------------------");
                    Console.WriteLine("    " + students[i, 3] + "                                                " + students[i,4]);
                    break;
                }
        }

        static void Top_10_Students()/*a procedure to perform the third option to  display the top 10 students in the 2nd year*/
        {
            int _2nd = 0;/*a variable that presents 2nd year students*/
            string[,] SecondYear = new string[150, 8];/*an array to store the second year students informations*/
            for (int i = 0; i < counter; i++)/*for loop to search through our main students array for every second year student and store in SecondYear array*/
            {
                if (students[i, 7/*the index of the current year in the students array*/] == "2")
                {
                    for (int j = 0; j < 8; j++)
                        SecondYear[_2nd, j] = students[i, j];
                        _2nd++;
                } 
            }
            for (int i = 1; i <= _2nd; i++)/*Algorithm to sort second-year students by their rates*/
            {
                for (int j = 1; j < _2nd; j++)
                {
                    if ( (Int32.Parse(SecondYear[j - 1, 4])) < (Int32.Parse(SecondYear[j, 4])) )
                    {
                        string[] record/*array to store data*/ = new string[8];
                        for (int k = 0; k < 8; k++)
                            record[k] = SecondYear[j - 1, k];

                        for (int k = 0; k < 8; k++)
                            SecondYear[j - 1, k] = SecondYear[j, k];

                        for (int k = 0; k < 8; k++)
                            SecondYear[j, k] = record[k];

                    }
                }
            }
            Console.WriteLine("Top 10 Students in the second year: ");
            Console.WriteLine("Rank" + "               " + "Student Name" + "                    " + "Average");
            Console.WriteLine("------------------------------------------------------------------------------");

            for (int i = 0; i < _2nd; i++)
            {
                if (i == 10)
                    break;

                Console.WriteLine((i + 1) + "          " + SecondYear[i, 1] + "          " + SecondYear[i, 2] + "          " + SecondYear[i, 4]);
            }
        }
        static void Display(string first_name, string last_name)/*a procedure to perform the first selection inside the fifth option */
        {
            int i;
            for(i =0; i < counter; i++)
            {
                if (students[i, 1].ToLower() == first_name && students[i, 2].ToLower() == last_name)
                    break;
            }
            if (i == counter)
                Console.WriteLine("Not found : {0} {1}", first_name, last_name);
            else
            {
                Console.WriteLine("ID     Student Name          Rates   Average  Date of birth    Regisration date   Current year");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------");
                Console.WriteLine(students[i, 0] + "     " + students[i, 1] + " " + students[i, 2] + "         " + students[i, 3] + "      " + students[i, 4] + "      " + students[i, 5] + "         " + students[i, 6] + "                " + students[i, 7]); 
            }
        }

        static void DisplayMatches(string stname)/*a procedure to perform the second selection inside the fifth option */
        {
            int n = 0; //n refers to the cases that can possibly match the user input

            Console.WriteLine("Results that match your input: ");
            Console.WriteLine("ID     Student Name          Rates   Average  Date of birth    Regisration date   Current year");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            for (int i =0; i < counter; i++)
            {
                string foundname = students[i, 1].ToLower();
                if(foundname.IndexOf(stname) >= 0)
                {
                    Console.WriteLine(students[i, 0] + "     " + students[i, 1] + " " + students[i, 2] + "         " + students[i, 3] + "      " + students[i, 4] + "      " + students[i, 5] + "         " + students[i, 6] + "                " + students[i, 7]);
                    n++;
                }
            }
            if (n == 0)
                Console.WriteLine("\n   There's no result for: " + stname);
            else
                Console.WriteLine("Your input matches" + n + "students");

        }


    }
}
