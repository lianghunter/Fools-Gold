using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Make sure you include the TextMeshPro namespace

public class SalesItemScript : MonoBehaviour
{
    // TextMeshPro component
    public TextMeshProUGUI textDisplay;

    // List of strings to choose from
    public List<string> texts = new List<string> { "Aqua", "Solar", "Thunder", "Shadow", "Cyber",
            "Turbo", "Quantum", "Mega", "Ultra", "Eco",
            "Nano", "Micro", "Hyper", "Super", "Mini",
            "Giant", "Rocket", "Phantom", "Laser", "Stellar",
            "Cosmic", "Geo", "Thermo", "Electro", "Robo",
            "Bio", "Techno", "Crystal", "Mystic", "Neuro",
            "Pyro", "Astro", "Time", "Dream", "Steam",
            "Retro", "Virtual", "Polar", "Holographic", "Atomic",
            "Dynamic", "Terra", "Spectral", "Infinite", "Plasma",
            "Galactic", "Quantum", "Frozen", "Illuminated", "Magical",
            "Iridescent", "Portable", "Wireless", "Silent", "Automated",
            "Manual", "Heavy", "Light", "Dual", "Single",
            "Triple", "Multi", "Poly", "Mono", "Semi",
            "Bio-", "Aero", "Hydro", "Alloy", "Marble",
            "Golden", "Silver", "Bronze", "Metal", "Digital",
            "Analog", "Fiber", "Silk", "Cotton", "Plastic",
            "Leather", "Velvet", "Satin", "Wool", "Bamboo",
            "Compact", "Expandable", "Foldable", "Inflatable", "Modular",
            "Sustainable", "Recyclable", "Disposable", "Edible", "Biodegradable",
            "Ancient", "Modern", "Future", "Antique", "Vintage",
            "Rustic", "Glossy", "Matte", "Transparent", "Opaque",
            "Fluorescent", "Glowing", "Sparkling", "Dull", "Shiny",
            "Smooth", "Rough", "Textured", "Soft", "Hard",
            "Elastic", "Rigid", "Flexible", "Stiff", "Thick",
            "Thin", "Wide", "Narrow", "Big", "Small",
            "Tall", "Short", "Long", "Square", "Round",
            "Triangular", "Rectangular", "Spherical", "Curved", "Straight",
            "High", "Low", "Medium", "Variable", "Fixed",
            "Adjustable", "Locked", "Unlocked", "Tight", "Loose",
            "Packed", "Empty", "Full", "Lined", "Plain",
            "Patterned", "Striped", "Spotted", "Floral", "Abstract",
            "Geometric", "Paisley", "Animal", "Camouflage", "Chequered",
            "Printed", "Handmade", "Mass-produced", "Tailored", "Custom",
            "Generic", "Branded", "Unbranded", "Tagged", "Untagged",
            "Sealed", "Unsealed", "Topped", "Bottomed", "Layered",
            "Focused", "Wide-Angle", "Zoom", "Macro", "Microscopic",
            "Visible", "Invisible", "Colored", "Colorless", "Tinted",
            "Solid", "Liquid", "Gaseous", "Powdered", "Granular",
            "Segmented", "Whole", "Perforated", "Smoothed", "Polished",
            "Reinforced", "Fragile", "Durable", "Temporary", "Permanent",
            "Seasonal", "Year-round", "Day", "Night", "Twilight",
            "Morning", "Evening", "Nocturnal", "Diurnal", "Creational",
            "Destructive", "Functional", "Decorative", "Utilitarian", "Aesthetic",
            "Ornamental", "Practical", "Impractical", "Usable", "Useless" };

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