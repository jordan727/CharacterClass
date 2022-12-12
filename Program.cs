#nullable disable

Character kungFuPanda = new Character("Kung Fu Panda", "Skadoosh", "You have been blinded by pure awesomeness!");
Character spiderman = new Character("Spiderman","My Spider-Sense is tingling", "Your friendly neighbourhood spiderman");

kungFuPanda.speak(1);
kungFuPanda.speak(2);
kungFuPanda.setLevel(3);

spiderman.speak(1);
spiderman.speak(2);
spiderman.setLevel(7);




class Character
{
    public string name;
    public string phrase1;
    public string phrase2;
    public int level;

    public Character(string charName, string firstPhrase, string secondPhrase)
    {
        this.name = charName;
        this.phrase1 = firstPhrase;
        this.phrase2 = secondPhrase;
        this.level = 0;
    }
    public void speak(int phraseNum)
    {
        if (phraseNum == 1)
        {
            Console.WriteLine(phrase1);
        }
        else if (phraseNum == 2)
        {
            Console.WriteLine(phrase2);
        }
    }

    public void setLevel(int newLevel)
    {
        this.level = newLevel;
        Console.WriteLine($"{name}'s level is {level}");
    }
}