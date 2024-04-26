using System;
using System.Collections.Generic;

class HashTable
{
    private Dictionary<int, List<KeyValuePair<string, int>>> buckets;

    public HashTable()
    {
        buckets = new Dictionary<int, List<KeyValuePair<string, int>>>();
    }

    private int GetBucketIndex(string key)
    {
        return Math.Abs(key.GetHashCode() % buckets.Count);
    }

    public void Add(string key, int value)
    {
        int index = GetBucketIndex(key);
        if (!buckets.ContainsKey(index))
        {
            buckets[index] = new List<KeyValuePair<string, int>>();
        }
        else
        {
            // Check if key already exists in the bucket
            foreach (var pair in buckets[index])
            {
                if (pair.Key == key)
                {
                    throw new ArgumentException("Key already exists");
                }
            }
        }

        // Add key-value pair to the bucket
        buckets[index].Add(new KeyValuePair<string, int>(key, value));
    }

    public int Get(string key)
    {
        int index = GetBucketIndex(key);
        if (buckets.ContainsKey(index))
        {
            foreach (var pair in buckets[index])
            {
                if (pair.Key == key)
                {
                    return pair.Value;
                }
            }
        }
        throw new KeyNotFoundException("Key not found");
    }

    public void Remove(string key)
    {
        int index = GetBucketIndex(key);
        if (buckets.ContainsKey(index))
        {
            for (int i = 0; i < buckets[index].Count; i++)
            {
                if (buckets[index][i].Key == key)
                {
                    buckets[index].RemoveAt(i);
                    return;
                }
            }
        }
        throw new KeyNotFoundException("Key not found");
    }
}

class Program
{
    static void Main(string[] args)
    {
        HashTable table = new HashTable();
        table.Add("apple", 5);
        table.Add("banana", 7);
        table.Add("orange", 3);

        Console.WriteLine("Value for 'apple': " + table.Get("apple"));
        Console.WriteLine("Value for 'banana': " + table.Get("banana"));
        Console.WriteLine("Value for 'orange': " + table.Get("orange"));

        table.Remove("apple");

        try
        {
            Console.WriteLine("Value for 'apple': " + table.Get("apple"));
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("Key 'apple' not found");
        }
    }
}
