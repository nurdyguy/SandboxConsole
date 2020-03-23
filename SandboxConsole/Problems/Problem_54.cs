using SandboxConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SandboxConsole.Problems
{
    public class Problem_54 : Problem
    {
        // count p1 wins
        private List<List<List<string>>> _games = new List<List<List<string>>>
        {
            new List<List<string>>{new List<string>{"8C", "10S", "KC", "9H", "4S"}, new List<string>{"7D", "2S", "5D", "3S", "AC"}},
            new List<List<string>>{new List<string>{"5C", "AD", "5D", "AC", "9C"}, new List<string>{"7C", "5H", "8D", "10D", "KS"}},
            new List<List<string>>{new List<string>{"3H", "7H", "6S", "KC", "JS"}, new List<string>{"QH", "10D", "JC", "2D", "8S"}},
            new List<List<string>>{new List<string>{"10H", "8H", "5C", "QS", "10C"}, new List<string>{"9H", "4D", "JC", "KS", "JS"}},
            new List<List<string>>{new List<string>{"7C", "5H", "KC", "QH", "JD"}, new List<string>{"AS", "KH", "4C", "AD", "4S"}},
            new List<List<string>>{new List<string>{"5H", "KS", "9C", "7D", "9H"}, new List<string>{"8D", "3S", "5D", "5C", "AH"}},
            new List<List<string>>{new List<string>{"6H", "4H", "5C", "3H", "2H"}, new List<string>{"3S", "QH", "5S", "6S", "AS"}},
            new List<List<string>>{new List<string>{"10D", "8C", "4H", "7C", "10C"}, new List<string>{"KC", "4C", "3H", "7S", "KS"}},
            new List<List<string>>{new List<string>{"7C", "9C", "6D", "KD", "3H"}, new List<string>{"4C", "QS", "QC", "AC", "KH"}},
            new List<List<string>>{new List<string>{"JC", "6S", "5H", "2H", "2D"}, new List<string>{"KD", "9D", "7C", "AS", "JS"}},
            new List<List<string>>{new List<string>{"AD", "QH", "10H", "9D", "8H"}, new List<string>{"10S", "6D", "3S", "AS", "AC"}},
            new List<List<string>>{new List<string>{"2H", "4S", "5C", "5S", "10C"}, new List<string>{"KC", "JD", "6C", "10S", "3C"}},
            new List<List<string>>{new List<string>{"QD", "AS", "6H", "JS", "2C"}, new List<string>{"3D", "9H", "KC", "4H", "8S"}},
            new List<List<string>>{new List<string>{"KD", "8S", "9S", "7C", "2S"}, new List<string>{"3S", "6D", "6S", "4H", "KC"}},
            new List<List<string>>{new List<string>{"3C", "8C", "2D", "7D", "4D"}, new List<string>{"9S", "4S", "QH", "4H", "JD"}},
            new List<List<string>>{new List<string>{"8C", "KC", "7S", "10C", "2D"}, new List<string>{"10S", "8H", "QD", "AC", "5C"}},
            new List<List<string>>{new List<string>{"3D", "KH", "QD", "6C", "6S"}, new List<string>{"AD", "AS", "8H", "2H", "QS"}},
            new List<List<string>>{new List<string>{"6S", "8D", "4C", "8S", "6C"}, new List<string>{"QH", "10C", "6D", "7D", "9D"}},
            new List<List<string>>{new List<string>{"2S", "8D", "8C", "4C", "10S"}, new List<string>{"9S", "9D", "9C", "AC", "3D"}},
            new List<List<string>>{new List<string>{"3C", "QS", "2S", "4H", "JH"}, new List<string>{"3D", "2D", "10D", "8S", "9H"}},
            new List<List<string>>{new List<string>{"5H", "QS", "8S", "6D", "3C"}, new List<string>{"8C", "JD", "AS", "7H", "7D"}},
            new List<List<string>>{new List<string>{"6H", "10D", "9D", "AS", "JH"}, new List<string>{"6C", "QC", "9S", "KD", "JC"}},
            new List<List<string>>{new List<string>{"AH", "8S", "QS", "4D", "10H"}, new List<string>{"AC", "10S", "3C", "3D", "5C"}},
            new List<List<string>>{new List<string>{"5S", "4D", "JS", "3D", "8H"}, new List<string>{"6C", "10S", "3S", "AD", "8C"}},
            new List<List<string>>{new List<string>{"6D", "7C", "5D", "5H", "3S"}, new List<string>{"5C", "JC", "2H", "5S", "3D"}},
            new List<List<string>>{new List<string>{"5H", "6H", "2S", "KS", "3D"}, new List<string>{"5D", "JD", "7H", "JS", "8H"}},
            new List<List<string>>{new List<string>{"KH", "4H", "AS", "JS", "QS"}, new List<string>{"QC", "10C", "6D", "7C", "KS"}},
            new List<List<string>>{new List<string>{"3D", "QS", "10S", "2H", "JS"}, new List<string>{"4D", "AS", "9S", "JC", "KD"}},
            new List<List<string>>{new List<string>{"QD", "5H", "4D", "5D", "KH"}, new List<string>{"7H", "3D", "JS", "KD", "4H"}},
            new List<List<string>>{new List<string>{"2C", "9H", "6H", "5C", "9D"}, new List<string>{"6C", "JC", "2D", "10H", "9S"}},
            new List<List<string>>{new List<string>{"7D", "6D", "AS", "QD", "JH"}, new List<string>{"4D", "JS", "7C", "QS", "5C"}},
            new List<List<string>>{new List<string>{"3H", "KH", "QD", "AD", "8C"}, new List<string>{"8H", "3S", "10H", "9D", "5S"}},
            new List<List<string>>{new List<string>{"AH", "9S", "4D", "9D", "8S"}, new List<string>{"4H", "JS", "3C", "10C", "8D"}},
            new List<List<string>>{new List<string>{"2C", "KS", "5H", "QD", "3S"}, new List<string>{"10S", "9H", "AH", "AD", "8S"}},
            new List<List<string>>{new List<string>{"5C", "7H", "5D", "KD", "9H"}, new List<string>{"4D", "3D", "2D", "KS", "AD"}},
            new List<List<string>>{new List<string>{"KS", "KC", "9S", "6D", "2C"}, new List<string>{"QH", "9D", "9H", "10S", "10C"}},
            new List<List<string>>{new List<string>{"9C", "6H", "5D", "QH", "4D"}, new List<string>{"AD", "6D", "QC", "JS", "KH"}},
            new List<List<string>>{new List<string>{"9S", "3H", "9D", "JD", "5C"}, new List<string>{"4D", "9H", "AS", "10C", "QH"}},
            new List<List<string>>{new List<string>{"2C", "6D", "JC", "9C", "3C"}, new List<string>{"AD", "9S", "KH", "9D", "7D"}},
            new List<List<string>>{new List<string>{"KC", "9C", "7C", "JC", "JS"}, new List<string>{"KD", "3H", "AS", "3C", "7D"}},
            new List<List<string>>{new List<string>{"QD", "KH", "QS", "2C", "3S"}, new List<string>{"8S", "8H", "9H", "9C", "JC"}},
            new List<List<string>>{new List<string>{"QH", "8D", "3C", "KC", "4C"}, new List<string>{"4H", "6D", "AD", "9H", "9D"}},
            new List<List<string>>{new List<string>{"3S", "KS", "QS", "7H", "KH"}, new List<string>{"7D", "5H", "5D", "JD", "AD"}},
            new List<List<string>>{new List<string>{"2H", "2C", "6H", "10H", "10C"}, new List<string>{"7D", "8D", "4H", "8C", "AS"}},
            new List<List<string>>{new List<string>{"4S", "2H", "AC", "QC", "3S"}, new List<string>{"6D", "10H", "4D", "4C", "KH"}},
            new List<List<string>>{new List<string>{"4D", "10C", "KS", "AS", "7C"}, new List<string>{"3C", "6D", "2D", "9H", "6C"}},
            new List<List<string>>{new List<string>{"8C", "10D", "5D", "QS", "2C"}, new List<string>{"7H", "4C", "9C", "3H", "9H"}},
            new List<List<string>>{new List<string>{"5H", "JH", "10S", "7S", "10D"}, new List<string>{"6H", "AD", "QD", "8H", "8S"}},
            new List<List<string>>{new List<string>{"5S", "AD", "9C", "8C", "7C"}, new List<string>{"8D", "5H", "9D", "8S", "2S"}},
            new List<List<string>>{new List<string>{"4H", "KH", "KS", "9S", "2S"}, new List<string>{"KC", "5S", "AD", "4S", "7D"}},
            new List<List<string>>{new List<string>{"QS", "9C", "QD", "6H", "JS"}, new List<string>{"5D", "AC", "8D", "2S", "AS"}},
            new List<List<string>>{new List<string>{"KH", "AC", "JC", "3S", "9D"}, new List<string>{"9S", "3C", "9C", "5S", "JS"}},
            new List<List<string>>{new List<string>{"AD", "3C", "3D", "KS", "3S"}, new List<string>{"5C", "9C", "8C", "10S", "4S"}},
            new List<List<string>>{new List<string>{"JH", "8D", "5D", "6H", "KD"}, new List<string>{"QS", "QD", "3D", "6C", "KC"}},
            new List<List<string>>{new List<string>{"8S", "JD", "6C", "3S", "8C"}, new List<string>{"10C", "QC", "3C", "QH", "JS"}},
            new List<List<string>>{new List<string>{"KC", "JC", "8H", "2S", "9H"}, new List<string>{"9C", "JH", "8S", "8C", "9S"}},
            new List<List<string>>{new List<string>{"8S", "2H", "QH", "4D", "QC"}, new List<string>{"9D", "KC", "AS", "10H", "3C"}},
            new List<List<string>>{new List<string>{"8S", "6H", "10H", "7C", "2H"}, new List<string>{"6S", "3C", "3H", "AS", "7S"}},
            new List<List<string>>{new List<string>{"QH", "5S", "JS", "4H", "5H"}, new List<string>{"10S", "8H", "AH", "AC", "JC"}},
            new List<List<string>>{new List<string>{"9D", "8H", "2S", "4S", "10C"}, new List<string>{"JC", "3C", "7H", "3H", "5C"}},
            new List<List<string>>{new List<string>{"3D", "AD", "3C", "3S", "4C"}, new List<string>{"QC", "AS", "5D", "10H", "8C"}},
            new List<List<string>>{new List<string>{"6S", "9D", "4C", "JS", "KH"}, new List<string>{"AH", "10S", "JD", "8H", "AD"}},
            new List<List<string>>{new List<string>{"4C", "6S", "9D", "7S", "AC"}, new List<string>{"4D", "3D", "3S", "10C", "JD"}},
            new List<List<string>>{new List<string>{"AD", "7H", "6H", "4H", "JH"}, new List<string>{"KC", "10D", "10S", "7D", "6S"}},
            new List<List<string>>{new List<string>{"8H", "JH", "10C", "3S", "8D"}, new List<string>{"8C", "9S", "2C", "5C", "4D"}},
            new List<List<string>>{new List<string>{"2C", "9D", "KC", "QH", "10H"}, new List<string>{"QS", "JC", "9C", "4H", "10S"}},
            new List<List<string>>{new List<string>{"QS", "3C", "QD", "8H", "KH"}, new List<string>{"4H", "8D", "10D", "8S", "AC"}},
            new List<List<string>>{new List<string>{"7C", "3C", "10H", "5S", "8H"}, new List<string>{"8C", "9C", "JD", "10C", "KD"}},
            new List<List<string>>{new List<string>{"QC", "10C", "JD", "10S", "8C"}, new List<string>{"3H", "6H", "KD", "7C", "10D"}},
            new List<List<string>>{new List<string>{"JH", "QS", "KS", "9C", "6D"}, new List<string>{"6S", "AS", "9H", "KH", "6H"}},
            new List<List<string>>{new List<string>{"2H", "4D", "AH", "2D", "JH"}, new List<string>{"6H", "10D", "5D", "4H", "JD"}},
            new List<List<string>>{new List<string>{"KD", "8C", "9S", "JH", "QD"}, new List<string>{"JS", "2C", "QS", "5C", "7C"}},
            new List<List<string>>{new List<string>{"4S", "10C", "7H", "8D", "2S"}, new List<string>{"6H", "7S", "9C", "7C", "KC"}},
            new List<List<string>>{new List<string>{"8C", "5D", "7H", "4S", "10D"}, new List<string>{"QC", "8S", "JS", "4H", "KS"}},
            new List<List<string>>{new List<string>{"AD", "8S", "JH", "6D", "10D"}, new List<string>{"KD", "7C", "6C", "2D", "7D"}},
            new List<List<string>>{new List<string>{"JC", "6H", "6S", "JS", "4H"}, new List<string>{"QH", "9H", "AH", "4C", "3C"}},
            new List<List<string>>{new List<string>{"6H", "5H", "AS", "7C", "7S"}, new List<string>{"3D", "KH", "KC", "5D", "5C"}},
            new List<List<string>>{new List<string>{"JC", "3D", "10D", "AS", "4D"}, new List<string>{"6D", "6S", "QH", "JD", "KS"}},
            new List<List<string>>{new List<string>{"8C", "7S", "8S", "QH", "2S"}, new List<string>{"JD", "5C", "7H", "AH", "QD"}},
            new List<List<string>>{new List<string>{"8S", "3C", "6H", "6C", "2C"}, new List<string>{"8D", "10D", "7D", "4C", "4D"}},
            new List<List<string>>{new List<string>{"5D", "QH", "KH", "7C", "2S"}, new List<string>{"7H", "JS", "6D", "QC", "QD"}},
            new List<List<string>>{new List<string>{"AD", "6C", "6S", "7D", "10H"}, new List<string>{"6H", "2H", "8H", "KH", "4H"}},
            new List<List<string>>{new List<string>{"KS", "JS", "KD", "5D", "2D"}, new List<string>{"KH", "7D", "9C", "8C", "3D"}},
            new List<List<string>>{new List<string>{"9C", "6D", "QD", "3C", "KS"}, new List<string>{"3S", "7S", "AH", "JD", "2D"}},
            new List<List<string>>{new List<string>{"AH", "QH", "AS", "JC", "8S"}, new List<string>{"8H", "4C", "KC", "10H", "7D"}},
            new List<List<string>>{new List<string>{"JC", "5H", "10D", "7C", "5D"}, new List<string>{"KD", "4C", "AD", "8H", "JS"}},
            new List<List<string>>{new List<string>{"KC", "2H", "AC", "AH", "7D"}, new List<string>{"JH", "KH", "5D", "7S", "6D"}},
            new List<List<string>>{new List<string>{"9S", "5S", "9C", "6H", "8S"}, new List<string>{"10D", "JD", "9H", "6C", "AC"}},
            new List<List<string>>{new List<string>{"7D", "8S", "6D", "10S", "KD"}, new List<string>{"7H", "AC", "5S", "7C", "5D"}},
            new List<List<string>>{new List<string>{"AH", "QC", "JC", "4C", "10C"}, new List<string>{"8C", "2H", "10S", "2C", "7D"}},
            new List<List<string>>{new List<string>{"KD", "KC", "6S", "3D", "7D"}, new List<string>{"2S", "8S", "3H", "5S", "5C"}},
            new List<List<string>>{new List<string>{"8S", "5D", "8H", "4C", "6H"}, new List<string>{"KC", "3H", "7C", "5S", "KD"}},
            new List<List<string>>{new List<string>{"JH", "8C", "3D", "3C", "6C"}, new List<string>{"KC", "10D", "7H", "7C", "4C"}},
            new List<List<string>>{new List<string>{"JC", "KC", "6H", "10S", "QS"}, new List<string>{"10D", "KS", "8H", "8C", "9S"}},
            new List<List<string>>{new List<string>{"6C", "5S", "9C", "QH", "7D"}, new List<string>{"AH", "KS", "KC", "9S", "2C"}},
            new List<List<string>>{new List<string>{"4D", "4S", "8H", "10D", "9C"}, new List<string>{"3S", "7D", "9D", "AS", "10H"}},
            new List<List<string>>{new List<string>{"6S", "7D", "3C", "6H", "5D"}, new List<string>{"KD", "2C", "5C", "9D", "9C"}},
            new List<List<string>>{new List<string>{"2H", "KC", "3D", "AD", "3H"}, new List<string>{"QD", "QS", "8D", "JC", "4S"}},
            new List<List<string>>{new List<string>{"8C", "3H", "9C", "7C", "AD"}, new List<string>{"5D", "JC", "9D", "JS", "AS"}},
            new List<List<string>>{new List<string>{"5D", "9H", "5C", "7H", "6S"}, new List<string>{"6C", "QC", "JC", "QD", "9S"}},
            new List<List<string>>{new List<string>{"JC", "QS", "JH", "2C", "6S"}, new List<string>{"9C", "QC", "3D", "4S", "10C"}},
            new List<List<string>>{new List<string>{"4H", "5S", "8D", "3D", "4D"}, new List<string>{"2S", "KC", "2H", "JS", "2C"}},
            new List<List<string>>{new List<string>{"10D", "3S", "10H", "KD", "4D"}, new List<string>{"7H", "JH", "JS", "KS", "AC"}},
            new List<List<string>>{new List<string>{"7S", "8C", "9S", "2D", "8S"}, new List<string>{"7D", "5C", "AD", "9D", "AS"}},
            new List<List<string>>{new List<string>{"8C", "7H", "2S", "6C", "10H"}, new List<string>{"3H", "4C", "3S", "8H", "AC"}},
            new List<List<string>>{new List<string>{"KD", "5H", "JC", "8H", "JD"}, new List<string>{"2D", "4H", "10D", "JH", "5C"}},
            new List<List<string>>{new List<string>{"3D", "AS", "QH", "KS", "7H"}, new List<string>{"JD", "8S", "5S", "6D", "5H"}},
            new List<List<string>>{new List<string>{"9S", "6S", "10C", "QS", "JC"}, new List<string>{"5C", "5D", "9C", "10H", "8C"}},
            new List<List<string>>{new List<string>{"5H", "3S", "JH", "9H", "2S"}, new List<string>{"2C", "6S", "7S", "AS", "KS"}},
            new List<List<string>>{new List<string>{"8C", "QD", "JC", "QS", "10C"}, new List<string>{"QC", "4H", "AC", "KH", "6C"}},
            new List<List<string>>{new List<string>{"10C", "5H", "7D", "JH", "4H"}, new List<string>{"2H", "8D", "JC", "KS", "4D"}},
            new List<List<string>>{new List<string>{"5S", "9C", "KH", "KD", "9H"}, new List<string>{"5C", "10S", "3D", "7D", "2D"}},
            new List<List<string>>{new List<string>{"5H", "AS", "10C", "4D", "8C"}, new List<string>{"2C", "10S", "9D", "3H", "8D"}},
            new List<List<string>>{new List<string>{"6H", "8D", "2D", "9H", "JD"}, new List<string>{"6C", "4S", "5H", "5S", "6D"}},
            new List<List<string>>{new List<string>{"AD", "9C", "JC", "7D", "6H"}, new List<string>{"9S", "6D", "JS", "9H", "3C"}},
            new List<List<string>>{new List<string>{"AD", "JH", "10C", "QS", "4C"}, new List<string>{"5D", "9S", "7C", "9C", "AH"}},
            new List<List<string>>{new List<string>{"KD", "6H", "2H", "10H", "8S"}, new List<string>{"QD", "KS", "9D", "9H", "AS"}},
            new List<List<string>>{new List<string>{"4H", "8H", "8D", "5H", "6C"}, new List<string>{"AH", "5S", "AS", "AD", "8S"}},
            new List<List<string>>{new List<string>{"QS", "5D", "4S", "2H", "10D"}, new List<string>{"KS", "5H", "AC", "3H", "JC"}},
            new List<List<string>>{new List<string>{"9C", "7D", "QD", "KD", "AC"}, new List<string>{"6D", "5H", "QH", "6H", "5S"}},
            new List<List<string>>{new List<string>{"KC", "AH", "QH", "2H", "7D"}, new List<string>{"QS", "3H", "KS", "7S", "JD"}},
            new List<List<string>>{new List<string>{"6C", "8S", "3H", "6D", "KS"}, new List<string>{"QD", "5D", "5C", "8H", "10C"}},
            new List<List<string>>{new List<string>{"9H", "4D", "4S", "6S", "9D"}, new List<string>{"KH", "QC", "4H", "6C", "JD"}},
            new List<List<string>>{new List<string>{"10D", "2D", "QH", "4S", "6H"}, new List<string>{"JH", "KD", "3C", "QD", "8C"}},
            new List<List<string>>{new List<string>{"4S", "6H", "7C", "QD", "9D"}, new List<string>{"AS", "AH", "6S", "AD", "3C"}},
            new List<List<string>>{new List<string>{"2C", "KC", "10H", "6H", "8D"}, new List<string>{"AH", "5C", "6D", "8S", "5D"}},
            new List<List<string>>{new List<string>{"10D", "10S", "7C", "AD", "JC"}, new List<string>{"QD", "9H", "3C", "KC", "7H"}},
            new List<List<string>>{new List<string>{"5D", "4D", "5S", "8H", "4H"}, new List<string>{"7D", "3H", "JD", "KD", "2D"}},
            new List<List<string>>{new List<string>{"JH", "10D", "6H", "QS", "4S"}, new List<string>{"KD", "5C", "8S", "7D", "8H"}},
            new List<List<string>>{new List<string>{"AC", "3D", "AS", "8C", "10D"}, new List<string>{"7H", "KH", "5D", "6C", "JD"}},
            new List<List<string>>{new List<string>{"9D", "KS", "7C", "6D", "QH"}, new List<string>{"10C", "JD", "KD", "AS", "KC"}},
            new List<List<string>>{new List<string>{"JH", "8S", "5S", "7S", "7D"}, new List<string>{"AS", "2D", "3D", "AD", "2H"}},
            new List<List<string>>{new List<string>{"2H", "5D", "AS", "3C", "QD"}, new List<string>{"KC", "6H", "9H", "9S", "2C"}},
            new List<List<string>>{new List<string>{"9D", "5D", "10H", "4C", "JH"}, new List<string>{"3H", "8D", "10C", "8H", "9H"}},
            new List<List<string>>{new List<string>{"6H", "KD", "2C", "10D", "2H"}, new List<string>{"6C", "9D", "2D", "JS", "8C"}},
            new List<List<string>>{new List<string>{"KD", "7S", "3C", "7C", "AS"}, new List<string>{"QH", "10S", "AD", "8C", "2S"}},
            new List<List<string>>{new List<string>{"QS", "8H", "6C", "JS", "4C"}, new List<string>{"9S", "QC", "AD", "10D", "10S"}},
            new List<List<string>>{new List<string>{"2H", "7C", "10S", "10C", "8C"}, new List<string>{"3C", "9H", "2D", "6D", "JC"}},
            new List<List<string>>{new List<string>{"10C", "2H", "8D", "JH", "KS"}, new List<string>{"6D", "3H", "10D", "10H", "8H"}},
            new List<List<string>>{new List<string>{"9D", "10D", "9H", "QC", "5D"}, new List<string>{"6C", "8H", "8C", "KC", "10S"}},
            new List<List<string>>{new List<string>{"2H", "8C", "3D", "AH", "4D"}, new List<string>{"10H", "10C", "7D", "8H", "KC"}},
            new List<List<string>>{new List<string>{"10S", "5C", "2D", "8C", "6S"}, new List<string>{"KH", "AH", "5H", "6H", "KC"}},
            new List<List<string>>{new List<string>{"5S", "5D", "AH", "10C", "4C"}, new List<string>{"JD", "8D", "6H", "8C", "6C"}},
            new List<List<string>>{new List<string>{"KC", "QD", "3D", "8H", "2D"}, new List<string>{"JC", "9H", "4H", "AD", "2S"}},
            new List<List<string>>{new List<string>{"10D", "6S", "7D", "JS", "KD"}, new List<string>{"4H", "QS", "2S", "3S", "8C"}},
            new List<List<string>>{new List<string>{"4C", "9H", "JH", "10S", "3S"}, new List<string>{"4H", "QC", "5S", "9S", "9C"}},
            new List<List<string>>{new List<string>{"2C", "KD", "9H", "JS", "9S"}, new List<string>{"3H", "JC", "10S", "5D", "AC"}},
            new List<List<string>>{new List<string>{"AS", "2H", "5D", "AD", "5H"}, new List<string>{"JC", "7S", "10D", "JS", "4C"}},
            new List<List<string>>{new List<string>{"2D", "4S", "8H", "3D", "7D"}, new List<string>{"2C", "AD", "KD", "9C", "10S"}},
            new List<List<string>>{new List<string>{"7H", "QD", "JH", "5H", "JS"}, new List<string>{"AC", "3D", "10H", "4C", "8H"}},
            new List<List<string>>{new List<string>{"6D", "KH", "KC", "QD", "5C"}, new List<string>{"AD", "7C", "2D", "4H", "AC"}},
            new List<List<string>>{new List<string>{"3D", "9D", "10C", "8S", "QD"}, new List<string>{"2C", "JC", "4H", "JD", "AH"}},
            new List<List<string>>{new List<string>{"6C", "10D", "5S", "10C", "8S"}, new List<string>{"AH", "2C", "5D", "AS", "AC"}},
            new List<List<string>>{new List<string>{"10H", "7S", "3D", "AS", "6C"}, new List<string>{"4C", "7H", "7D", "4H", "AH"}},
            new List<List<string>>{new List<string>{"5C", "2H", "KS", "6H", "7S"}, new List<string>{"4H", "5H", "3D", "3C", "7H"}},
            new List<List<string>>{new List<string>{"3C", "9S", "AC", "7S", "QH"}, new List<string>{"2H", "3D", "6S", "3S", "3H"}},
            new List<List<string>>{new List<string>{"2D", "3H", "AS", "2C", "6H"}, new List<string>{"10C", "JS", "6S", "9C", "6C"}},
            new List<List<string>>{new List<string>{"QH", "KD", "QD", "6D", "AC"}, new List<string>{"6H", "KH", "2C", "10S", "8C"}},
            new List<List<string>>{new List<string>{"8H", "7D", "3S", "9H", "5D"}, new List<string>{"3H", "4S", "QC", "9S", "5H"}},
            new List<List<string>>{new List<string>{"2D", "9D", "7H", "6H", "3C"}, new List<string>{"8S", "5H", "4D", "3S", "4S"}},
            new List<List<string>>{new List<string>{"KD", "9S", "4S", "10C", "7S"}, new List<string>{"QC", "3S", "8S", "2H", "7H"}},
            new List<List<string>>{new List<string>{"10C", "3D", "8C", "3H", "6C"}, new List<string>{"2H", "6H", "KS", "KD", "4D"}},
            new List<List<string>>{new List<string>{"KC", "3D", "9S", "3H", "JS"}, new List<string>{"4S", "8H", "2D", "6C", "8S"}},
            new List<List<string>>{new List<string>{"6H", "QS", "6C", "10C", "QD"}, new List<string>{"9H", "7D", "7C", "5H", "4D"}},
            new List<List<string>>{new List<string>{"10D", "9D", "8D", "6S", "6C"}, new List<string>{"10C", "5D", "10S", "JS", "8H"}},
            new List<List<string>>{new List<string>{"4H", "KC", "JD", "9H", "10C"}, new List<string>{"2C", "6S", "5H", "8H", "AS"}},
            new List<List<string>>{new List<string>{"JS", "9C", "5C", "6S", "9D"}, new List<string>{"JD", "8H", "KC", "4C", "6D"}},
            new List<List<string>>{new List<string>{"4D", "8D", "8S", "6C", "7C"}, new List<string>{"6H", "7H", "8H", "5C", "KC"}},
            new List<List<string>>{new List<string>{"10C", "3D", "JC", "6D", "KS"}, new List<string>{"9S", "6H", "7S", "9C", "2C"}},
            new List<List<string>>{new List<string>{"6C", "3S", "KD", "5H", "10S"}, new List<string>{"7D", "9H", "9S", "6H", "KH"}},
            new List<List<string>>{new List<string>{"3D", "QD", "4C", "6H", "10S"}, new List<string>{"AC", "3S", "5C", "2H", "KD"}},
            new List<List<string>>{new List<string>{"4C", "AS", "JS", "9S", "7C"}, new List<string>{"10S", "7H", "9H", "JC", "KS"}},
            new List<List<string>>{new List<string>{"4H", "8C", "JD", "3H", "6H"}, new List<string>{"AD", "9S", "4S", "5S", "KS"}},
            new List<List<string>>{new List<string>{"4C", "2C", "7D", "3D", "AS"}, new List<string>{"9C", "2S", "QS", "KC", "6C"}},
            new List<List<string>>{new List<string>{"8S", "5H", "3D", "2S", "AC"}, new List<string>{"9D", "6S", "3S", "4D", "10D"}},
            new List<List<string>>{new List<string>{"QD", "10H", "7S", "10S", "3D"}, new List<string>{"AC", "7H", "6C", "5D", "QC"}},
            new List<List<string>>{new List<string>{"10C", "QD", "AD", "9C", "QS"}, new List<string>{"5C", "8D", "KD", "3D", "3C"}},
            new List<List<string>>{new List<string>{"9D", "8H", "AS", "3S", "7C"}, new List<string>{"8S", "JD", "2D", "8D", "KC"}},
            new List<List<string>>{new List<string>{"4C", "10H", "AC", "QH", "JS"}, new List<string>{"8D", "7D", "7S", "9C", "KH"}},
            new List<List<string>>{new List<string>{"9D", "8D", "4C", "JH", "2C"}, new List<string>{"2S", "QD", "KD", "10S", "4H"}},
            new List<List<string>>{new List<string>{"4D", "6D", "5D", "2D", "JH"}, new List<string>{"3S", "8S", "3H", "10C", "KH"}},
            new List<List<string>>{new List<string>{"AD", "4D", "2C", "QS", "8C"}, new List<string>{"KD", "JH", "JD", "AH", "5C"}},
            new List<List<string>>{new List<string>{"5C", "6C", "5H", "2H", "JH"}, new List<string>{"4H", "KS", "7C", "10C", "3H"}},
            new List<List<string>>{new List<string>{"3C", "4C", "QC", "5D", "JH"}, new List<string>{"9C", "QD", "KH", "8D", "10C"}},
            new List<List<string>>{new List<string>{"3H", "9C", "JS", "7H", "QH"}, new List<string>{"AS", "7C", "9H", "5H", "JC"}},
            new List<List<string>>{new List<string>{"2D", "5S", "QD", "4S", "3C"}, new List<string>{"KC", "6S", "6C", "5C", "4C"}},
            new List<List<string>>{new List<string>{"5D", "KH", "2D", "10S", "8S"}, new List<string>{"9C", "AS", "9S", "7C", "4C"}},
            new List<List<string>>{new List<string>{"7C", "AH", "8C", "8D", "5S"}, new List<string>{"KD", "QH", "QS", "JH", "2C"}},
            new List<List<string>>{new List<string>{"8C", "9D", "AH", "2H", "AC"}, new List<string>{"QC", "5S", "8H", "7H", "2C"}},
            new List<List<string>>{new List<string>{"QD", "9H", "5S", "QS", "QC"}, new List<string>{"9C", "5H", "JC", "10H", "4H"}},
            new List<List<string>>{new List<string>{"6C", "6S", "3H", "5H", "3S"}, new List<string>{"6H", "KS", "8D", "AC", "7S"}},
            new List<List<string>>{new List<string>{"AC", "QH", "7H", "8C", "4S"}, new List<string>{"KC", "6C", "3D", "3S", "10C"}},
            new List<List<string>>{new List<string>{"9D", "3D", "JS", "10H", "AC"}, new List<string>{"5H", "3H", "8S", "3S", "10C"}},
            new List<List<string>>{new List<string>{"QD", "KH", "JS", "KS", "9S"}, new List<string>{"QC", "8D", "AH", "3C", "AC"}},
            new List<List<string>>{new List<string>{"5H", "6C", "KH", "3S", "9S"}, new List<string>{"JH", "2D", "QD", "AS", "8C"}},
            new List<List<string>>{new List<string>{"6C", "4D", "7S", "7H", "5S"}, new List<string>{"JC", "6S", "9H", "4H", "JH"}},
            new List<List<string>>{new List<string>{"AH", "5S", "6H", "9S", "AD"}, new List<string>{"3S", "10H", "2H", "9D", "8C"}},
            new List<List<string>>{new List<string>{"4C", "8D", "9H", "7C", "QC"}, new List<string>{"AD", "4S", "9C", "KC", "5S"}},
            new List<List<string>>{new List<string>{"9D", "6H", "4D", "10C", "4C"}, new List<string>{"JH", "2S", "5D", "3S", "AS"}},
            new List<List<string>>{new List<string>{"2H", "6C", "7C", "KH", "5C"}, new List<string>{"AD", "QS", "10H", "JD", "8S"}},
            new List<List<string>>{new List<string>{"3S", "4S", "7S", "AH", "AS"}, new List<string>{"KC", "JS", "2S", "AD", "10H"}},
            new List<List<string>>{new List<string>{"JS", "KC", "2S", "7D", "8C"}, new List<string>{"5C", "9C", "10S", "5H", "9D"}},
            new List<List<string>>{new List<string>{"7S", "9S", "4D", "10D", "JH"}, new List<string>{"JS", "KH", "6H", "5D", "2C"}},
            new List<List<string>>{new List<string>{"JD", "JS", "JC", "10H", "2D"}, new List<string>{"3D", "QD", "8C", "AC", "5H"}},
            new List<List<string>>{new List<string>{"7S", "KH", "5S", "9D", "5D"}, new List<string>{"10D", "4S", "6H", "3C", "2D"}},
            new List<List<string>>{new List<string>{"4S", "5D", "AC", "8D", "4D"}, new List<string>{"7C", "AD", "AS", "AH", "9C"}},
            new List<List<string>>{new List<string>{"6S", "10H", "10S", "KS", "2C"}, new List<string>{"QC", "AH", "AS", "3C", "4S"}},
            new List<List<string>>{new List<string>{"2H", "8C", "3S", "JC", "5C"}, new List<string>{"7C", "3H", "3C", "KH", "JH"}},
            new List<List<string>>{new List<string>{"7S", "3H", "JC", "5S", "6H"}, new List<string>{"4C", "2S", "4D", "KC", "7H"}},
            new List<List<string>>{new List<string>{"4D", "7C", "4H", "9S", "8S"}, new List<string>{"6S", "AD", "10C", "6C", "JC"}},
            new List<List<string>>{new List<string>{"KH", "QS", "3S", "10C", "4C"}, new List<string>{"8H", "8S", "AC", "3C", "10S"}},
            new List<List<string>>{new List<string>{"QD", "QS", "10H", "3C", "10S"}, new List<string>{"7H", "7D", "AH", "10D", "JC"}},
            new List<List<string>>{new List<string>{"10D", "JD", "QC", "4D", "9S"}, new List<string>{"7S", "10S", "AD", "7D", "AC"}},
            new List<List<string>>{new List<string>{"AH", "7H", "4S", "6D", "7C"}, new List<string>{"2H", "9D", "KS", "JC", "10D"}},
            new List<List<string>>{new List<string>{"7C", "AH", "JD", "4H", "6D"}, new List<string>{"QS", "10S", "2H", "2C", "5C"}},
            new List<List<string>>{new List<string>{"10C", "KC", "8C", "9S", "4C"}, new List<string>{"JS", "3C", "JC", "6S", "AH"}},
            new List<List<string>>{new List<string>{"AS", "7D", "QC", "3D", "5S"}, new List<string>{"JC", "JD", "9D", "10D", "KH"}},
            new List<List<string>>{new List<string>{"10H", "3C", "2S", "6H", "AH"}, new List<string>{"AC", "5H", "5C", "7S", "8H"}},
            new List<List<string>>{new List<string>{"QC", "2D", "AC", "QD", "2S"}, new List<string>{"3S", "JD", "QS", "6S", "8H"}},
            new List<List<string>>{new List<string>{"KC", "4H", "3C", "9D", "JS"}, new List<string>{"6H", "3S", "8S", "AS", "8C"}},
            new List<List<string>>{new List<string>{"7H", "KC", "7D", "JD", "2H"}, new List<string>{"JC", "QH", "5S", "3H", "QS"}},
            new List<List<string>>{new List<string>{"9H", "10D", "3S", "8H", "7S"}, new List<string>{"AC", "5C", "6C", "AH", "7C"}},
            new List<List<string>>{new List<string>{"8D", "9H", "AH", "JD", "10D"}, new List<string>{"QS", "7D", "3S", "9C", "8S"}},
            new List<List<string>>{new List<string>{"AH", "QH", "3C", "JD", "KC"}, new List<string>{"4S", "5S", "5D", "10D", "KS"}},
            new List<List<string>>{new List<string>{"9H", "7H", "6S", "JH", "10H"}, new List<string>{"4C", "7C", "AD", "5C", "2D"}},
            new List<List<string>>{new List<string>{"7C", "KD", "5S", "10C", "9D"}, new List<string>{"6S", "6C", "5D", "2S", "10H"}},
            new List<List<string>>{new List<string>{"KC", "9H", "8D", "5H", "7H"}, new List<string>{"4H", "QC", "3D", "7C", "AS"}},
            new List<List<string>>{new List<string>{"6S", "8S", "QC", "10D", "4S"}, new List<string>{"5C", "10H", "QS", "QD", "2S"}},
            new List<List<string>>{new List<string>{"8S", "5H", "10H", "QC", "9H"}, new List<string>{"6S", "KC", "7D", "7C", "5C"}},
            new List<List<string>>{new List<string>{"7H", "KD", "AH", "4D", "KH"}, new List<string>{"5C", "4S", "2D", "KC", "QH"}},
            new List<List<string>>{new List<string>{"6S", "2C", "10D", "JC", "AS"}, new List<string>{"4D", "6C", "8C", "4H", "5S"}},
            new List<List<string>>{new List<string>{"JC", "10C", "JD", "5S", "6S"}, new List<string>{"8D", "AS", "9D", "AD", "3S"}},
            new List<List<string>>{new List<string>{"6D", "6H", "5D", "5S", "10C"}, new List<string>{"3D", "7D", "QS", "9D", "QD"}},
            new List<List<string>>{new List<string>{"4S", "6C", "8S", "3S", "7S"}, new List<string>{"AD", "KS", "2D", "7D", "7C"}},
            new List<List<string>>{new List<string>{"KC", "QH", "JC", "AC", "QD"}, new List<string>{"5D", "8D", "QS", "7H", "7D"}},
            new List<List<string>>{new List<string>{"JS", "AH", "8S", "5H", "3D"}, new List<string>{"10D", "3H", "4S", "6C", "JH"}},
            new List<List<string>>{new List<string>{"4S", "QS", "7D", "AS", "9H"}, new List<string>{"JS", "KS", "6D", "10C", "5C"}},
            new List<List<string>>{new List<string>{"2D", "5C", "6H", "10C", "4D"}, new List<string>{"QH", "3D", "9H", "8S", "6C"}},
            new List<List<string>>{new List<string>{"6D", "7H", "10C", "10H", "5S"}, new List<string>{"JD", "5C", "9C", "KS", "KD"}},
            new List<List<string>>{new List<string>{"8D", "10D", "QH", "6S", "4S"}, new List<string>{"6C", "8S", "KC", "5C", "10C"}},
            new List<List<string>>{new List<string>{"5S", "3D", "KS", "AC", "4S"}, new List<string>{"7D", "QD", "4C", "10H", "2S"}},
            new List<List<string>>{new List<string>{"10S", "8H", "9S", "6S", "7S"}, new List<string>{"QH", "3C", "AH", "7H", "8C"}},
            new List<List<string>>{new List<string>{"4C", "8C", "10S", "JS", "QC"}, new List<string>{"3D", "7D", "5D", "7S", "JH"}},
            new List<List<string>>{new List<string>{"8S", "7S", "9D", "QC", "AC"}, new List<string>{"7C", "6D", "2H", "JH", "KC"}},
            new List<List<string>>{new List<string>{"JS", "KD", "3C", "6S", "4S"}, new List<string>{"7C", "AH", "QC", "KS", "5H"}},
            new List<List<string>>{new List<string>{"KS", "6S", "4H", "JD", "QS"}, new List<string>{"10C", "8H", "KC", "6H", "AS"}},
            new List<List<string>>{new List<string>{"KH", "7C", "10C", "6S", "10D"}, new List<string>{"JC", "5C", "7D", "AH", "3S"}},
            new List<List<string>>{new List<string>{"3H", "4C", "4H", "10C", "10H"}, new List<string>{"6S", "7H", "6D", "9C", "QH"}},
            new List<List<string>>{new List<string>{"7D", "5H", "4S", "8C", "JS"}, new List<string>{"4D", "3D", "8S", "QH", "KC"}},
            new List<List<string>>{new List<string>{"3H", "6S", "AD", "7H", "3S"}, new List<string>{"QC", "8S", "4S", "7S", "JS"}},
            new List<List<string>>{new List<string>{"3S", "JD", "KH", "10H", "6H"}, new List<string>{"QS", "9C", "6C", "2D", "QD"}},
            new List<List<string>>{new List<string>{"4S", "QH", "4D", "5H", "KC"}, new List<string>{"7D", "6D", "8D", "10H", "5S"}},
            new List<List<string>>{new List<string>{"10D", "AD", "6S", "7H", "KD"}, new List<string>{"KH", "9H", "5S", "KC", "JC"}},
            new List<List<string>>{new List<string>{"3H", "QC", "AS", "10S", "4S"}, new List<string>{"QD", "KS", "9C", "7S", "KC"}},
            new List<List<string>>{new List<string>{"10S", "6S", "QC", "6C", "10H"}, new List<string>{"10C", "9D", "5C", "5D", "KD"}},
            new List<List<string>>{new List<string>{"JS", "3S", "4H", "KD", "4C"}, new List<string>{"QD", "6D", "9S", "JC", "9D"}},
            new List<List<string>>{new List<string>{"8S", "JS", "6D", "4H", "JH"}, new List<string>{"6H", "6S", "6C", "KS", "KH"}},
            new List<List<string>>{new List<string>{"AC", "7D", "5D", "10C", "9S"}, new List<string>{"KH", "6S", "QD", "6H", "AS"}},
            new List<List<string>>{new List<string>{"AS", "7H", "6D", "QH", "8D"}, new List<string>{"10H", "2S", "KH", "5C", "5H"}},
            new List<List<string>>{new List<string>{"4C", "7C", "3D", "QC", "10C"}, new List<string>{"4S", "KH", "8C", "2D", "JS"}},
            new List<List<string>>{new List<string>{"6H", "5D", "7S", "5H", "9C"}, new List<string>{"9H", "JH", "8S", "10H", "7H"}},
            new List<List<string>>{new List<string>{"AS", "JS", "2S", "QD", "KH"}, new List<string>{"8H", "4S", "AC", "8D", "8S"}},
            new List<List<string>>{new List<string>{"3H", "4C", "10D", "KD", "8C"}, new List<string>{"JC", "5C", "QS", "2D", "JD"}},
            new List<List<string>>{new List<string>{"10S", "7D", "5D", "6C", "2C"}, new List<string>{"QS", "2H", "3C", "AH", "KS"}},
            new List<List<string>>{new List<string>{"4S", "7C", "9C", "7D", "JH"}, new List<string>{"6C", "5C", "8H", "9D", "QD"}},
            new List<List<string>>{new List<string>{"2S", "10D", "7S", "6D", "9C"}, new List<string>{"9S", "QS", "KH", "QH", "5C"}},
            new List<List<string>>{new List<string>{"JC", "6S", "9C", "QH", "JH"}, new List<string>{"8D", "7S", "JS", "KH", "2H"}},
            new List<List<string>>{new List<string>{"8D", "5H", "10H", "KC", "4D"}, new List<string>{"4S", "3S", "6S", "3D", "QS"}},
            new List<List<string>>{new List<string>{"2D", "JD", "4C", "10D", "7C"}, new List<string>{"6D", "10H", "7S", "JC", "AH"}},
            new List<List<string>>{new List<string>{"QS", "7S", "4C", "10H", "9D"}, new List<string>{"10S", "AD", "4D", "3H", "6H"}},
            new List<List<string>>{new List<string>{"2D", "3H", "7D", "JD", "3D"}, new List<string>{"AS", "2S", "9C", "QC", "8S"}},
            new List<List<string>>{new List<string>{"4H", "9H", "9C", "2C", "7S"}, new List<string>{"JH", "KD", "5C", "5D", "6H"}},
            new List<List<string>>{new List<string>{"10C", "9H", "8H", "JC", "3C"}, new List<string>{"9S", "8D", "KS", "AD", "KC"}},
            new List<List<string>>{new List<string>{"10S", "5H", "JD", "QS", "QH"}, new List<string>{"QC", "8D", "5D", "KH", "AH"}},
            new List<List<string>>{new List<string>{"5D", "AS", "8S", "6S", "4C"}, new List<string>{"AH", "QC", "QD", "10H", "7H"}},
            new List<List<string>>{new List<string>{"3H", "4H", "7D", "6S", "4S"}, new List<string>{"9H", "AS", "8H", "JS", "9D"}},
            new List<List<string>>{new List<string>{"JD", "8C", "2C", "9D", "7D"}, new List<string>{"5H", "5S", "9S", "JC", "KD"}},
            new List<List<string>>{new List<string>{"KD", "9C", "4S", "QD", "AH"}, new List<string>{"7C", "AD", "9D", "AC", "10D"}},
            new List<List<string>>{new List<string>{"6S", "4H", "4S", "9C", "8D"}, new List<string>{"KS", "10C", "9D", "JH", "7C"}},
            new List<List<string>>{new List<string>{"5S", "JC", "5H", "4S", "QH"}, new List<string>{"AC", "2C", "JS", "2S", "9S"}},
            new List<List<string>>{new List<string>{"8C", "5H", "AS", "QD", "AD"}, new List<string>{"5C", "7D", "8S", "QC", "10D"}},
            new List<List<string>>{new List<string>{"JC", "4C", "8D", "5C", "KH"}, new List<string>{"QS", "4D", "6H", "2H", "2C"}},
            new List<List<string>>{new List<string>{"10H", "4S", "2D", "KC", "3H"}, new List<string>{"QD", "AC", "7H", "AD", "9D"}},
            new List<List<string>>{new List<string>{"KH", "QD", "AS", "8H", "10H"}, new List<string>{"KC", "8D", "7S", "QH", "8C"}},
            new List<List<string>>{new List<string>{"JC", "6C", "7D", "8C", "KH"}, new List<string>{"AD", "QS", "2H", "6S", "2D"}},
            new List<List<string>>{new List<string>{"JC", "KH", "2D", "7D", "JS"}, new List<string>{"QC", "5H", "4C", "5D", "AD"}},
            new List<List<string>>{new List<string>{"10S", "3S", "AD", "4S", "10D"}, new List<string>{"2D", "10H", "6S", "9H", "JH"}},
            new List<List<string>>{new List<string>{"9H", "2D", "QS", "2C", "4S"}, new List<string>{"3D", "KH", "AS", "AC", "9D"}},
            new List<List<string>>{new List<string>{"KH", "6S", "8H", "4S", "KD"}, new List<string>{"7D", "9D", "10S", "QD", "QC"}},
            new List<List<string>>{new List<string>{"JH", "5H", "AH", "KS", "AS"}, new List<string>{"AD", "JC", "QC", "5S", "KH"}},
            new List<List<string>>{new List<string>{"5D", "7D", "6D", "KS", "KD"}, new List<string>{"3D", "7C", "4D", "JD", "3S"}},
            new List<List<string>>{new List<string>{"AC", "JS", "8D", "5H", "9C"}, new List<string>{"3H", "4H", "4D", "10S", "2C"}},
            new List<List<string>>{new List<string>{"6H", "KS", "KH", "9D", "7C"}, new List<string>{"2S", "6S", "8S", "2H", "3D"}},
            new List<List<string>>{new List<string>{"6H", "AC", "JS", "7S", "3S"}, new List<string>{"10D", "8H", "3H", "4H", "10H"}},
            new List<List<string>>{new List<string>{"9H", "10C", "QC", "KC", "5C"}, new List<string>{"KS", "6H", "4H", "AC", "8S"}},
            new List<List<string>>{new List<string>{"10C", "7D", "QH", "4S", "JC"}, new List<string>{"10S", "6D", "6C", "AC", "KH"}},
            new List<List<string>>{new List<string>{"QH", "7D", "7C", "JH", "QS"}, new List<string>{"QD", "10H", "3H", "5D", "KS"}},
            new List<List<string>>{new List<string>{"3D", "5S", "8D", "JS", "4C"}, new List<string>{"2C", "KS", "7H", "9C", "4H"}},
            new List<List<string>>{new List<string>{"5H", "8S", "4H", "10D", "2C"}, new List<string>{"3S", "QD", "QC", "3H", "KC"}},
            new List<List<string>>{new List<string>{"QC", "JS", "KD", "9C", "AD"}, new List<string>{"5S", "9D", "7D", "7H", "10S"}},
            new List<List<string>>{new List<string>{"8C", "JC", "KH", "7C", "7S"}, new List<string>{"6C", "10S", "2C", "QD", "10H"}},
            new List<List<string>>{new List<string>{"5S", "9D", "10H", "3C", "7S"}, new List<string>{"QH", "8S", "9C", "2H", "5H"}},
            new List<List<string>>{new List<string>{"5D", "9H", "6H", "2S", "JS"}, new List<string>{"KH", "3H", "7C", "2H", "5S"}},
            new List<List<string>>{new List<string>{"JD", "5D", "5S", "2C", "10C"}, new List<string>{"2S", "6S", "6C", "3C", "8S"}},
            new List<List<string>>{new List<string>{"4D", "KH", "8H", "4H", "2D"}, new List<string>{"KS", "3H", "5C", "2S", "9H"}},
            new List<List<string>>{new List<string>{"3S", "2D", "10D", "7H", "8S"}, new List<string>{"6H", "JD", "KC", "9C", "8D"}},
            new List<List<string>>{new List<string>{"6S", "QD", "JH", "7C", "9H"}, new List<string>{"5H", "8S", "8H", "10H", "10D"}},
            new List<List<string>>{new List<string>{"QS", "7S", "10D", "7D", "10S"}, new List<string>{"JC", "KD", "7C", "3C", "2C"}},
            new List<List<string>>{new List<string>{"3C", "JD", "8S", "4H", "2D"}, new List<string>{"2S", "10D", "AS", "4D", "AC"}},
            new List<List<string>>{new List<string>{"AH", "KS", "6C", "4C", "4S"}, new List<string>{"7D", "8C", "9H", "6H", "AS"}},
            new List<List<string>>{new List<string>{"5S", "3C", "9S", "2C", "QS"}, new List<string>{"KD", "4D", "4S", "AC", "5D"}},
            new List<List<string>>{new List<string>{"2D", "10S", "2C", "JS", "KH"}, new List<string>{"QH", "5D", "8C", "AS", "KC"}},
            new List<List<string>>{new List<string>{"KD", "3H", "6C", "10H", "8S"}, new List<string>{"7S", "KH", "6H", "9S", "AC"}},
            new List<List<string>>{new List<string>{"6H", "7S", "6C", "QS", "AH"}, new List<string>{"2S", "2H", "4H", "5D", "5H"}},
            new List<List<string>>{new List<string>{"5H", "JC", "QD", "2C", "2S"}, new List<string>{"JD", "AS", "QC", "6S", "7D"}},
            new List<List<string>>{new List<string>{"6C", "10C", "AS", "KD", "8H"}, new List<string>{"9D", "2C", "7D", "JH", "9S"}},
            new List<List<string>>{new List<string>{"2H", "4C", "6C", "AH", "8S"}, new List<string>{"10D", "3H", "10H", "7C", "10S"}},
            new List<List<string>>{new List<string>{"KD", "4S", "10S", "6C", "QH"}, new List<string>{"8D", "9D", "9C", "AH", "7D"}},
            new List<List<string>>{new List<string>{"6D", "JS", "5C", "QD", "QC"}, new List<string>{"9C", "5D", "8C", "2H", "KD"}},
            new List<List<string>>{new List<string>{"3C", "QH", "JH", "AD", "6S"}, new List<string>{"AH", "KC", "8S", "6D", "6H"}},
            new List<List<string>>{new List<string>{"3D", "7C", "4C", "7S", "5S"}, new List<string>{"3S", "6S", "5H", "JC", "3C"}},
            new List<List<string>>{new List<string>{"QH", "7C", "5H", "3C", "3S"}, new List<string>{"8C", "10S", "4C", "KD", "9C"}},
            new List<List<string>>{new List<string>{"QD", "3S", "7S", "5H", "7H"}, new List<string>{"QH", "JC", "7C", "8C", "KD"}},
            new List<List<string>>{new List<string>{"3C", "KD", "KH", "2S", "4C"}, new List<string>{"10S", "AC", "6S", "2C", "7C"}},
            new List<List<string>>{new List<string>{"2C", "KH", "3C", "4C", "6H"}, new List<string>{"4D", "5H", "5S", "7S", "QD"}},
            new List<List<string>>{new List<string>{"4D", "7C", "8S", "QD", "10S"}, new List<string>{"9D", "KS", "6H", "KD", "3C"}},
            new List<List<string>>{new List<string>{"QS", "4D", "10S", "7S", "4C"}, new List<string>{"3H", "QD", "8D", "9S", "10C"}},
            new List<List<string>>{new List<string>{"10S", "QH", "AC", "6S", "3C"}, new List<string>{"9H", "9D", "QS", "8S", "6H"}},
            new List<List<string>>{new List<string>{"3S", "7S", "5D", "4S", "JS"}, new List<string>{"2D", "6C", "QH", "6S", "10H"}},
            new List<List<string>>{new List<string>{"4C", "4H", "AS", "JS", "5D"}, new List<string>{"3D", "10S", "9C", "AC", "8S"}},
            new List<List<string>>{new List<string>{"6S", "9C", "7C", "3S", "5C"}, new List<string>{"QS", "AD", "AS", "6H", "3C"}},
            new List<List<string>>{new List<string>{"9S", "8C", "7H", "3H", "6S"}, new List<string>{"7C", "AS", "9H", "JD", "KH"}},
            new List<List<string>>{new List<string>{"3D", "3H", "7S", "4D", "6C"}, new List<string>{"7C", "AC", "2H", "9C", "10H"}},
            new List<List<string>>{new List<string>{"4H", "5S", "3H", "AC", "10C"}, new List<string>{"10H", "9C", "9H", "9S", "8D"}},
            new List<List<string>>{new List<string>{"8D", "9H", "5H", "4D", "6C"}, new List<string>{"2H", "QD", "6S", "5D", "3S"}},
            new List<List<string>>{new List<string>{"4C", "5C", "JD", "QS", "4D"}, new List<string>{"3H", "10H", "AC", "QH", "8C"}},
            new List<List<string>>{new List<string>{"QC", "5S", "3C", "7H", "AD"}, new List<string>{"4C", "KS", "4H", "JD", "6D"}},
            new List<List<string>>{new List<string>{"QS", "AH", "3H", "KS", "9H"}, new List<string>{"2S", "JS", "JH", "5H", "2H"}},
            new List<List<string>>{new List<string>{"2H", "5S", "10H", "6S", "10S"}, new List<string>{"3S", "KS", "3C", "5H", "JS"}},
            new List<List<string>>{new List<string>{"2D", "9S", "7H", "3D", "KC"}, new List<string>{"JH", "6D", "7D", "JS", "10D"}},
            new List<List<string>>{new List<string>{"AC", "JS", "8H", "2C", "8C"}, new List<string>{"JH", "JC", "2D", "10H", "7S"}},
            new List<List<string>>{new List<string>{"5D", "9S", "8H", "2H", "3D"}, new List<string>{"10C", "AH", "JC", "KD", "9C"}},
            new List<List<string>>{new List<string>{"9D", "QD", "JC", "2H", "6D"}, new List<string>{"KH", "10S", "9S", "QH", "10H"}},
            new List<List<string>>{new List<string>{"2C", "8D", "4S", "JD", "5H"}, new List<string>{"3H", "10H", "10C", "9C", "KC"}},
            new List<List<string>>{new List<string>{"AS", "3D", "9H", "7D", "4D"}, new List<string>{"10H", "KH", "2H", "7S", "3H"}},
            new List<List<string>>{new List<string>{"4H", "7S", "KS", "2S", "JS"}, new List<string>{"10S", "8S", "2H", "QD", "8D"}},
            new List<List<string>>{new List<string>{"5S", "6H", "JH", "KS", "8H"}, new List<string>{"2S", "QC", "AC", "6S", "3S"}},
            new List<List<string>>{new List<string>{"JC", "AS", "AD", "QS", "8H"}, new List<string>{"6C", "KH", "4C", "4D", "QD"}},
            new List<List<string>>{new List<string>{"2S", "3D", "10S", "10D", "9S"}, new List<string>{"KS", "6S", "QS", "5C", "8D"}},
            new List<List<string>>{new List<string>{"3C", "6D", "4S", "QC", "KC"}, new List<string>{"JH", "QD", "10H", "KH", "AD"}},
            new List<List<string>>{new List<string>{"9H", "AH", "4D", "KS", "2S"}, new List<string>{"8D", "JH", "JC", "7C", "QS"}},
            new List<List<string>>{new List<string>{"2D", "6C", "10H", "3C", "8H"}, new List<string>{"QD", "QH", "2S", "3S", "KS"}},
            new List<List<string>>{new List<string>{"6H", "5D", "9S", "4C", "10S"}, new List<string>{"10D", "JS", "QD", "9D", "JD"}},
            new List<List<string>>{new List<string>{"5H", "8H", "KH", "8S", "KS"}, new List<string>{"7C", "10D", "AD", "4S", "KD"}},
            new List<List<string>>{new List<string>{"2C", "7C", "JC", "5S", "AS"}, new List<string>{"6C", "7D", "8S", "5H", "9C"}},
            new List<List<string>>{new List<string>{"6S", "QD", "9S", "10S", "KH"}, new List<string>{"QS", "5S", "QH", "3C", "KC"}},
            new List<List<string>>{new List<string>{"7D", "3H", "3C", "KD", "5C"}, new List<string>{"AS", "JH", "7H", "6H", "JD"}},
            new List<List<string>>{new List<string>{"9D", "5C", "9H", "KC", "8H"}, new List<string>{"KS", "4S", "AD", "4D", "2S"}},
            new List<List<string>>{new List<string>{"3S", "JD", "QD", "8D", "2S"}, new List<string>{"7C", "5S", "6S", "5H", "10S"}},
            new List<List<string>>{new List<string>{"6D", "9S", "KC", "10D", "3S"}, new List<string>{"6H", "QD", "JD", "5C", "8D"}},
            new List<List<string>>{new List<string>{"5H", "9D", "10S", "KD", "8D"}, new List<string>{"6H", "10D", "QC", "4C", "7D"}},
            new List<List<string>>{new List<string>{"6D", "4S", "JD", "9D", "AH"}, new List<string>{"9S", "AS", "10D", "9H", "QD"}},
            new List<List<string>>{new List<string>{"2D", "5S", "2H", "9C", "6H"}, new List<string>{"9S", "10D", "QC", "7D", "10C"}},
            new List<List<string>>{new List<string>{"3S", "2H", "KS", "10S", "2C"}, new List<string>{"9C", "8S", "JS", "9D", "7D"}},
            new List<List<string>>{new List<string>{"3C", "KC", "6D", "5D", "6C"}, new List<string>{"6H", "8S", "AS", "7S", "QS"}},
            new List<List<string>>{new List<string>{"JH", "9S", "2H", "8D", "4C"}, new List<string>{"8H", "9H", "AD", "10H", "KH"}},
            new List<List<string>>{new List<string>{"QC", "AS", "2S", "JS", "5C"}, new List<string>{"6H", "KD", "3H", "7H", "2C"}},
            new List<List<string>>{new List<string>{"QD", "8H", "2S", "8D", "3S"}, new List<string>{"6D", "AH", "2C", "10C", "5C"}},
            new List<List<string>>{new List<string>{"JD", "JS", "10S", "8S", "3H"}, new List<string>{"5D", "10D", "KC", "JC", "6H"}},
            new List<List<string>>{new List<string>{"6S", "QS", "10C", "3H", "5D"}, new List<string>{"AH", "JC", "7C", "7D", "4H"}},
            new List<List<string>>{new List<string>{"7C", "5D", "8H", "9C", "2H"}, new List<string>{"9H", "JH", "KH", "5S", "2C"}},
            new List<List<string>>{new List<string>{"9C", "7H", "6S", "10H", "3S"}, new List<string>{"QC", "QD", "4C", "AC", "JD"}},
            new List<List<string>>{new List<string>{"2H", "5D", "9S", "7D", "KC"}, new List<string>{"3S", "QS", "2D", "AS", "KH"}},
            new List<List<string>>{new List<string>{"2S", "4S", "2H", "7D", "5C"}, new List<string>{"10D", "10H", "QH", "9S", "4D"}},
            new List<List<string>>{new List<string>{"6D", "3S", "10S", "6H", "4H"}, new List<string>{"KS", "9D", "8H", "5S", "2D"}},
            new List<List<string>>{new List<string>{"9H", "KS", "4H", "3S", "5C"}, new List<string>{"5D", "KH", "6H", "6S", "JS"}},
            new List<List<string>>{new List<string>{"KC", "AS", "8C", "4C", "JC"}, new List<string>{"KH", "QC", "10H", "QD", "AH"}},
            new List<List<string>>{new List<string>{"6S", "KH", "9S", "2C", "5H"}, new List<string>{"10C", "3C", "7H", "JC", "4D"}},
            new List<List<string>>{new List<string>{"JD", "4S", "6S", "5S", "8D"}, new List<string>{"7H", "7S", "4D", "4C", "2H"}},
            new List<List<string>>{new List<string>{"7H", "9H", "5D", "KH", "9C"}, new List<string>{"7C", "10S", "10C", "7S", "5H"}},
            new List<List<string>>{new List<string>{"4C", "8D", "QC", "10S", "4S"}, new List<string>{"9H", "3D", "AD", "JS", "7C"}},
            new List<List<string>>{new List<string>{"8C", "QS", "5C", "5D", "3H"}, new List<string>{"JS", "AH", "KC", "4S", "9D"}},
            new List<List<string>>{new List<string>{"10S", "JD", "8S", "QS", "10H"}, new List<string>{"JH", "KH", "2D", "QD", "JS"}},
            new List<List<string>>{new List<string>{"JD", "QC", "5D", "6S", "9H"}, new List<string>{"3S", "2C", "8H", "9S", "10S"}},
            new List<List<string>>{new List<string>{"2S", "4C", "AD", "7H", "JC"}, new List<string>{"5C", "2D", "6D", "4H", "3D"}},
            new List<List<string>>{new List<string>{"7S", "JS", "2C", "4H", "8C"}, new List<string>{"AD", "QD", "9C", "3S", "10D"}},
            new List<List<string>>{new List<string>{"JD", "10S", "4C", "6H", "9H"}, new List<string>{"7D", "QD", "6D", "3C", "AS"}},
            new List<List<string>>{new List<string>{"AS", "7C", "4C", "6S", "5D"}, new List<string>{"5S", "5C", "JS", "QC", "4S"}},
            new List<List<string>>{new List<string>{"KD", "6S", "9S", "7C", "3C"}, new List<string>{"5S", "7D", "JH", "QD", "JS"}},
            new List<List<string>>{new List<string>{"4S", "7S", "JH", "2C", "8S"}, new List<string>{"5D", "7H", "3D", "QH", "AD"}},
            new List<List<string>>{new List<string>{"10D", "6H", "2H", "8D", "4H"}, new List<string>{"2D", "7C", "AD", "KH", "5D"}},
            new List<List<string>>{new List<string>{"10S", "3S", "5H", "2C", "QD"}, new List<string>{"AH", "2S", "5C", "KH", "10D"}},
            new List<List<string>>{new List<string>{"KC", "4D", "8C", "5D", "AS"}, new List<string>{"6C", "2H", "2S", "9H", "7C"}},
            new List<List<string>>{new List<string>{"KD", "JS", "QC", "10S", "QS"}, new List<string>{"KH", "JH", "2C", "5D", "AD"}},
            new List<List<string>>{new List<string>{"3S", "5H", "KC", "6C", "9H"}, new List<string>{"3H", "2H", "AD", "7D", "7S"}},
            new List<List<string>>{new List<string>{"7S", "JS", "JH", "KD", "8S"}, new List<string>{"7D", "2S", "9H", "7C", "2H"}},
            new List<List<string>>{new List<string>{"9H", "2D", "8D", "QC", "6S"}, new List<string>{"AD", "AS", "8H", "5H", "6C"}},
            new List<List<string>>{new List<string>{"2S", "7H", "6C", "6D", "7D"}, new List<string>{"8C", "5D", "9D", "JC", "3C"}},
            new List<List<string>>{new List<string>{"7C", "9C", "7H", "JD", "2H"}, new List<string>{"KD", "3S", "KH", "AD", "4S"}},
            new List<List<string>>{new List<string>{"QH", "AS", "9H", "4D", "JD"}, new List<string>{"KS", "KD", "10S", "KH", "5H"}},
            new List<List<string>>{new List<string>{"4C", "8H", "5S", "3S", "3D"}, new List<string>{"7D", "10D", "AD", "7S", "KC"}},
            new List<List<string>>{new List<string>{"JS", "8S", "5S", "JC", "8H"}, new List<string>{"10H", "9C", "4D", "5D", "KC"}},
            new List<List<string>>{new List<string>{"7C", "5S", "9C", "QD", "2C"}, new List<string>{"QH", "JS", "5H", "8D", "KH"}},
            new List<List<string>>{new List<string>{"10D", "2S", "KS", "3D", "AD"}, new List<string>{"KC", "7S", "10C", "3C", "5D"}},
            new List<List<string>>{new List<string>{"4C", "2S", "AD", "QS", "6C"}, new List<string>{"9S", "QD", "10H", "QH", "5C"}},
            new List<List<string>>{new List<string>{"8C", "AD", "QS", "2D", "2S"}, new List<string>{"KC", "JD", "KS", "6C", "JC"}},
            new List<List<string>>{new List<string>{"8D", "4D", "JS", "2H", "5D"}, new List<string>{"QD", "7S", "7D", "QH", "10S"}},
            new List<List<string>>{new List<string>{"6S", "7H", "3S", "8C", "8S"}, new List<string>{"9D", "QS", "8H", "6C", "9S"}},
            new List<List<string>>{new List<string>{"4S", "10C", "2S", "5C", "QD"}, new List<string>{"4D", "QS", "6D", "10H", "6S"}},
            new List<List<string>>{new List<string>{"3S", "5C", "9D", "6H", "8D"}, new List<string>{"4C", "7D", "10C", "7C", "10D"}},
            new List<List<string>>{new List<string>{"AH", "6S", "AS", "7H", "5S"}, new List<string>{"KD", "3H", "5H", "AC", "4C"}},
            new List<List<string>>{new List<string>{"8D", "8S", "AH", "KS", "QS"}, new List<string>{"2C", "AD", "6H", "7D", "5D"}},
            new List<List<string>>{new List<string>{"6H", "9H", "9S", "2H", "QS"}, new List<string>{"8S", "9C", "5D", "2D", "KD"}},
            new List<List<string>>{new List<string>{"10S", "QC", "5S", "JH", "7D"}, new List<string>{"7S", "10H", "9S", "9H", "AC"}},
            new List<List<string>>{new List<string>{"7H", "3H", "6S", "KC", "4D"}, new List<string>{"6D", "5C", "4S", "QD", "10S"}},
            new List<List<string>>{new List<string>{"10D", "2S", "7C", "QD", "3H"}, new List<string>{"JH", "9D", "4H", "7S", "7H"}},
            new List<List<string>>{new List<string>{"KS", "3D", "4H", "5H", "10C"}, new List<string>{"2S", "AS", "2D", "6D", "7D"}},
            new List<List<string>>{new List<string>{"8H", "3C", "7H", "10D", "3H"}, new List<string>{"AD", "KC", "10H", "9C", "KH"}},
            new List<List<string>>{new List<string>{"10C", "4C", "2C", "9S", "9D"}, new List<string>{"9C", "5C", "2H", "JD", "3C"}},
            new List<List<string>>{new List<string>{"3H", "AC", "10S", "5D", "AD"}, new List<string>{"8D", "6H", "QC", "6S", "8C"}},
            new List<List<string>>{new List<string>{"2S", "10S", "3S", "JD", "7H"}, new List<string>{"8S", "QH", "4C", "5S", "8D"}},
            new List<List<string>>{new List<string>{"AC", "4S", "6C", "3C", "KH"}, new List<string>{"3D", "7C", "2D", "8S", "2H"}},
            new List<List<string>>{new List<string>{"4H", "6C", "8S", "10H", "2H"}, new List<string>{"4S", "8H", "9S", "3H", "7S"}},
            new List<List<string>>{new List<string>{"7C", "4C", "9C", "2C", "5C"}, new List<string>{"AS", "5D", "KD", "4D", "QH"}},
            new List<List<string>>{new List<string>{"9H", "4H", "10S", "AS", "7D"}, new List<string>{"8D", "5D", "9S", "8C", "2H"}},
            new List<List<string>>{new List<string>{"QC", "KD", "AC", "AD", "2H"}, new List<string>{"7S", "AS", "3S", "2D", "9S"}},
            new List<List<string>>{new List<string>{"2H", "QC", "8H", "10C", "6D"}, new List<string>{"QD", "QS", "5D", "KH", "3C"}},
            new List<List<string>>{new List<string>{"10H", "JD", "QS", "4C", "2S"}, new List<string>{"5S", "AD", "7H", "3S", "AS"}},
            new List<List<string>>{new List<string>{"7H", "JS", "3D", "6C", "3S"}, new List<string>{"6D", "AS", "9S", "AC", "QS"}},
            new List<List<string>>{new List<string>{"9C", "10S", "AS", "8C", "10C"}, new List<string>{"8S", "6H", "9D", "8D", "6C"}},
            new List<List<string>>{new List<string>{"4D", "JD", "9C", "KC", "7C"}, new List<string>{"6D", "KS", "3S", "8C", "AS"}},
            new List<List<string>>{new List<string>{"3H", "6S", "10C", "8D", "10S"}, new List<string>{"3S", "KC", "9S", "7C", "AS"}},
            new List<List<string>>{new List<string>{"8C", "QC", "4H", "4S", "8S"}, new List<string>{"6C", "3S", "10C", "AH", "AC"}},
            new List<List<string>>{new List<string>{"4D", "7D", "5C", "AS", "2H"}, new List<string>{"6S", "10S", "QC", "AD", "10C"}},
            new List<List<string>>{new List<string>{"QD", "QC", "8S", "4S", "10H"}, new List<string>{"3D", "AH", "10S", "JH", "4H"}},
            new List<List<string>>{new List<string>{"5C", "2D", "9S", "2C", "3H"}, new List<string>{"3C", "9D", "QD", "QH", "7D"}},
            new List<List<string>>{new List<string>{"KC", "9H", "6C", "KD", "7S"}, new List<string>{"3C", "4D", "AS", "10C", "2D"}},
            new List<List<string>>{new List<string>{"3D", "JS", "4D", "9D", "KS"}, new List<string>{"7D", "10H", "QC", "3H", "3C"}},
            new List<List<string>>{new List<string>{"8D", "5S", "2H", "9D", "3H"}, new List<string>{"8C", "4C", "4H", "3C", "10H"}},
            new List<List<string>>{new List<string>{"JC", "10H", "4S", "6S", "JD"}, new List<string>{"2D", "4D", "6C", "3D", "4C"}},
            new List<List<string>>{new List<string>{"10S", "3S", "2D", "4H", "AC"}, new List<string>{"2C", "6S", "2H", "JH", "6H"}},
            new List<List<string>>{new List<string>{"10D", "8S", "AD", "10C", "AH"}, new List<string>{"AC", "JH", "9S", "6S", "7S"}},
            new List<List<string>>{new List<string>{"6C", "KC", "4S", "JD", "8D"}, new List<string>{"9H", "5S", "7H", "QH", "AH"}},
            new List<List<string>>{new List<string>{"KD", "8D", "10S", "JH", "5C"}, new List<string>{"5H", "3H", "AD", "AS", "JS"}},
            new List<List<string>>{new List<string>{"2D", "4H", "3D", "6C", "8C"}, new List<string>{"7S", "AD", "5D", "5C", "8S"}},
            new List<List<string>>{new List<string>{"10D", "5D", "7S", "9C", "4S"}, new List<string>{"5H", "6C", "8C", "4C", "8S"}},
            new List<List<string>>{new List<string>{"JS", "QH", "9C", "AS", "5C"}, new List<string>{"QS", "JC", "3D", "QC", "7C"}},
            new List<List<string>>{new List<string>{"JC", "9C", "KH", "JH", "QS"}, new List<string>{"QC", "2C", "10S", "3D", "AD"}},
            new List<List<string>>{new List<string>{"5D", "JH", "AC", "5C", "9S"}, new List<string>{"10S", "4C", "JD", "8C", "KS"}},
            new List<List<string>>{new List<string>{"KC", "AS", "2D", "KH", "9H"}, new List<string>{"2C", "5S", "4D", "3D", "6H"}},
            new List<List<string>>{new List<string>{"10H", "AH", "2D", "8S", "JC"}, new List<string>{"3D", "8C", "QH", "7S", "3S"}},
            new List<List<string>>{new List<string>{"8H", "QD", "4H", "JC", "AS"}, new List<string>{"KH", "KS", "3C", "9S", "6D"}},
            new List<List<string>>{new List<string>{"9S", "QH", "7D", "9C", "4S"}, new List<string>{"AC", "7H", "KH", "4D", "KD"}},
            new List<List<string>>{new List<string>{"AH", "AD", "10H", "6D", "9C"}, new List<string>{"9S", "KD", "KS", "QH", "4H"}},
            new List<List<string>>{new List<string>{"QD", "6H", "9C", "7C", "QS"}, new List<string>{"6D", "6S", "9D", "5S", "JH"}},
            new List<List<string>>{new List<string>{"AH", "8D", "5H", "QD", "2H"}, new List<string>{"JC", "KS", "4H", "KH", "5S"}},
            new List<List<string>>{new List<string>{"5C", "2S", "JS", "8D", "9C"}, new List<string>{"8C", "3D", "AS", "KC", "AH"}},
            new List<List<string>>{new List<string>{"JD", "9S", "2H", "QS", "8H"}, new List<string>{"5S", "8C", "10H", "5C", "4C"}},
            new List<List<string>>{new List<string>{"QC", "QS", "8C", "2S", "2C"}, new List<string>{"3S", "9C", "4C", "KS", "KH"}},
            new List<List<string>>{new List<string>{"2D", "5D", "8S", "AH", "AD"}, new List<string>{"10D", "2C", "JS", "KS", "8C"}},
            new List<List<string>>{new List<string>{"10C", "5S", "5H", "8H", "QC"}, new List<string>{"9H", "6H", "JD", "4H", "9S"}},
            new List<List<string>>{new List<string>{"3C", "JH", "4H", "9H", "AH"}, new List<string>{"4S", "2H", "4C", "8D", "AC"}},
            new List<List<string>>{new List<string>{"8S", "10H", "4D", "7D", "6D"}, new List<string>{"QD", "QS", "7S", "10C", "7C"}},
            new List<List<string>>{new List<string>{"KH", "6D", "2D", "JD", "5H"}, new List<string>{"JS", "QD", "JH", "4H", "4S"}},
            new List<List<string>>{new List<string>{"9C", "7S", "JH", "4S", "3S"}, new List<string>{"10S", "QC", "8C", "10C", "4H"}},
            new List<List<string>>{new List<string>{"QH", "9D", "4D", "JH", "QS"}, new List<string>{"3S", "2C", "7C", "6C", "2D"}},
            new List<List<string>>{new List<string>{"4H", "9S", "JD", "5C", "5H"}, new List<string>{"AH", "9D", "10S", "2D", "4C"}},
            new List<List<string>>{new List<string>{"KS", "JH", "10S", "5D", "2D"}, new List<string>{"AH", "JS", "7H", "AS", "8D"}},
            new List<List<string>>{new List<string>{"JS", "AH", "8C", "AD", "KS"}, new List<string>{"5S", "8H", "2C", "6C", "10H"}},
            new List<List<string>>{new List<string>{"2H", "5D", "AD", "AC", "KS"}, new List<string>{"3D", "8H", "10S", "6H", "QC"}},
            new List<List<string>>{new List<string>{"6D", "4H", "10S", "9C", "5H"}, new List<string>{"JS", "JH", "6S", "JD", "4C"}},
            new List<List<string>>{new List<string>{"JH", "QH", "4H", "2C", "6D"}, new List<string>{"3C", "5D", "4C", "QS", "KC"}},
            new List<List<string>>{new List<string>{"6H", "4H", "6C", "7H", "6S"}, new List<string>{"2S", "8S", "KH", "QC", "8C"}},
            new List<List<string>>{new List<string>{"3H", "3D", "5D", "KS", "4H"}, new List<string>{"10D", "AD", "3S", "4D", "10S"}},
            new List<List<string>>{new List<string>{"5S", "7C", "8S", "7D", "2C"}, new List<string>{"KS", "7S", "6C", "8C", "JS"}},
            new List<List<string>>{new List<string>{"5D", "2H", "3S", "7C", "5C"}, new List<string>{"QD", "5H", "6D", "9C", "9H"}},
            new List<List<string>>{new List<string>{"JS", "2S", "KD", "9S", "8D"}, new List<string>{"10D", "10S", "AC", "8C", "9D"}},
            new List<List<string>>{new List<string>{"5H", "QD", "2S", "AC", "8C"}, new List<string>{"9H", "KS", "7C", "4S", "3C"}},
            new List<List<string>>{new List<string>{"KH", "AS", "3H", "8S", "9C"}, new List<string>{"JS", "QS", "4S", "AD", "4D"}},
            new List<List<string>>{new List<string>{"AS", "2S", "10D", "AD", "4D"}, new List<string>{"9H", "JC", "4C", "5H", "QS"}},
            new List<List<string>>{new List<string>{"5D", "7C", "4H", "10C", "2D"}, new List<string>{"6C", "JS", "4S", "KC", "3S"}},
            new List<List<string>>{new List<string>{"4C", "2C", "5D", "AC", "9H"}, new List<string>{"3D", "JD", "8S", "QS", "QH"}},
            new List<List<string>>{new List<string>{"2C", "8S", "6H", "3C", "QH"}, new List<string>{"6D", "10C", "KD", "AC", "AH"}},
            new List<List<string>>{new List<string>{"QC", "6C", "3S", "QS", "4S"}, new List<string>{"AC", "8D", "5C", "AD", "KH"}},
            new List<List<string>>{new List<string>{"5S", "4C", "AC", "KH", "AS"}, new List<string>{"QC", "2C", "5C", "8D", "9C"}},
            new List<List<string>>{new List<string>{"8H", "JD", "3C", "KH", "8D"}, new List<string>{"5C", "9C", "QD", "QH", "9D"}},
            new List<List<string>>{new List<string>{"7H", "10S", "2C", "8C", "4S"}, new List<string>{"10D", "JC", "9C", "5H", "QH"}},
            new List<List<string>>{new List<string>{"JS", "4S", "2C", "7C", "10H"}, new List<string>{"6C", "AS", "KS", "7S", "JD"}},
            new List<List<string>>{new List<string>{"JH", "7C", "9H", "7H", "10C"}, new List<string>{"5H", "3D", "6D", "5D", "4D"}},
            new List<List<string>>{new List<string>{"2C", "QD", "JH", "2H", "9D"}, new List<string>{"5S", "3D", "10D", "AD", "KS"}},
            new List<List<string>>{new List<string>{"JD", "QH", "3S", "4D", "10H"}, new List<string>{"7D", "6S", "QS", "KS", "4H"}},
            new List<List<string>>{new List<string>{"10C", "KS", "5S", "8D", "8H"}, new List<string>{"AD", "2S", "2D", "4C", "JH"}},
            new List<List<string>>{new List<string>{"5S", "JH", "10C", "3S", "2D"}, new List<string>{"QS", "9D", "4C", "KD", "9S"}},
            new List<List<string>>{new List<string>{"AC", "KH", "3H", "AS", "9D"}, new List<string>{"KC", "9H", "QD", "6C", "6S"}},
            new List<List<string>>{new List<string>{"9H", "7S", "3D", "5C", "7D"}, new List<string>{"KC", "10D", "8H", "4H", "6S"}},
            new List<List<string>>{new List<string>{"3C", "7H", "8H", "10C", "QD"}, new List<string>{"4D", "7S", "6S", "QH", "6C"}},
            new List<List<string>>{new List<string>{"6D", "AD", "4C", "QD", "6C"}, new List<string>{"5D", "7D", "9D", "KS", "10S"}},
            new List<List<string>>{new List<string>{"JH", "2H", "JD", "9S", "7S"}, new List<string>{"10S", "KH", "8D", "5D", "8H"}},
            new List<List<string>>{new List<string>{"2D", "9S", "4C", "7D", "9D"}, new List<string>{"5H", "QD", "6D", "AC", "6S"}},
            new List<List<string>>{new List<string>{"7S", "6D", "JC", "QD", "JH"}, new List<string>{"4C", "6S", "QS", "2H", "7D"}},
            new List<List<string>>{new List<string>{"8C", "10D", "JH", "KD", "2H"}, new List<string>{"5C", "QS", "2C", "JS", "7S"}},
            new List<List<string>>{new List<string>{"10C", "5H", "4H", "JH", "QD"}, new List<string>{"3S", "5S", "5D", "8S", "KH"}},
            new List<List<string>>{new List<string>{"KS", "KH", "7C", "2C", "5D"}, new List<string>{"JH", "6S", "9C", "6D", "JC"}},
            new List<List<string>>{new List<string>{"5H", "AH", "JD", "9C", "JS"}, new List<string>{"KC", "2H", "6H", "4D", "5S"}},
            new List<List<string>>{new List<string>{"AS", "3C", "10H", "QC", "6H"}, new List<string>{"9C", "8S", "8C", "10D", "7C"}},
            new List<List<string>>{new List<string>{"KC", "2C", "QD", "9C", "KH"}, new List<string>{"4D", "7S", "3C", "10S", "9H"}},
            new List<List<string>>{new List<string>{"9C", "QC", "2S", "10S", "8C"}, new List<string>{"10D", "9S", "QD", "3S", "3C"}},
            new List<List<string>>{new List<string>{"4D", "9D", "10H", "JH", "AH"}, new List<string>{"6S", "2S", "JD", "QH", "JS"}},
            new List<List<string>>{new List<string>{"QD", "9H", "6C", "KD", "7D"}, new List<string>{"7H", "5D", "6S", "8H", "AH"}},
            new List<List<string>>{new List<string>{"8H", "3C", "4S", "2H", "5H"}, new List<string>{"QS", "QH", "7S", "4H", "AC"}},
            new List<List<string>>{new List<string>{"QS", "3C", "7S", "9S", "4H"}, new List<string>{"3S", "AH", "KS", "9D", "7C"}},
            new List<List<string>>{new List<string>{"AD", "5S", "6S", "2H", "2D"}, new List<string>{"5H", "10C", "4S", "3C", "8C"}},
            new List<List<string>>{new List<string>{"QH", "10S", "6S", "4D", "JS"}, new List<string>{"KS", "JH", "AS", "8S", "6D"}},
            new List<List<string>>{new List<string>{"2C", "8S", "2S", "10D", "5H"}, new List<string>{"AS", "10C", "10S", "6C", "KC"}},
            new List<List<string>>{new List<string>{"KC", "10S", "8H", "2H", "3H"}, new List<string>{"7C", "4C", "5S", "10H", "10D"}},
            new List<List<string>>{new List<string>{"KD", "AD", "KH", "7H", "7S"}, new List<string>{"5D", "5H", "5S", "2D", "9C"}},
            new List<List<string>>{new List<string>{"AD", "9S", "3D", "7S", "8C"}, new List<string>{"QC", "7C", "9C", "KD", "KS"}},
            new List<List<string>>{new List<string>{"3C", "QC", "9S", "8C", "4D"}, new List<string>{"5C", "AS", "QD", "6C", "2C"}},
            new List<List<string>>{new List<string>{"2H", "KC", "8S", "JD", "7S"}, new List<string>{"AC", "8D", "5C", "2S", "4D"}},
            new List<List<string>>{new List<string>{"9D", "QH", "3D", "2S", "10C"}, new List<string>{"3S", "KS", "3C", "9H", "10D"}},
            new List<List<string>>{new List<string>{"KD", "6S", "AC", "2C", "7H"}, new List<string>{"5H", "3S", "6C", "6H", "8C"}},
            new List<List<string>>{new List<string>{"QH", "10C", "8S", "6S", "KH"}, new List<string>{"10H", "4H", "5D", "10S", "4D"}},
            new List<List<string>>{new List<string>{"8C", "JS", "4H", "6H", "2C"}, new List<string>{"2H", "7D", "AC", "QD", "3D"}},
            new List<List<string>>{new List<string>{"QS", "KC", "6S", "2D", "5S"}, new List<string>{"4H", "10D", "3H", "JH", "4C"}},
            new List<List<string>>{new List<string>{"7S", "5H", "7H", "8H", "KH"}, new List<string>{"6H", "QS", "10H", "KD", "7D"}},
            new List<List<string>>{new List<string>{"5H", "AD", "KD", "7C", "KH"}, new List<string>{"5S", "10D", "6D", "3C", "6C"}},
            new List<List<string>>{new List<string>{"8C", "9C", "5H", "JD", "7C"}, new List<string>{"KC", "KH", "7H", "2H", "3S"}},
            new List<List<string>>{new List<string>{"7S", "4H", "AD", "4D", "8S"}, new List<string>{"QS", "10H", "3D", "7H", "5S"}},
            new List<List<string>>{new List<string>{"8D", "10C", "KS", "KD", "9S"}, new List<string>{"6D", "AD", "JD", "5C", "2S"}},
            new List<List<string>>{new List<string>{"7H", "8H", "6C", "QD", "2H"}, new List<string>{"6H", "9D", "10C", "9S", "7C"}},
            new List<List<string>>{new List<string>{"8D", "6D", "4C", "7C", "6C"}, new List<string>{"3C", "10H", "KH", "JS", "JH"}},
            new List<List<string>>{new List<string>{"5S", "3S", "8S", "JS", "9H"}, new List<string>{"AS", "AD", "8H", "7S", "KD"}},
            new List<List<string>>{new List<string>{"JH", "7C", "2C", "KC", "5H"}, new List<string>{"AS", "AD", "9C", "9S", "JS"}},
            new List<List<string>>{new List<string>{"AD", "AC", "2C", "6S", "QD"}, new List<string>{"7C", "3H", "10H", "KS", "KD"}},
            new List<List<string>>{new List<string>{"9D", "JD", "4H", "8H", "4C"}, new List<string>{"KH", "7S", "10S", "8C", "KC"}},
            new List<List<string>>{new List<string>{"3S", "5S", "2H", "7S", "6H"}, new List<string>{"7D", "KS", "5C", "6D", "AD"}},
            new List<List<string>>{new List<string>{"5S", "8C", "9H", "QS", "7H"}, new List<string>{"7S", "2H", "6C", "7D", "10D"}},
            new List<List<string>>{new List<string>{"QS", "5S", "10D", "AC", "9D"}, new List<string>{"KC", "3D", "10C", "2D", "4D"}},
            new List<List<string>>{new List<string>{"10D", "2H", "7D", "JD", "QD"}, new List<string>{"4C", "7H", "5D", "KC", "3D"}},
            new List<List<string>>{new List<string>{"4C", "3H", "8S", "KD", "QH"}, new List<string>{"5S", "QC", "9H", "10C", "5H"}},
            new List<List<string>>{new List<string>{"9C", "QD", "10H", "5H", "10S"}, new List<string>{"5C", "9H", "AH", "QH", "2C"}},
            new List<List<string>>{new List<string>{"4D", "6S", "3C", "AC", "6C"}, new List<string>{"3D", "2C", "2H", "10D", "10H"}},
            new List<List<string>>{new List<string>{"AC", "9C", "5D", "QC", "4D"}, new List<string>{"AD", "8D", "6D", "8C", "KC"}},
            new List<List<string>>{new List<string>{"AD", "3C", "4H", "AC", "8D"}, new List<string>{"8H", "7S", "9S", "10D", "JC"}},
            new List<List<string>>{new List<string>{"4H", "9H", "QH", "JS", "2D"}, new List<string>{"10H", "10D", "10C", "KD", "KS"}},
            new List<List<string>>{new List<string>{"5S", "6S", "9S", "8D", "10H"}, new List<string>{"AS", "KH", "5H", "5C", "8S"}},
            new List<List<string>>{new List<string>{"JD", "2S", "9S", "6S", "5S"}, new List<string>{"8S", "5D", "7S", "7H", "9D"}},
            new List<List<string>>{new List<string>{"5D", "8C", "4C", "9D", "AD"}, new List<string>{"10S", "2C", "7D", "KD", "10C"}},
            new List<List<string>>{new List<string>{"8S", "QS", "4D", "KC", "5C"}, new List<string>{"8D", "4S", "KH", "JD", "KD"}},
            new List<List<string>>{new List<string>{"AS", "5C", "AD", "QH", "7D"}, new List<string>{"2H", "9S", "7H", "7C", "10C"}},
            new List<List<string>>{new List<string>{"2S", "8S", "JD", "KH", "7S"}, new List<string>{"6C", "6D", "AD", "5D", "QC"}},
            new List<List<string>>{new List<string>{"9H", "6H", "3S", "8C", "8H"}, new List<string>{"AH", "10C", "4H", "JS", "10D"}},
            new List<List<string>>{new List<string>{"2C", "10S", "4D", "7H", "2D"}, new List<string>{"QC", "9C", "5D", "10H", "7C"}},
            new List<List<string>>{new List<string>{"6C", "8H", "QC", "5D", "10S"}, new List<string>{"JH", "5C", "5H", "9H", "4S"}},
            new List<List<string>>{new List<string>{"2D", "QC", "7H", "AS", "JS"}, new List<string>{"8S", "2H", "4C", "4H", "8D"}},
            new List<List<string>>{new List<string>{"JS", "6S", "AC", "KD", "3D"}, new List<string>{"3C", "4S", "7H", "10H", "KC"}},
            new List<List<string>>{new List<string>{"QH", "KH", "6S", "QS", "5S"}, new List<string>{"4H", "3C", "QD", "3S", "3H"}},
            new List<List<string>>{new List<string>{"7H", "AS", "KH", "8C", "4H"}, new List<string>{"9C", "5S", "3D", "6S", "10S"}},
            new List<List<string>>{new List<string>{"9C", "7C", "3H", "5S", "QD"}, new List<string>{"2C", "3D", "AD", "AC", "5H"}},
            new List<List<string>>{new List<string>{"JH", "10D", "2D", "4C", "10S"}, new List<string>{"3H", "KH", "AD", "3S", "7S"}},
            new List<List<string>>{new List<string>{"AS", "4C", "5H", "4D", "6S"}, new List<string>{"KD", "JC", "3C", "6H", "2D"}},
            new List<List<string>>{new List<string>{"3H", "6S", "8C", "2D", "10H"}, new List<string>{"4S", "AH", "QH", "AD", "5H"}},
            new List<List<string>>{new List<string>{"7C", "2S", "9H", "7H", "KC"}, new List<string>{"5C", "6D", "5S", "3H", "JC"}},
            new List<List<string>>{new List<string>{"3C", "10C", "9C", "4H", "QD"}, new List<string>{"10D", "JH", "6D", "9H", "5S"}},
            new List<List<string>>{new List<string>{"7C", "6S", "5C", "5D", "6C"}, new List<string>{"4S", "7H", "9H", "6H", "AH"}},
            new List<List<string>>{new List<string>{"AD", "2H", "7D", "KC", "2C"}, new List<string>{"4C", "2S", "9S", "7H", "3S"}},
            new List<List<string>>{new List<string>{"10H", "4C", "8S", "6S", "3S"}, new List<string>{"AD", "KS", "AS", "JH", "10D"}},
            new List<List<string>>{new List<string>{"5C", "10D", "4S", "4D", "AD"}, new List<string>{"6S", "5D", "10C", "9C", "7D"}},
            new List<List<string>>{new List<string>{"8H", "3S", "4D", "4S", "5S"}, new List<string>{"6H", "5C", "AC", "3H", "3D"}},
            new List<List<string>>{new List<string>{"9H", "3C", "AC", "4S", "QS"}, new List<string>{"8S", "9D", "QH", "5H", "4D"}},
            new List<List<string>>{new List<string>{"JC", "6C", "5H", "10S", "AC"}, new List<string>{"9C", "JD", "8C", "7C", "QD"}},
            new List<List<string>>{new List<string>{"8S", "8H", "9C", "JD", "2D"}, new List<string>{"QC", "QH", "6H", "3C", "8D"}},
            new List<List<string>>{new List<string>{"KS", "JS", "2H", "6H", "5H"}, new List<string>{"QH", "QS", "3H", "7C", "6D"}},
            new List<List<string>>{new List<string>{"10C", "3H", "4S", "7H", "QC"}, new List<string>{"2H", "3S", "8C", "JS", "KH"}},
            new List<List<string>>{new List<string>{"AH", "8H", "5S", "4C", "9H"}, new List<string>{"JD", "3H", "7S", "JC", "AC"}},
            new List<List<string>>{new List<string>{"3C", "2D", "4C", "5S", "6C"}, new List<string>{"4S", "QS", "3S", "JD", "3D"}},
            new List<List<string>>{new List<string>{"5H", "2D", "10C", "AH", "KS"}, new List<string>{"6D", "7H", "AD", "8C", "6H"}},
            new List<List<string>>{new List<string>{"6C", "7S", "3C", "JD", "7C"}, new List<string>{"8H", "KS", "KH", "AH", "6D"}},
            new List<List<string>>{new List<string>{"AH", "7D", "3H", "8H", "8S"}, new List<string>{"7H", "QS", "5H", "9D", "2D"}},
            new List<List<string>>{new List<string>{"JD", "AC", "4H", "7S", "8S"}, new List<string>{"9S", "KS", "AS", "9D", "QH"}},
            new List<List<string>>{new List<string>{"7S", "2C", "8S", "5S", "JH"}, new List<string>{"QS", "JC", "AH", "KD", "4C"}},
            new List<List<string>>{new List<string>{"AH", "2S", "9H", "4H", "8D"}, new List<string>{"10S", "10D", "6H", "QH", "JD"}},
            new List<List<string>>{new List<string>{"4H", "JC", "3H", "QS", "6D"}, new List<string>{"7S", "9C", "8S", "9D", "8D"}},
            new List<List<string>>{new List<string>{"5H", "10D", "4S", "9S", "4C"}, new List<string>{"8C", "8D", "7H", "3H", "3D"}},
            new List<List<string>>{new List<string>{"QS", "KH", "3S", "2C", "2S"}, new List<string>{"3C", "7S", "10D", "4S", "QD"}},
            new List<List<string>>{new List<string>{"7C", "10D", "4D", "5S", "KH"}, new List<string>{"AC", "AS", "7H", "4C", "6C"}},
            new List<List<string>>{new List<string>{"2S", "5H", "6D", "JD", "9H"}, new List<string>{"QS", "8S", "2C", "2H", "10D"}},
            new List<List<string>>{new List<string>{"2S", "10S", "6H", "9H", "7S"}, new List<string>{"4H", "JC", "4C", "5D", "5S"}},
            new List<List<string>>{new List<string>{"2C", "5H", "7D", "4H", "3S"}, new List<string>{"QH", "JC", "JS", "6D", "8H"}},
            new List<List<string>>{new List<string>{"4C", "QH", "7C", "QD", "3S"}, new List<string>{"AD", "10H", "8S", "5S", "10S"}},
            new List<List<string>>{new List<string>{"9H", "10C", "2S", "10D", "JC"}, new List<string>{"7D", "3S", "3D", "10H", "QH"}},
            new List<List<string>>{new List<string>{"7D", "4C", "8S", "5C", "JH"}, new List<string>{"8H", "6S", "3S", "KC", "3H"}},
            new List<List<string>>{new List<string>{"JC", "3H", "KH", "10C", "QH"}, new List<string>{"10H", "6H", "2C", "AC", "5H"}},
            new List<List<string>>{new List<string>{"QS", "2H", "9D", "2C", "AS"}, new List<string>{"6S", "6C", "2S", "8C", "8S"}},
            new List<List<string>>{new List<string>{"9H", "7D", "QC", "10H", "4H"}, new List<string>{"KD", "QS", "AC", "7S", "3C"}},
            new List<List<string>>{new List<string>{"4D", "JH", "6S", "5S", "8H"}, new List<string>{"KS", "9S", "QC", "3S", "AS"}},
            new List<List<string>>{new List<string>{"JD", "2D", "6S", "7S", "10C"}, new List<string>{"9H", "KC", "3H", "7D", "KD"}},
            new List<List<string>>{new List<string>{"2H", "KH", "7C", "4D", "4S"}, new List<string>{"3H", "JS", "QD", "7D", "KC"}},
            new List<List<string>>{new List<string>{"4C", "JC", "AS", "9D", "3C"}, new List<string>{"JS", "6C", "8H", "QD", "4D"}},
            new List<List<string>>{new List<string>{"AH", "JS", "3S", "6C", "4C"}, new List<string>{"3D", "JH", "6D", "9C", "9H"}},
            new List<List<string>>{new List<string>{"9H", "2D", "8C", "7H", "5S"}, new List<string>{"KS", "6H", "9C", "2S", "10C"}},
            new List<List<string>>{new List<string>{"6C", "8C", "AD", "7H", "6H"}, new List<string>{"3D", "KH", "AS", "5D", "10H"}},
            new List<List<string>>{new List<string>{"KS", "8C", "3S", "10S", "8S"}, new List<string>{"4D", "5S", "9S", "6C", "4H"}},
            new List<List<string>>{new List<string>{"9H", "4S", "4H", "5C", "7D"}, new List<string>{"KC", "2D", "2H", "9D", "JH"}},
            new List<List<string>>{new List<string>{"5C", "JS", "10C", "9D", "9H"}, new List<string>{"5H", "7S", "KH", "JC", "6S"}},
            new List<List<string>>{new List<string>{"7C", "9H", "8H", "4D", "JC"}, new List<string>{"KH", "JD", "2H", "10D", "10C"}},
            new List<List<string>>{new List<string>{"8H", "6C", "2H", "2C", "KH"}, new List<string>{"6H", "9D", "QS", "QH", "5H"}},
            new List<List<string>>{new List<string>{"AC", "7D", "2S", "3D", "QD"}, new List<string>{"JC", "2D", "8D", "JD", "JH"}},
            new List<List<string>>{new List<string>{"2H", "JC", "2D", "7H", "2C"}, new List<string>{"3C", "8D", "KD", "10D", "4H"}},
            new List<List<string>>{new List<string>{"3S", "4H", "6D", "8D", "10S"}, new List<string>{"3H", "10D", "3D", "6H", "10H"}},
            new List<List<string>>{new List<string>{"JH", "JC", "3S", "AC", "QH"}, new List<string>{"9H", "7H", "8S", "QC", "2C"}},
            new List<List<string>>{new List<string>{"7H", "10D", "QS", "4S", "8S"}, new List<string>{"9C", "2S", "5D", "4D", "2H"}},
            new List<List<string>>{new List<string>{"3D", "10S", "3H", "2S", "QC"}, new List<string>{"8H", "6H", "KC", "JC", "KS"}},
            new List<List<string>>{new List<string>{"5D", "JD", "7D", "10C", "8C"}, new List<string>{"6C", "9S", "3D", "8D", "AC"}},
            new List<List<string>>{new List<string>{"8H", "6H", "JH", "6C", "5D"}, new List<string>{"8D", "8S", "4H", "AD", "2C"}},
            new List<List<string>>{new List<string>{"9D", "4H", "2D", "2C", "3S"}, new List<string>{"10S", "AS", "10C", "3C", "5D"}},
            new List<List<string>>{new List<string>{"4D", "10H", "5H", "KS", "QS"}, new List<string>{"6C", "4S", "2H", "3D", "AD"}},
            new List<List<string>>{new List<string>{"5C", "KC", "6H", "2C", "5S"}, new List<string>{"3C", "4D", "2D", "9H", "9S"}},
            new List<List<string>>{new List<string>{"JD", "4C", "3H", "10H", "QH"}, new List<string>{"9H", "5S", "AH", "8S", "AC"}},
            new List<List<string>>{new List<string>{"7D", "9S", "6S", "2H", "10D"}, new List<string>{"9C", "4H", "8H", "QS", "4C"}},
            new List<List<string>>{new List<string>{"3C", "6H", "5D", "4H", "8C"}, new List<string>{"9C", "KC", "6S", "QD", "QS"}},
            new List<List<string>>{new List<string>{"3S", "9H", "KD", "10C", "2D"}, new List<string>{"JS", "8C", "6S", "4H", "4S"}},
            new List<List<string>>{new List<string>{"2S", "4C", "8S", "QS", "6H"}, new List<string>{"KH", "3H", "10H", "8C", "5D"}},
            new List<List<string>>{new List<string>{"2C", "KH", "5S", "3S", "7S"}, new List<string>{"7H", "6C", "9D", "QD", "8D"}},
            new List<List<string>>{new List<string>{"8H", "KS", "AC", "2D", "KH"}, new List<string>{"10S", "6C", "JS", "KC", "7H"}},
            new List<List<string>>{new List<string>{"9C", "KS", "5C", "10D", "QC"}, new List<string>{"AH", "6C", "5H", "9S", "7C"}},
            new List<List<string>>{new List<string>{"5D", "4D", "3H", "4H", "6S"}, new List<string>{"7C", "7S", "AH", "QD", "10D"}},
            new List<List<string>>{new List<string>{"2H", "7D", "QC", "6S", "10C"}, new List<string>{"10S", "AH", "7S", "9D", "3H"}},
            new List<List<string>>{new List<string>{"10H", "5H", "QD", "9S", "KS"}, new List<string>{"7S", "7C", "6H", "8C", "10D"}},
            new List<List<string>>{new List<string>{"10H", "2D", "4D", "QC", "5C"}, new List<string>{"7D", "JD", "AH", "9C", "4H"}},
            new List<List<string>>{new List<string>{"4H", "3H", "AH", "8D", "6H"}, new List<string>{"QC", "QH", "9H", "2H", "2C"}},
            new List<List<string>>{new List<string>{"2D", "AD", "4C", "10S", "6H"}, new List<string>{"7S", "10H", "4H", "QS", "10D"}},
            new List<List<string>>{new List<string>{"3C", "KD", "2H", "3H", "QS"}, new List<string>{"JD", "10C", "QC", "5D", "8H"}},
            new List<List<string>>{new List<string>{"KS", "JC", "QD", "10H", "9S"}, new List<string>{"KD", "8D", "8C", "2D", "9C"}},
            new List<List<string>>{new List<string>{"3C", "QD", "KD", "6D", "4D"}, new List<string>{"8D", "AH", "AD", "QC", "8S"}},
            new List<List<string>>{new List<string>{"8H", "3S", "9D", "2S", "3H"}, new List<string>{"KS", "6H", "4C", "7C", "KC"}},
            new List<List<string>>{new List<string>{"10H", "9S", "5C", "3D", "7D"}, new List<string>{"6H", "AC", "7S", "4D", "2C"}},
            new List<List<string>>{new List<string>{"5C", "3D", "JD", "4D", "2D"}, new List<string>{"6D", "5H", "9H", "4C", "KH"}},
            new List<List<string>>{new List<string>{"AS", "7H", "10D", "6C", "2H"}, new List<string>{"3D", "QD", "KS", "4C", "4S"}},
            new List<List<string>>{new List<string>{"JC", "3C", "AC", "7C", "JD"}, new List<string>{"JS", "8H", "9S", "QC", "5D"}},
            new List<List<string>>{new List<string>{"JD", "6S", "5S", "2H", "AS"}, new List<string>{"8C", "7D", "5H", "JH", "3D"}},
            new List<List<string>>{new List<string>{"8D", "10C", "5S", "9S", "8S"}, new List<string>{"3H", "JC", "5H", "7S", "AS"}},
            new List<List<string>>{new List<string>{"5C", "10D", "3D", "7D", "4H"}, new List<string>{"8D", "7H", "4D", "5D", "JS"}},
            new List<List<string>>{new List<string>{"QS", "9C", "KS", "10D", "2S"}, new List<string>{"8S", "5C", "2H", "4H", "AS"}},
            new List<List<string>>{new List<string>{"10H", "7S", "4H", "7D", "3H"}, new List<string>{"JD", "KD", "5D", "2S", "KC"}},
            new List<List<string>>{new List<string>{"JD", "7H", "4S", "8H", "4C"}, new List<string>{"JS", "6H", "QH", "5S", "4H"}},
            new List<List<string>>{new List<string>{"2C", "QS", "8C", "5S", "3H"}, new List<string>{"QC", "2S", "6C", "QD", "AD"}},
            new List<List<string>>{new List<string>{"8C", "3D", "JD", "10C", "4H"}, new List<string>{"2H", "AD", "5S", "AC", "2S"}},
            new List<List<string>>{new List<string>{"5D", "2C", "JS", "2D", "AD"}, new List<string>{"9D", "3D", "4C", "4S", "JH"}},
            new List<List<string>>{new List<string>{"8D", "5H", "5D", "6H", "7S"}, new List<string>{"4D", "KS", "9D", "10D", "JD"}},
            new List<List<string>>{new List<string>{"3D", "6D", "9C", "2S", "AS"}, new List<string>{"7D", "5S", "5C", "8H", "JD"}},
            new List<List<string>>{new List<string>{"7C", "8S", "3S", "6S", "5H"}, new List<string>{"JD", "10C", "AD", "7H", "7S"}},
            new List<List<string>>{new List<string>{"2S", "9D", "10S", "4D", "AC"}, new List<string>{"8D", "6C", "QD", "JD", "3H"}},
            new List<List<string>>{new List<string>{"9S", "KH", "2C", "3C", "AC"}, new List<string>{"3D", "5H", "6H", "8D", "5D"}},
            new List<List<string>>{new List<string>{"KS", "3D", "2D", "6S", "AS"}, new List<string>{"4C", "2S", "7C", "7H", "KH"}},
            new List<List<string>>{new List<string>{"AC", "2H", "3S", "JC", "5C"}, new List<string>{"QH", "4D", "2D", "5H", "7S"}},
            new List<List<string>>{new List<string>{"10S", "AS", "JD", "8C", "6H"}, new List<string>{"JC", "8S", "5S", "2C", "5D"}},
            new List<List<string>>{new List<string>{"7S", "QH", "7H", "6C", "QC"}, new List<string>{"8H", "2D", "7C", "JD", "2S"}},
            new List<List<string>>{new List<string>{"2C", "QD", "2S", "2H", "JC"}, new List<string>{"9C", "5D", "2D", "JD", "JH"}},
            new List<List<string>>{new List<string>{"7C", "5C", "9C", "8S", "7D"}, new List<string>{"6D", "8D", "6C", "9S", "JH"}},
            new List<List<string>>{new List<string>{"2C", "AD", "6S", "5H", "3S"}, new List<string>{"KS", "7S", "9D", "KH", "4C"}},
            new List<List<string>>{new List<string>{"7H", "6C", "2C", "5C", "10H"}, new List<string>{"9D", "8D", "3S", "QC", "AH"}},
            new List<List<string>>{new List<string>{"5S", "KC", "6H", "10C", "5H"}, new List<string>{"8S", "10H", "6D", "3C", "AH"}},
            new List<List<string>>{new List<string>{"9C", "KD", "4H", "AD", "10D"}, new List<string>{"9S", "4S", "7D", "6H", "5D"}},
            new List<List<string>>{new List<string>{"7H", "5C", "5H", "6D", "AS"}, new List<string>{"4C", "KD", "KH", "4H", "9D"}},
            new List<List<string>>{new List<string>{"3C", "2S", "5C", "6C", "JD"}, new List<string>{"QS", "2H", "9D", "7D", "3H"}},
            new List<List<string>>{new List<string>{"AC", "2S", "6S", "7S", "JS"}, new List<string>{"QD", "5C", "QS", "6H", "AD"}},
            new List<List<string>>{new List<string>{"5H", "10H", "QC", "7H", "10C"}, new List<string>{"3S", "7C", "6D", "KC", "3D"}},
            new List<List<string>>{new List<string>{"4H", "3D", "QC", "9S", "8H"}, new List<string>{"2C", "3S", "JC", "KS", "5C"}},
            new List<List<string>>{new List<string>{"4S", "6S", "2C", "6H", "8S"}, new List<string>{"3S", "3D", "9H", "3H", "JS"}},
            new List<List<string>>{new List<string>{"4S", "8C", "4D", "2D", "8H"}, new List<string>{"9H", "7D", "9D", "AH", "10S"}},
            new List<List<string>>{new List<string>{"9S", "2C", "9H", "4C", "8D"}, new List<string>{"AS", "7D", "3D", "6D", "5S"}},
            new List<List<string>>{new List<string>{"6S", "4C", "7H", "8C", "3H"}, new List<string>{"5H", "JC", "AH", "9D", "9C"}},
            new List<List<string>>{new List<string>{"2S", "7C", "5S", "JD", "8C"}, new List<string>{"3S", "3D", "4D", "7D", "6S"}},
            new List<List<string>>{new List<string>{"3C", "KC", "4S", "5D", "7D"}, new List<string>{"3D", "JD", "7H", "3H", "4H"}},
            new List<List<string>>{new List<string>{"9C", "9H", "4H", "4D", "10H"}, new List<string>{"6D", "QD", "8S", "9S", "7S"}},
            new List<List<string>>{new List<string>{"2H", "AC", "8S", "4S", "AD"}, new List<string>{"8C", "2C", "AH", "7D", "10C"}},
            new List<List<string>>{new List<string>{"10S", "9H", "3C", "AD", "KS"}, new List<string>{"10C", "3D", "8C", "8H", "JD"}},
            new List<List<string>>{new List<string>{"QC", "8D", "2C", "3C", "7D"}, new List<string>{"7C", "JD", "9H", "9C", "6C"}},
            new List<List<string>>{new List<string>{"AH", "6S", "JS", "JH", "5D"}, new List<string>{"AS", "QC", "2C", "JD", "10D"}},
            new List<List<string>>{new List<string>{"9H", "KD", "2H", "5D", "2D"}, new List<string>{"3S", "7D", "10C", "AH", "10S"}},
            new List<List<string>>{new List<string>{"10D", "8H", "AS", "5D", "AH"}, new List<string>{"QC", "AC", "6S", "10C", "5H"}},
            new List<List<string>>{new List<string>{"KS", "4S", "7H", "4D", "8D"}, new List<string>{"9C", "10C", "2H", "6H", "3H"}},
            new List<List<string>>{new List<string>{"3H", "KD", "4S", "QD", "QH"}, new List<string>{"3D", "8H", "8C", "10D", "7S"}},
            new List<List<string>>{new List<string>{"8S", "JD", "10C", "AH", "JS"}, new List<string>{"QS", "2D", "KH", "KS", "4D"}},
            new List<List<string>>{new List<string>{"3C", "AD", "JC", "KD", "JS"}, new List<string>{"KH", "4S", "10H", "9H", "2C"}},
            new List<List<string>>{new List<string>{"QC", "5S", "JS", "9S", "KS"}, new List<string>{"AS", "7C", "QD", "2S", "JD"}},
            new List<List<string>>{new List<string>{"KC", "5S", "QS", "3S", "2D"}, new List<string>{"AC", "5D", "9H", "8H", "KS"}},
            new List<List<string>>{new List<string>{"6H", "9C", "10C", "AD", "2C"}, new List<string>{"6D", "5S", "JD", "6C", "7C"}},
            new List<List<string>>{new List<string>{"QS", "KH", "10D", "QD", "2C"}, new List<string>{"3H", "8S", "2S", "QC", "AH"}},
            new List<List<string>>{new List<string>{"9D", "9H", "JH", "10C", "QH"}, new List<string>{"3C", "2S", "JS", "5C", "7H"}},
            new List<List<string>>{new List<string>{"6C", "3S", "3D", "2S", "4S"}, new List<string>{"QD", "2D", "10H", "5D", "2C"}},
            new List<List<string>>{new List<string>{"2D", "6H", "6D", "2S", "JC"}, new List<string>{"QH", "AS", "7H", "4H", "KH"}},
            new List<List<string>>{new List<string>{"5H", "6S", "KS", "AD", "10C"}, new List<string>{"10S", "7C", "AC", "4S", "4H"}},
            new List<List<string>>{new List<string>{"AD", "3C", "4H", "QS", "8C"}, new List<string>{"9D", "KS", "2H", "2D", "4D"}},
            new List<List<string>>{new List<string>{"4S", "9D", "6C", "6D", "9C"}, new List<string>{"AC", "8D", "3H", "7H", "KD"}},
            new List<List<string>>{new List<string>{"JC", "AH", "6C", "10S", "JD"}, new List<string>{"6D", "AD", "3S", "5D", "QD"}},
            new List<List<string>>{new List<string>{"JC", "JH", "JD", "3S", "7S"}, new List<string>{"8S", "JS", "QC", "3H", "4S"}},
            new List<List<string>>{new List<string>{"JD", "10H", "5C", "2C", "AD"}, new List<string>{"JS", "7H", "9S", "2H", "7S"}},
            new List<List<string>>{new List<string>{"8D", "3S", "JH", "4D", "QC"}, new List<string>{"AS", "JD", "2C", "KC", "6H"}},
            new List<List<string>>{new List<string>{"2C", "AC", "5H", "KD", "5S"}, new List<string>{"7H", "QD", "JH", "AH", "2D"}},
            new List<List<string>>{new List<string>{"JC", "QH", "8D", "8S", "10C"}, new List<string>{"5H", "5C", "AH", "8C", "6C"}},
            new List<List<string>>{new List<string>{"3H", "JS", "8S", "QD", "JH"}, new List<string>{"3C", "4H", "6D", "5C", "3S"}},
            new List<List<string>>{new List<string>{"6D", "4S", "4C", "AH", "5H"}, new List<string>{"5S", "3H", "JD", "7C", "8D"}},
            new List<List<string>>{new List<string>{"8H", "AH", "2H", "3H", "JS"}, new List<string>{"3C", "7D", "QC", "4H", "KD"}},
            new List<List<string>>{new List<string>{"6S", "2H", "KD", "5H", "8H"}, new List<string>{"2D", "3C", "8S", "7S", "QD"}},
            new List<List<string>>{new List<string>{"2S", "7S", "KC", "QC", "AH"}, new List<string>{"10C", "QS", "6D", "4C", "8D"}},
            new List<List<string>>{new List<string>{"5S", "9H", "2C", "3S", "QD"}, new List<string>{"7S", "6C", "2H", "7C", "9D"}},
            new List<List<string>>{new List<string>{"3C", "6C", "5C", "5S", "JD"}, new List<string>{"JC", "KS", "3S", "5D", "10S"}},
            new List<List<string>>{new List<string>{"7C", "KS", "6S", "5S", "2S"}, new List<string>{"2D", "10C", "2H", "5H", "QS"}},
            new List<List<string>>{new List<string>{"AS", "7H", "6S", "10S", "5H"}, new List<string>{"9S", "9D", "3C", "KD", "2H"}},
            new List<List<string>>{new List<string>{"4S", "JS", "QS", "3S", "4H"}, new List<string>{"7C", "2S", "AC", "6S", "9D"}},
            new List<List<string>>{new List<string>{"8C", "JH", "2H", "5H", "7C"}, new List<string>{"5D", "QH", "QS", "KH", "QC"}},
            new List<List<string>>{new List<string>{"3S", "10D", "3H", "7C", "KC"}, new List<string>{"8D", "5H", "8S", "KH", "8C"}},
            new List<List<string>>{new List<string>{"4H", "KH", "JD", "10S", "3C"}, new List<string>{"7H", "AS", "QC", "JS", "5S"}},
            new List<List<string>>{new List<string>{"AH", "9D", "2C", "8D", "4D"}, new List<string>{"2D", "6H", "6C", "KC", "6S"}},
            new List<List<string>>{new List<string>{"2S", "6H", "9D", "3S", "7H"}, new List<string>{"4D", "KH", "8H", "KD", "3D"}},
            new List<List<string>>{new List<string>{"9C", "10C", "AC", "JH", "KH"}, new List<string>{"4D", "JD", "5H", "10D", "3S"}},
            new List<List<string>>{new List<string>{"7S", "4H", "9D", "AS", "4C"}, new List<string>{"7D", "QS", "9S", "2S", "KH"}},
            new List<List<string>>{new List<string>{"3S", "8D", "8S", "KS", "8C"}, new List<string>{"JC", "5C", "KH", "2H", "5D"}},
            new List<List<string>>{new List<string>{"8S", "QH", "2C", "4D", "KC"}, new List<string>{"JS", "QC", "9D", "AC", "6H"}},
            new List<List<string>>{new List<string>{"8S", "8C", "7C", "JS", "JD"}, new List<string>{"6S", "4C", "9C", "AC", "4S"}},
            new List<List<string>>{new List<string>{"QH", "5D", "2C", "7D", "JC"}, new List<string>{"8S", "2D", "JS", "JH", "4C"}},
            new List<List<string>>{new List<string>{"JS", "4C", "7S", "10S", "JH"}, new List<string>{"KC", "KH", "5H", "QD", "4S"}},
            new List<List<string>>{new List<string>{"QD", "8C", "8D", "2D", "6S"}, new List<string>{"10D", "9D", "AC", "QH", "5S"}},
            new List<List<string>>{new List<string>{"QH", "QC", "JS", "3D", "3C"}, new List<string>{"5C", "4H", "KH", "8S", "7H"}},
            new List<List<string>>{new List<string>{"7C", "2C", "5S", "JC", "8S"}, new List<string>{"3H", "QC", "5D", "2H", "KC"}},
            new List<List<string>>{new List<string>{"5S", "8D", "KD", "6H", "4H"}, new List<string>{"QD", "QH", "6D", "AH", "3D"}},
            new List<List<string>>{new List<string>{"7S", "KS", "6C", "2S", "4D"}, new List<string>{"AC", "QS", "5H", "10S", "JD"}},
            new List<List<string>>{new List<string>{"7C", "2D", "10C", "5D", "QS"}, new List<string>{"AC", "JS", "QC", "6C", "KC"}},
            new List<List<string>>{new List<string>{"2C", "KS", "4D", "3H", "10S"}, new List<string>{"8S", "AD", "4H", "7S", "9S"}},
            new List<List<string>>{new List<string>{"QD", "9H", "QH", "5H", "4H"}, new List<string>{"4D", "KH", "3S", "JC", "AD"}},
            new List<List<string>>{new List<string>{"4D", "AC", "KC", "8D", "6D"}, new List<string>{"4C", "2D", "KH", "2C", "JD"}},
            new List<List<string>>{new List<string>{"2C", "9H", "2D", "AH", "3H"}, new List<string>{"6D", "9C", "7D", "10C", "KS"}},
            new List<List<string>>{new List<string>{"8C", "3H", "KD", "7C", "5C"}, new List<string>{"2S", "4S", "5H", "AS", "AH"}},
            new List<List<string>>{new List<string>{"10H", "JD", "4H", "KD", "3H"}, new List<string>{"10C", "5C", "3S", "AC", "KH"}},
            new List<List<string>>{new List<string>{"6D", "7H", "AH", "7S", "QC"}, new List<string>{"6H", "2D", "10D", "JD", "AS"}},
            new List<List<string>>{new List<string>{"JH", "5D", "7H", "10C", "9S"}, new List<string>{"7D", "JC", "AS", "5S", "KH"}},
            new List<List<string>>{new List<string>{"2H", "8C", "AD", "10H", "6H"}, new List<string>{"QD", "KD", "9H", "6S", "6C"}},
            new List<List<string>>{new List<string>{"QH", "KC", "9D", "4D", "3S"}, new List<string>{"JS", "JH", "4H", "2C", "9H"}},
            new List<List<string>>{new List<string>{"10C", "7H", "KH", "4H", "JC"}, new List<string>{"7D", "9S", "3H", "QS", "7S"}},
            new List<List<string>>{new List<string>{"AD", "7D", "JH", "6C", "7H"}, new List<string>{"4H", "3S", "3H", "4D", "QH"}},
            new List<List<string>>{new List<string>{"JD", "2H", "5C", "AS", "6C"}, new List<string>{"QC", "4D", "3C", "10C", "JH"}},
            new List<List<string>>{new List<string>{"AC", "JD", "3H", "6H", "4C"}, new List<string>{"JC", "AD", "7D", "7H", "9H"}},
            new List<List<string>>{new List<string>{"4H", "10C", "10S", "2C", "8C"}, new List<string>{"6S", "KS", "2H", "JD", "9S"}},
            new List<List<string>>{new List<string>{"4C", "3H", "QS", "QC", "9S"}, new List<string>{"9H", "6D", "KC", "9D", "9C"}},
            new List<List<string>>{new List<string>{"5C", "AD", "8C", "2C", "QH"}, new List<string>{"10H", "QD", "JC", "8D", "8H"}},
            new List<List<string>>{new List<string>{"QC", "2C", "2S", "QD", "9C"}, new List<string>{"4D", "3S", "8D", "JH", "QS"}},
            new List<List<string>>{new List<string>{"9D", "3S", "2C", "7S", "7C"}, new List<string>{"JC", "10D", "3C", "10C", "9H"}},
            new List<List<string>>{new List<string>{"3C", "10S", "8H", "5C", "4C"}, new List<string>{"2C", "6S", "8D", "7C", "4H"}},
            new List<List<string>>{new List<string>{"KS", "7H", "2H", "10C", "4H"}, new List<string>{"2C", "3S", "AS", "AH", "QS"}},
            new List<List<string>>{new List<string>{"8C", "2D", "2H", "2C", "4S"}, new List<string>{"4C", "6S", "7D", "5S", "3S"}},
            new List<List<string>>{new List<string>{"10H", "QC", "5D", "10D", "3C"}, new List<string>{"QS", "KD", "KC", "KS", "AS"}},
            new List<List<string>>{new List<string>{"4D", "AH", "KD", "9H", "KS"}, new List<string>{"5C", "4C", "6H", "JC", "7S"}},
            new List<List<string>>{new List<string>{"KC", "4H", "5C", "QS", "10C"}, new List<string>{"2H", "JC", "9S", "AH", "QH"}},
            new List<List<string>>{new List<string>{"4S", "9H", "3H", "5H", "3C"}, new List<string>{"QD", "2H", "QC", "JH", "8H"}},
            new List<List<string>>{new List<string>{"5D", "AS", "7H", "2C", "3D"}, new List<string>{"JH", "6H", "4C", "6S", "7D"}},
            new List<List<string>>{new List<string>{"9C", "JD", "9H", "AH", "JS"}, new List<string>{"8S", "QH", "3H", "KS", "8H"}},
            new List<List<string>>{new List<string>{"3S", "AC", "QC", "10S", "4D"}, new List<string>{"AD", "3D", "AH", "8S", "9H"}},
            new List<List<string>>{new List<string>{"7H", "3H", "QS", "9C", "9S"}, new List<string>{"5H", "JH", "JS", "AH", "AC"}},
            new List<List<string>>{new List<string>{"8D", "3C", "JD", "2H", "AC"}, new List<string>{"9C", "7H", "5S", "4D", "8H"}},
            new List<List<string>>{new List<string>{"7C", "JH", "9H", "6C", "JS"}, new List<string>{"9S", "7H", "8C", "9D", "4H"}},
            new List<List<string>>{new List<string>{"2D", "AS", "9S", "6H", "4D"}, new List<string>{"JS", "JH", "9H", "AD", "QD"}},
            new List<List<string>>{new List<string>{"6H", "7S", "JH", "KH", "AH"}, new List<string>{"7H", "10D", "5S", "6S", "2C"}},
            new List<List<string>>{new List<string>{"8H", "JH", "6S", "5H", "5S"}, new List<string>{"9D", "10C", "4C", "QC", "9S"}},
            new List<List<string>>{new List<string>{"7D", "2C", "KD", "3H", "5H"}, new List<string>{"AS", "QD", "7H", "JS", "4D"}},
            new List<List<string>>{new List<string>{"10S", "QH", "6C", "8H", "10H"}, new List<string>{"5H", "3C", "3H", "9C", "9D"}},
            new List<List<string>>{new List<string>{"AD", "KH", "JS", "5D", "3H"}, new List<string>{"AS", "AC", "9S", "5C", "KC"}},
            new List<List<string>>{new List<string>{"2C", "KH", "8C", "JC", "QS"}, new List<string>{"6D", "AH", "2D", "KC", "10C"}},
            new List<List<string>>{new List<string>{"9D", "3H", "2S", "7C", "4D"}, new List<string>{"6D", "KH", "KS", "8D", "7D"}},
            new List<List<string>>{new List<string>{"9H", "2S", "10C", "JH", "AC"}, new List<string>{"QC", "3H", "5S", "3S", "8H"}},
            new List<List<string>>{new List<string>{"3S", "AS", "KD", "8H", "4C"}, new List<string>{"3H", "7C", "JH", "QH", "10S"}},
            new List<List<string>>{new List<string>{"7S", "6D", "7H", "9D", "JH"}, new List<string>{"4C", "3D", "3S", "6C", "AS"}},
            new List<List<string>>{new List<string>{"4S", "2H", "2C", "4C", "8S"}, new List<string>{"5H", "KC", "8C", "QC", "QD"}},
            new List<List<string>>{new List<string>{"3H", "3S", "6C", "QS", "QC"}, new List<string>{"2D", "6S", "5D", "2C", "9D"}},
            new List<List<string>>{new List<string>{"2H", "8D", "JH", "2S", "3H"}, new List<string>{"2D", "6C", "5C", "7S", "AD"}},
            new List<List<string>>{new List<string>{"9H", "JS", "5D", "QH", "8S"}, new List<string>{"10S", "2H", "7S", "6S", "AD"}},
            new List<List<string>>{new List<string>{"6D", "QC", "9S", "7H", "5H"}, new List<string>{"5C", "7D", "KC", "JD", "4H"}},
            new List<List<string>>{new List<string>{"QC", "5S", "9H", "9C", "4D"}, new List<string>{"6S", "KS", "2S", "4C", "7C"}},
            new List<List<string>>{new List<string>{"9H", "7C", "4H", "8D", "3S"}, new List<string>{"6H", "5C", "8H", "JS", "7S"}},
            new List<List<string>>{new List<string>{"2D", "6H", "JS", "10D", "4H"}, new List<string>{"4D", "JC", "10H", "5H", "KC"}},
            new List<List<string>>{new List<string>{"AC", "7C", "8D", "10H", "3H"}, new List<string>{"9S", "2D", "4C", "KC", "4D"}},
            new List<List<string>>{new List<string>{"KD", "QS", "9C", "7S", "3D"}, new List<string>{"KS", "AD", "10S", "4C", "4H"}},
            new List<List<string>>{new List<string>{"QH", "9C", "8H", "2S", "7D"}, new List<string>{"KS", "7H", "5D", "KD", "4C"}},
            new List<List<string>>{new List<string>{"9C", "2S", "2H", "JC", "6S"}, new List<string>{"6C", "10C", "QC", "JH", "5C"}},
            new List<List<string>>{new List<string>{"7S", "AC", "8H", "KC", "8S"}, new List<string>{"6H", "QS", "JC", "3D", "6S"}},
            new List<List<string>>{new List<string>{"JS", "2D", "JH", "8C", "4S"}, new List<string>{"6H", "8H", "6D", "5D", "AD"}},
            new List<List<string>>{new List<string>{"6H", "7D", "2S", "4H", "9H"}, new List<string>{"7C", "AS", "AC", "8H", "5S"}},
            new List<List<string>>{new List<string>{"3C", "JS", "4S", "6D", "5H"}, new List<string>{"2S", "QH", "6S", "9C", "2C"}},
            new List<List<string>>{new List<string>{"3D", "5S", "6S", "9S", "4C"}, new List<string>{"QS", "8D", "QD", "8S", "10C"}},
            new List<List<string>>{new List<string>{"9C", "3D", "AH", "9H", "5S"}, new List<string>{"2C", "7D", "AD", "JC", "3S"}},
            new List<List<string>>{new List<string>{"7H", "10C", "AS", "3C", "6S"}, new List<string>{"6D", "7S", "KH", "KC", "9H"}},
            new List<List<string>>{new List<string>{"3S", "10C", "8H", "6S", "5H"}, new List<string>{"JH", "8C", "7D", "AC", "2S"}},
            new List<List<string>>{new List<string>{"QD", "9D", "9C", "3S", "JC"}, new List<string>{"8C", "KS", "8H", "5D", "4D"}},
            new List<List<string>>{new List<string>{"JS", "AH", "JD", "6D", "9D"}, new List<string>{"8C", "9H", "9S", "8H", "3H"}},
            new List<List<string>>{new List<string>{"2D", "6S", "4C", "4D", "8S"}, new List<string>{"AD", "4S", "10C", "AH", "9H"}},
            new List<List<string>>{new List<string>{"10S", "AC", "QC", "10H", "KC"}, new List<string>{"6D", "4H", "7S", "8C", "2H"}},
            new List<List<string>>{new List<string>{"3C", "QD", "JS", "9D", "5S"}, new List<string>{"JC", "AH", "2H", "10S", "9H"}},
            new List<List<string>>{new List<string>{"3H", "4D", "QH", "5D", "9C"}, new List<string>{"5H", "7D", "4S", "JC", "3S"}},
            new List<List<string>>{new List<string>{"8S", "10H", "3H", "7C", "2H"}, new List<string>{"JD", "JS", "10S", "AC", "8D"}},
            new List<List<string>>{new List<string>{"9C", "2H", "10D", "KC", "JD"}, new List<string>{"2S", "8C", "5S", "AD", "2C"}},
            new List<List<string>>{new List<string>{"3D", "KD", "7C", "5H", "4D"}, new List<string>{"QH", "QD", "10C", "6H", "7D"}},
            new List<List<string>>{new List<string>{"7H", "2C", "KC", "5S", "KD"}, new List<string>{"6H", "AH", "QC", "7S", "QH"}},
            new List<List<string>>{new List<string>{"6H", "5C", "AC", "5H", "2C"}, new List<string>{"9C", "2D", "7C", "10D", "2S"}},
            new List<List<string>>{new List<string>{"4D", "9D", "AH", "3D", "7C"}, new List<string>{"JD", "4H", "8C", "4C", "KS"}},
            new List<List<string>>{new List<string>{"10H", "3C", "JS", "QH", "8H"}, new List<string>{"4C", "AS", "3D", "QS", "QC"}},
            new List<List<string>>{new List<string>{"4D", "7S", "5H", "JH", "6D"}, new List<string>{"7D", "6H", "JS", "KH", "3C"}},
            new List<List<string>>{new List<string>{"QD", "8S", "7D", "2H", "2C"}, new List<string>{"7C", "JC", "2S", "5H", "8C"}},
            new List<List<string>>{new List<string>{"QH", "8S", "9D", "10C", "2H"}, new List<string>{"AD", "7C", "8D", "QD", "6S"}},
            new List<List<string>>{new List<string>{"3S", "7C", "AD", "9H", "2H"}, new List<string>{"9S", "JD", "10S", "4C", "2D"}},
            new List<List<string>>{new List<string>{"3S", "AS", "4H", "QC", "2C"}, new List<string>{"8H", "8S", "7S", "10D", "10C"}},
            new List<List<string>>{new List<string>{"JH", "10H", "10D", "3S", "4D"}, new List<string>{"4H", "5S", "5D", "QS", "2C"}},
            new List<List<string>>{new List<string>{"8C", "QD", "QH", "10C", "6D"}, new List<string>{"4S", "9S", "9D", "4H", "QC"}},
            new List<List<string>>{new List<string>{"8C", "JS", "9D", "6H", "JD"}, new List<string>{"3H", "AD", "6S", "10D", "QC"}},
            new List<List<string>>{new List<string>{"KC", "8S", "3D", "7C", "10D"}, new List<string>{"7D", "8D", "9H", "4S", "3S"}},
            new List<List<string>>{new List<string>{"6C", "4S", "3D", "9D", "KD"}, new List<string>{"10C", "KC", "KS", "AC", "5S"}},
            new List<List<string>>{new List<string>{"7C", "6S", "QH", "3D", "JS"}, new List<string>{"KD", "6H", "6D", "2D", "8C"}},
            new List<List<string>>{new List<string>{"JD", "2S", "5S", "4H", "8S"}, new List<string>{"AC", "2D", "6S", "10S", "5C"}},
            new List<List<string>>{new List<string>{"5H", "8C", "5S", "3C", "4S"}, new List<string>{"3D", "7C", "8D", "AS", "3H"}},
            new List<List<string>>{new List<string>{"AS", "10S", "7C", "3H", "AD"}, new List<string>{"7D", "JC", "QS", "6C", "6H"}},
            new List<List<string>>{new List<string>{"3S", "9S", "4C", "AC", "QH"}, new List<string>{"5H", "5D", "9H", "10S", "4H"}},
            new List<List<string>>{new List<string>{"6C", "5C", "7H", "7S", "10D"}, new List<string>{"AD", "JD", "5S", "2H", "2S"}},
            new List<List<string>>{new List<string>{"7D", "6C", "KC", "3S", "JD"}, new List<string>{"8D", "8S", "10S", "QS", "KH"}},
            new List<List<string>>{new List<string>{"8S", "QS", "8D", "6C", "10H"}, new List<string>{"AC", "AH", "2C", "8H", "9S"}},
            new List<List<string>>{new List<string>{"7H", "10D", "KH", "QH", "8S"}, new List<string>{"3D", "4D", "AH", "JD", "AS"}},
            new List<List<string>>{new List<string>{"10S", "3D", "2H", "JC", "2S"}, new List<string>{"JH", "KH", "6C", "QC", "JS"}},
            new List<List<string>>{new List<string>{"KC", "10H", "2D", "6H", "7S"}, new List<string>{"2S", "10C", "8C", "9D", "QS"}},
            new List<List<string>>{new List<string>{"3C", "9D", "6S", "KH", "8H"}, new List<string>{"6D", "5D", "10H", "2C", "2H"}},
            new List<List<string>>{new List<string>{"6H", "10C", "7D", "AD", "4D"}, new List<string>{"8S", "10S", "9H", "10D", "7S"}},
            new List<List<string>>{new List<string>{"JS", "6D", "JD", "JC", "2H"}, new List<string>{"AC", "6C", "3D", "KH", "8D"}},
            new List<List<string>>{new List<string>{"KH", "JD", "9S", "5D", "4H"}, new List<string>{"4C", "3H", "7S", "QS", "5C"}},
            new List<List<string>>{new List<string>{"4H", "JD", "5D", "3S", "3C"}, new List<string>{"4D", "KH", "QH", "QS", "7S"}},
            new List<List<string>>{new List<string>{"JD", "10S", "8S", "QD", "AH"}, new List<string>{"4C", "6H", "3S", "5S", "2C"}},
            new List<List<string>>{new List<string>{"QS", "3D", "JD", "AS", "8D"}, new List<string>{"10H", "7C", "6S", "QC", "KS"}},
            new List<List<string>>{new List<string>{"7S", "2H", "8C", "QC", "7H"}, new List<string>{"AC", "6D", "2D", "10H", "KH"}},
            new List<List<string>>{new List<string>{"5S", "6C", "7H", "KH", "7D"}, new List<string>{"AH", "8C", "5C", "7S", "3D"}},
            new List<List<string>>{new List<string>{"3C", "KD", "AD", "7D", "6C"}, new List<string>{"4D", "KS", "2D", "8C", "4S"}},
            new List<List<string>>{new List<string>{"7C", "8D", "5S", "2D", "2S"}, new List<string>{"AH", "AD", "2C", "9D", "10D"}},
            new List<List<string>>{new List<string>{"3C", "AD", "4S", "KS", "JH"}, new List<string>{"7C", "5C", "8C", "9C", "10H"}},
            new List<List<string>>{new List<string>{"AS", "10D", "4D", "7C", "JD"}, new List<string>{"8C", "QH", "3C", "5H", "9S"}},
            new List<List<string>>{new List<string>{"3H", "9C", "8S", "9S", "6S"}, new List<string>{"QD", "KS", "AH", "5H", "JH"}},
            new List<List<string>>{new List<string>{"QC", "9C", "5S", "4H", "2H"}, new List<string>{"10D", "7D", "AS", "8C", "9D"}},
            new List<List<string>>{new List<string>{"8C", "2C", "9D", "KD", "10C"}, new List<string>{"7S", "3D", "KH", "QC", "3C"}},
            new List<List<string>>{new List<string>{"4D", "AS", "4C", "QS", "5S"}, new List<string>{"9D", "6S", "JD", "QH", "KS"}},
            new List<List<string>>{new List<string>{"6D", "AH", "6C", "4C", "5H"}, new List<string>{"10S", "9H", "7D", "3D", "5S"}},
            new List<List<string>>{new List<string>{"QS", "JD", "7C", "8D", "9C"}, new List<string>{"AC", "3S", "6S", "6C", "KH"}},
            new List<List<string>>{new List<string>{"8H", "JH", "5D", "9S", "6D"}, new List<string>{"AS", "6S", "3S", "QC", "7H"}},
            new List<List<string>>{new List<string>{"QD", "AD", "5C", "JH", "2H"}, new List<string>{"AH", "4H", "AS", "KC", "2C"}},
            new List<List<string>>{new List<string>{"JH", "9C", "2C", "6H", "2D"}, new List<string>{"JS", "5D", "9H", "KC", "6D"}},
            new List<List<string>>{new List<string>{"7D", "9D", "KD", "10H", "3H"}, new List<string>{"AS", "6S", "QC", "6H", "AD"}},
            new List<List<string>>{new List<string>{"JD", "4H", "7D", "KC", "3H"}, new List<string>{"JS", "3C", "10H", "3D", "QS"}},
            new List<List<string>>{new List<string>{"4C", "3H", "8C", "QD", "5H"}, new List<string>{"6H", "AS", "8H", "AD", "JD"}},
            new List<List<string>>{new List<string>{"10H", "8S", "KD", "5D", "QC"}, new List<string>{"7D", "JS", "5S", "5H", "10S"}},
            new List<List<string>>{new List<string>{"7D", "KC", "9D", "QS", "3H"}, new List<string>{"3C", "6D", "10S", "7S", "AH"}},
            new List<List<string>>{new List<string>{"7C", "4H", "7H", "AH", "QC"}, new List<string>{"AC", "4D", "5D", "6D", "10H"}},
            new List<List<string>>{new List<string>{"3C", "4H", "2S", "KD", "8H"}, new List<string>{"5H", "JH", "10C", "6C", "JD"}},
            new List<List<string>>{new List<string>{"4S", "8C", "3D", "4H", "JS"}, new List<string>{"10D", "7S", "JH", "QS", "KD"}},
            new List<List<string>>{new List<string>{"7C", "QC", "KD", "4D", "7H"}, new List<string>{"6S", "AD", "10D", "10C", "KH"}},
            new List<List<string>>{new List<string>{"5H", "9H", "KC", "3H", "4D"}, new List<string>{"3D", "AD", "6S", "QD", "6H"}},
            new List<List<string>>{new List<string>{"10H", "7C", "6H", "10S", "QH"}, new List<string>{"5S", "2C", "KC", "10D", "6S"}},
            new List<List<string>>{new List<string>{"7C", "4D", "5S", "JD", "JH"}, new List<string>{"7D", "AC", "KD", "KH", "4H"}},
            new List<List<string>>{new List<string>{"7D", "6C", "8D", "8H", "5C"}, new List<string>{"JH", "8S", "QD", "10H", "JD"}},
            new List<List<string>>{new List<string>{"8D", "7D", "6C", "7C", "9D"}, new List<string>{"KD", "AS", "5C", "QH", "JH"}},
            new List<List<string>>{new List<string>{"9S", "2C", "8C", "3C", "4C"}, new List<string>{"KS", "JH", "2D", "8D", "4H"}},
            new List<List<string>>{new List<string>{"7S", "6C", "JH", "KH", "8H"}, new List<string>{"3H", "9D", "2D", "AH", "6D"}},
            new List<List<string>>{new List<string>{"4D", "10C", "9C", "8D", "7H"}, new List<string>{"10D", "KS", "10H", "KD", "3C"}},
            new List<List<string>>{new List<string>{"JD", "9H", "8D", "QD", "AS"}, new List<string>{"KD", "9D", "2C", "2S", "9C"}},
            new List<List<string>>{new List<string>{"8D", "3H", "5C", "7H", "KS"}, new List<string>{"5H", "QH", "2D", "8C", "9H"}},
            new List<List<string>>{new List<string>{"2D", "10H", "6D", "QD", "6C"}, new List<string>{"KC", "3H", "3S", "AD", "4C"}},
            new List<List<string>>{new List<string>{"4H", "3H", "JS", "9D", "3C"}, new List<string>{"10C", "5H", "QH", "QC", "JC"}},
            new List<List<string>>{new List<string>{"3D", "5C", "6H", "3S", "3C"}, new List<string>{"JC", "5S", "7S", "2S", "QH"}},
            new List<List<string>>{new List<string>{"AC", "5C", "8C", "4D", "5D"}, new List<string>{"4H", "2S", "QD", "3C", "3H"}},
            new List<List<string>>{new List<string>{"2C", "10D", "AH", "9C", "KD"}, new List<string>{"JS", "6S", "QD", "4C", "QC"}},
            new List<List<string>>{new List<string>{"QS", "8C", "3S", "4H", "10C"}, new List<string>{"JS", "3H", "7C", "JC", "AD"}},
            new List<List<string>>{new List<string>{"5H", "4D", "9C", "KS", "JC"}, new List<string>{"10D", "9S", "10S", "8S", "9H"}},
            new List<List<string>>{new List<string>{"QD", "10S", "7D", "AS", "AC"}, new List<string>{"2C", "10D", "6H", "8H", "AH"}},
            new List<List<string>>{new List<string>{"6S", "AD", "8C", "4S", "9H"}, new List<string>{"8D", "9D", "KH", "8S", "3C"}},
            new List<List<string>>{new List<string>{"QS", "4D", "2D", "7S", "KH"}, new List<string>{"JS", "JC", "AD", "4C", "3C"}},
            new List<List<string>>{new List<string>{"QS", "9S", "7H", "KC", "10D"}, new List<string>{"10H", "5H", "JS", "AC", "JH"}},
            new List<List<string>>{new List<string>{"6D", "AC", "2S", "QS", "7C"}, new List<string>{"AS", "KS", "6S", "KH", "5S"}},
            new List<List<string>>{new List<string>{"6D", "8H", "KH", "3C", "QS"}, new List<string>{"2H", "5C", "9C", "9D", "6C"}},
            new List<List<string>>{new List<string>{"JS", "2C", "4C", "6H", "7D"}, new List<string>{"JC", "AC", "QD", "10D", "3H"}},
            new List<List<string>>{new List<string>{"4H", "QC", "8H", "JD", "4C"}, new List<string>{"KD", "KS", "5C", "KC", "7S"}},
            new List<List<string>>{new List<string>{"6D", "2D", "3H", "2S", "QD"}, new List<string>{"5S", "7H", "AS", "10H", "6S"}},
            new List<List<string>>{new List<string>{"AS", "6D", "8D", "2C", "8S"}, new List<string>{"10D", "8H", "QD", "JC", "AH"}},
            new List<List<string>>{new List<string>{"9C", "9H", "2D", "10D", "QH"}, new List<string>{"2H", "5C", "10C", "3D", "8H"}},
            new List<List<string>>{new List<string>{"KC", "8S", "3D", "KH", "2S"}, new List<string>{"10S", "10C", "6S", "4D", "JH"}},
            new List<List<string>>{new List<string>{"9H", "9D", "QS", "AC", "KC"}, new List<string>{"6H", "5D", "4D", "8D", "AH"}},
            new List<List<string>>{new List<string>{"9S", "5C", "QS", "4H", "7C"}, new List<string>{"7D", "2H", "8S", "AD", "JS"}},
            new List<List<string>>{new List<string>{"3D", "AC", "9S", "AS", "2C"}, new List<string>{"2D", "2H", "3H", "JC", "KH"}},
            new List<List<string>>{new List<string>{"7H", "QH", "KH", "JD", "10C"}, new List<string>{"KS", "5S", "8H", "4C", "8D"}},
            new List<List<string>>{new List<string>{"2H", "7H", "3S", "2S", "5H"}, new List<string>{"QS", "3C", "AS", "9H", "KD"}},
            new List<List<string>>{new List<string>{"AD", "3D", "JD", "6H", "5S"}, new List<string>{"9C", "6D", "AC", "9S", "3S"}},
            new List<List<string>>{new List<string>{"3D", "5D", "9C", "2D", "AC"}, new List<string>{"4S", "2S", "AD", "6C", "6S"}},
            new List<List<string>>{new List<string>{"QC", "4C", "2D", "3H", "6S"}, new List<string>{"KC", "QH", "QD", "2H", "JH"}},
            new List<List<string>>{new List<string>{"QC", "3C", "8S", "4D", "9S"}, new List<string>{"2H", "5C", "8H", "QS", "QD"}},
            new List<List<string>>{new List<string>{"6D", "KD", "6S", "7H", "3S"}, new List<string>{"KH", "2H", "5C", "JC", "6C"}},
            new List<List<string>>{new List<string>{"3S", "9S", "10C", "6S", "8H"}, new List<string>{"2D", "AD", "7S", "8S", "10S"}},
            new List<List<string>>{new List<string>{"3C", "6H", "9C", "3H", "5C"}, new List<string>{"JC", "8H", "QH", "10D", "QD"}},
            new List<List<string>>{new List<string>{"3C", "JS", "QD", "5D", "10D"}, new List<string>{"2C", "KH", "9H", "10H", "AS"}},
            new List<List<string>>{new List<string>{"9S", "10C", "JD", "3D", "5C"}, new List<string>{"5H", "AD", "QH", "9H", "KC"}},
            new List<List<string>>{new List<string>{"10C", "7H", "4H", "8H", "3H"}, new List<string>{"10D", "6S", "AC", "7C", "2S"}},
            new List<List<string>>{new List<string>{"QS", "9D", "5D", "3C", "JC"}, new List<string>{"KS", "4D", "6C", "JH", "2S"}},
            new List<List<string>>{new List<string>{"9S", "6S", "3C", "7H", "10S"}, new List<string>{"4C", "KD", "6D", "3D", "9C"}},
            new List<List<string>>{new List<string>{"2D", "9H", "AH", "AC", "7H"}, new List<string>{"2S", "JH", "3S", "7C", "QC"}},
            new List<List<string>>{new List<string>{"QD", "9H", "3C", "2H", "AC"}, new List<string>{"AS", "8S", "KD", "8C", "KH"}},
            new List<List<string>>{new List<string>{"2D", "7S", "10D", "10H", "6D"}, new List<string>{"JD", "8D", "4D", "2H", "5S"}},
            new List<List<string>>{new List<string>{"8S", "QH", "KD", "JD", "QS"}, new List<string>{"JH", "4D", "KC", "5H", "3S"}},
            new List<List<string>>{new List<string>{"3C", "KH", "QC", "6D", "8H"}, new List<string>{"3S", "AH", "7D", "10D", "2D"}},
            new List<List<string>>{new List<string>{"5S", "9H", "QH", "4S", "6S"}, new List<string>{"6C", "6D", "10S", "10H", "7S"}},
            new List<List<string>>{new List<string>{"6C", "4C", "6D", "QS", "JS"}, new List<string>{"9C", "10S", "3H", "8D", "8S"}},
            new List<List<string>>{new List<string>{"JS", "5C", "7S", "AS", "2C"}, new List<string>{"AH", "2H", "AD", "5S", "10C"}},
            new List<List<string>>{new List<string>{"KD", "6C", "9C", "9D", "10S"}, new List<string>{"2S", "JC", "4H", "2C", "QD"}},
            new List<List<string>>{new List<string>{"QS", "9H", "10C", "3H", "KC"}, new List<string>{"KS", "4H", "3C", "AD", "10H"}},
            new List<List<string>>{new List<string>{"KH", "9C", "2H", "KD", "9D"}, new List<string>{"10C", "7S", "KC", "JH", "2D"}},
            new List<List<string>>{new List<string>{"7C", "3S", "KC", "AS", "8C"}, new List<string>{"5D", "9C", "9S", "QH", "3H"}},
            new List<List<string>>{new List<string>{"2D", "8C", "10D", "4C", "2H"}, new List<string>{"QC", "5D", "10C", "2C", "7D"}},
            new List<List<string>>{new List<string>{"KS", "4D", "6C", "QH", "10D"}, new List<string>{"KH", "5D", "7C", "AD", "8D"}},
            new List<List<string>>{new List<string>{"2S", "9S", "8S", "4C", "8C"}, new List<string>{"3D", "6H", "QD", "7C", "7H"}},
            new List<List<string>>{new List<string>{"6C", "8S", "QH", "5H", "10S"}, new List<string>{"5C", "3C", "4S", "2S", "2H"}},
            new List<List<string>>{new List<string>{"8S", "6S", "2H", "JC", "3S"}, new List<string>{"3H", "9D", "8C", "2S", "7H"}},
            new List<List<string>>{new List<string>{"QC", "2C", "8H", "9C", "AC"}, new List<string>{"JD", "4C", "4H", "6S", "3S"}},
            new List<List<string>>{new List<string>{"3H", "3S", "7D", "4C", "9S"}, new List<string>{"5H", "8H", "JC", "3D", "10C"}},
            new List<List<string>>{new List<string>{"QH", "2S", "2D", "9S", "KD"}, new List<string>{"QD", "9H", "AD", "6D", "9C"}},
            new List<List<string>>{new List<string>{"8D", "2D", "KS", "9S", "JC"}, new List<string>{"4C", "JD", "KC", "4S", "10H"}},
            new List<List<string>>{new List<string>{"KH", "10S", "6D", "4D", "5C"}, new List<string>{"KD", "5H", "AS", "9H", "AD"}},
            new List<List<string>>{new List<string>{"QD", "JS", "7C", "6D", "5D"}, new List<string>{"5C", "10H", "5H", "QH", "QS"}},
            new List<List<string>>{new List<string>{"9D", "QH", "KH", "5H", "JH"}, new List<string>{"4C", "4D", "10C", "10H", "6C"}},
            new List<List<string>>{new List<string>{"KH", "AS", "10S", "9D", "KD"}, new List<string>{"9C", "7S", "4D", "8H", "5S"}},
            new List<List<string>>{new List<string>{"KH", "AS", "2S", "7D", "9D"}, new List<string>{"4C", "10S", "10H", "AH", "7C"}},
            new List<List<string>>{new List<string>{"KS", "4D", "AC", "8S", "9S"}, new List<string>{"8D", "10H", "QH", "9D", "5C"}},
            new List<List<string>>{new List<string>{"5D", "5C", "8C", "QS", "10C"}, new List<string>{"4C", "3D", "3S", "2C", "8D"}},
            new List<List<string>>{new List<string>{"9D", "KS", "2D", "3C", "KC"}, new List<string>{"4S", "8C", "KH", "6C", "JC"}},
            new List<List<string>>{new List<string>{"8H", "AH", "6H", "7D", "7S"}, new List<string>{"QD", "3C", "4C", "6C", "KC"}},
            new List<List<string>>{new List<string>{"3H", "2C", "QH", "8H", "AS"}, new List<string>{"7D", "4C", "8C", "4H", "KC"}},
            new List<List<string>>{new List<string>{"QD", "5S", "4H", "2C", "10D"}, new List<string>{"AH", "JH", "QH", "4C", "8S"}},
            new List<List<string>>{new List<string>{"3H", "QS", "5S", "JS", "8H"}, new List<string>{"2S", "9H", "9C", "3S", "2C"}},
            new List<List<string>>{new List<string>{"6H", "10S", "7S", "JC", "QD"}, new List<string>{"AC", "10D", "KC", "5S", "3H"}},
            new List<List<string>>{new List<string>{"QH", "AS", "QS", "7D", "JC"}, new List<string>{"KC", "2C", "4C", "5C", "5S"}},
            new List<List<string>>{new List<string>{"QH", "3D", "AS", "JS", "4H"}, new List<string>{"8D", "7H", "JC", "2S", "9C"}},
            new List<List<string>>{new List<string>{"5D", "4D", "2S", "4S", "9D"}, new List<string>{"9C", "2D", "QS", "8H", "7H"}},
            new List<List<string>>{new List<string>{"6D", "7H", "3H", "JS", "10S"}, new List<string>{"AC", "2D", "JH", "7C", "8S"}},
            new List<List<string>>{new List<string>{"JH", "5H", "KC", "3C", "10C"}, new List<string>{"5S", "9H", "4C", "8H", "9D"}},
            new List<List<string>>{new List<string>{"8S", "KC", "5H", "9H", "AD"}, new List<string>{"KS", "9D", "KH", "8D", "AH"}},
            new List<List<string>>{new List<string>{"JC", "2H", "9H", "KS", "6S"}, new List<string>{"3H", "QC", "5H", "AH", "9C"}},
            new List<List<string>>{new List<string>{"5C", "KH", "5S", "AD", "6C"}, new List<string>{"JC", "9H", "QC", "9C", "10D"}},
            new List<List<string>>{new List<string>{"5S", "5D", "JC", "QH", "2D"}, new List<string>{"KS", "8H", "QS", "2H", "10S"}},
            new List<List<string>>{new List<string>{"JH", "5H", "5S", "AH", "7H"}, new List<string>{"3C", "8S", "AS", "10D", "KH"}},
            new List<List<string>>{new List<string>{"6H", "3D", "JD", "2C", "4C"}, new List<string>{"KC", "7S", "AH", "6C", "JH"}},
            new List<List<string>>{new List<string>{"4C", "KS", "9D", "AD", "7S"}, new List<string>{"KC", "7D", "8H", "3S", "9C"}},
            new List<List<string>>{new List<string>{"7H", "5C", "5H", "3C", "8H"}, new List<string>{"QC", "3D", "KH", "6D", "JC"}},
            new List<List<string>>{new List<string>{"2D", "4H", "5D", "7D", "QC"}, new List<string>{"AD", "AH", "9H", "QH", "8H"}},
            new List<List<string>>{new List<string>{"KD", "8C", "JS", "9D", "3S"}, new List<string>{"3C", "2H", "5D", "6D", "2S"}},
            new List<List<string>>{new List<string>{"8S", "6S", "10S", "3C", "6H"}, new List<string>{"8D", "5S", "3H", "10D", "6C"}},
            new List<List<string>>{new List<string>{"KS", "3D", "JH", "9C", "7C"}, new List<string>{"9S", "QS", "5S", "4H", "6H"}},
            new List<List<string>>{new List<string>{"7S", "6S", "10H", "4S", "KC"}, new List<string>{"KD", "3S", "JC", "JH", "KS"}},
            new List<List<string>>{new List<string>{"7C", "3C", "2S", "6D", "QH"}, new List<string>{"2C", "7S", "5H", "8H", "AH"}},
            new List<List<string>>{new List<string>{"KC", "8D", "QD", "6D", "KH"}, new List<string>{"5C", "7H", "9D", "3D", "9C"}},
            new List<List<string>>{new List<string>{"6H", "2D", "8S", "JS", "9S"}, new List<string>{"2S", "6D", "KC", "7C", "10C"}},
            new List<List<string>>{new List<string>{"KD", "9C", "JH", "7H", "KC"}, new List<string>{"8S", "2S", "7S", "3D", "6H"}},
            new List<List<string>>{new List<string>{"4H", "9H", "2D", "4C", "8H"}, new List<string>{"7H", "5S", "8S", "2H", "8D"}},
            new List<List<string>>{new List<string>{"AD", "7C", "3C", "7S", "5S"}, new List<string>{"4D", "9H", "3D", "JC", "KH"}},
            new List<List<string>>{new List<string>{"5D", "AS", "7D", "6D", "9C"}, new List<string>{"JC", "4C", "QH", "QS", "KH"}},
            new List<List<string>>{new List<string>{"KD", "JD", "7D", "3D", "QS"}, new List<string>{"QC", "8S", "6D", "JS", "QD"}},
            new List<List<string>>{new List<string>{"6S", "8C", "5S", "QH", "10H"}, new List<string>{"9H", "AS", "AC", "2C", "JD"}},
            new List<List<string>>{new List<string>{"QC", "KS", "QH", "7S", "3C"}, new List<string>{"4C", "5C", "KC", "5D", "AH"}},
            new List<List<string>>{new List<string>{"6C", "4H", "9D", "AH", "2C"}, new List<string>{"3H", "KD", "3D", "10S", "5C"}},
            new List<List<string>>{new List<string>{"10D", "8S", "QS", "AS", "JS"}, new List<string>{"3H", "KD", "AC", "4H", "KS"}},
            new List<List<string>>{new List<string>{"7D", "5D", "10S", "9H", "4H"}, new List<string>{"4C", "9C", "2H", "8C", "QC"}},
            new List<List<string>>{new List<string>{"2C", "7D", "9H", "4D", "KS"}, new List<string>{"4C", "QH", "AD", "KD", "JS"}},
            new List<List<string>>{new List<string>{"QD", "AD", "AH", "KH", "9D"}, new List<string>{"JS", "9H", "JC", "KD", "JD"}},
            new List<List<string>>{new List<string>{"8S", "3C", "4S", "10S", "7S"}, new List<string>{"4D", "5C", "2S", "6H", "7C"}},
            new List<List<string>>{new List<string>{"JS", "7S", "5C", "KD", "6D"}, new List<string>{"QH", "8S", "10D", "2H", "6S"}},
            new List<List<string>>{new List<string>{"QH", "6C", "10C", "6H", "10D"}, new List<string>{"4C", "9D", "2H", "QC", "8H"}},
            new List<List<string>>{new List<string>{"3D", "10S", "4D", "2H", "6H"}, new List<string>{"6S", "2C", "7H", "8S", "6C"}},
            new List<List<string>>{new List<string>{"9H", "9D", "JD", "JH", "3S"}, new List<string>{"AH", "2C", "6S", "3H", "8S"}},
            new List<List<string>>{new List<string>{"2C", "QS", "8C", "5S", "3H"}, new List<string>{"2S", "7D", "3C", "AD", "4S"}},
            new List<List<string>>{new List<string>{"5C", "QC", "QH", "AS", "10S"}, new List<string>{"4S", "6S", "4C", "5H", "JS"}},
            new List<List<string>>{new List<string>{"JH", "5C", "10D", "4C", "6H"}, new List<string>{"JS", "KD", "KH", "QS", "4H"}},
            new List<List<string>>{new List<string>{"10C", "KH", "JC", "4D", "9H"}, new List<string>{"9D", "8D", "KC", "3C", "8H"}},
            new List<List<string>>{new List<string>{"2H", "10C", "8S", "AD", "9S"}, new List<string>{"4H", "10S", "7H", "2C", "5C"}},
            new List<List<string>>{new List<string>{"4H", "2S", "6C", "5S", "KS"}, new List<string>{"AH", "9C", "7C", "8H", "KD"}},
            new List<List<string>>{new List<string>{"10S", "QH", "10D", "QS", "3C"}, new List<string>{"JH", "AH", "2C", "8D", "7D"}},
            new List<List<string>>{new List<string>{"5D", "KC", "3H", "5S", "AC"}, new List<string>{"4S", "7H", "QS", "4C", "2H"}},
            new List<List<string>>{new List<string>{"3D", "7D", "QC", "KH", "JH"}, new List<string>{"6D", "6C", "10D", "10H", "KD"}},
            new List<List<string>>{new List<string>{"5S", "8D", "10H", "6C", "9D"}, new List<string>{"7D", "KH", "8C", "9S", "6D"}},
            new List<List<string>>{new List<string>{"JD", "QS", "7S", "QC", "2S"}, new List<string>{"QH", "JC", "4S", "KS", "8D"}},
            new List<List<string>>{new List<string>{"7S", "5S", "9S", "JD", "KD"}, new List<string>{"9C", "JC", "AD", "2D", "7C"}},
            new List<List<string>>{new List<string>{"4S", "5H", "AH", "JH", "9C"}, new List<string>{"5D", "10D", "7C", "2D", "6S"}},
            new List<List<string>>{new List<string>{"KC", "6C", "7H", "6S", "9C"}, new List<string>{"QD", "5S", "4H", "KS", "10D"}},
            new List<List<string>>{new List<string>{"6S", "8D", "KS", "2D", "10H"}, new List<string>{"10D", "9H", "JD", "10S", "3S"}},
            new List<List<string>>{new List<string>{"KH", "JS", "4H", "5D", "9D"}, new List<string>{"10C", "10D", "QC", "JD", "10S"}},
            new List<List<string>>{new List<string>{"QS", "QD", "AC", "AD", "4C"}, new List<string>{"6S", "2D", "AS", "3H", "KC"}},
            new List<List<string>>{new List<string>{"4C", "7C", "3C", "10D", "QS"}, new List<string>{"9C", "KC", "AS", "8D", "AD"}},
            new List<List<string>>{new List<string>{"KC", "7H", "QC", "6D", "8H"}, new List<string>{"6S", "5S", "AH", "7S", "8C"}},
            new List<List<string>>{new List<string>{"3S", "AD", "9H", "JC", "6D"}, new List<string>{"JD", "AS", "KH", "6S", "JH"}},
            new List<List<string>>{new List<string>{"AD", "3D", "10S", "KS", "7H"}, new List<string>{"JH", "2D", "JS", "QD", "AC"}},
            new List<List<string>>{new List<string>{"9C", "JD", "7C", "6D", "10C"}, new List<string>{"6H", "6C", "JC", "3D", "3S"}},
            new List<List<string>>{new List<string>{"QC", "KC", "3S", "JC", "KD"}, new List<string>{"2C", "8D", "AH", "QS", "10S"}},
            new List<List<string>>{new List<string>{"AS", "KD", "3D", "JD", "8H"}, new List<string>{"7C", "8C", "5C", "QD", "6C"}}
        };
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var done = false;
            var p1Wins = 0;

            for(var i = 0; i < _games.Count; i++)
            {
                var p1 = _games[i][0].Select(c => Card.GetCardByShortName(c)).OrderBy(c => c.Id).ToList();
                var p2 = _games[i][1].Select(c => Card.GetCardByShortName(c)).OrderBy(c => c.Id).ToList();

                var r1 = CalculateHandScore(p1, 0);
                var r2 = CalculateHandScore(p2, 0);

                if (r1 > r2)
                    p1Wins++;
            }


            return new { result = p1Wins };
        }

        private long CalculateHandScore(List<Card> hand, long highScore)
        {
            CalcHand cHand = new CalcHand()
            {
                cards = hand,
                firstFlush = new List<Card>(),
                firstTrip = new List<Card>(),
                score = 0
            };
            cHand.cards = cHand.cards.OrderByDescending(c => c.Number).ToList();

            int checkTo = (int)(highScore / 10000000000);
            Func<CalcHand, CalcHand>[] HandCheck = {CheckStrFlush, CheckFourKind, CheckFullHouse,
                                            CheckFlush, CheckStr, CheckThreeKind,
                                            CheckTwoPair, CheckPair, CheckHighCard  };

            for (int i = 0; cHand.score == 0 && HandCheck.Length - i > checkTo && i < HandCheck.Length; i++)
            {
                cHand = HandCheck[i](cHand);
            }

            return cHand.score;
        }

        private CalcHand CheckStrFlush(CalcHand cHand)
        {
            cHand.firstFlush = FindFlush(cHand.cards);
            if (cHand.firstFlush.Count > 0)
            {
                var str = FindFirstStr(cHand.firstFlush);
                if (str.Count > 0)
                {
                    cHand.score = 80000000000;
                    cHand.score += str[0].Number * 100000000;
                }
            }
            return cHand;
        }

        private CalcHand CheckFourKind(CalcHand cHand)
        {
            var cardsLeft = 1;
            var tmpHand = new List<Card>(cHand.cards);

            List<Card> quad = FindFirstQuad(tmpHand);
            if (quad.Count > 0)
            {
                cHand.score = 70000000000;
                cHand.score += quad[0].Number * 100000000;
                //tmpHand = tmpHand.Where(c => c.Number != quad[0].Number).ToList();
                tmpHand.RemoveAll(c => c.Number == quad[0].Number);
                cHand.score += ScoreHighCards(tmpHand, cardsLeft);
            }
            return cHand;
        }

        private CalcHand CheckFullHouse(CalcHand cHand)
        {
            long score = 0;
            List<Card> pair;
            var tmpHand = new List<Card>(cHand.cards);

            cHand.firstTrip = FindFirstTrip(tmpHand);
            if (cHand.firstTrip.Count > 0)
            {
                //tmpHand = tmpHand.Where(c => c.Number != cHand.firstTrip[0].Number).ToList();
                tmpHand.RemoveAll(c => c.Number == cHand.firstTrip[0].Number);
                pair = FindFirstPair(tmpHand);
                if (pair.Count > 0)
                {
                    cHand.score = 60000000000;
                    cHand.score += cHand.firstTrip[0].Number * 100000000;
                    cHand.score += pair[0].Number * 1000000;
                }
            }
            return cHand;
        }

        private CalcHand CheckFlush(CalcHand cHand)
        {
            if (cHand.firstFlush.Count == 0)
                return cHand;

            cHand.score = 50000000000;
            cHand.score += ScoreHighCards(cHand.firstFlush, 5);

            return cHand;
        }

        private CalcHand CheckStr(CalcHand cHand)
        {
            var tmpHand = new List<Card>(cHand.cards);
            tmpHand = FindFirstStr(tmpHand);
            if (tmpHand.Count > 0)
            {
                cHand.score = 40000000000;
                cHand.score += tmpHand[0].Number * 100000000;
            }

            return cHand;
        }

        private CalcHand CheckThreeKind(CalcHand cHand)
        {
            if (cHand.firstTrip.Count == 0)
                return cHand;

            var cardsLeft = 2;
            var tmpHand = new List<Card>(cHand.cards.Where(c => c.Number != cHand.firstTrip[0].Number)) { };

            cHand.score = 30000000000;
            cHand.score += cHand.firstTrip[0].Number * 100000000;
            cHand.score += ScoreHighCards(tmpHand, 2);

            return cHand;
        }

        private CalcHand CheckTwoPair(CalcHand cHand)
        {
            var tmpHand = new List<Card>(cHand.cards) { };
            List<Card> pair1 = FindFirstPair(tmpHand);
            cHand.firstPair = new List<Card>(pair1);
            if (pair1.Count > 0)
            {
                //tmpHand = tmpHand.Where(c => c.Number != pair1[0].Number).ToList();
                tmpHand.RemoveAll(c => c.Number == pair1[0].Number);
                List<Card> pair2 = FindFirstPair(tmpHand);
                if (pair2.Count > 0)
                {
                    cHand.score = 20000000000;
                    cHand.score += pair1[0].Number * 100000000;
                    cHand.score += pair2[0].Number * 1000000;
                    //tmpHand = tmpHand.Where(c => c.Number != pair2[0].Number).ToList();
                    tmpHand.RemoveAll(c => c.Number == pair2[0].Number);
                    cHand.score += tmpHand[0].Number;
                }
            }
            return cHand;
        }

        private CalcHand CheckPair(CalcHand cHand)
        {
            if (cHand.firstPair.Count == 0)
                return cHand;
            int cardsLeft = 3;
            var tmpHand = new List<Card>(cHand.cards);

            List<Card> pair = FindFirstPair(tmpHand);
            if (pair.Count > 0)
            {
                cHand.score = 10000000000;
                cHand.score += pair[0].Number * 100000000;
                //tmpHand = tmpHand.Where(c => c.Number != pair[0].Number).ToList();
                tmpHand.RemoveAll(c => c.Number == pair[0].Number);
                cHand.score += ScoreHighCards(tmpHand, cardsLeft);
            }
            return cHand;
        }

        private CalcHand CheckHighCard(CalcHand cHand)
        {
            cHand.score = ScoreHighCards(cHand.cards, 5);
            return cHand;
        }

        //// assumes no more pair/trips left --- hand may be only partial
        private long ScoreHighCards(List<Card> cards, int numCards = 5)
        {
            long score = 0;
            int cardsLeft = numCards;
            for (var i = 0; i < cards.Count && cardsLeft > 0; i++)
            {
                score += cards[i].Number * (long)Math.Pow(100, cardsLeft - 1);
                cardsLeft--;
            }
            return score;
        }

        private List<Card> FindFirstPair(List<Card> cards)
        {
            for (var i = 0; i < cards.Count - 1; i++)
                if (cards[i].Number == cards[i + 1].Number)
                {
                    return new List<Card>() { cards[i], cards[i + 1] };
                }
            return new List<Card>(0);
        }

        private List<Card> FindFirstTrip(List<Card> cards)
        {
            for (var i = 0; i < cards.Count - 2; i++)
                if (cards[i].Number == cards[i + 1].Number && cards[i].Number == cards[i + 2].Number)
                {
                    return new List<Card>() { cards[i], cards[i + 1], cards[i + 2] };
                }
            return new List<Card>(0);
        }

        private List<Card> FindFirstStr(List<Card> cards)
        {
            var failed = false;
            var passed = false;
            var start = 0;
            var i = start;
            var firstStr = new List<Card>(10);
            while (start + 4 < cards.Count && !passed)
            {
                i = start;
                failed = false;
                firstStr.Add(cards[start]);
                while (i + 1 < cards.Count && !failed && firstStr.Count < 5)
                {
                    switch (cards[i].Number - cards[i + 1].Number)
                    {
                        case 0:
                            i++;
                            break;
                        case 1:
                            firstStr.Add(cards[i + 1]);
                            i++;
                            break;
                        default:
                            failed = true;
                            start = i + 1;
                            firstStr.Clear();
                            break;
                    }
                }
                if (firstStr.Count == 5)
                    passed = true;
                else
                    start = i + 1;

            }
            if (passed)
                return firstStr;

            // if not a normal straight, check for wheel
            return this.FindWheel(cards);
        }

        private List<Card> FindWheel(List<Card> cards)
        {
            bool found = false;
            var firstStr = new List<Card>(10);
            // first card has to be Ace and last card a 2
            if (cards[0].Number == 14 && cards[cards.Count - 1].Number == 2)
            {
                // look for 5 -- cant be in first or last 3 spots
                for (var i = 1; i < cards.Count - 3 && !found; i++)
                    if (cards[i].Number == 5)
                    {
                        found = true;
                        firstStr.Add(cards[i]);
                    }
                if (!found)
                    return new List<Card>(0);
                // look for 4 -- cant be in first 2 or last 2 spots
                found = false;
                for (var i = 2; i < cards.Count - 2 && !found; i++)
                    if (cards[i].Number == 4)
                    {
                        found = true;
                        firstStr.Add(cards[i]);
                    }
                if (!found)
                    return new List<Card>(0);
                // look for 3 -- cant be in first 3 or last 1 spots
                found = false;
                for (var i = 3; i < cards.Count - 1 && !found; i++)
                    if (cards[i].Number == 3)
                    {
                        found = true;
                        firstStr.Add(cards[i]);
                    }
                if (!found)
                    return new List<Card>(0);
                // know it contains a 2 so add last card
                firstStr.Add(cards[cards.Count - 1]);

                return firstStr;
            }
            return new List<Card>(0);

        }

        private List<Card> FindFlush(List<Card> cards)
        {
            var suits = new List<List<Card>>(4);
            for (int i = 0; i < 4; i++)
                suits.Add(new List<Card>(10));
            cards.ForEach(c =>
            {
                suits[c.Suit.Id].Add(c);
            });

            var flush = suits.Where(s => s.Count > 4).SingleOrDefault();
            if (flush == null)
                return new List<Card>(0);
            else
                return flush;
        }

        private List<Card> FindFirstQuad(List<Card> cards)
        {
            var quads = new List<Card>(4);
            for (var i = 0; i < cards.Count - 3; i++)
                if (cards[i].Number == cards[i + 1].Number
                    && cards[i].Number == cards[i + 2].Number
                    && cards[i].Number == cards[i + 3].Number)
                {
                    quads = new List<Card>() { cards[i], cards[i + 1], cards[i + 2], cards[i + 3] };
                }
            return quads;
        }

        private class CalcHand
        {
            public List<Card> firstFlush { get; set; }
            public List<Card> firstTrip { get; set; }
            public List<Card> firstPair { get; set; }
            public List<Card> cards { get; set; }
            public long score { get; set; }
        }

        private class Card : EnumClass
        {
            
            private int _id;
            private Suit _suit;
            private int _number;
            private string _shortName;
            private string _name;
            private string _image;

            #region CardEnum
            public static readonly Card Club2 = new Card(0, Suit.Clubs, 2, "2c", "2 of clubs", "Images/2C.png");
            public static readonly Card Club3 = new Card(1, Suit.Clubs, 3, "3c", "3 of clubs", "Images/3C.png");
            public static readonly Card Club4 = new Card(2, Suit.Clubs, 4, "4c", "4 of clubs", "Images/4C.png");
            public static readonly Card Club5 = new Card(3, Suit.Clubs, 5, "5c", "5 of clubs", "Images/5C.png");
            public static readonly Card Club6 = new Card(4, Suit.Clubs, 6, "6c", "6 of clubs", "Images/6C.png");
            public static readonly Card Club7 = new Card(5, Suit.Clubs, 7, "7c", "7 of clubs", "Images/7C.png");
            public static readonly Card Club8 = new Card(6, Suit.Clubs, 8, "8c", "8 of clubs", "Images/8C.png");
            public static readonly Card Club9 = new Card(7, Suit.Clubs, 9, "9c", "9 of clubs", "Images/9C.png");
            public static readonly Card Club10 = new Card(8, Suit.Clubs, 10, "10c", "10 of clubs", "Images/10C.png");
            public static readonly Card Club11 = new Card(9, Suit.Clubs, 11, "Jc", "Jack of clubs", "Images/11C.png");
            public static readonly Card Club12 = new Card(10, Suit.Clubs, 12, "Qc", "Queen of clubs", "Images/12C.png");
            public static readonly Card Club13 = new Card(11, Suit.Clubs, 13, "Kc", "King of clubs", "Images/13C.png");
            public static readonly Card Club14 = new Card(12, Suit.Clubs, 14, "Ac", "Ace of clubs", "Images/14C.png");
            public static readonly Card Diamond2 = new Card(13, Suit.Diamonds, 2, "2d", "2 of diamonds", "Images/2D.png");
            public static readonly Card Diamond3 = new Card(14, Suit.Diamonds, 3, "3d", "3 of diamonds", "Images/3D.png");
            public static readonly Card Diamond4 = new Card(15, Suit.Diamonds, 4, "4d", "4 of diamonds", "Images/4D.png");
            public static readonly Card Diamond5 = new Card(16, Suit.Diamonds, 5, "5d", "5 of diamonds", "Images/5D.png");
            public static readonly Card Diamond6 = new Card(17, Suit.Diamonds, 6, "6d", "6 of diamonds", "Images/6D.png");
            public static readonly Card Diamond7 = new Card(18, Suit.Diamonds, 7, "7d", "7 of diamonds", "Images/7D.png");
            public static readonly Card Diamond8 = new Card(19, Suit.Diamonds, 8, "8d", "8 of diamonds", "Images/8D.png");
            public static readonly Card Diamond9 = new Card(20, Suit.Diamonds, 9, "9d", "9 of diamonds", "Images/9D.png");
            public static readonly Card Diamond10 = new Card(21, Suit.Diamonds, 10, "10d", "10 of diamonds", "Images/10D.png");
            public static readonly Card Diamond11 = new Card(22, Suit.Diamonds, 11, "Jd", "Jack of diamonds", "Images/11D.png");
            public static readonly Card Diamond12 = new Card(23, Suit.Diamonds, 12, "Qd", "Queen of diamonds", "Images/12D.png");
            public static readonly Card Diamond13 = new Card(24, Suit.Diamonds, 13, "Kd", "King of diamonds", "Images/13D.png");
            public static readonly Card Diamond14 = new Card(25, Suit.Diamonds, 14, "Ad", "Ace of diamonds", "Images/14D.png");
            public static readonly Card Heart2 = new Card(26, Suit.Hearts, 2, "2h", "2 of hearts", "Images/2H.png");
            public static readonly Card Heart3 = new Card(27, Suit.Hearts, 3, "3h", "3 of hearts", "Images/3H.png");
            public static readonly Card Heart4 = new Card(28, Suit.Hearts, 4, "4h", "4 of hearts", "Images/4H.png");
            public static readonly Card Heart5 = new Card(29, Suit.Hearts, 5, "5h", "5 of hearts", "Images/5H.png");
            public static readonly Card Heart6 = new Card(30, Suit.Hearts, 6, "6h", "6 of hearts", "Images/6H.png");
            public static readonly Card Heart7 = new Card(31, Suit.Hearts, 7, "7h", "7 of hearts", "Images/7H.png");
            public static readonly Card Heart8 = new Card(32, Suit.Hearts, 8, "8h", "8 of hearts", "Images/8H.png");
            public static readonly Card Heart9 = new Card(33, Suit.Hearts, 9, "9h", "9 of hearts", "Images/9H.png");
            public static readonly Card Heart10 = new Card(34, Suit.Hearts, 10, "10h", "10 of hearts", "Images/10H.png");
            public static readonly Card Heart11 = new Card(35, Suit.Hearts, 11, "Jh", "Jack of hearts", "Images/11H.png");
            public static readonly Card Heart12 = new Card(36, Suit.Hearts, 12, "Qh", "Queen of hearts", "Images/12H.png");
            public static readonly Card Heart13 = new Card(37, Suit.Hearts, 13, "Kh", "King of hearts", "Images/13H.png");
            public static readonly Card Heart14 = new Card(38, Suit.Hearts, 14, "Ah", "Ace of hearts", "Images/14H.png");
            public static readonly Card Spade2 = new Card(39, Suit.Spades, 2, "2s", "2 of spades", "Images/2S.png");
            public static readonly Card Spade3 = new Card(40, Suit.Spades, 3, "3s", "3 of spades", "Images/3S.png");
            public static readonly Card Spade4 = new Card(41, Suit.Spades, 4, "4s", "4 of spades", "Images/4S.png");
            public static readonly Card Spade5 = new Card(42, Suit.Spades, 5, "5s", "5 of spades", "Images/5S.png");
            public static readonly Card Spade6 = new Card(43, Suit.Spades, 6, "6s", "6 of spades", "Images/6S.png");
            public static readonly Card Spade7 = new Card(44, Suit.Spades, 7, "7s", "7 of spades", "Images/7S.png");
            public static readonly Card Spade8 = new Card(45, Suit.Spades, 8, "8s", "8 of spades", "Images/8S.png");
            public static readonly Card Spade9 = new Card(46, Suit.Spades, 9, "9s", "9 of spades", "Images/9S.png");
            public static readonly Card Spade10 = new Card(47, Suit.Spades, 10, "10s", "10 of spades", "Images/10S.png");
            public static readonly Card Spade11 = new Card(48, Suit.Spades, 11, "Js", "Jack of spades", "Images/11S.png");
            public static readonly Card Spade12 = new Card(49, Suit.Spades, 12, "Qs", "Queen of spades", "Images/12S.png");
            public static readonly Card Spade13 = new Card(50, Suit.Spades, 13, "Ks", "King of spades", "Images/13S.png");
            public static readonly Card Spade14 = new Card(51, Suit.Spades, 14, "As", "Ace of spades", "Images/14S.png");
            #endregion

            //[JsonConstructor]
            private Card(int Id, Suit Suit, int Number, string ShortName, string Name, string Image)
            {
                _id = Id;
                _suit = Suit;
                _number = Number;
                _shortName = ShortName;
                _name = Name;
                _image = Image;
            }

            public int Id { get { return _id; } }
            public Suit Suit { get { return _suit; } }
            public int Number { get { return _number; } }
            public string ShortName { get { return _shortName; } }
            public string Name { get { return _name; } }
            public string Image { get { return _image; } }

            public static SortedList<int, Card> AllCards =
                new SortedList<int, Card>()
                {
                {Card.Club2.Id,     Card.Club2},
                {Card.Club3.Id,     Card.Club3},
                {Card.Club4.Id,     Card.Club4},
                {Card.Club5.Id,     Card.Club5},
                {Card.Club6.Id,     Card.Club6},
                {Card.Club7.Id,     Card.Club7},
                {Card.Club8.Id,     Card.Club8},
                {Card.Club9.Id,     Card.Club9},
                {Card.Club10.Id,    Card.Club10},
                {Card.Club11.Id,    Card.Club11},
                {Card.Club12.Id,    Card.Club12},
                {Card.Club13.Id,    Card.Club13},
                {Card.Club14.Id,    Card.Club14},
                {Card.Diamond2.Id,  Card.Diamond2},
                {Card.Diamond3.Id,  Card.Diamond3},
                {Card.Diamond4.Id,  Card.Diamond4},
                {Card.Diamond5.Id,  Card.Diamond5},
                {Card.Diamond6.Id,  Card.Diamond6},
                {Card.Diamond7.Id,  Card.Diamond7},
                {Card.Diamond8.Id,  Card.Diamond8},
                {Card.Diamond9.Id,  Card.Diamond9},
                {Card.Diamond10.Id, Card.Diamond10},
                {Card.Diamond11.Id, Card.Diamond11},
                {Card.Diamond12.Id, Card.Diamond12},
                {Card.Diamond13.Id, Card.Diamond13},
                {Card.Diamond14.Id, Card.Diamond14},
                {Card.Heart2.Id,    Card.Heart2},
                {Card.Heart3.Id,    Card.Heart3},
                {Card.Heart4.Id,    Card.Heart4},
                {Card.Heart5.Id,    Card.Heart5},
                {Card.Heart6.Id,    Card.Heart6},
                {Card.Heart7.Id,    Card.Heart7},
                {Card.Heart8.Id,    Card.Heart8},
                {Card.Heart9.Id,    Card.Heart9},
                {Card.Heart10.Id,   Card.Heart10},
                {Card.Heart11.Id,   Card.Heart11},
                {Card.Heart12.Id,   Card.Heart12},
                {Card.Heart13.Id,   Card.Heart13},
                {Card.Heart14.Id,   Card.Heart14},
                {Card.Spade2.Id,    Card.Spade2},
                {Card.Spade3.Id,    Card.Spade3},
                {Card.Spade4.Id,    Card.Spade4},
                {Card.Spade5.Id,    Card.Spade5},
                {Card.Spade6.Id,    Card.Spade6},
                {Card.Spade7.Id,    Card.Spade7},
                {Card.Spade8.Id,    Card.Spade8},
                {Card.Spade9.Id,    Card.Spade9},
                {Card.Spade10.Id,   Card.Spade10},
                {Card.Spade11.Id,   Card.Spade11},
                {Card.Spade12.Id,   Card.Spade12},
                {Card.Spade13.Id,   Card.Spade13},
                {Card.Spade14.Id,   Card.Spade14}
                };

            public static Card GetCardById(int cardId) { return AllCards[cardId]; }

            public static Card GetCardByShortName(string shortName) { return AllCards.First(ac => ac.Value.ShortName.ToLower() == shortName.ToLower()).Value; }
        }

        private class Suit : EnumClass
        {
            private int _id;
            private string _shortName;
            private string _name;
            private string _image;
            public static readonly Suit Clubs = new Suit(0, "C", "Clubs", "Images/Clubs.png");
            public static readonly Suit Diamonds = new Suit(1, "D", "Diamonds", "Images/Diamonds.png");
            public static readonly Suit Hearts = new Suit(2, "H", "Hearts", "Images/Hearts.png");
            public static readonly Suit Spades = new Suit(3, "S", "Spades", "Images/Spades.png");
            private Suit(int Id, string ShortName, string Name, string Image)
            {
                _id = Id;
                _shortName = ShortName;
                _name = Name;
                _image = Image;
            }
            public int Id { get { return _id; } }
            public string ShortName { get { return _shortName; } }
            public string Name { get { return _name; } }
            public string Image { get { return _image; } }

            public static List<Suit> Suits { get { return new List<Suit>() { Suit.Clubs, Suit.Diamonds, Suit.Hearts, Suit.Spades }; } }
        }
    
    }
}
