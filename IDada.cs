using System;
using System.Data;
 
namespace Andy
{
    internal class IDada : IDataAdapter
    {
        public MissingMappingAction MissingMappingAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MissingSchemaAction MissingSchemaAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ITableMappingCollection TableMappings => throw new NotImplementedException();

        public int Fill(DataSet dataSet)
        {
            throw new NotImplementedException();
        }

        public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
        {
            throw new NotImplementedException();
        }

        public IDataParameter[] GetFillParameters()
        {
            throw new NotImplementedException();
        }

        public int Update(DataSet dataSet)
        {
            if (dataSet.HasChanges())
            {
                
                dataSet.Merge(dataSet);
                
            }
            
            return dataSet.Tables.Count;
        }
    }
}
