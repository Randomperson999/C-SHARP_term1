/* 
Name: Caleb Keller
Start Date: 9/21/2021 12:27PM
Chapter 2 Project
*/

/*
 Notes:
 Tested By: Dyson Smith
Grade A
*/

//imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2_1
{
    class Program
    {
        static void Main(string[] args)//static: can be run without instance elsewhere,
                                       //void: returns no values, Main:name,
                                       //() argument: parameters
        {
            //get info
            Console.Write("What is your name?:\n");
            String name = Console.ReadLine();//1

            Console.Write("What is your middle name?:\n");
            String middleName = Console.ReadLine();//2

            Console.Write("What is your last name?:\n");
            String lastName = Console.ReadLine();//3

            Console.Write("What is your age?:\n");
            String age = Console.ReadLine();//4

            Console.Write("What is your grade?:\n");
            String grade = Console.ReadLine();//5

            Console.Write("What is your social security number?:\n");
            String social_securityNum = Console.ReadLine();//6

            Console.Write("What is your phone number?:\n");
            String phoneNum = Console.ReadLine();//7

            Console.Write("What is your address?:\n");
            String address = Console.ReadLine();//8

            Console.Write("What does your room look like?:\n");
            String roomDescription = Console.ReadLine();//9

            Console.Write("What is your mothers name? (If you don't have one type N/A):\n");
            String parentName1 = Console.ReadLine();//10

            Console.Write("What is your father's name or gaurdian's name? (If you don't have one type N/A):\n");
            String parentName2 = Console.ReadLine();//11

            Console.Write("What school do you go to? (If you don't go to one, type N/A):\n");
            String school = Console.ReadLine();//12

            Console.Write("Do you have anyone living with you?:\n");
            String one_livingWith = Console.ReadLine();//13

            Console.Write("If an assassin came to your house would anyone notice?:\n");
            String noticeAssassin = Console.ReadLine();//14

            Console.Write("How well do you feel like you can fight?:\n");
            String fightAbility = Console.ReadLine();//15

            Console.Write("Is this a random poorly written script by a kid in senior year for a coding class?:\n");
            String written_byKid = Console.ReadLine();//16

            Console.Write("Is this fun?:\n");
            String fun = Console.ReadLine();//17

            Console.Write("Have you been honest in your answers?:\n");
            String honesty = Console.ReadLine();//18

            Console.Write("Do you realize the weirdo who made this doesn't know how to save data, so there's no problem?:\n");
            String knows_no_savaData = Console.ReadLine();//19

            Console.Write("Do you feel like you're wasting your time?:\n");
            String timeWaste = Console.ReadLine();//20

            Console.Write("How are you doing today?:\n");
            String emotion = Console.ReadLine();//21

            Console.Write("Do you feel accomplished?:\n");
            String accomplished = Console.ReadLine();//22

            Console.Write("Are you prepared for the last question?:\n");
            String ready = Console.ReadLine();//23

            Console.Write("Are you sure?:\n");
            String sure = Console.ReadLine();//24

            Console.Write("Really?:\n");
            String really = Console.ReadLine();//25

            Console.Write("Really???:\n");
            String really2 = Console.ReadLine();//26

            Console.Write("Are you really sure you're ready:\n");
            String trulyReady = Console.ReadLine(); //27

            Console.Write("Side question, What is your favorite show?:\n");
            String favShow = Console.ReadLine(); //28

            Console.Write("Another side question, are you tired?:\n");
            String tired = Console.ReadLine(); //29

            Console.Write("Are you sure this is all a joke?:\n");
            String joke = Console.ReadLine(); //30
            Console.WriteLine();

            //print it all out
            Console.WriteLine(name+"\n"+middleName + "\n" +lastName + "\n" +age);
            Console.WriteLine(grade + "\n" + social_securityNum + "\n" + phoneNum + "\n" + address);
            Console.WriteLine(roomDescription + "\n" + parentName1 + "\n" + parentName2 + "\n" + school + "\n" +one_livingWith);
            Console.WriteLine(noticeAssassin + "\n" + fightAbility + "\n" + written_byKid + "\n" + fun);
            Console.WriteLine(honesty + "\n" + knows_no_savaData + "\n" + timeWaste + "\n" + emotion + "\n" + accomplished);
            Console.WriteLine(ready + "\n" + sure + "\n" + really + "\n" + really2 + "\n" + trulyReady);
            Console.WriteLine(favShow + "\n" + tired + "\n" + joke + "\n\n"+"Yes, this is all a joke and a waste of your time!!!");
            Console.ReadLine();
        }//main

    }//program
}// end of namespace Ch2_1
