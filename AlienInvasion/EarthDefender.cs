using System;
using System.Collections.Generic;
using System.Linq;
using AlienInvasion.Client;
using AlienInvasion.Client.AlienInvaders;
using AlienInvasion.Client.DefenceAssets;

namespace AlienInvasion
{
	public class EarthDefender : IEarthDefender
	{

		public DefenceStrategy DefendEarth(IAlienInvasionWave invasionWave)
		{
		    return new DefenceStrategy(invasionWave.WeaponsAvailableForDefence.Take(invasionWave.AlienInvaders.Count()));
		}


	}
}
