using System;

namespace HashTablesAndBinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
                        Console.WriteLine("Enter the string");
                        string statement = Console.ReadLine();
                        string[] sentence = statement.Split(" ");
                        HashTable<string, string> hash = new HashTable<string, string>(sentence.Length);
                        for (int i = 0; i < sentence.Length; i++)
                        {
                            hash.Add(Convert.ToString(i), sentence[i]);
                        }
                        Console.WriteLine(string.Join(" ", sentence));
                        string hash1 = hash.GetV("2");
                        Console.WriteLine("The value at the index is:" + hash1);
                        Console.WriteLine("Enter the word to delete:");
                        string word = Console.ReadLine();
                        int count = 0;
                        for (int i = 0; i < sentence.Length; i++)
                        {
                            if (hash.GetV(Convert.ToString(i)) == word)
                            {
                                hash.Remove(Convert.ToString(i));
                                count++;
                            }
                        }
        }
    }
}
