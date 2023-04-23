namespace MorseCodeDecoder
{
    public static class MorseCodeDecoder
    {
           public static string DecodeMorse(this string _morseCode)
        {
            var morseAlphabetDictionary = new Dictionary<string, string>()
                                   {
                                       {"A", ".-"},
                                       {"B", "-..."},
                                       {"C", "-.-."},
                                       {"D", "-.."},
                                       {"E", "."},
                                       {"F", "..-."},
                                       {"G", "--."},
                                       {"H", "...."},
                                       {"I", ".."},
                                       {"J", ".---"},
                                       {"K", "-.-"},
                                       {"L", ".-.."},
                                       {"M", "--"},
                                       {"N", "-."},
                                       {"O", "---"},
                                       {"P", ".--."},
                                       {"Q", "--.-"},
                                       {"R", ".-."},
                                       {"S", "..."},
                                       {"T", "-"},
                                       {"U", "..-"},
                                       {"V", "...-"},
                                       {"W", ".--"},
                                       {"X", "-..-"},
                                       {"Y", "-.--"},
                                       {"Z", "--.."},
                                       {"0", "-----"},
                                       {"1", ".----"},
                                       {"2", "..---"},
                                       {"3", "...--"},
                                       {"4", "....-"},
                                       {"5", "....."},
                                       {"6", "-...."},
                                       {"7", "--..."},
                                       {"8", "---.."},
                                       {"9", "----."},
                                       {"SOS", "...---..."},
                                       {".", ".-.-.-"},
                                       {"!", "-.-.--"},
                                   };
            _morseCode = _morseCode.Trim();
            var words = _morseCode.Split("   ").ToList();
            List<string> result = new List<string>();

            List<string> chars = new List<string>();
            for (int i = 0; i < words.Count(); i++)
            {
                var word = words[i].Split(" ");

                for (int v = 0; v < word.Count(); v++)
                {
                    var onechar = word[v];
                    var translatedChar = morseAlphabetDictionary.FirstOrDefault(x => x.Value == onechar).Key;
                    result.Add(translatedChar.ToString());
                    if (v == word.Count() - 1)
                    {
                        result.Add(" ");
                        break;
                    }
                }

            }
            return string.Join("", result).Trim();
        }
    }
}