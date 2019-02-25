using System.Collections.Generic;

using gk1911.TheGame.Core.Impl.Effects;
using gk1911.TheGame.Core.Model;

namespace gk1911.TheGame.Core.Impl.Units
{
	public class MainGuy : Unit
	{
		public MainGuy() : base(name: "Main Guy the Cool", maxHp: 1000)
		{
			Abilities.AddRange(new List<Effect> {
				new Fireball(),
			});
		}
	}
}
