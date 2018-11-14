using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Location;
using HULAF.Domain.PersonCharacteristic;

namespace HULAF.Domain.Person
{

		public class MissingPerson
		{

				#region Compositions


				#endregion

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


				public SeenLocation LastSeenLocation
				{
						get
						{
								return m_LastSeenLocation;
						}
						set
						{
								m_LastSeenLocation = value;
						}
				}
				private SeenLocation m_LastSeenLocation;


				public Characteristics Characteristics
				{
						get
						{
								return m_Characteristics;
						}
						set
						{
								m_Characteristics = value;
						}
				}
				private Characteristics m_Characteristics;



				#endregion


		}

}  // end of namespace Person

