using System;

namespace InvestCar.Models
{
	public class Responsavel
	{
		public double Porcentagem { get; set; }
		public Responsavel()
		{

		}

		public Responsavel(double porcentagem)
		{
			Porcentagem = porcentagem;
		}
	}

}