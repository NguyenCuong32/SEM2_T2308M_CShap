using System;
namespace BasicOOP_Generic
{
	public class GenerticList<T> where T : Employee
	{
		public List<T> listObject;
		public GenerticList()
		{
			listObject = new List<T>();
		}
		public void Add(T obj)
		{
			listObject.Add(obj);
		}
	}
}

