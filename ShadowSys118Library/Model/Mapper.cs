// COMPILER GENERATED CODE
// THIS WILL BE OVERWRITTEN AT EACH GENERATION
// EDIT AT YOUR OWN RISK

using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ECAClientFramework;
using ECAClientUtilities;
using ECACommonUtilities;
using ECACommonUtilities.Model;
using GSF.TimeSeries;

namespace ShadowSys118.Model
{
    [CompilerGenerated]
    public class Mapper : MapperBase
    {
        #region [ Members ]

        // Fields
        private readonly Unmapper m_unmapper;

        #endregion

        #region [ Constructors ]

        public Mapper(Framework framework)
            : base(framework, SystemSettings.InputMapping)
        {
            m_unmapper = new Unmapper(framework, MappingCompiler);
            Unmapper = m_unmapper;
        }

        #endregion

        #region [ Methods ]

        public override void Map(IDictionary<MeasurementKey, IMeasurement> measurements)
        {
            SignalLookup.UpdateMeasurementLookup(measurements);
            TypeMapping inputMapping = MappingCompiler.GetTypeMapping(InputMapping);

            Reset();
            ShadowSys118.Model.SS118Data.Inputs inputData = CreateSS118DataInputs(inputMapping);
            Reset();
            ShadowSys118.Model.SS118Data._InputsMeta inputMeta = CreateSS118Data_InputsMeta(inputMapping);

            Algorithm.Output algorithmOutput = Algorithm.Execute(inputData, inputMeta);
            Subscriber.SendMeasurements(m_unmapper.Unmap(algorithmOutput.OutputData, algorithmOutput.OutputMeta));
        }

        private ShadowSys118.Model.SS118Data.Inputs CreateSS118DataInputs(TypeMapping typeMapping)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);
            ShadowSys118.Model.SS118Data.Inputs obj = new ShadowSys118.Model.SS118Data.Inputs();

            {
                // Assign short value to "ResetSignal" field
                FieldMapping fieldMapping = fieldLookup["ResetSignal"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ResetSignal = (short)measurement.Value;
            }

            {
                // Assign short value to "LoadIncrementPercentage" field
                FieldMapping fieldMapping = fieldLookup["LoadIncrementPercentage"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.LoadIncrementPercentage = (short)measurement.Value;
            }

            {
                // Assign short value to "ActTxRaise" field
                FieldMapping fieldMapping = fieldLookup["ActTxRaise"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ActTxRaise = (short)measurement.Value;
            }

            {
                // Assign short value to "ActTxLower" field
                FieldMapping fieldMapping = fieldLookup["ActTxLower"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ActTxLower = (short)measurement.Value;
            }

            {
                // Assign short value to "ActSn1Close" field
                FieldMapping fieldMapping = fieldLookup["ActSn1Close"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ActSn1Close = (short)measurement.Value;
            }

            {
                // Assign short value to "ActSn1Trip" field
                FieldMapping fieldMapping = fieldLookup["ActSn1Trip"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ActSn1Trip = (short)measurement.Value;
            }

            {
                // Assign short value to "ActSn2Close" field
                FieldMapping fieldMapping = fieldLookup["ActSn2Close"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ActSn2Close = (short)measurement.Value;
            }

            {
                // Assign short value to "ActSn2Trip" field
                FieldMapping fieldMapping = fieldLookup["ActSn2Trip"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ActSn2Trip = (short)measurement.Value;
            }

            return obj;
        }

        private ShadowSys118.Model.SS118Data._InputsMeta CreateSS118Data_InputsMeta(TypeMapping typeMapping)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);
            ShadowSys118.Model.SS118Data._InputsMeta obj = new ShadowSys118.Model.SS118Data._InputsMeta();

            {
                // Assign MetaValues value to "LoadIncrementPercentage" field
                FieldMapping fieldMapping = fieldLookup["LoadIncrementPercentage"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.LoadIncrementPercentage = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "ActTxRaise" field
                FieldMapping fieldMapping = fieldLookup["ActTxRaise"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ActTxRaise = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "ActTxLower" field
                FieldMapping fieldMapping = fieldLookup["ActTxLower"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ActTxLower = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "ActSn1Close" field
                FieldMapping fieldMapping = fieldLookup["ActSn1Close"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ActSn1Close = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "ActSn1Trip" field
                FieldMapping fieldMapping = fieldLookup["ActSn1Trip"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ActSn1Trip = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "ActSn2Close" field
                FieldMapping fieldMapping = fieldLookup["ActSn2Close"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ActSn2Close = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "ActSn2Trip" field
                FieldMapping fieldMapping = fieldLookup["ActSn2Trip"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ActSn2Trip = GetMetaValues(measurement);
            }

            return obj;
        }

        #endregion
    }
}
