namespace LinqStuff.Qinshift.LinqMethods.Entities
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }
		public abstract string Info();
	}
}
