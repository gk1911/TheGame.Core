using gk1911.TheGame.Core.Model;

namespace gk1911.TheGame.Core.Impl.Hexes
{
	public class Water : Hex
	{
		public Water(int q, int r) => cords = new MapCoordinates(q, r);
	}
}
