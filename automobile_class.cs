using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Automobile
{

	
			
			private string _modello = "";
			private int _marcia = 0;
			private int _potenza = 0;
			private int _velocita = 0;
			bool int _motore = false;
	

	public Automobile()
	{
		public string Modello
		{
			get { return _modello; }
			set {_modello = value;}
		}

		public int Marcia
		{
			get { return _marcia; }
			set 
			{
				if (value < 0 || value > 6)
				{
					_marcia = 0;
				}
				else
				{
					_marcia = value;
				}
			}
		}

		public int Potenza
		{
			get { return _potenza; }
			set 
			{
				if (value <0)
				{
					_potenza = 0;
				}
				else
				{
					_potenza = value;
				}
			}
		}

		
		public int Velocita
		{
			get { return _velocita; }
			set 
			{	
				if (value < 0 || value > 300)
				{
					_velocita = 0;
				}
				else
					_velocita = value;
				}
		}

		
		public int Motore
		{
			get { return _motore; }
			set
			{ 
					_motore = value;
			}
		}



		//METODI SET E GET
		public void SetModello(string mod)
		{
			_modello = mod;
		}

		public void GetModello()
		{
			return _modello;
		}

		public void SetPotenza(int pot)
		{
			if (pot < 0)
				{
					_potenza = 0;
				}
			else
				{
					_potenza = pot;
				}
		}

		public int GetPotenza()
		{
			return _potenza;
		}

		public void SetVelocita(int vel)
		{
			if (vel < 0 || vel > 300)
			{
				_velocita = 0;
			}
			else
				_velocita = vel;

		}

		public int GetVelocita()
		{
			return _velocita;
		}

		public void SetMotore(int mot)
		{
			_motore = mot;
		}

		public int GetMotore()
		{
			return _motore;
		}

		//COSTRUTTORI
		public Automobile(string mod, int pot, int vel, int mot, int mar)
		{
			_marcia = mar;
			_modello = mod;
			_potenza = pot;
			_velocita = vel;
			_motore = mot;
		}

		


























}
}
