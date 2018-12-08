using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCapstoneProject
{

    public class StableHorse
    {
        public enum EmotionalState
        {
            Happy,
            Sad,
            Nervous,
            Meloncoly

        }

        #region FIELDS

        private string _name;
        private double _weight;
        private bool _canUseSideSaddle;
        private EmotionalState _currentEmotionalState;
        private string _homeStable;
                              
        #endregion


        #region FIELDS

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public bool canUseSideSaddle
        {
            get { return _canUseSideSaddle; }
            set { _canUseSideSaddle = value; }
        }

        public EmotionalState CurrentEmotionalState
        {
            get { return _currentEmotionalState; }
            set { _currentEmotionalState = value; }
        }

        public string HomeStable
        {
            get { return _homeStable; }
            set { _homeStable = value; }
        }
        
        #endregion

        #region CONSTRUCTORS

        public StableHorse()
        {

        }

        public StableHorse(string name)
        {
            _name = name;
        }

        public string StableHorseAttitude()
        {
            return _name + "is" + _currentEmotionalState + ".";
        }

        #endregion


    }
}
