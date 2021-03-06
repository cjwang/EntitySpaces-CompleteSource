/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0319.0
EntitySpaces Driver  : VistaDB4
Date Generated       : 3/17/2012 4:45:36 AM
===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using EntitySpaces.Interfaces;
using EntitySpaces.Core;

namespace BusinessObjects
{
    public partial class CustomersMetadata : esMetadata, IMetadata
    {
		static private int RegisterDelegateesVistaDB4()
		{
			// This is only executed once per the life of the application
			lock (typeof(CustomersMetadata))
			{
				if(CustomersMetadata.mapDelegates == null)
				{
					CustomersMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CustomersMetadata.meta == null)
				{
					CustomersMetadata.meta = new CustomersMetadata();
				}
				
				MapToMeta mapMethod = new MapToMeta(meta.esVistaDB4);
				mapDelegates.Add("esVistaDB4", mapMethod);
				mapMethod("esVistaDB4");
			}
			return 0;	
		}		
		
		private esProviderSpecificMetadata esVistaDB4(string mapName)
		{
			if(!m_providerMetadataMaps.ContainsKey(mapName))
			{
				esProviderSpecificMetadata meta = new esProviderSpecificMetadata();	
				

				meta.AddTypeMap("CustomerID", new esTypeMap("NVarChar", "System.String"));
				meta.AddTypeMap("CompanyName", new esTypeMap("NVarChar", "System.String"));
				meta.AddTypeMap("ContactName", new esTypeMap("NVarChar", "System.String"));
				meta.AddTypeMap("ContactTitle", new esTypeMap("NVarChar", "System.String"));
				meta.AddTypeMap("Address", new esTypeMap("NVarChar", "System.String"));
				meta.AddTypeMap("City", new esTypeMap("NVarChar", "System.String"));
				meta.AddTypeMap("Region", new esTypeMap("NVarChar", "System.String"));
				meta.AddTypeMap("PostalCode", new esTypeMap("NVarChar", "System.String"));
				meta.AddTypeMap("Country", new esTypeMap("NVarChar", "System.String"));
				meta.AddTypeMap("Phone", new esTypeMap("NVarChar", "System.String"));
				meta.AddTypeMap("Fax", new esTypeMap("NVarChar", "System.String"));				
				meta.Catalog = "Northwind.vdb4";
				
				meta.Source = "Customers";
				meta.Destination = "Customers";
				
				meta.spInsert = "proc_CustomersInsert";				
				meta.spUpdate = "proc_CustomersUpdate";		
				meta.spDelete = "proc_CustomersDelete";
				meta.spLoadAll = "proc_CustomersLoadAll";
				meta.spLoadByPrimaryKey = "proc_CustomersLoadByPrimaryKey";
				
				m_providerMetadataMaps["esVistaDB4"] = meta;
			}
			
			return m_providerMetadataMaps["esVistaDB4"];
		}
		
		static private int _esVistaDB4 = RegisterDelegateesVistaDB4();
    }
}
