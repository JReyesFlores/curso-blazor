using DataAccess;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_InputOutput
    {
        public static List<InputOutputEntity> ListInputOutputs()
        {
            using (var db = new InventoryContext())
            {
                return db.InputOutputs.ToList();
            }
        }

        public static void CreateInputOutp(InputOutputEntity inputOutput)
        {
            using (var db = new InventoryContext())
            {
                db.InputOutputs.Add(inputOutput);
                db.SaveChanges();
            }
        }

        public static void UpdateInputOutput(InputOutputEntity inputOutput)
        {
            using (var db = new InventoryContext())
            {
                db.InputOutputs.Add(inputOutput);
                db.SaveChanges();
            }
        }
    }
}
