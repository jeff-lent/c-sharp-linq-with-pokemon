# Linq with Pokemon

## Objective

* Use C# and Linq to analyze Pokemon data

## Rationale

Procedural programming is giving way to an increasing reliance on the declarative functional paradigm.  This lesson helps familiarize students with Linq and lambda expressions which are the two most common functional features used in modern C# applications.

## Setup

1. Fork this repo
1. Clone this repo
1. Implement the story shown below using the method stubs provided in `PokeProcessor.cs`
1. Commit
1. Push!

## Instructions

* Use linq syntax to implement the story below.
* It's okay to use for loops at first, but you must refactor
* Submit your work using only higher-order functions

## Story

As a Pokemon enthusiast,
I want to run various queries against the PokeData
So that I can learn enough to create the perfect deck!

#####Acceptance Criteria
* `listPokemon` should return a list of names of all pokemon.
* `pokemonWith3Weaknesses` should return a list of all pokemon with 3 weaknesses
* ~~`calculateAverageMaxHP` should calculate the average MaxHP of all pokemon.~~ <span style="color:red;"> Don't worry about this one, the seed JSON data doesn't support this problem </span>
* `listWeaknesses` should return a list of all weaknesses.
* `pokemonResistantByAttack` should return a list of pokemon resistant to a given attack.
* `numOfPokemonResistantByAttack` should return an object with each type of attack and the number of pokemon that are resistant to that attack.
* `typesOfFastAttacks` should return a list of all types of fast attacks.
* `specialAttacksPokemon` should return a list of Pokemon that have more than three special attacks.
* `heavyPokemon` should return the percent of pokemon who have a mass > 50 kg.
* `describePokemonByNumber` should return a description of a pokemon when given a number.


## Stretch

* Use only pure functions in your PokeProcessor class.
* One statement solutions

## Resources

* [Microsoft Getting Started with LINQ Tutorials](https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/concepts/linq/getting-started-with-linq)
* [LINQ Reference](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)

