using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowSys118.Adapters
{
    class CsvLineAdapter
    {
        #region [ Members ]

        private string[] m_lineArray = new string[] { };

        #endregion

        #region [ Properties ]


        public string[] LineArray
        {
            get
            {
                return m_lineArray;
            }
            set
            {
                m_lineArray = value;
            }
        }

        #endregion

        #region [ Constructor ]
        public CsvLineAdapter()
        {
            string[] m_lineArray = new string[] { };
        }
        #endregion

        #region [ Public Methods ]

        public string[] ReadCsvLine(String path, int indexOfLine)
        {

            string line = File.ReadLines(path).ElementAtOrDefault(indexOfLine);

            LineArray = line.Split(',');
            return LineArray;

        }

        public string[] ReadCsvLastLine(String path)
        {

            string line = File.ReadLines(path).Last();

            LineArray = line.Split(',');
            return LineArray;

        }

        #endregion

    }
}
