using System.Collections.Generic;

namespace DM
{
    public class Convoi
    {
        private List<Vehicule> _allVehicule;

        public List<Vehicule> AllVehicules
        {
            get { return _allVehicule; }
        }

        public Convoi()
        {
            _allVehicule = new List<Vehicule>();
        }

        public override string ToString()
        {
            string toDisplay = $"Le convoi contient {_allVehicule.Count} vehicule(s) : \n";
            foreach (Vehicule vehicule in _allVehicule)
            {
                toDisplay += vehicule + "\n";
            }
            return toDisplay;
        }

        public void AddVehicule(Vehicule newVehicule)
        {
            _allVehicule.Add(newVehicule);
        }

        public void AddConvoi(Convoi addConvoi)
        {
            _allVehicule.AddRange(addConvoi.AllVehicules);
        }

        public int GetMaxVitesse()
        {
            int vitesseMaxConvoi = 0;
            if (_allVehicule.Count > 0)
            {
                vitesseMaxConvoi = _allVehicule[0].VitesseMax;

                for (int i = 1; i < _allVehicule.Count; i++)
                {
                    if (vitesseMaxConvoi > _allVehicule[i].VitesseMax)
                    {
                        vitesseMaxConvoi = _allVehicule[i].VitesseMax;
                    }
                }
            }
            return vitesseMaxConvoi;
        }
    }
}