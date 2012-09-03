using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1.Model
{

    public class Logger
    {
        private List<string> LastTenStrings = new List<string>();

        public void Log(string msg)
        {
            if (msg == null)
            {
                throw new Exception("Msg is null");
            } else {
                LastTenStrings.Add(msg);
            }

            if (LastTenStrings.Count > 10)
            {
                LastTenStrings.RemoveAt(0);
            }
        }
        
        public override string ToString()
        {
            string output = "";

            for (int x = 0; x < LastTenStrings.Count; x++)
            {
                output += LastTenStrings[x] + "\n";
            }

            return output;
        }
    }
}
