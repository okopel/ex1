using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private string name;
        private string type;
        public string Name
        {
            get {
                return this.name;
            }
        }
        
        public string Type
        {
            get
            {
                return this.type;
            }
        }

        private Function function;

        public event EventHandler<double> OnCalculate; //todo

        public SingleMission( Function function, string name)
        {
            this.name = name;
            this.function = function;
            this.type = "Single";
        }
       
        public double Calculate(double value)
        {
            double res= this.function(value);
            OnCalculate?.Invoke(this, res);
            return res; 
        }
        
        
    }
}
