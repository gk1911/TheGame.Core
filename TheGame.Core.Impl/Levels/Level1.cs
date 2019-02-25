using gk1911.TheGame.Core.Impl.Maps;
using gk1911.TheGame.Core.Impl.Units;
using gk1911.TheGame.Core.Model;

namespace gk1911.TheGame.Core.Impl.Levels
{
	public class Level1 : Level
	{
		public Level1()
		{
			Map = new Level1Map();
			Units.Add(new MapCoordinates(5, 5), new MainGuy());
		}
	}
}
