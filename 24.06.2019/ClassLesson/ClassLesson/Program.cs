using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HomeWork Call Function
            //int[] intArr = { 15, 5, 6 };
            //Console.WriteLine(Average(intArr));

            //CountLetter("Kamran");

            //string sentences = "Salam Sirvan necesen";
            //Console.WriteLine(ReverseWordInSent(sentences));
            #endregion
            //Person cavid = new Person();
            //cavid.Name = "Cavid";
            //cavid.Surname = "Bashirov";
            //cavid.Birthday = new DateTime(1993, 10, 5);

            //Job workCavid = new Job();
            //workCavid.Profession = "unemployed";
            //cavid.work = workCavid;
            //Console.WriteLine(cavid.FullInfo());

            //Woman woman1 = new Woman();
            //woman1.Gender = "woman";
            //woman1.Name = "Aynur";
            //woman1.Surname = "Abdullayeva";
            //woman1.Birthday = new DateTime(1991, 2, 5);

            //Console.WriteLine(woman1.FullInfo());

            Person person = new Person("Kamran", "Jabiyev",new DateTime(1990,4,14));
            Console.WriteLine(person.FullInfo());

            Woman firuze = new Woman();


        }

        #region HomeWork methods
        //static string ReverseWordInSent(string str)
        //{
        //    string[] words = str.Split(' ');
        //    string result = "";
        //    foreach (var word in words)
        //    {
        //        if (words[0] != word)
        //        {
        //            result += " ";
        //        }
        //        for (int i = word.Length-1; i >=0; i--)
        //        {
        //            result += word[i];
        //        }

        //    }
        //    return result;
        //}

        //static void CountLetter(string str)
        //{
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        int count = 0;
        //        for (int j = 0; j < str.Length; j++)
        //        {
        //            if (str[i] == str[j])
        //            {
        //                count++;
        //            }
        //        }
        //        //Console.WriteLine(str[i]+" - "+count+" defe tekrarlanib");
        //        Console.WriteLine($"{str[i]} - {count} defe tekrarlanib");
        //    }
        //}


        //static float Average(int[] arr)
        //{
        //    int sum = 0;
        //    foreach (var item in arr)
        //    {
        //        sum += item;
        //    }

        //    return sum / arr.Length;
        //}
        #endregion 

    }
}
