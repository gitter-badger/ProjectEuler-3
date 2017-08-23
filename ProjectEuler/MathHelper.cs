namespace ProjectEuler
{
	public static class MathHelper
	{
		public static int SumDivisibleBy(int divider, int max)
		{
			return divider * (max / divider) * ((max / divider) + 1) / 2;
		}
	}
}