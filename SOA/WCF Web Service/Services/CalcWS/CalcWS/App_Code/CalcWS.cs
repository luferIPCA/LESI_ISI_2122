/*
 * lufer
 * ISI
 * WCF CalcWS
 * */
using System;

/// <summary>
/// Class that implements ICalc
/// </summary>
public class CalcWS : ICalc
{
	public int Sum(int x, int y)
    {
        return x + y;
    }

    public Res SumClock(int x, int y)
    {
        Res aux = new Res();

        aux.Sum = Sum(x, y);
        aux.Clock = DateTime.Now;
        return aux;
    }
}
