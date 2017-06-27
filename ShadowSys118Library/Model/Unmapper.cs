// COMPILER GENERATED CODE
// THIS WILL BE OVERWRITTEN AT EACH GENERATION
// EDIT AT YOUR OWN RISK

using System;
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
    public class Unmapper : UnmapperBase
    {
        #region [ Constructors ]

        public Unmapper(Framework framework, MappingCompiler mappingCompiler)
            : base(framework, mappingCompiler, SystemSettings.OutputMapping)
        {
            Algorithm.Output.CreateNew = () => new Algorithm.Output()
            {
                OutputData = FillOutputData(),
                OutputMeta = FillOutputMeta()
            };
        }

        #endregion

        #region [ Methods ]

        public ShadowSys118.Model.SS118Data.Outputs FillOutputData()
        {
            TypeMapping outputMapping = MappingCompiler.GetTypeMapping(OutputMapping);
            Reset();
            return FillSS118DataOutputs(outputMapping);
        }

        public ShadowSys118.Model.SS118Data._OutputsMeta FillOutputMeta()
        {
            TypeMapping outputMeta = MappingCompiler.GetTypeMapping(OutputMapping);
            Reset();
            return FillSS118Data_OutputsMeta(outputMeta);
        }

        public IEnumerable<IMeasurement> Unmap(ShadowSys118.Model.SS118Data.Outputs outputData, ShadowSys118.Model.SS118Data._OutputsMeta outputMeta)
        {
            List<IMeasurement> measurements = new List<IMeasurement>();
            TypeMapping outputMapping = MappingCompiler.GetTypeMapping(OutputMapping);

            CollectFromSS118DataOutputs(measurements, outputMapping, outputData, outputMeta);

            return measurements;
        }

        private ShadowSys118.Model.SS118Data.Outputs FillSS118DataOutputs(TypeMapping typeMapping)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);
            ShadowSys118.Model.SS118Data.Outputs obj = new ShadowSys118.Model.SS118Data.Outputs();

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            return obj;
        }

        private ShadowSys118.Model.SS118Data._OutputsMeta FillSS118Data_OutputsMeta(TypeMapping typeMapping)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);
            ShadowSys118.Model.SS118Data._OutputsMeta obj = new ShadowSys118.Model.SS118Data._OutputsMeta();

            {
                // Initialize meta value structure to "StateTxTapV" field
                FieldMapping fieldMapping = fieldLookup["StateTxTapV"];
                obj.StateTxTapV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "StateSn1CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSn1CapBkrV"];
                obj.StateSn1CapBkrV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "StateSn2CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSn2CapBkrV"];
                obj.StateSn2CapBkrV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "StateSn1BusBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSn1BusBkrV"];
                obj.StateSn1BusBkrV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "StateSn2BusBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSn2BusBkrV"];
                obj.StateSn2BusBkrV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasTxVoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasTxVoltV"];
                obj.MeasTxVoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasSn1VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasSn1VoltV"];
                obj.MeasSn1VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasSn2VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasSn2VoltV"];
                obj.MeasSn2VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasTxMwV" field
                FieldMapping fieldMapping = fieldLookup["MeasTxMwV"];
                obj.MeasTxMwV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasTxMvrV" field
                FieldMapping fieldMapping = fieldLookup["MeasTxMvrV"];
                obj.MeasTxMvrV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasGn1MwV" field
                FieldMapping fieldMapping = fieldLookup["MeasGn1MwV"];
                obj.MeasGn1MwV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasGn1MvrV" field
                FieldMapping fieldMapping = fieldLookup["MeasGn1MvrV"];
                obj.MeasGn1MvrV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasGn2MwV" field
                FieldMapping fieldMapping = fieldLookup["MeasGn2MwV"];
                obj.MeasGn2MwV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasGn2MvrV" field
                FieldMapping fieldMapping = fieldLookup["MeasGn2MvrV"];
                obj.MeasGn2MvrV = CreateMetaValues(fieldMapping);
            }

            return obj;
        }

        private void CollectFromSS118DataOutputs(List<IMeasurement> measurements, TypeMapping typeMapping, ShadowSys118.Model.SS118Data.Outputs data, ShadowSys118.Model.SS118Data._OutputsMeta meta)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);

            {
                // Convert value from "StateTxTapV" field to measurement
                FieldMapping fieldMapping = fieldLookup["StateTxTapV"];
                IMeasurement measurement = MakeMeasurement(meta.StateTxTapV, (double)data.StateTxTapV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "StateSn1CapBkrV" field to measurement
                FieldMapping fieldMapping = fieldLookup["StateSn1CapBkrV"];
                IMeasurement measurement = MakeMeasurement(meta.StateSn1CapBkrV, (double)data.StateSn1CapBkrV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "StateSn2CapBkrV" field to measurement
                FieldMapping fieldMapping = fieldLookup["StateSn2CapBkrV"];
                IMeasurement measurement = MakeMeasurement(meta.StateSn2CapBkrV, (double)data.StateSn2CapBkrV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "StateSn1BusBkrV" field to measurement
                FieldMapping fieldMapping = fieldLookup["StateSn1BusBkrV"];
                IMeasurement measurement = MakeMeasurement(meta.StateSn1BusBkrV, (double)data.StateSn1BusBkrV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "StateSn2BusBkrV" field to measurement
                FieldMapping fieldMapping = fieldLookup["StateSn2BusBkrV"];
                IMeasurement measurement = MakeMeasurement(meta.StateSn2BusBkrV, (double)data.StateSn2BusBkrV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasTxVoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasTxVoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasTxVoltV, (double)data.MeasTxVoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasSn1VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasSn1VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasSn1VoltV, (double)data.MeasSn1VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasSn2VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasSn2VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasSn2VoltV, (double)data.MeasSn2VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasTxMwV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasTxMwV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasTxMwV, (double)data.MeasTxMwV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasTxMvrV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasTxMvrV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasTxMvrV, (double)data.MeasTxMvrV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasGn1MwV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasGn1MwV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasGn1MwV, (double)data.MeasGn1MwV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasGn1MvrV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasGn1MvrV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasGn1MvrV, (double)data.MeasGn1MvrV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasGn2MwV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasGn2MwV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasGn2MwV, (double)data.MeasGn2MwV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasGn2MvrV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasGn2MvrV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasGn2MvrV, (double)data.MeasGn2MvrV);
                measurements.Add(measurement);
            }
        }

        #endregion
    }
}
