﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackOffice
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GameGeekCustomer")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::BackOffice.Properties.Settings.Default.GameGeekCustomerConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetCustomerNo")]
		public ISingleResult<GetCustomerNoResult> GetCustomerNo()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetCustomerNoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sproc_GetAllCustomer")]
		public ISingleResult<sproc_GetAllCustomerResult> sproc_GetAllCustomer()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sproc_GetAllCustomerResult>)(result.ReturnValue));
		}
	}
	
	public partial class GetCustomerNoResult
	{
		
		private int _CustomerNo;
		
		public GetCustomerNoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerNo", DbType="Int NOT NULL")]
		public int CustomerNo
		{
			get
			{
				return this._CustomerNo;
			}
			set
			{
				if ((this._CustomerNo != value))
				{
					this._CustomerNo = value;
				}
			}
		}
	}
	
	public partial class sproc_GetAllCustomerResult
	{
		
		private int _CustomerNo;
		
		private string _Tilte;
		
		private string _FirstName;
		
		private string _LastName;
		
		private System.Nullable<System.DateTime> _DateOfBirth;
		
		private string _Address;
		
		private string _PostCode;
		
		public sproc_GetAllCustomerResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerNo", DbType="Int NOT NULL")]
		public int CustomerNo
		{
			get
			{
				return this._CustomerNo;
			}
			set
			{
				if ((this._CustomerNo != value))
				{
					this._CustomerNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tilte", DbType="VarChar(10)")]
		public string Tilte
		{
			get
			{
				return this._Tilte;
			}
			set
			{
				if ((this._Tilte != value))
				{
					this._Tilte = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this._FirstName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this._LastName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfBirth", DbType="Date")]
		public System.Nullable<System.DateTime> DateOfBirth
		{
			get
			{
				return this._DateOfBirth;
			}
			set
			{
				if ((this._DateOfBirth != value))
				{
					this._DateOfBirth = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(250)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostCode", DbType="VarChar(50)")]
		public string PostCode
		{
			get
			{
				return this._PostCode;
			}
			set
			{
				if ((this._PostCode != value))
				{
					this._PostCode = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
