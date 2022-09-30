using System.Diagnostics;
using Flyweight;

Console.Title = "Flyweight";


var characters = "abba";
var characterFactory = new CharacterFactory();

var characterObject = characterFactory.GetCharacter(characters[0]);
characterObject?.Draw("Arial", 12);

characterObject = characterFactory.GetCharacter(characters[1]);
characterObject?.Draw("Arial", 14);

characterObject = characterFactory.GetCharacter(characters[2]);
characterObject?.Draw("Arial", 16);

characterObject = characterFactory.GetCharacter(characters[3]);
characterObject?.Draw("Arial", 18);

var paragraph = characterFactory.CreateParagraph(
    new List<ICharacter>() { characterObject }, 1);
paragraph.Draw("Lucinda", 12); 

Console.ReadKey();