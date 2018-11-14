using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Location
{

		public class SeenLocation
		{

				#region Attributes

				public Guid Id
				{
						get
						{
								return m_Id;
						}
						set
						{
								m_Id = value;
						}
				}
				private Guid m_Id;


				public string City
				{
						get
						{
								return m_City;
						}
						set
						{
								m_City = value;
						}
				}
				private string m_City;



				#endregion


		}

}  // end of namespace Location

