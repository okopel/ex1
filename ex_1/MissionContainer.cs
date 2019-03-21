using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double Function(double num);

    public class FunctionsContainer
    {

        private Dictionary<string,Function> funcDict= new Dictionary<string, Function>();

        public List<string> getAllMissions()
        {
            return this.funcDict.Keys.ToList();
        }
        public Function this [string idx]
        {

            get
            {
                if (!this.funcDict.ContainsKey(idx))
                {
                    this.funcDict.Add(idx, val => val);
                }
                return this.funcDict[idx];
            }
            set
            {
                if (!this.funcDict.ContainsKey(idx))
                {
                    this.funcDict.Add(idx, value);
                }
                else
                {
                    this.funcDict[idx] = value;
                }


            }
        }

    }
}
