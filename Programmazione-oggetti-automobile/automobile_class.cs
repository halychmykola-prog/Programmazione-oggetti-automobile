using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmazione_oggetti_automobile
{
    public class Automobile
    {
        // ATTRIBUTI CON PROPRIETA

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
            set
            {
                if (value >= 0 && value <= 2300)
                    _potenza = value;
                else
                    _potenza = 0;
            }
        }

        private int _marcia;
        public int Marcia
        {
            get { return _marcia; }
            set
            {
                if (value >= 0 && value <= 6)
                    _marcia = value;
                else
                    _marcia = 0;
            }
        }

        private int _velocita;
        public int Velocita
        {
            get { return _velocita; }
            set
            {
                if (value >= 0 && value <= 350)
                    _velocita = value;
                else
                    _velocita = 0;
            }
        }

        private bool _statoMotore;
        public bool StatoMotore
        {
            get { return _statoMotore; }
            set { _statoMotore = value; }
        }

        // METODI SET E GET

        public void SetModello(string mod)
        {
            Modello = mod;
        }

        public string GetModello()
        {
            return _modello;
        }

        public void SetPotenza(int pot)
        {
            if (pot >= 0 && pot <= 2300)
                _potenza = pot;
            else
                _potenza = 0;
        }

        public int GetPotenza()
        {
            return _potenza;
        }

        public void SetMarcia(int mar)
        {
            if (mar >= 0 && mar <= 6)
                _marcia = mar;
            else
                _marcia = 0;
        }

        public int GetMarcia()
        {
            return _marcia;
        }

        public void SetVelocita(int vel)
        {
            if (vel >= 0 && vel <= 350)
                _velocita = vel;
            else
                _velocita = 0;
        }

        public int GetVelocita()
        {
            return _velocita;
        }

        public void SetStatoMotore(bool stato)
        {
            StatoMotore = stato;
        }

        public bool GetStatoMotore()
        {
            return _statoMotore;
        }

        // COSTRUTTORE SENZA PARAMETRI

        public Automobile()
        {
            Modello = "Z";
            Potenza = 0;
            Marcia = 0;
            Velocita = 0;
            StatoMotore = false;
        }

        // COSTRUTTORE CON TUTTI I PARAMETRI

        public Automobile(string mod, int pot, int mar, int vel, bool stato)
        {
            Modello = mod;
            Potenza = pot;
            Marcia = mar;
            Velocita = vel;
            StatoMotore = stato;
        }

        // COSTRUTTORE CON IL MODELLO

        public Automobile(string mod)
        {
            Modello = mod;
            Potenza = 0;
            Marcia = 0;
            Velocita = 0;
            StatoMotore = false;
        }

        // COSTRUTTORE CON MODELLO E POTENZA

        public Automobile(string mod, int pot)
        {
            Modello = mod;
            Potenza = pot;
            Marcia = 0;
            Velocita = 0;
            StatoMotore = false;
        }

        // METODO ToString

        public override string ToString()
        {
            string s;
            s = "Modello: " + Modello + "\n";
            s = s + "Potenza: " + Potenza + " CV\n";
            s = s + "Marcia: " + Marcia + "\n";
            s = s + "Velocita: " + Velocita + " km/h\n";
            s = s + "Stato motore: " + StatoMotore + "\n";
            return s;
        }

        // METODO ACCELERA

        public void Accelera()
        {
            Velocita = Velocita + 5;
        }

        // METODO DECELERA

        public void Decelera()
        {
            Velocita = Velocita - 5;
        }

        // METODO ACCENDI

        public void Accendi()
        {
            StatoMotore = true;
        }

        // METODO SPEGNI

        public void Spegni()
        {
            StatoMotore = false;
        }
    }
}