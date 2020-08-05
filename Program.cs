using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ColllectionsMethodsEx
{
    class Program
    {
        static void Main(string[] args)
        {

            StringDictionary Sd = new StringDictionary();
            Sd.Add("1", "Lohitha");
            Sd.Add("2", "ASmin");
            Sd.Add("3", "Anitha");
            Sd.Add("4", "Chamu");

            Console.WriteLine("**************Displaying********************");
           foreach(DictionaryEntry de in Sd)
            {
                Console.WriteLine(" {0} : {1}", de.Key, de.Value);
            }
            Console.WriteLine("**********ContainsValue***************");
            Console.WriteLine(Sd.ContainsValue("Anitha"));
            Console.WriteLine("***********ContainKey**************");
            Console.WriteLine(Sd.ContainsKey("1"));
            //  DictionaryEntry[] myARr = { new DictionaryEntry(), new DictionaryEntry(), new DictionaryEntry() };
            // DictionaryEntry[] STrArr = { new DictionaryEntry(), new DictionaryEntry(), new DictionaryEntry(), new DictionaryEntry() };
            Dictionary<string, string>[] STrArr = new Dictionary<string, string>[20];
            //Sd.CopyTo(STrArr, 1);
            //for(int i=0;i<STrArr.Length;i++)
            //{
            //    Console.WriteLine("{0}:{1}",STrArr[i].Keys,STrArr[i].Values);
            // }
            DictionaryEntry[] myArr = { new DictionaryEntry(),
                                    new DictionaryEntry(),
                                    new DictionaryEntry(),
                                    new DictionaryEntry()
                              };

            Sd.CopyTo(myArr, 0);
            Console.WriteLine("*************CopyTo***************");
            // Displaying key and value pairs in Array myArr 
            for (int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine(myArr[i].Key + " " + myArr[i].Value);
            }
          Console.WriteLine(  Sd.Equals(Sd));
            Console.WriteLine("*********GEtEnumerator************");
            IEnumerator Ie = Sd.GetEnumerator();
            DictionaryEntry ds;
            while (Ie.MoveNext())
            {
                ds = (DictionaryEntry)Ie.Current;
                Console.WriteLine("{0}:{1}", ds.Key, ds.Value);
            }
            HybridDictionary Hd = new HybridDictionary();
            Console.WriteLine("HyBRID DIcTIOnARY-----------------------------------------------------------------------------------------------------");
            Hd.Add(1,"Amma");
            Hd.Add(2, "Nanna");
            Hd.Add(3, "Chelli");
            foreach(DictionaryEntry de1 in Hd)
            {
                Console.WriteLine("{0}:{1}",de1.Key,de1.Value);
            }
            Console.WriteLine("ContainsKEyWord");
            Console.WriteLine(Hd.Contains(1));
            Console.WriteLine("Equals");
            Console.WriteLine(Hd.Equals(Sd));
                Console.WriteLine("GETs Hash Code");
            Console.WriteLine( Hd.GetHashCode());
            Console.WriteLine("REturns String the Represent dictionary TOSTRING");
           Console.WriteLine( Hd.ToString());


            ListDictionary Ld = new ListDictionary();

            Ld.Add(1, "one");
            Ld.Add(2, "Two");
            Ld.Add(3, "Three");
            foreach(DictionaryEntry de2 in Ld)
            {
                Console.WriteLine("{0}:{1}", de2.Key, de2.Value);
            }
            Ld.Remove(2);
            Console.WriteLine("AFter remove() Method");
            foreach (DictionaryEntry de2 in Ld)
            {
                Console.WriteLine("{0}:{1}", de2.Key, de2.Value);
            }
            Console.WriteLine("Contains");
            Console.WriteLine(Ld.Contains(1));
            Ld.Clear();
            Console.WriteLine("Clear");
            foreach (DictionaryEntry de2 in Ld)
            {
                Console.WriteLine("{0}:{1}", de2.Key, de2.Value);
            }







        }
    }
}
