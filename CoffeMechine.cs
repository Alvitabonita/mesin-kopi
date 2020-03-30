using System;
using System.Collections.Generic;
using System.Text;

namespace kopi
{
    class CoffeMechine
    {


        private CoffePowder coffePowder;
		private WaterGalon waterGalon;

		public string Esspresso { get; internal set; }

		public CoffeMechine(CoffePowder powder, WaterGalon galon){
			this.waterGalon = galon;
			this.coffePowder = powder;
		}

		public String makeEsspresso()
		{
			if (!this.waterGalon.isAvailable())
			{
				return "sorry,the water is empty";
			}
			if (!this.coffePowder.isAvailable())
			{
				return "sorry, the coffe is empty";
			}

			this.waterGalon.makeOneCup();
			this.coffePowder.makeOneCup();
			return "yey! your coffe is ready";
			
		}

		public String checkAvailability(){
			return $"the water :{this.waterGalon.getVolume()} and the coffe powder : {this.coffePowder.getNetto()}";
			
		}
    }
}
