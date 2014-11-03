using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
namespace AppleRobot
{
	[Serializable]
	public class ProductInfo : IComparable, ICloneable
	{
		public string m_Code;
		public string m_Color;
		public int m_iCount;
		public int m_iState;
		public DateTime m_LastTime;
		public int m_level;
		public ListViewItem m_lsItem;
		public string m_Name;
		public string m_Product;
		public string m_Size;
		public string m_State;
		public StoreInfo m_Store;
		public string m_Type;
		public ProductInfo()
		{
			Class2.e1eQOijzrvtg6();
		}
		public object Clone()
		{
			MemoryStream memoryStream = new MemoryStream();
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			binaryFormatter.Serialize(memoryStream, this);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			object result = binaryFormatter.Deserialize(memoryStream);
			memoryStream.Close();
			return result;
		}
		public int CompareTo(object right)
		{
			if (!(right is ProductInfo))
			{
				throw new ArgumentException("參數必須為 ProductInfo 類型");
			}
			return this.m_level.CompareTo(((ProductInfo)right).m_level);
		}
	}
}
