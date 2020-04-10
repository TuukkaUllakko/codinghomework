using System;
using System.Collections.Generic;

namespace Exercise
{
  public class DictionaryOfManyTranslations
  {
    private Dictionary<string, List<string>> dictionary;
    public DictionaryOfManyTranslations()
    {
      this.dictionary = new Dictionary<string, List<string>>();
    }

    public void Add(string word, string translation)
    {
      if (!this.dictionary.ContainsKey(word))
      {
        this.dictionary.Add(word, new List<string>());
      }
        this.dictionary[word].Add(translation);

    }

    public List<string> Translate(string word)
    {
      if (!this.dictionary.ContainsKey(word))
      {
        this.dictionary.Add(word, new List<string>());
      }
      return this.dictionary[word];
    }

    public void Remove(string word)
    {
      this.dictionary.Remove(word);
    }
  }
}