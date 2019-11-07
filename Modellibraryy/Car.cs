using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellibrary
{
    public class Car
    {
        private string _model;
        private string _color;
        private string _regNr;

        public Car()
        {
        }


        public Car(string model, string color, string regNr)
        {
            _model = model;
            _color = color;
            _regNr = regNr;
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public string RegNr
        {
            get { return _regNr; }
            set { _regNr = value; }
        }


        public override string ToString()
        {
            return $"{nameof(_model)}: {Model}, {nameof(_color)}: {Color}, {nameof(_regNr)}: {RegNr}";
        }
    }
}
