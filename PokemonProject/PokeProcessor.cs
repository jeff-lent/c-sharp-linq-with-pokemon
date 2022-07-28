using System.Text.Json;

public class PokeProcessor 
{
    private List<Pokemon>? pokedex;

    public void loadPokemon(string pathOpt = "pokeData.json")
    {
        try
        {
            using (StreamReader r = new StreamReader(pathOpt))
            {
                string json = r.ReadToEnd();
                pokedex = JsonSerializer.Deserialize<List<Pokemon>>(json);
            }
        }
        catch(Exception)
        {
            throw;
        }
    }

    public int getPokemonCount()
    {
        if(pokedex is not null)
        {
            return pokedex.Count;
        }
        return 0;
    }

    // list all Pokemon by name
    public List<string> listPokemon() 
    {
        return new List<string>();
    }

    // return an array of Pokemon that have 3 weaknesses
    public List<Pokemon> pokemonWith3Weaknesses() 
    {
        return new List<Pokemon>();
    }


    // average MaxHP
    public int calculateAverageMaxHP() 
    {
        return 0;
    }

    // list all weaknesses
    public List<string> listWeaknesses() 
    {
        return new List<string>();
    }

    // Pokemon resistant to a supplied type of attack
    public List<Pokemon> pokemonResistantByAttackType(String attack) 
    {
        return new List<Pokemon>();
    }

    // Map of attack types and the number of Pokemon resistant to each type of attack
    public Dictionary<string, int> numOfPokemonResistantByAttackType() 
    {
        return new Dictionary<string,int>();
    }

    // list types of fast attacks
    public List<string> typesOfFastAttacks() 
    {
        return new List<string>();
    }

    // list of Pokemon that have more than three special attacks
    public List<Pokemon> specialAttacksPokemon() 
    {
        return new List<Pokemon>();
    }

    // % of Pokemon that have >50kg maximum mass
    public Double heavyPokemon() 
    {
        return 0.0;
    }

    // accept the index of a Pokemon and return an object of name, description and array of next evolutions
    public Object describePokemonByNumber(int number) 
    {
        return new Object();
    }
}