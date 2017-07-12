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

        private short m_actSnB34Close;
        private short m_actSnB44Close;
        private short m_actSnB45Close;
        private short m_actSnB48Close;
        private short m_actSnB74Close;
        private short m_actSnB105Close;
        private short m_actSnB34Trip;
        private short m_actSnB44Trip;
        private short m_actSnB45Trip;
        private short m_actSnB48Trip;
        private short m_actSnB74Trip;
        private short m_actSnB105Trip;

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

        [XmlAttribute("ActSnB34Close")]
        public short ActSnB34Close
        {
            get
            {
                return m_actSnB34Close;
            }
            set
            {
                m_actSnB34Close = value;
            }
        }

        [XmlAttribute("ActSnB44Close")]
        public short ActSnB44Close
        {
            get
            {
                return m_actSnB44Close;
            }
            set
            {
                m_actSnB44Close = value;
            }
        }

        [XmlAttribute("ActSnB45Close")]
        public short ActSnB45Close
        {
            get
            {
                return m_actSnB45Close;
            }
            set
            {
                m_actSnB45Close = value;
            }
        }

        [XmlAttribute("ActSnB48Close")]
        public short ActSnB48Close
        {
            get
            {
                return m_actSnB48Close;
            }
            set
            {
                m_actSnB48Close = value;
            }
        }

        [XmlAttribute("ActSnB74Close")]
        public short ActSnB74Close
        {
            get
            {
                return m_actSnB74Close;
            }
            set
            {
                m_actSnB74Close = value;
            }
        }

        [XmlAttribute("ActSnB105Close")]
        public short ActSnB105Close
        {
            get
            {
                return m_actSnB105Close;
            }
            set
            {
                m_actSnB105Close = value;
            }
        }

        [XmlAttribute("ActSnB34Trip")]
        public short ActSnB34Trip
        {
            get
            {
                return m_actSnB34Trip;
            }
            set
            {
                m_actSnB34Trip = value;
            }
        }

        [XmlAttribute("ActSnB44Trip")]
        public short ActSnB44Trip
        {
            get
            {
                return m_actSnB44Trip;
            }
            set
            {
                m_actSnB44Trip = value;
            }
        }

        [XmlAttribute("ActSnB45Trip")]
        public short ActSnB45Trip
        {
            get
            {
                return m_actSnB45Trip;
            }
            set
            {
                m_actSnB45Trip = value;
            }
        }

        [XmlAttribute("ActSnB48Trip")]
        public short ActSnB48Trip
        {
            get
            {
                return m_actSnB48Trip;
            }
            set
            {
                m_actSnB48Trip = value;
            }
        }

        [XmlAttribute("ActSnB74Trip")]
        public short ActSnB74Trip
        {
            get
            {
                return m_actSnB74Trip;
            }
            set
            {
                m_actSnB74Trip = value;
            }
        }

        [XmlAttribute("ActSnB105Trip")]
        public short ActSnB105Trip
        {
            get
            {
                return m_actSnB105Trip;
            }
            set
            {
                m_actSnB105Trip = value;
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
            m_actSnB34Close = 0;
            m_actSnB44Close = 0;
            m_actSnB45Close = 0;
            m_actSnB48Close = 0;
            m_actSnB74Close = 0;
            m_actSnB105Close = 0;
            m_actSnB34Trip = 0;
            m_actSnB44Trip = 0;
            m_actSnB45Trip = 0;
            m_actSnB48Trip = 0;
            m_actSnB74Trip = 0;
            m_actSnB105Trip = 0;
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

            m_actSnB34Close = inputData.ActSnB34Close;
            m_actSnB44Close = inputData.ActSnB44Close;
            m_actSnB45Close = inputData.ActSnB45Close;
            m_actSnB48Close = inputData.ActSnB48Close;
            m_actSnB74Close = inputData.ActSnB74Close;
            m_actSnB105Close = inputData.ActSnB105Close;
            m_actSnB34Trip = inputData.ActSnB34Trip;
            m_actSnB44Trip = inputData.ActSnB44Trip;
            m_actSnB45Trip = inputData.ActSnB45Trip;
            m_actSnB48Trip = inputData.ActSnB48Trip;
            m_actSnB74Trip = inputData.ActSnB74Trip;
            m_actSnB105Trip = inputData.ActSnB105Trip;
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
