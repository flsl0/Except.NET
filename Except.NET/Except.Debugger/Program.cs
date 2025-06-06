﻿using static System.Excepts.Except;

Dictionary<string, int> dict = new()
{
    { "toto", 0 },
    { "tata", 1 },
    { "tutu", 2 },
};

int val = Try(() => dict["toto"]); // easy way to lookup index in Dictionary

int val2 = Try(() => dict["titi"]); // will simply return default in case of non existing index

double Divide(double a, double b)
{
    Check(b != 0); // will throw an exception if b == 0

    return a / b;
}

double result = Try(() => Divide(1, 0)).Catch<Exception>(double.PositiveInfinity); // return double.PositiveInfinity in case of an exception
