using System;
namespace AppleRobot
{
	[Serializable]
	public class StoreInfo : IComparable
	{
		public string m_Code;
		public DateTime m_LastTime;
		public int m_level;
		public string m_Name;
		public string m_sName;
		public APtimeslots[] timeslots;
		public StoreInfo()
		{
			Class2.e1eQOijzrvtg6();
		}
		public int CompareTo(object right)
		{
			if (!(right is StoreInfo))
			{
				throw new ArgumentException("參數必須為 StoreInfo 類型");
			}
			return this.m_level.CompareTo(((StoreInfo)right).m_level);
		}
	}
}
