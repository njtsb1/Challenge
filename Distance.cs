// Challenge
// Two motorcycles (X and Y) depart in the same direction. The X bike leaves with a constant speed of 60 km/h and the Y bike leaves with a constant speed of 90 km/h.

// In one hour (60 minutes) the bike Y can distance itself 30 kilometers from the bike X, that is, it can move away one kilometer every 2 minutes.

// Your challenge is to read the distance (in km) and calculate how long it takes (in minutes) for bike Y to take that distance from the other bike.

// Input
// The input file contains an integer K that represents how many kilometers the bike Y must be from the bike X.

// Exit
// Print the time required for the bike Y to stay with the K kilometer quantity of the bike X, followed by the message "minutes".

using System;

class Challenge {
    static void Main() {
        int kilometers = Int32.Parse(Console.ReadLine());
        int minutes =  kilometers  * 2;
        Console.WriteLine(minutes + " minutes");
    }
}
