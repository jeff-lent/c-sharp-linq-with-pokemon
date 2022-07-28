using System;


namespace PokemonProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PokeProcessor pokeProcessor = new PokeProcessor();
            pokeProcessor.loadPokemon();
            System.Console.WriteLine(pokeProcessor.getPokemonCount());
        }
    }
}
