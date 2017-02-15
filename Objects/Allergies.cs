using System;
using System.Collections.Generic;

namespace Allergies.Objects

{
  public class Allergy
  {
    public List<string> dictionary = new List<string>();

    public int _eggs;
    public int _peanuts;
    public int _shellfish;
    public int _strawberries;
    public int _tomatoes;
    public int _chocolate;
    public int _pollen;
    public int _cats;

    public int _eggsCount;
    public int _peanutsCount;
    public int _shellfishCount;
    public int _strawberriesCount;
    public int _tomatoesCount;
    public int _chocolateCount;
    public int _pollenCount;
    public int _catsCount;

    public Allergy()
    {
      _eggs = 1;
      _peanuts = 2;
      _shellfish = 4;
      _strawberries = 8;
      _tomatoes = 16;
      _chocolate = 32;
      _pollen = 64;
      _cats = 128;
    }

    public void AllergyCheck(int userScore)
    {

      while (userScore != 0)
      {
        _catsCount =  userScore / _cats;
        int catsSum = _catsCount * _cats;
        userScore = userScore - catsSum;

        if (catsSum == 128) {
          dictionary.Add("cats");
        }

        _pollenCount = userScore / _pollen;
        int pollenSum = _pollenCount * _pollen;
        userScore = userScore - pollenSum;

        if (pollenSum == 64) {
          dictionary.Add("pollen");
        }

        _chocolateCount = userScore / _chocolate;
        int chocolateSum = _chocolateCount * _chocolate;
        userScore = userScore - chocolateSum;

        if (chocolateSum == 32) {
          dictionary.Add("chocolate");
        }

        _tomatoesCount = userScore / _tomatoes;
        int tomatoesSum = _tomatoesCount * _tomatoes;
        userScore = userScore - tomato15esSum;

        if (tomatoesSum == 16) {
          dictionary.Add("tomatoes");
        }

        _strawberriesCount = userScore / _strawberries;
        int strawberriesSum = _strawberriesCount * _strawberries;
        userScore = userScore - strawberriesSum;

        if (strawberriesSum == 8) {
          dictionary.Add("strawberries");
        }

        _shellfishCount = userScore / _shellfish;
        int shellfishSum = _shellfishCount * _shellfish;
        userScore = userScore - shellfishSum;

        if (shellfishSum == 4) {
          dictionary.Add("shellfish");
        }

        _peanutsCount = userScore / _peanuts;
        int peanutsSum = _peanutsCount * _peanuts;
        userScore = userScore - peanutsSum;

        if (peanutsSum == 2) {
          dictionary.Add("peanuts");
        }

        _eggsCount = userScore / _eggs;
        int eggsSum = _eggsCount * _eggs;
        userScore = userScore - eggsSum;

        if (eggsSum == 1) {
          dictionary.Add("eggs");
        }
      }

    }
  }
}
