/*
 * lufer
 * ISI
 * WCF CalcWS
 * */

using System;
using System.Runtime.Serialization;
using System.ServiceModel;

[ServiceContract]
public interface ICalc
{
	[OperationContract]
	int Sum(int x, int y);
	[OperationContract]
	Res SumClock(int x, int y);

}

[DataContract]
public class Res
{
	int sum;
	DateTime clock;

	public Res() { }

	[DataMember]
	public int Sum
    {
        get { return sum; }
		set { sum = value; }
    }

	[DataMember]
	public DateTime Clock
    {
		get { return clock; }
		set { clock = value; }
	}


}


