// Challenge
// The months of June and July are traditionally known throughout Brazil for their typical parties, and for Marlene's group of friends it's no different, every second fortnight of July she and her friends get together for traditional manioc! During the festival, Chico, Beto, Bernardo, Marina and Iara always get together at Marlene's house. And as it couldn't be different, the main dish of this meeting is cassava. They each eat one to ten servings of cassava and they always advise Marlene in advance as to how many servings they will be eating that day. The serving sizes of each are different, but they are always the same. The servings are as follows (in grams):

// Chico eats 300

// Bento eats 1500

// Bernardo eats 600

// Marina eats 1000

// Iara eats 150

// Marlene, in turn, always eats 225 grams of manioc. Tired of every year having to calculate how much cassava to prepare, she challenged you to write a program that tells you how much cassava should be prepared in grams.

// Input
// The entry consists of 5 integers each representing the portions that Dona Chica's guests will consume. The first integer represents the portions of Chico, the second of Bento, the third of Bernardo, the fourth of Marina and the fifth of Iara.

// Exit
// The output consists of a single integer that represents how much cassava Marlene should prepare in grams.

using System;

class QuantaMandioca
{
    static void Main() 
    {
        var chico = 300 * Int32.Parse(Console.ReadLine());
        var bento = 1500 * Int32.Parse(Console.ReadLine());
        var bernardo = 600 * Int32.Parse(Console.ReadLine());
        var marina = 1000 * Int32.Parse(Console.ReadLine());
        var iara = 150 * Int32.Parse(Console.ReadLine());
        var marlene = 225;
        
        var total = chico + bento + bernardo + marina + iara + marlene;
        
        Console.WriteLine(total);
    }
}
