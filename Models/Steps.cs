using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenRecipesApp1.Models
{
    public class Step
    {
        public int StepID { get; set; }
        public string Description { get; set; }
        public int Timer {  get; set; }
        public int Time { get; set; }
    }
}
