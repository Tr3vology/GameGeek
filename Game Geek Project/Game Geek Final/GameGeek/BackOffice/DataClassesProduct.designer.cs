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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GameGeekProduct")]
	public partial class DataClasses2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses2DataContext() : 
				base(global::BackOffice.Properties.Settings.Default.GameGeekProductConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetGameNo")]
		public ISingleResult<GetGameNoResult> GetGameNo()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetGameNoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sproc_GetAllGame")]
		public ISingleResult<sproc_GetAllGameResult> sproc_GetAllGame()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sproc_GetAllGameResult>)(result.ReturnValue));
		}
	}
	
	public partial class GetGameNoResult
	{
		
		private int _GameNo;
		
		public GetGameNoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GameNo", DbType="Int NOT NULL")]
		public int GameNo
		{
			get
			{
				return this._GameNo;
			}
			set
			{
				if ((this._GameNo != value))
				{
					this._GameNo = value;
				}
			}
		}
	}
	
	public partial class sproc_GetAllGameResult
	{
		
		private int _GameNo;
		
		private string _Title;
		
		private string _Console;
		
		private System.Nullable<decimal> _Price;
		
		private string _ImagePath;
		
		private System.Data.Linq.Binary _ImagePic;
		
		public sproc_GetAllGameResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GameNo", DbType="Int NOT NULL")]
		public int GameNo
		{
			get
			{
				return this._GameNo;
			}
			set
			{
				if ((this._GameNo != value))
				{
					this._GameNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(50)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this._Title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Console", DbType="VarChar(50)")]
		public string Console
		{
			get
			{
				return this._Console;
			}
			set
			{
				if ((this._Console != value))
				{
					this._Console = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this._Price = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImagePath", DbType="VarChar(250)")]
		public string ImagePath
		{
			get
			{
				return this._ImagePath;
			}
			set
			{
				if ((this._ImagePath != value))
				{
					this._ImagePath = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImagePic", DbType="Image")]
		public System.Data.Linq.Binary ImagePic
		{
			get
			{
				return this._ImagePic;
			}
			set
			{
				if ((this._ImagePic != value))
				{
					this._ImagePic = value;
				}
			}
		}
	}
}
#pragma warning restore 1591