using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace HULAF.Domain.PersonCharacteristic
{
    public class Characteristics
    {

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


        public int ApproxHeight
        {
            get
            {
                return m_ApproxHeight;
            }
            set
            {
                m_ApproxHeight = value;
            }
        }
        private int m_ApproxHeight;


        public int ApproxWeight
        {
            get
            {
                return m_ApproxWeight;
            }
            set
            {
                m_ApproxWeight = value;
            }
        }
        private int m_ApproxWeight;


        public HairColor HairColor
        {
            get
            {
                return m_HairColor;
            }
            set
            {
                m_HairColor = value;
            }
        }
        private HairColor m_HairColor;


        public EyeColor EyeColor
        {
            get
            {
                return m_EyeColor;
            }
            set
            {
                m_EyeColor = value;
            }
        }
        private EyeColor m_EyeColor;


        public int ApproxAgeMin
        {
            get
            {
                return m_ApproxAgeMin;
            }
            set
            {
                m_ApproxAgeMin = value;
            }
        }
        private int m_ApproxAgeMin;


        public int ApproxAgeMax
        {
            get
            {
                return m_ApproxAgeMax;
            }
            set
            {
                m_ApproxAgeMax = value;
            }
        }
        private int m_ApproxAgeMax;


        public List<string> KnownNames
        {
            get
            {
                return m_KnownNames;
            }
            set
            {
                m_KnownNames = value;
            }
        }
        private List<string> m_KnownNames;


    }

}  // end of namespace Person

