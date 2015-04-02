﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobiiGUI
{
    class Configuration
    {
        public static Dictionary<int, Configuration> mapping; // Uniquely binds a button id to a Configuration. 
        static Dictionary<string, object> mouseFunctions = new Dictionary<string, object> {
            {"Left click", 1},
            {"Right click", 2}
        };

        static Dictionary<string, object> keyBoardFunctions = new Dictionary<string, object>
        {
            {"Alt + F4", 3},
            {"Alt + Tab", 4}
        };

        static Dictionary<string, object> commandFunctions = new Dictionary<string, object>
        {
            {"Launch Chrome", 5},
            {"Launch Music", 6}
        };
        SelectionForm.ButtonEnum buttonChoice;
        SelectionForm.DeviceEnum deviceChoice;
        object functionChoice;

        static Dictionary<string, object>[] deviceFunctions = new Dictionary<string, object>[] { mouseFunctions, keyBoardFunctions, commandFunctions };
        
        public static Dictionary<string, object> GetFunctions(SelectionForm.DeviceEnum choice)
        {
            return deviceFunctions[(int) choice];
        }

        public void BindFunction(SelectionForm.ButtonEnum buttonChoice, SelectionForm.DeviceEnum deviceChoice, object functionChoice)
        {
            this.buttonChoice = buttonChoice;
            this.deviceChoice = deviceChoice;
            this.functionChoice = functionChoice;
        }


    }
}