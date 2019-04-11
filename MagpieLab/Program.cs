using System;
using System.Collections.Generic;
using System.Threading;

namespace ChatBot
{
    class Program
    {
        public static String[] StartingQuestions = new String[]{
            "Whats Your Name?",
            "Are you gay?",
        };
        public static List<String> StartingAnswers = new List<String>();
        public static String[] ReqQuestions = new String[]{
            "i want to build a robot",
            "i want to understand French",
            "do you like me",
            "you confuse me",
            "i want something",
        };
        public static String[] ReqAnswers = new String[]{
            "Thats Super Cool!",
            "French Is A Dying Language",
            "Nope",
            "Sure I do, your the dumb one",
            "Would you really be happy if you had something?",
        };
        static void Main(string[] args)
        {
            for (Int32 i = 0; i < StartingQuestions.Length; i++)
            {
                Console.WriteLine(StartingQuestions[i]);
                String ans = Console.ReadLine();
                StartingAnswers.Add(ans);
            }
            if (check(StartingAnswers[1]) && StartingAnswers[0] == "nofilter")
            {
                Console.WriteLine("GoodBye");
                Thread.Sleep(1000);
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Hey I'm Proud of You!");
            }
            while (true)
            {
                String ans = Console.ReadLine();
                Console.WriteLine(getResp(ans));
            }
        }
        static String getResp(String input)
        {
            String resp = input.ToLower();
            String[] RandomResp = new String[]
            {
                "I don't understand you",
                "I don't get that",
                "What did you say?",
                "I can't respond to that yet",
            };
            for (int i = 0; i < ReqQuestions.Length; i++)
            {
                if (resp.Contains(ReqQuestions[i]))
                {
                    return ReqAnswers[i];
                }
            }
            Random ran = new Random();
            String randomeresp = RandomResp[ran.Next(0, RandomResp.Length)];
            return randomeresp;
        }
        static bool check(String input)
        {
            String resp = input.ToLower();
            String[] trueResp = new String[]{
                "yes",
                "true",
                "affermative",
                "yeah"

            };
            String[] falseResp = new String[]{
                "no",
                "false",
                "negative",
                "nope"
            };
            for (int i = 0; i < trueResp.Length; i++)
            {
                if (resp.Contains(trueResp[i]))
                {
                    return true;
                }
            }
            for (int i = 0; i < falseResp.Length; i++)
            {
                if (resp.Contains(falseResp[i]))
                {
                    return false;
                }
            }
            return false;
        }
    }
}
