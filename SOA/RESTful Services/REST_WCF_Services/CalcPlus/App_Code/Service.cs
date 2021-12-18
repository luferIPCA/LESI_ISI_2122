/*
 * lufer
 * ISI - 2021-2022
 * WCF RESTful
 * */
using System;

public class Service : IService
{
	public int Prod(string x, string y)
    {
        int v1, v2;
        if (((int.TryParse(x, out v1)) == false) || ((int.TryParse(y, out v2)) == false))
            throw new Exception("Invalid parameters!!!"); 
        return (v1 * v2);
    }
}
