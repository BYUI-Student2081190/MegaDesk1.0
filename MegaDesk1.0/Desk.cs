using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk1._0
{
    internal class Desk
    {
        // Attributes.
        public int _deskWidth;
        public int _deskDepth;
        public int _numOfDrawers;
        public string _deskTopSurfMat = "";

        // Consts stored in Class.
        const int MAX_WIDTH = 96;
        const int MIN_WIDTH = 24;

        const int MAX_DEPTH = 48;
        const int MIN_DEPTH = 12;

        const int MAX_DRAWERS = 7;
        const int MIN_DRAWERS = 0;

        // Constructors.
        /* None needed right now, default is fine. */

        // Methods.

        /* Add Setters as well */

        /* Not too many are needed right now, just a few
           Getters for the const values to go to the Form for
           value testing. 
        */
        public int GetMAXWIDTH() 
        {
            return MAX_WIDTH;
        }

        public int GetMINWIDTH()
        {
            return MIN_WIDTH;
        }

        public int GetMAXDEPTH()
        {
            return MAX_DEPTH;
        }

        public int GetMINDEPTH()
        {
            return MIN_DEPTH;
        }

        public int GetMAXDRAWERS() 
        {
            return MAX_DRAWERS;
        }

        public int GetMINDRAWERS() 
        {
            return MIN_DRAWERS;
        }
    }


    /* Enum named DesktopMaterial stored here in file,
       but not in Class.
    */
    enum DesktopMaterial 
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    }
}
