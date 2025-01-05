using System;

public class Calculadora
{
	private int num1 {  get; set; }
	private int num2 { get; set; }

	public Calculadora(int num1,int num2)
	{
		num1 = num1;
		num2 = num2;
	}

	public sumar()
	{
		return num1 + num2;
	}

	public restar()
	{
		return num1 - num2;
	}

	public multiplicar()
	{
		return num1 * num2;
	}

	public dividir()
	{
		return num1 / num2;
	}
}
