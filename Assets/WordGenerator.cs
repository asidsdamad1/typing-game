using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordlist = { "replace",
"premium",
"chew",
"peel",
"spade",
"uneven",
"produce",
"graceful",
"weak",
"deer",
"pretty",
"smell",
"high-pitched",
"poised",
"aspiring",
"rate",
"neighborly",
"return",
"juggle",
"porter",
"hill",
"reflective",
"motion",
"paint",
"sack",
"floor",
"flowery",
"mellow",
"rabbits",
"volatile",
"picayune",
"cherry",
"shaggy",
"nice",
"bang",
"wakeful",
"secretary",
"plucky",
"mate",
"breathe",
"lying",
"gratis",
"tiny",
"night",
"consist",
"rest",
"expansion",
"mass",
"bee",
"able" };
    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordlist.Length);
        string randomWord = wordlist[randomIndex];

        return randomWord;
    }
}
