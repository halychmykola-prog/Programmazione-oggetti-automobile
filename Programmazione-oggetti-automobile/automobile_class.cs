using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Automobile
{
	public Automobile()
	{
		//ATRIBBUTI CON PROPRIETA
		private string _modello;
		public string Modello
		{
			get { return _modello; }
			set { _modello = value; }
		}

		private int _potenza;
		public int Potenza
		{
			get { return _potenza; }
			set { _potenza = value; }
		}

		private int _velocita;
		public int Velocita
		{
			get { return _velocita; }
			set { _velocita = value; }
		}

		private int _motore;
		public int Motore
		{
			get { return _motore; }
			set { _motore = value; }
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
			_potenza = pot;
		}

		public int GetPotenza()
		{
			return _potenza;
		}

		public void SetVelocita(int vel)
		{
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
		public Automobile(string mod, int pot, int vel, int mot)
		{
			_modello = mod;
			_potenza = pot;
			_velocita = vel;
			_motore = mot;
		}

		public Automobile()
		{
			_modello = "ZHopastiy";
			_potenza = 0;
			_velocita = 0;
			_motore = 0;
		}


























}
}
