using System;

namespace Problems
{
    public class Program
    {
          public string Prefix(string input)
          {
           
            int len=0;
            foreach(char r in input)
            {
                len++;
            }
            if(len>0){
            
            string[] arr=input.Split(' ');
            
            int num=0;
            foreach(string s in arr)
            {
              num++;
            }


           return len+","+num+":"+input;
           
           }
           else
           {
            return "0,0";
           }
          
          }
        
        static void Main(string[] args)
        {
            Program p=new Program();
            Console.WriteLine(p.Prefix("hello"));
        }
    }
}
