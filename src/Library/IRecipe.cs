using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID
{
    public interface IRecipe
    {
        Product FinalProduct { get; set; }

        // Agregado por Creator
        void AddStep(Product input, double quantity, Equipment equipment, int time);

        // Agregado por OCP y Creator
        void AddStep(string description, int time);


        void RemoveStep(BaseStep step);


        // Agregado por SRP
        string GetTextToPrint();


        // Agregado por Expert
        double GetProductionCost();

    }
}