using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeasuringDevice
{
    interface IMeasuringDeviceWithProperties : ILoggingMeasuringDevice
    {
      
           
        // Gets the Units used natively by the device.
       
        Units UnitsToUse { get; }

        // Gets an array of the measurements taken by the device.
           
        int[] DataCaptured { get; }

          
        // Gets the most recent measurement taken by the device.
             
        int MostRecentMeasure { get; }

          
        // Gets or sets the name of the logging file used. 
        // If the logging file changes this closes the current file and creates the new file.
        
        string LoggingFileName { get; set; }
    }
}
