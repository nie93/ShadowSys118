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

            {
                // Initialize meta value structure to "StateSnB34CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSnB34CapBkrV"];
                obj.StateSnB34CapBkrV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "StateSnB44CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSnB44CapBkrV"];
                obj.StateSnB44CapBkrV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "StateSnB45CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSnB45CapBkrV"];
                obj.StateSnB45CapBkrV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "StateSnB48CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSnB48CapBkrV"];
                obj.StateSnB48CapBkrV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "StateSnB74CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSnB74CapBkrV"];
                obj.StateSnB74CapBkrV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "StateSnB105CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSnB105CapBkrV"];
                obj.StateSnB105CapBkrV = CreateMetaValues(fieldMapping);
            }
     
            {
                // Initialize meta value structure to "MeasB1VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB1VoltV"];
                obj.MeasB1VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB2VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB2VoltV"];
                obj.MeasB2VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB3VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB3VoltV"];
                obj.MeasB3VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB4VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB4VoltV"];
                obj.MeasB4VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB5VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB5VoltV"];
                obj.MeasB5VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB6VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB6VoltV"];
                obj.MeasB6VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB7VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB7VoltV"];
                obj.MeasB7VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB8VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB8VoltV"];
                obj.MeasB8VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB9VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB9VoltV"];
                obj.MeasB9VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB10VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB10VoltV"];
                obj.MeasB10VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB11VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB11VoltV"];
                obj.MeasB11VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB12VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB12VoltV"];
                obj.MeasB12VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB13VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB13VoltV"];
                obj.MeasB13VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB14VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB14VoltV"];
                obj.MeasB14VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB15VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB15VoltV"];
                obj.MeasB15VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB16VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB16VoltV"];
                obj.MeasB16VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB17VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB17VoltV"];
                obj.MeasB17VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB18VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB18VoltV"];
                obj.MeasB18VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB19VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB19VoltV"];
                obj.MeasB19VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB20VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB20VoltV"];
                obj.MeasB20VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB21VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB21VoltV"];
                obj.MeasB21VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB22VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB22VoltV"];
                obj.MeasB22VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB23VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB23VoltV"];
                obj.MeasB23VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB24VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB24VoltV"];
                obj.MeasB24VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB25VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB25VoltV"];
                obj.MeasB25VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB26VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB26VoltV"];
                obj.MeasB26VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB27VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB27VoltV"];
                obj.MeasB27VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB28VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB28VoltV"];
                obj.MeasB28VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB29VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB29VoltV"];
                obj.MeasB29VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB30VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB30VoltV"];
                obj.MeasB30VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB31VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB31VoltV"];
                obj.MeasB31VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB32VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB32VoltV"];
                obj.MeasB32VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB33VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB33VoltV"];
                obj.MeasB33VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB34VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB34VoltV"];
                obj.MeasB34VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB35VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB35VoltV"];
                obj.MeasB35VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB36VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB36VoltV"];
                obj.MeasB36VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB37VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB37VoltV"];
                obj.MeasB37VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB38VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB38VoltV"];
                obj.MeasB38VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB39VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB39VoltV"];
                obj.MeasB39VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB40VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB40VoltV"];
                obj.MeasB40VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB41VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB41VoltV"];
                obj.MeasB41VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB42VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB42VoltV"];
                obj.MeasB42VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB43VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB43VoltV"];
                obj.MeasB43VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB44VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB44VoltV"];
                obj.MeasB44VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB45VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB45VoltV"];
                obj.MeasB45VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB46VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB46VoltV"];
                obj.MeasB46VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB47VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB47VoltV"];
                obj.MeasB47VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB48VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB48VoltV"];
                obj.MeasB48VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB49VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB49VoltV"];
                obj.MeasB49VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB50VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB50VoltV"];
                obj.MeasB50VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB51VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB51VoltV"];
                obj.MeasB51VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB52VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB52VoltV"];
                obj.MeasB52VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB53VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB53VoltV"];
                obj.MeasB53VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB54VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB54VoltV"];
                obj.MeasB54VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB55VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB55VoltV"];
                obj.MeasB55VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB56VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB56VoltV"];
                obj.MeasB56VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB57VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB57VoltV"];
                obj.MeasB57VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB58VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB58VoltV"];
                obj.MeasB58VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB59VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB59VoltV"];
                obj.MeasB59VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB60VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB60VoltV"];
                obj.MeasB60VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB61VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB61VoltV"];
                obj.MeasB61VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB62VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB62VoltV"];
                obj.MeasB62VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB63VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB63VoltV"];
                obj.MeasB63VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB64VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB64VoltV"];
                obj.MeasB64VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB65VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB65VoltV"];
                obj.MeasB65VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB66VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB66VoltV"];
                obj.MeasB66VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB67VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB67VoltV"];
                obj.MeasB67VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB68VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB68VoltV"];
                obj.MeasB68VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB69VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB69VoltV"];
                obj.MeasB69VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB70VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB70VoltV"];
                obj.MeasB70VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB71VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB71VoltV"];
                obj.MeasB71VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB72VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB72VoltV"];
                obj.MeasB72VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB73VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB73VoltV"];
                obj.MeasB73VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB74VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB74VoltV"];
                obj.MeasB74VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB75VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB75VoltV"];
                obj.MeasB75VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB76VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB76VoltV"];
                obj.MeasB76VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB77VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB77VoltV"];
                obj.MeasB77VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB78VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB78VoltV"];
                obj.MeasB78VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB79VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB79VoltV"];
                obj.MeasB79VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB80VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB80VoltV"];
                obj.MeasB80VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB81VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB81VoltV"];
                obj.MeasB81VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB82VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB82VoltV"];
                obj.MeasB82VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB83VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB83VoltV"];
                obj.MeasB83VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB84VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB84VoltV"];
                obj.MeasB84VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB85VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB85VoltV"];
                obj.MeasB85VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB86VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB86VoltV"];
                obj.MeasB86VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB87VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB87VoltV"];
                obj.MeasB87VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB88VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB88VoltV"];
                obj.MeasB88VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB89VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB89VoltV"];
                obj.MeasB89VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB90VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB90VoltV"];
                obj.MeasB90VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB91VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB91VoltV"];
                obj.MeasB91VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB92VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB92VoltV"];
                obj.MeasB92VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB93VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB93VoltV"];
                obj.MeasB93VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB94VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB94VoltV"];
                obj.MeasB94VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB95VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB95VoltV"];
                obj.MeasB95VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB96VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB96VoltV"];
                obj.MeasB96VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB97VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB97VoltV"];
                obj.MeasB97VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB98VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB98VoltV"];
                obj.MeasB98VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB99VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB99VoltV"];
                obj.MeasB99VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB100VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB100VoltV"];
                obj.MeasB100VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB101VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB101VoltV"];
                obj.MeasB101VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB102VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB102VoltV"];
                obj.MeasB102VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB103VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB103VoltV"];
                obj.MeasB103VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB104VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB104VoltV"];
                obj.MeasB104VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB105VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB105VoltV"];
                obj.MeasB105VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB106VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB106VoltV"];
                obj.MeasB106VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB107VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB107VoltV"];
                obj.MeasB107VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB108VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB108VoltV"];
                obj.MeasB108VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB109VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB109VoltV"];
                obj.MeasB109VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB110VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB110VoltV"];
                obj.MeasB110VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB111VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB111VoltV"];
                obj.MeasB111VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB112VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB112VoltV"];
                obj.MeasB112VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB113VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB113VoltV"];
                obj.MeasB113VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB114VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB114VoltV"];
                obj.MeasB114VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB115VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB115VoltV"];
                obj.MeasB115VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB116VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB116VoltV"];
                obj.MeasB116VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB117VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB117VoltV"];
                obj.MeasB117VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "MeasB118VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasB118VoltV"];
                obj.MeasB118VoltV = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "StateLoad" field
                FieldMapping fieldMapping = fieldLookup["StateLoad"];
                obj.StateLoad = CreateMetaValues(fieldMapping);
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

            {
                // Convert value from "StateSnB34CapBkrV" field to measurement
                FieldMapping fieldMapping = fieldLookup["StateSnB34CapBkrV"];
                IMeasurement measurement = MakeMeasurement(meta.StateSnB34CapBkrV, (double)data.StateSnB34CapBkrV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "StateSnB44CapBkrV" field to measurement
                FieldMapping fieldMapping = fieldLookup["StateSnB44CapBkrV"];
                IMeasurement measurement = MakeMeasurement(meta.StateSnB44CapBkrV, (double)data.StateSnB44CapBkrV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "StateSnB45CapBkrV" field to measurement
                FieldMapping fieldMapping = fieldLookup["StateSnB45CapBkrV"];
                IMeasurement measurement = MakeMeasurement(meta.StateSnB45CapBkrV, (double)data.StateSnB45CapBkrV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "StateSnB48CapBkrV" field to measurement
                FieldMapping fieldMapping = fieldLookup["StateSnB48CapBkrV"];
                IMeasurement measurement = MakeMeasurement(meta.StateSnB48CapBkrV, (double)data.StateSnB48CapBkrV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "StateSnB74CapBkrV" field to measurement
                FieldMapping fieldMapping = fieldLookup["StateSnB74CapBkrV"];
                IMeasurement measurement = MakeMeasurement(meta.StateSnB74CapBkrV, (double)data.StateSnB74CapBkrV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "StateSnB105CapBkrV" field to measurement
                FieldMapping fieldMapping = fieldLookup["StateSnB105CapBkrV"];
                IMeasurement measurement = MakeMeasurement(meta.StateSnB105CapBkrV, (double)data.StateSnB105CapBkrV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB1VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB1VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB1VoltV, (double)data.MeasB1VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB2VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB2VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB2VoltV, (double)data.MeasB2VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB3VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB3VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB3VoltV, (double)data.MeasB3VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB4VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB4VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB4VoltV, (double)data.MeasB4VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB5VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB5VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB5VoltV, (double)data.MeasB5VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB6VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB6VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB6VoltV, (double)data.MeasB6VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB7VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB7VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB7VoltV, (double)data.MeasB7VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB8VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB8VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB8VoltV, (double)data.MeasB8VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB9VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB9VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB9VoltV, (double)data.MeasB9VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB10VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB10VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB10VoltV, (double)data.MeasB10VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB11VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB11VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB11VoltV, (double)data.MeasB11VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB12VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB12VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB12VoltV, (double)data.MeasB12VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB13VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB13VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB13VoltV, (double)data.MeasB13VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB14VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB14VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB14VoltV, (double)data.MeasB14VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB15VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB15VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB15VoltV, (double)data.MeasB15VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB16VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB16VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB16VoltV, (double)data.MeasB16VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB17VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB17VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB17VoltV, (double)data.MeasB17VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB18VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB18VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB18VoltV, (double)data.MeasB18VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB19VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB19VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB19VoltV, (double)data.MeasB19VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB20VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB20VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB20VoltV, (double)data.MeasB20VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB21VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB21VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB21VoltV, (double)data.MeasB21VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB22VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB22VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB22VoltV, (double)data.MeasB22VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB23VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB23VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB23VoltV, (double)data.MeasB23VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB24VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB24VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB24VoltV, (double)data.MeasB24VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB25VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB25VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB25VoltV, (double)data.MeasB25VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB26VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB26VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB26VoltV, (double)data.MeasB26VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB27VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB27VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB27VoltV, (double)data.MeasB27VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB28VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB28VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB28VoltV, (double)data.MeasB28VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB29VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB29VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB29VoltV, (double)data.MeasB29VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB30VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB30VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB30VoltV, (double)data.MeasB30VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB31VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB31VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB31VoltV, (double)data.MeasB31VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB32VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB32VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB32VoltV, (double)data.MeasB32VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB33VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB33VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB33VoltV, (double)data.MeasB33VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB34VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB34VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB34VoltV, (double)data.MeasB34VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB35VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB35VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB35VoltV, (double)data.MeasB35VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB36VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB36VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB36VoltV, (double)data.MeasB36VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB37VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB37VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB37VoltV, (double)data.MeasB37VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB38VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB38VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB38VoltV, (double)data.MeasB38VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB39VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB39VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB39VoltV, (double)data.MeasB39VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB40VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB40VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB40VoltV, (double)data.MeasB40VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB41VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB41VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB41VoltV, (double)data.MeasB41VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB42VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB42VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB42VoltV, (double)data.MeasB42VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB43VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB43VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB43VoltV, (double)data.MeasB43VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB44VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB44VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB44VoltV, (double)data.MeasB44VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB45VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB45VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB45VoltV, (double)data.MeasB45VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB46VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB46VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB46VoltV, (double)data.MeasB46VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB47VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB47VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB47VoltV, (double)data.MeasB47VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB48VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB48VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB48VoltV, (double)data.MeasB48VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB49VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB49VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB49VoltV, (double)data.MeasB49VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB50VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB50VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB50VoltV, (double)data.MeasB50VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB51VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB51VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB51VoltV, (double)data.MeasB51VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB52VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB52VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB52VoltV, (double)data.MeasB52VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB53VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB53VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB53VoltV, (double)data.MeasB53VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB54VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB54VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB54VoltV, (double)data.MeasB54VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB55VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB55VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB55VoltV, (double)data.MeasB55VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB56VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB56VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB56VoltV, (double)data.MeasB56VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB57VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB57VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB57VoltV, (double)data.MeasB57VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB58VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB58VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB58VoltV, (double)data.MeasB58VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB59VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB59VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB59VoltV, (double)data.MeasB59VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB60VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB60VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB60VoltV, (double)data.MeasB60VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB61VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB61VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB61VoltV, (double)data.MeasB61VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB62VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB62VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB62VoltV, (double)data.MeasB62VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB63VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB63VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB63VoltV, (double)data.MeasB63VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB64VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB64VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB64VoltV, (double)data.MeasB64VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB65VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB65VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB65VoltV, (double)data.MeasB65VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB66VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB66VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB66VoltV, (double)data.MeasB66VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB67VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB67VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB67VoltV, (double)data.MeasB67VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB68VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB68VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB68VoltV, (double)data.MeasB68VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB69VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB69VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB69VoltV, (double)data.MeasB69VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB70VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB70VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB70VoltV, (double)data.MeasB70VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB71VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB71VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB71VoltV, (double)data.MeasB71VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB72VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB72VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB72VoltV, (double)data.MeasB72VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB73VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB73VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB73VoltV, (double)data.MeasB73VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB74VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB74VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB74VoltV, (double)data.MeasB74VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB75VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB75VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB75VoltV, (double)data.MeasB75VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB76VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB76VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB76VoltV, (double)data.MeasB76VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB77VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB77VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB77VoltV, (double)data.MeasB77VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB78VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB78VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB78VoltV, (double)data.MeasB78VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB79VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB79VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB79VoltV, (double)data.MeasB79VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB80VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB80VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB80VoltV, (double)data.MeasB80VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB81VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB81VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB81VoltV, (double)data.MeasB81VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB82VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB82VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB82VoltV, (double)data.MeasB82VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB83VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB83VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB83VoltV, (double)data.MeasB83VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB84VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB84VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB84VoltV, (double)data.MeasB84VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB85VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB85VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB85VoltV, (double)data.MeasB85VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB86VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB86VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB86VoltV, (double)data.MeasB86VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB87VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB87VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB87VoltV, (double)data.MeasB87VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB88VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB88VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB88VoltV, (double)data.MeasB88VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB89VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB89VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB89VoltV, (double)data.MeasB89VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB90VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB90VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB90VoltV, (double)data.MeasB90VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB91VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB91VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB91VoltV, (double)data.MeasB91VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB92VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB92VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB92VoltV, (double)data.MeasB92VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB93VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB93VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB93VoltV, (double)data.MeasB93VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB94VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB94VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB94VoltV, (double)data.MeasB94VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB95VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB95VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB95VoltV, (double)data.MeasB95VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB96VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB96VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB96VoltV, (double)data.MeasB96VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB97VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB97VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB97VoltV, (double)data.MeasB97VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB98VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB98VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB98VoltV, (double)data.MeasB98VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB99VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB99VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB99VoltV, (double)data.MeasB99VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB100VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB100VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB100VoltV, (double)data.MeasB100VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB101VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB101VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB101VoltV, (double)data.MeasB101VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB102VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB102VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB102VoltV, (double)data.MeasB102VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB103VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB103VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB103VoltV, (double)data.MeasB103VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB104VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB104VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB104VoltV, (double)data.MeasB104VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB105VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB105VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB105VoltV, (double)data.MeasB105VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB106VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB106VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB106VoltV, (double)data.MeasB106VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB107VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB107VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB107VoltV, (double)data.MeasB107VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB108VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB108VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB108VoltV, (double)data.MeasB108VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB109VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB109VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB109VoltV, (double)data.MeasB109VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB110VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB110VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB110VoltV, (double)data.MeasB110VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB111VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB111VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB111VoltV, (double)data.MeasB111VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB112VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB112VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB112VoltV, (double)data.MeasB112VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB113VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB113VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB113VoltV, (double)data.MeasB113VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB114VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB114VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB114VoltV, (double)data.MeasB114VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB115VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB115VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB115VoltV, (double)data.MeasB115VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB116VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB116VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB116VoltV, (double)data.MeasB116VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB117VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB117VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB117VoltV, (double)data.MeasB117VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "MeasB118VoltV" field to measurement
                FieldMapping fieldMapping = fieldLookup["MeasB118VoltV"];
                IMeasurement measurement = MakeMeasurement(meta.MeasB118VoltV, (double)data.MeasB118VoltV);
                measurements.Add(measurement);
            }

            {
                // Convert value from "StateLoad" field to measurement
                FieldMapping fieldMapping = fieldLookup["StateLoad"];
                IMeasurement measurement = MakeMeasurement(meta.StateLoad, (double)data.StateLoad);
                measurements.Add(measurement);
            }

        }

        #endregion
    }
}
