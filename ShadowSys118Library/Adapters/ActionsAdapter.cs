using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ShadowSys118.Model.SS118Data;

namespace ShadowSys118.Adapters
{
    [Serializable()]
    public class ActionsAdapter
    {
        #region [ Private Members ]

        private short m_actTxRaise;
        private short m_actTxLower;
        private short m_actSn1Close;
        private short m_actSn1Trip;
        private short m_actSn2Close;
        private short m_actSn2Trip;

        #endregion

        #region [ Public Properties ]

        [XmlAttribute("ActTxRaise")]
        public short ActTxRaise
        {
            get
            {
                return m_actTxRaise;
            }
            set
            {
                m_actTxRaise = value;
            }
        }

        [XmlAttribute("ActTxLower")]
        public short ActTxLower
        {
            get
            {
                return m_actTxLower;
            }
            set
            {
                m_actTxLower = value;
            }
        }

        [XmlAttribute("ActSn1Close")]
        public short ActSn1Close
        {
            get
            {
                return m_actSn1Close;
            }
            set
            {
                m_actSn1Close = value;
            }
        }

        [XmlAttribute("ActSn1Trip")]
        public short ActSn1Trip
        {
            get
            {
                return m_actSn1Trip;
            }
            set
            {
                m_actSn1Trip = value;
            }
        }

        [XmlAttribute("ActSn2Close")]
        public short ActSn2Close
        {
            get
            {
                return m_actSn2Close;
            }
            set
            {
                m_actSn2Close = value;
            }
        }

        [XmlAttribute("ActSn2Trip")]
        public short ActSn2Trip
        {
            get
            {
                return m_actSn2Trip;
            }
            set
            {
                m_actSn2Trip = value;
            }
        }

        #endregion

        #region [ Constructor ]

        public ActionsAdapter()
        {
            Initialize();
        }

        #endregion

        #region [ Private Methods ]

        private void Initialize()
        {
            m_actTxRaise = 0;
            m_actTxLower = 0;
            m_actSn1Close = 0;
            m_actSn1Trip = 0;
            m_actSn2Close = 0;
            m_actSn2Trip = 0;
        }

        #endregion

        #region [ Public Methods ]

        public void ReadFromEcaInputData(Inputs inputData)
        {
            m_actTxRaise = inputData.ActTxRaise;
            m_actTxLower = inputData.ActTxLower;
            m_actSn1Close = inputData.ActSn1Close;
            m_actSn1Trip = inputData.ActSn1Trip;
            m_actSn2Close = inputData.ActSn2Close;
            m_actSn2Trip = inputData.ActSn2Trip;
        }

        #endregion

        #region [ Xml Serialization/Deserialization methods ]
        public void SerializeToXml(string pathName)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ActionsAdapter));
                TextWriter writer = new StreamWriter(pathName);
                serializer.Serialize(writer, this);
                writer.Close();
            }
            catch (Exception exception)
            {
                throw new Exception("Error: XML Serialization failed.");
            }
        }

        public static ActionsAdapter DeserializeFromXml(string pathName)
        {
            try
            {
                ActionsAdapter act = null;
                XmlSerializer deserializer = new XmlSerializer(typeof(ActionsAdapter));
                StreamReader reader = new StreamReader(pathName);
                act = (ActionsAdapter)deserializer.Deserialize(reader);
                reader.Close();
                return act;
            }
            catch (Exception exception)
            {
                throw new Exception("Error: XML Deserialization failed.");
            }
        }

        #endregion

    }
}
