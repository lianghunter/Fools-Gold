using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Make sure you include the TextMeshPro namespace

public class RandomTextDisplay : MonoBehaviour
{
    // TextMeshPro component
    public TextMeshProUGUI textDisplay;

    // List of strings to choose from
    public List<string> texts = new List<string> { "Astronaut", "Time Traveler", "Wizard", "Superhero", "Movie Star", 
            "Detective", "Pirate", "Cowboy", "Vampire", "Werewolf", 
            "Ninja", "Caveman", "Mad Scientist", "Robot", "Fairy", 
            "Knight", "Princess", "Billionaire", "Secret Agent", "Zombie", 
            "Mermaid", "Alien", "Viking", "Gladiator", "Olympic Athlete", 
            "Chef", "Rock Star", "Ghost", "Pharaoh", "Spy", 
            "King", "Queen", "Jester", "Monk", "Samurai", 
            "Elf", "Dwarf", "Bard", "Warlock", "Sorcerer", 
            "Paladin", "Ranger", "Druid", "Necromancer", "Explorer", 
            "Witch", "Politician", "Talk Show Host", "Game Show Host", "Farmer", 
            "Teacher", "Librarian", "Archaeologist", "Firefighter", "Police Officer", 
            "Doctor", "Nurse", "Lawyer", "Judge", "Inventor", 
            "Philosopher", "Historian", "Artist", "Poet", "Novelist", 
            "Sculptor", "Composer", "Singer", "Actor", "Director", 
            "Producer", "Critic", "Designer", "Model", "Photographer", 
            "Journalist", "Reporter", "Editor", "Stylist", "Barber", 
            "Hairdresser", "Beautician", "Makeup Artist", "Personal Trainer", "Coach", 
            "Referee", "Olympian", "Cyclist", "Skier", "Snowboarder", 
            "Surfer", "Diver", "Sailor", "Fisherman", "Marine Biologist", 
            "Zoologist", "Veterinarian", "Botanist", "Geologist", "Meteorologist" };

    // Start is called before the first frame update
    void Start()
    {
        if (textDisplay != null)
            textDisplay.text = GetRandomText();
    }

    // Method to retrieve a random string from the list
    string GetRandomText()
    {
        int randomIndex = Random.Range(0, texts.Count); // Get a random index
        return texts[randomIndex]; // Return the string at the random index
    }
}
