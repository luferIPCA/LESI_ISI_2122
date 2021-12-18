/*
 * lufer
 * Aplicações Orientadas a Serviços com WCF
 * Desc:....
 * Nota: Olhar para Doxygen????
 * 
 * Nota: em WCF OperationContracts apenas podem devolver dados tipados
 * 
 * Para devolver um ArrayList == List<object>  ou objet[]
 * 
 * see https://docs.microsoft.com/pt-br/dotnet/framework/wcf/
 * */


using System.Collections;
using System.Collections.Generic;

public class Calc : ICalc
{

	/// <summary>
	/// Calcula a soma de dois valores
	/// </summary>
	/// <param name="x"></param>
	/// <param name="y"></param>
	/// <returns></returns>
	public int Soma(int x, int y)
	{
		return x + y;
	}

	/// <summary>
	/// Devolve objeto
	/// </summary>
	/// <param name="nome"></param>
	/// <param name="idade"></param>
	/// <returns></returns>
	public Pessoa GetPessoa(string nome, int idade)
	{
		Pessoa p = new Pessoa();
		p.Nome = nome;
		p.Idade = idade;
		return p;
	}

	/// <summary>
	/// Devolve conjunto de objetos
	/// ArrayList é convertido em "Pessoa[]"
	/// </summary>
	/// <returns></returns>
	public Pessoa[] GetAll()
	{
		//simular dados vindos de uma BD...
		ArrayList aux = new ArrayList();
		aux.Add(new Pessoa(12, "ok"));
		aux.Add(new Pessoa(13, "oka"));
		return ((Pessoa[])aux.ToArray(typeof(Pessoa)));
	}

	/// <summary>
	/// Serializar Typed Data collections
	/// </summary>
	/// <returns></returns>
	public List<Pessoa> GetPessoas()
	{
		List<Pessoa> pes = new List<Pessoa>();

		pes.Add(new Pessoa(1, "João"));
		pes.Add(new Pessoa(2, "Joana"));
		return pes;
	}

}
