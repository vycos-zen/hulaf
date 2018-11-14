using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using HULAF.Domain.PersonCharacteristic;

namespace HULAF.Domain.Person
{

		public class SeekerPerson
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


				public Characteristics SeekedCharacteristics
				{
						get
						{
								return m_SeekedCharacteristics;
						}
						set
						{
								m_SeekedCharacteristics = value;
						}
				}
				private Characteristics m_SeekedCharacteristics;



				#endregion


		}

}  // end of namespace Person

