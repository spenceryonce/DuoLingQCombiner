using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuoLingQCombiner.Models
{
    public class WordList
    {
        public int Id { get; set; }
        public string Language { get; set; }

        public List<Word> Words { get; set; }
    }

    public class Word
    {
        public int Id { get; set; }
        public string NativeLanguage { get; set; }
        public string ForeignLanguage { get; set; }

        public TypeOfSpeech TypeOfSpeech { get; set; }
        
    }

    public enum TypeOfSpeech
    {
        Adj,
        Noun,
        Adverb,
        Verb,
        Article,
        Pronoun
    }
}
