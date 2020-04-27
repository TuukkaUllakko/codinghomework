namespace Exercise
{
  using System;
  using System.IO;
  using System.Collections.Generic;
  public class SaveableDictionary
  {
    private Dictionary<string, string> dictionary;
    private string file;
    public SaveableDictionary()
    {
      this.dictionary = new Dictionary<string, string>();
    }

    public SaveableDictionary(string file) : this()
    {
      this.file = file;
    }

    public void Add(string word, string translation)
    {
      if (!this.dictionary.ContainsKey(word) && !this.dictionary.ContainsValue(translation))
      {
        this.dictionary.Add(word, translation);
      }
    }

    public bool Load()
    {
      try
      {
        string[] lines = File.ReadAllLines(this.file);
        foreach (string line in lines)
        {
          string[] pieces = line.Split(":");
          this.dictionary.Add(pieces[0], pieces[1]);
        }

        return true;
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);

        return false;
      }
    }

    public bool Save() //The test for this works now!
    {
      try
      {
        StreamWriter writer = new StreamWriter(this.file);
        foreach (KeyValuePair<string, string> kvp in this.dictionary)
        {

          writer.WriteLine(kvp.Key + ":" + kvp.Value);
        }
        writer.Close();
        
        return true;
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);

      return false;
      }
    }

    public string Translate(string word)
    {
      if (this.dictionary.ContainsKey(word))
      {
        return this.dictionary[word];
      }
      foreach (KeyValuePair<string, string> kvp in this.dictionary)
      {
        if (kvp.Value == word)
        {
          return kvp.Key;
        }
      }
      return null;
    }

    public void Delete(string word)
    {
      foreach (KeyValuePair<string, string> kvp in this.dictionary)
      {
        if (kvp.Key == word || kvp.Value == word)
        {
          this.dictionary.Remove(kvp.Key);
        }
      }
    }
  }
}