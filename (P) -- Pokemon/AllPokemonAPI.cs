using System;
using System.Collections.Generic;
using System.Text;

namespace _P_____Pokemon
{
    public class AllPokemonAPI
    {
        public List<ResultObject> results { get; set; }


    }

    public class ResultObject
    {
        public string name { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return $"{name}, {url}";
        }


    }
    public class IndividualPokemon
    {
        public string height { get; set; }
        public string weight { get; set; }

        public Sprite sprites { get; set; }

        public override string ToString()
        {
            return $"{height}, {weight}"; 
        }
    }

    public class Sprite
    {
        public string front_default {get; set;}
        public string back_default {get; set;}

    }
}
