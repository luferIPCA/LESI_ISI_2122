/*
 * lufer
 * WCF
 * Desc:....INterface
 * Nota: Olhar para Doxygen????
 * */

using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;


[ServiceContract]
public interface ICalc
{
	/// <summary>
	/// Envio de dados simples
	/// </summary>
	/// <param name="x"></param>
	/// <param name="y"></param>
	/// <returns></returns>
	[OperationContract]
	int Soma(int x, int y);

	/// <summary>
	/// Dados Estruturados tipados
	/// </summary>
	/// <param name="nome"></param>
	/// <param name="idade"></param>
	/// <returns></returns>
	[OperationContract]
	Pessoa GetPessoa(string nome, int idade);

	/// <summary>
	/// Envio de Conjuntos de Dados estruturados não tipados (objects)
	/// </summary>
	/// <returns></returns>
	[OperationContract]
	Pessoa[] GetAll();

	/// <summary>
	/// Envio de Conjuntos de Dados estruturados tipados
	/// </summary>
	/// <returns></returns>
	[OperationContract]
	List<Pessoa> GetPessoas();

}

#region DataContracts

/// <summary>
/// Classe auxiliar para serializar dados
/// </summary>
[DataContract]
public class Pessoa
{
	string nome;
	int idade;

	public Pessoa() { }
	public Pessoa(int i, string n)
	{
		nome = n;
		idade = i;
	}

	[DataMember]
	public string Nome
	{
		get { return nome; }
		set { nome = value; }
	}

	[DataMember]
	public int Idade
	{
		get { return idade; }
		set { idade = value; }
	}

}
#endregion
