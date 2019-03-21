using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private Queue<Function> functions;
        private string name;
        private string type;
        public string Name
        {
            get
            {
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

        public ComposedMission(Queue<Function> functionsFromUser, string name, string type)
        {
            this.functions = functionsFromUser;
            this.name = name;
            this.type = type;
        }
        public ComposedMission (string name)
        {
            this.name = name;
            this.functions = new Queue<Function>();
            this.type = "Composed";


        }
        public ComposedMission Add(Function f)
        {
            this.functions.Enqueue(f);
            return this;
        }
        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            double result = value;
            foreach (var f in this.functions)
            {
                result = f(result);
            }
            OnCalculate?.Invoke(this, result);
            return result;
        }
    }
}
