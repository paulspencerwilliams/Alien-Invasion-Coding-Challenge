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
		    IEnumerable<IDefenceWeapon> weaponsToUse;
            weaponsToUse = invasionWave.WeaponsAvailableForDefence.Take(1);
            //weaponsToUse = invasionWave.WeaponsAvailableForDefence.Take(invasionWave.AlienInvaders.Count());
		    return new DefenceStrategy(weaponsToUse);
		}
	}
}
