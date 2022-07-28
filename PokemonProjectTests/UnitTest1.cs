namespace PokemonTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void allPokemonShouldBeLoadedIntoMemory()
    {
        //Setup
        int expected = 245;
        PokeProcessor cut = new PokeProcessor();
        cut.loadPokemon();

        //Execute
        int actual = cut.getPokemonCount();
        Assert.AreEqual(expected,actual);
    }
}