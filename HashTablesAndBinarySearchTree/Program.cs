using System;

namespace HashTablesAndBinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the option to execute\n 1.Hash Table\n 2.Binary Search Tree\n 3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
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
                        break;
                    case 2:
                        BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
                        binarySearch.Insert(30);
                        binarySearch.Insert(70);
                        binarySearch.Insert(22);
                        binarySearch.Insert(40);
                        binarySearch.Insert(60);
                        binarySearch.Insert(95);
                        binarySearch.Insert(11);
                        binarySearch.Insert(65);
                        binarySearch.Insert(3);
                        binarySearch.Insert(16);
                        binarySearch.Insert(63);
                        binarySearch.Insert(67);
                        binarySearch.Display();
                        binarySearch.GetSize();
                        bool result = binarySearch.IfExists(67, binarySearch);
                        Console.WriteLine(result);
                        break;
                    case 3:
                        flag = false;
                    break;
                }
            }
        }
    }
}